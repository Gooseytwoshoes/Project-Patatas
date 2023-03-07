import java.util.Scanner;
class Grade{

      public static void main(String[] args) {
         Scanner scanner = new Scanner(System.in);

         System.out.print("Enter grades for JAVA: ");
         double i = scanner.nextDouble();

         System.out.print("Enter grades for P.E: ");
         double j =  scanner.nextDouble();

         System.out.print("Enter grades for STS: ");
         double x =  scanner.nextDouble();

         System.out.print("Enter grades for COM: ");
         double y =  scanner.nextDouble();

         double total = i + j + x + y;
         double ave = total / 4;

         if (ave > 100) {
            System.out.println("Invalid grade ");
         }
         else if (ave >= 98) {
            System.out.println("With Highest Honor.");
         }
         else if (ave >= 95){
            System.out.println("With High Honor.");
         }
         else if (ave >= 90){
            System.out.println("With Honor.");
         }
         else if (ave >= 75){
            System.out.println("passed.");
         }
         else {
            System.out.println("failed.");

         }
      }
}
