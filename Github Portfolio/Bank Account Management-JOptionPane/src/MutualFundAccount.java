import javax.swing.JOptionPane;

public class MutualFundAccount extends BankAccount {
	//fields
    private double investmentBalance;
    private String riskLevel;

    //constructor
    public MutualFundAccount(String accountNumber, String ownerName, String email, String phoneNumber, double balance, double investmentBalance, String riskLevel) {
        super(accountNumber, ownerName, email, phoneNumber, balance);
        this.investmentBalance = investmentBalance;
        this.riskLevel = riskLevel;
    }

    @Override
  //override parent displayAccountInfo method
    public void displayAccountInfo() {
    	//call parent method, and then display info for child method
        super.displayAccountInfo();
        JOptionPane.showMessageDialog(null, "Investment Balance: $" + investmentBalance + "\nRisk Level: " + riskLevel);
    }
}
