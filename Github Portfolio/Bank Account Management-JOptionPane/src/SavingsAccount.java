import javax.swing.JOptionPane;

public class SavingsAccount extends BankAccount {
	//field
    private double interestRate;

    //constructor
    public SavingsAccount(String accountNumber, String ownerName, String email, String phoneNumber, double balance, double interestRate) {
        super(accountNumber, ownerName, email, phoneNumber, balance);
        this.interestRate = interestRate;
    }

    @Override
    //override parent displayAccountInfo method
    public void displayAccountInfo() {
    	//call parent method, and then display info for child method
        super.displayAccountInfo();
        JOptionPane.showMessageDialog(null, "Interest Rate: " + interestRate + "%");
    }
}