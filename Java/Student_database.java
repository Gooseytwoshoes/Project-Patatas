import java.util.Scanner;
public class Student_database {

	public static void main(String[] args) {

		// array storing values
		int ID[] = {100, 101, 102, 103, 104, 105, 106, 107, 108, 109};
		String Name[] = {"Lance", "Noel", "Eve", "Raya", "Vincent", "Ann", "Celestino", "Bianca", "Andrew", "Michael"};
		String Section[] = {"BSCS-1A", "BSCS-1B", "BSCS-2A", "BSCS-2B", "BSCS-3A", "BSCS-3B", "BSCS-4A", "BSCS-4B", "BSIT-1A", "BSIT-1B"};
		String Email[] = {"Lance@gmail.com", "Noel@gmail.com", "Eve@gmail.com" , "Raya@gmail.com", "Vincent@gmail.com", "Ann@gmail.com", "Celestino@gmail.com", "Biance@gmail.com", "Andrew@gmail.com", "Michael@gmail.com"};
		Scanner input = new Scanner(System.in);
		boolean condition = true;

		while (condition){  
    //condition to loop the execution of the file

			try {

				System.out.print("Student ID: ");
				int x = 0;
				x = input.nextInt();
        
				for(int i = 0; i < ID.length; i++){
        //checks the array for the id provided by user
					if (x == ID[i]){
						System.out.println("Student ID:        " + ID[i]);
						System.out.println("Student Name:      " + Name[i]);
						System.out.println("Student Section:   " + Section[i]);
						System.out.println("Student Email:     " + Email[i]);
					}
				}
			}

			catch(Exception e) {
      //doesn't catch numeric errors
				System.out.println("INVALID INPUT!");
				input.nextLine();
				}

			System.out.print("Proceed? (Yes/No): ");
			String ans = input.next().toLowerCase();

			if (ans.equals("no")){
      //to break the loop execution
				condition = false;
			}
		}

	}
}
