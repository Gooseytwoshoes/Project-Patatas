import java.util.Scanner;

public class CreditCardValidator {
    public static void main(String[] args){
        Scanner input = new Scanner(System.in);

        System.out.println("Welcome to credit card validator, we only support a limited number of credit card types");
        //this program only supports VISA, American Express, and Master Card
        /*sample numbers to enter on the program:
        >>> 5555555555554444 - Mastercard credit card
        >>> 4111111111111111 - VISA
        >>> 371111111111114  - American Express
        */

        System.out.println("Please enter the credit card number: ");
        String CardNum = input.nextLine();

        String CardType = TypeCheck(Long.parseLong(CardNum));
        System.out.println("The Card number " + CardNum + " is " + CardType);
    }

    public static String TypeCheck(long CardNum){
        //return string of what type of CC

        int digit1 = 0, digit2 = 0, numDigits = 0, sumOfDoubleOdds = 0, sumOfEvens = 0;
        while (CardNum > 0) {
            digit2 = digit1;
            digit1 = (int) (CardNum % 10);

            if (numDigits % 2 == 0) {
                sumOfEvens += digit1;
            } else {
                int multiple = 2 * digit1;
                sumOfDoubleOdds += (multiple / 10) + (multiple % 10);
            }

            CardNum /= 10;
            numDigits++;
        }

        boolean isValid = (sumOfEvens + sumOfDoubleOdds) % 10 == 0;
        int firstTwoDigits = digit1 * 10 + digit2;

        // if credit card num gets validated, this checks which card type it is
        if (digit1 == 4 && numDigits >= 13 && numDigits <= 16 && isValid) {
            return "VISA";
        } else if (firstTwoDigits >= 51 && firstTwoDigits <= 55 && numDigits == 16 && isValid) {
            return "MASTERCARD";
        } else if ((firstTwoDigits == 34 || firstTwoDigits == 37) && numDigits == 15 && isValid) {
            return "AMERICAN EXPRESS";
        } else {
            return "INVALID";
        }
    }
}
