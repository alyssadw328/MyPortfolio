import javax.swing.*;

//Alyssa Walker
//CPT 236-A80S
//Lab 7/8- Bank Account Management

//base class
public class BankAccount {
	
	//fields
    public String accountNumber;
    public String ownerName;
    public String email;
    public String phoneNumber;
    public double balance;

    //constructor
    public BankAccount(String accountNumber, String ownerName, String email, String phoneNumber, double balance) {
        this.accountNumber = accountNumber;
        this.ownerName = ownerName;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.balance = balance;
    }

    //deposit method
    public void deposit(double amount) {
        if (amount > 0) {
        	//if deposit amount is valid, update balance and give user confirmation
            balance += amount;
            JOptionPane.showMessageDialog(null, "Deposit successful.");
        }
        else {
        	//error if user enters a negative number or zero
            JOptionPane.showMessageDialog(null, "Please enter a valid deposit amount");
        }
    }

    //withdrawal method
    public void withdraw(double amount) {
        if (amount > 0 && amount <= balance) {
        	//if withdrawal amount is over 0 and less than or equal to the total account balance, update the balance and give user confirmation
            balance -= amount;
            JOptionPane.showMessageDialog(null, "Withdrawal successful.");
        }
        else {
        	//error message if user enters an invalid amount
            JOptionPane.showMessageDialog(null, "Please enter a valid withdrawal amount");
        }
    }

    //display account info method
    public void displayAccountInfo() {
        String acctInfo = "Account Number: " + accountNumber + "\n" + "Owner Name: " + ownerName + "\n" + "Email: " + email + "\n" + "Phone Number: " + phoneNumber + "\n" + "Balance: $" + balance;
        JOptionPane.showMessageDialog(null, acctInfo);
    }
}


