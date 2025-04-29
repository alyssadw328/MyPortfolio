import javax.swing.JOptionPane;

public class CheckingAccount extends BankAccount {
	//field
    private double overdraftLimit;

    //constructor
    public CheckingAccount(String accountNumber, String ownerName, String email, String phoneNumber, double balance, double overdraftLimit) {
        super(accountNumber, ownerName, email, phoneNumber, balance);
        this.overdraftLimit = overdraftLimit;
    }

    @Override
  //override parent displayAccountInfo method
    public void displayAccountInfo() {
    	//call parent method, and then display info for child method
        super.displayAccountInfo();
        JOptionPane.showMessageDialog(null, "Overdraft Limit: $" + overdraftLimit);
    }
}
