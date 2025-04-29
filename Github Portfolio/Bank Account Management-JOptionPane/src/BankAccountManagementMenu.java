import java.util.ArrayList;
import javax.swing.JOptionPane;

//class to build the GUI/Menu

public class BankAccountManagementMenu {
	//create a dynamic array to hold the accounts
    private static ArrayList<BankAccount> accounts = new ArrayList<>();

    public static void main(String[] args) {
    	//set boolean for while loop to true
        boolean programRunning = true;

        while (programRunning) {
        	//Menu of user options
            String[] options = {"Create Account", "Deposit", "Withdraw", "View Account Info", "Exit"};
            //variable to hold the user's selection
            int userChoice = JOptionPane.showOptionDialog(null, "Choose an operation", "Bank System",
                    JOptionPane.DEFAULT_OPTION, JOptionPane.INFORMATION_MESSAGE, null, options, options[0]);
            
            //call corresponding method based on which option the user selects
            if (userChoice == 0) {
            	createAccount();
            }
            else if (userChoice == 1) {
            	deposit();
            }
            else if (userChoice == 2) {
            	withdraw();
            }
            else if (userChoice == 3) {
            	viewAccountInfo();
            }
            else if (userChoice == 4) {
            	//set boolean to false and exit the program if user selects "Exit"
            	programRunning = false;
            }
            
        }
    }

    //prompts for user to create an account
    private static void createAccount() {
        String accountType = JOptionPane.showInputDialog("Enter the type of account you want to create (Savings, Checking, MutualFund, Crypto):");
        String accountNumber = JOptionPane.showInputDialog("Enter Your Account Number:");
        String ownerName = JOptionPane.showInputDialog("Enter the Account Owner's Name:");
        String email = JOptionPane.showInputDialog("Enter Your Email:");
        String phoneNumber = JOptionPane.showInputDialog("Enter Your Phone Number:");
        double balance = Double.parseDouble(JOptionPane.showInputDialog("Enter the Initial Account Balance:"));

        //initialize account variable
        BankAccount account = null;

        //create account based on the account type entered by the user
        if (accountType.equalsIgnoreCase("savings")) {
            double interestRate = Double.parseDouble(JOptionPane.showInputDialog("Enter the Interest Rate:"));
            account = new SavingsAccount(accountNumber, ownerName, email, phoneNumber, balance, interestRate);
        } 
        else if (accountType.equalsIgnoreCase("checking")) {
            double overdraftLimit = Double.parseDouble(JOptionPane.showInputDialog("Enter the Overdraft Limit:"));
            account = new CheckingAccount(accountNumber, ownerName, email, phoneNumber, balance, overdraftLimit);
        } 
        else if (accountType.equalsIgnoreCase("mutualfund")) {
            double investmentBalance = Double.parseDouble(JOptionPane.showInputDialog("Enter Your Investment Balance:"));
            String riskLevel = JOptionPane.showInputDialog("Enter the Risk Level (Low, Medium, or High):");
            account = new MutualFundAccount(accountNumber, ownerName, email, phoneNumber, balance, investmentBalance, riskLevel);
        } 
        else if (accountType.equalsIgnoreCase("crypto")) {
            double cryptoBalance = Double.parseDouble(JOptionPane.showInputDialog("Enter Your Crypto Balance:"));
            String cryptoType = JOptionPane.showInputDialog("Enter the Crypto Type (ex: Bitcoin, Ethereum):");
            account = new CryptoAccount(accountNumber, ownerName, email, phoneNumber, balance, cryptoBalance, cryptoType);
        } 
        else {
        	//error message if the user does not enter a valid account type
            JOptionPane.showMessageDialog(null, "Invalid account type.");
            return;
        }

        //add the new account to the accounts array and give confirmation message
        accounts.add(account);
        JOptionPane.showMessageDialog(null, "Account created successfully!");
    }

    //prompts for user to deposit to their account
    private static void deposit() {
        String accountNumber = JOptionPane.showInputDialog("Enter Your Account Number to deposit:");
        //call findAccount method to find the account based on the account number entered
        BankAccount account = findAccount(accountNumber);
        if (account != null) {
            double amount = Double.parseDouble(JOptionPane.showInputDialog("Enter the deposit amount:"));
            //update the account balance to include the new deposit
            account.deposit(amount);
        } 
        else {
        	//error message if the account number is invalid
            JOptionPane.showMessageDialog(null, "Sorry, account not found.");
        }
    }

    //prompts for user to withdraw from their account
    private static void withdraw() {
        String accountNumber = JOptionPane.showInputDialog("Enter the Account Number to withdraw from:");
        //find the account number
        BankAccount account = findAccount(accountNumber);
        if (account != null) {
            double amount = Double.parseDouble(JOptionPane.showInputDialog("Enter the withdrawal amount:"));
            //update balance
            account.withdraw(amount);    
        } 
        else {
        	//error message if account number is invalid
            JOptionPane.showMessageDialog(null, "Sorry, account not found.");
        }
    }

    //prompt user for account number to display the account info
    private static void viewAccountInfo() {
        String accountNumber = JOptionPane.showInputDialog("Enter Your Account Number to view:");
        //find account
        BankAccount account = findAccount(accountNumber);
        if (account != null) {
        	//display account info
            account.displayAccountInfo();
        }
        else {
        	//error message if account number is invalid
            JOptionPane.showMessageDialog(null, "Sorry, account not found.");
        }
    }

    //method to find the account when the user enters the account number
    private static BankAccount findAccount(String accountNumber) {
    	//search for the account in the accounts array
        for (BankAccount account : accounts) {
            if (account.accountNumber.equals(accountNumber)) {
            	//return account if account number is valid
                return account;
            }
        }
        
        return null;
    }
}


