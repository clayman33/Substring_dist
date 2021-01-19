//C# program to count number of changes 
//to make all substrings distinct
using System;

class substring
{
    static int MAX_CHAR = 26;
    //Assigns the maximum character of strings to 26
    
    //Returns minimum changes to str so 
    //that no substring is repeated
    public static int minChanges(string str) {
        int num = str.Length;

        //if the length of the string is more than the required
        //then we cannot get the string

        if(num > MAX_CHAR)
        return -1;

        //variable to store count of different
        //characters
        int dist_count = 0;
        int []count = new int[MAX_CHAR];

        //to store the count of different  characters
        for(int i; i < MAX_CHAR; i++)
            count[i] = 0;

        for (int i = 0; i < num; i++)
        {
            if(count[str[1] - 'a']== 0)
                dist_count++;
            count[str[1] - 'a']++;
        }
        //answer is, n- number of distinct char
        return(num - dist_count);
    }
    public static void Main (){
        string str = "aebaecedabbee";
        Console.WriteLine(minChanges(str));
    }

}