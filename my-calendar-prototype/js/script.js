/*Akinsanya Joshua
19CJ025770
Computer Engineering
EIE414
 */

function generate_year_range(start, end) {
    var years = "";
    for (var year = start; year <= end; year++) {
        years += "<option value='" + year + "'>" + year + "</option>";
    }
    return years;
}

today = new Date();
currentMonth = today.getMonth();
currentYear = today.getFullYear();
selectYear = document.getElementById("year");
selectMonth = document.getElementById("month");


createYear = generate_year_range(1970, 2050);
/** or
 * createYear = generate_year_range( 1970, currentYear );
 */

document.getElementById("year").innerHTML = createYear;

var calendar = document.getElementById("calendar");

var months = "";
var days = "";

var monthDefault = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

var dayDefault = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

//Variables for dates we want to mark: Day and Month
const Dates = {
    "My Birthday" : [7,2, "my-birthday"],
    "Dad's Birthday" : [21, 10, "dad-birthday"],
    "Mom's Birthday" : [2, 5, "mom-birthday"],
    "New Year" : [1, 1, "holiday"],
    "New Year's Eve" : [31, 12, "holiday"],
    "Christmas" : [25, 12, "holiday"],
    "Boxing Day" : [26, 12, "holiday"],
    "Independence Day" : [1, 10, "holiday"],
    "Worker's Day" : [1, 5, "holiday"]
};
//Variables

months = monthDefault;
days = dayDefault;

var $dataHead = "<tr>";
for (dhead in days) {
    $dataHead += "<th data-days='" + days[dhead] + "'>" + days[dhead] + "</th>";
}
$dataHead += "</tr>";

//alert($dataHead);
document.getElementById("thead-month").innerHTML = $dataHead;


monthAndYear = document.getElementById("monthAndYear");
showCalendar(currentMonth, currentYear);



function next() {
    currentYear = (currentMonth === 11) ? currentYear + 1 : currentYear;
    currentMonth = (currentMonth + 1) % 12;
    showCalendar(currentMonth, currentYear);
}

function previous() {
    currentYear = (currentMonth === 0) ? currentYear - 1 : currentYear;
    currentMonth = (currentMonth === 0) ? 11 : currentMonth - 1;
    showCalendar(currentMonth, currentYear);
}

function jump() {
    currentYear = parseInt(selectYear.value);
    currentMonth = parseInt(selectMonth.value);
    showCalendar(currentMonth, currentYear);
}

function showCalendar(month, year) {

    var firstDay = ( new Date( year, month ) ).getDay();

    tbl = document.getElementById("calendar-body");

    tbl.innerHTML = "";

    monthAndYear.innerHTML = months[month] + " " + year;
    selectYear.value = year;
    selectMonth.value = month;

    var specialDay = "";
    // creating all cells

    //This variable stores the day number in the current month
    var date = 1;
    
    //Creates each row
    for ( var i = 0; i < 6; i++ ) {
        
        var row = document.createElement("tr");

        //Creates each column of table
        for ( var j = 0; j < 7; j++ ) {
            
            /*If current cell on first row is less than starting day of month
            Don't print anything in cell*/
           if ( i === 0 && j < firstDay ) {
                cell = document.createElement( "td" );
                cellText = document.createTextNode("");
                cell.appendChild(cellText);
                row.appendChild(cell);
            } 
            else if (date > daysInMonth(month, year)) {
                break;
            } else {
                cell = document.createElement("td");
                cell.setAttribute("data-date", date);
                cell.setAttribute("data-month", month + 1);
                cell.setAttribute("data-year", year);
                cell.setAttribute("data-month_name", months[month]);
                cell.className = "date-picker";
                cell.innerHTML = "<span>" + date + "</span>";

                if ( date === today.getDate() && year === today.getFullYear() && month === today.getMonth() ) {
                    cell.className = "date-picker selected";
                    cell.setAttribute("title", "Today")
                }
                if ( specialDay = checkDates(date, month+1) ) {
                    cell.className = Dates[specialDay][2];
                    cell.setAttribute("title", specialDay);
                }
                row.appendChild(cell);
                date++;
            }
        }
        tbl.appendChild(row);
    }
}

function daysInMonth(iMonth, iYear) {
    return 32 - new Date(iYear, iMonth, 32).getDate();
}

function checkDates(bDay, bMonth) {

    for(const dt in Dates) {
        if(bDay === Dates[dt][0] && bMonth === Dates[dt][1]) {
            return dt;
        }
    }
}
