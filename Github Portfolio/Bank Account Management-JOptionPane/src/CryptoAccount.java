import javax.swing.JOptionPane;

public class CryptoAccount extends BankAccount {
	//fields
    private double cryptoBalance;
    private String cryptoType;

    //constructor
    public CryptoAccount(String accountNumber, String ownerName, String email, String phoneNumber, double balance, double cryptoBalance, String cryptoType) {
        super(accountNumber, ownerName, email, phoneNumber, balance);
        this.cryptoBalance = cryptoBalance;
        this.cryptoType = cryptoType;
    }

    @Override
  //override parent displayAccountInfo method
    public void displayAccountInfo() {
    	//call parent method, and then display info for child method
        super.displayAccountInfo();
        JOptionPane.showMessageDialog(null, "Crypto Balance: " + cryptoBalance + "\nCrypto Type: " + cryptoType);
    }
}