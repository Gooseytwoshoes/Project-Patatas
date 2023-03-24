#include <iostream>

using namespace std;

int main() {

    int max, sum, i, j;

    cout << "How many numbers do you want to enter? ";
    cin >> max;
      //provide program to have a limit on how many to add
    
    int arr[max] = {};
      //store values given by the user in respect to how many the user want to add

    for (i = 0; i < max; i++)
    {
        cout << "Enter number "<< i + 1 << " :";
        cin >> arr[i];
          //put the value into the array "arr"
    }

    for (j = 0; j < max; j++){
        sum = sum + arr[j];  
        // add values of the array one by one
    }
    
    cout << "Sum of Entered Numbers: " << sum << endl;

    return 0;
}
