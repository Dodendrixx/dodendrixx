using System;
using static System.Console; //using this means I don't have to type 'Console.' in front of every Write or Read function

namespace WK10_Project
//title
{
               
class Program
    { //initializing namespace
        static void Main(string[] args)
        {
		string input_string; //variable for string input_num
		int input_num;       //variable to store converted string to int
		string check;        //variable to check if user wants to continue using program
		
		do {  //outer loop to 'restart' program
			Write("Please enter a number: ");             //prompt to get user input
			input_string = ReadLine();                    //stores input in this variable
			input_num = Convert.ToInt16(input_string);    //converts string to int

			for (int i = 1; i <= input_num; i++)   //inner loop to write as many asterisks as the value of the user input
			{
				Write("*");      //write an asterisk for every iteration of this loop
			}
				
			if (input_num < 0)                  //something extra I put in just in case someone puts in a negative number
                Write("Please enter a positive integer.");  //output if condition is true
		
		WriteLine();                                   //for spacing
		WriteLine("Do you want to continue: (y/n)?");  //prompts user if they want to keep using
		check = ReadLine();                            //stores input in this variable
		
		} while (check == "y"); //as long as the user put "y", then the program starts again at the begginning of the do-loop
	    Write("Thank you!");        //prompt to let user know ho grateful I am
	    ReadLine();                 //halts program
	    }
    }
}	