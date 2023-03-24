#include <iostream>
#include <string>

using namespace std;


string roman_numerals (int num)
{
string m[] = { "", "M", "MM"};
string c[] = { "", "C", "CC", "CCC", "CD","D", "DC", "DCC", "DCCC", "CM" };
string x[] = { "", "X", "XX", "XXX", "XL","L", "LX", "LXX", "LXXX", "XC" };
string i[] = { "", "I", "II", "III", "IV","V", "VI", "VII", "VIII", "IX" };
    //array containing values corresponding to romn numerals

    string thou = m[num / 1000];
    string hund = c[(num % 1000) / 100];
    string tens = x[(num % 100) / 10];
    string ones = i[num % 10];
        // % (modulo) == gets the remainder
 
    string roman_numer = thou + hund + tens + ones;
 
    return roman_numer;
}

int main ()
{
int number;

cout<< "Enter an integer number: "; //ask user for input
cin>>number;

 if (number <= 2000) {
    cout << "Output: " << roman_numerals(number);
        // rejects number greater than 2000
 }
 else {
     cout << "Output: Integer is out of range";
 }
    return 0;
}

