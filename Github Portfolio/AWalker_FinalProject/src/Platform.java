import javafx.scene.image.Image;
import javafx.scene.image.ImageView;

//platform class
public class Platform extends ImageView {
	//initialize variables
    private double actualX;
    private double actualY;
    private double width;
    private double height;

    public Platform(String imagePath, double x, double y, double width, double height) {
        super(new Image("file:" + imagePath)); //load image
        this.setFitWidth(width);
        this.setFitHeight(height);
        this.setLayoutX(x);
        this.setLayoutY(y);
        this.actualX = x;
        this.actualY = y;
        this.width = width;
        this.height = height;
    }
    //update platform position to keep it in line with the background
    public void updatePosition(double scrollAmount) {
        actualX -= scrollAmount;
    }

    public boolean isPointOver(double x, double y) {
        return x >= actualX && x <= actualX + width && y >= actualY && y <= actualY + height;
    }

    public double getActualX() {
        return actualX;
    }

    public double getActualY() {
        return actualY;
    }

    public double getActualWidth() {
        return width;
    }

    public double getActualHeight() {
        return height;
    }
}
