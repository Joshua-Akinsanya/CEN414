public class JavaMath {
  //19CJ025770
  public static void main(String args[]) {
    int x=7;
    int y=0;
    
    //Math functions
    System.out.println("Square root = " + Math.sqrt(x*y));
    System.out.println("Absolute Value = " + Math.abs(x*y));
    System.out.println(x + " raised to the power of " + y + " = " + Math.pow(x,y));
    System.out.println("Exponential " + x + " = " + Math.exp(x));
    System.out.println("Cube root of " + x + " = " + Math.cbrt(x));
    
    //if statements
    if (x>y) {
      System.out.println(x + " is greater than " + y);
    }
    else if (x<y) {
      System.out.println(x + " is less than " + y);
    }
    else {
      System.out.println("Both numbers are equal to "+x);
    }
    
    //Logical operations
    System.out.println(x&y);
    System.out.println(x|y);
    System.out.println(x^y);
    System.out.println(~y);
    System.out.println(~x);
    
    //Boolean operations
    System.out.println(x<y);
    System.out.println(x>y);
    System.out.println(x==y);
    
    //Switch Statement
    int grade = 5;
    switch (grade) {
      case 0:
        System.out.println("F");
        break;
      case 2:
        System.out.println("D");
        break;
      case 3:
        System.out.println("C");
        break;
      case 4:
        System.out.println("B");
        break;
      case 5:
        System.out.println("A");
        break;
      default:
        System.out.println("Enter a valid grade");
    }
    
    //for statement
    for(int i = 0; i <=99;i++){
      if(i==70){
        System.out.println(i);
      }
    }
    
    //Boolean expression
    String smaller = x==y ? "x is equal to y" : "x is not equal to y";
        System.out.println(smaller+ "\n");

         smaller = x>y ? "x is greater than y" : "x is not greater than y";
        System.out.println(smaller+ "\n");

         smaller = x<y ? "x is less than y" : "x is not less than y";
        System.out.println(smaller+ "\n");

        smaller = ((x>1)||(y>6)) ? "the or statement returns true" : "the or statement returns false";
        System.out.println(smaller+ "\n");

        smaller = ((x>1)&&(y>6)) ? "the and statement returns true" : "the and statement returns false";
        System.out.println(smaller+ "\n");

        smaller = ((x!=y)) ? "the and statement returns true" : "the and statement returns false";
        System.out.println(smaller+ "\n");
        
        System.out.println("x ^ y returns " +( x^y )+ " \n");
  }
}    