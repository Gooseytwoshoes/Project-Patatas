#include <iostream>

using namespace std;

int main() {

    char letter;
    bool vowel;

    cout << "Enter any alphabet (lowercase): ";
        // only take char that is lowercase

    vowel = (letter == 'a' || letter == 'e' || letter == 'o' || letter == 'u');


    if (!isalpha(letter))
        cout << "You didn't entered an alphabet.";
    else if (vowel)
        cout << "The entered character is " << letter << " and it is a Vowel";
    else
        cout << "The entered character is " << letter << " and it is a Consonant";


    return 0;
}
