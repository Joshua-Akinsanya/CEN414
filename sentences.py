#Length of sentence

sentences = ["I am not a boy",
            "I am not a girl",
            "I am a man",
            "I am not a woman"]

for i in sentences:
    length = 0
    word_length = 1
    for j in i:
        length += 1
        if ( j.isalnum() and not(i[length-2].isalnum()) ):
            word_length += 1
            
    print(i, '\nLength: ', length, '\nWord Length: ', word_length)
    