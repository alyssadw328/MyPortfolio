import javafx.scene.image.Image;
import javafx.scene.image.ImageView;

//class for hazards
public class Hazard extends ImageView {
    private double x, y, width, height;

    public Hazard(String imagePath, double x, double y, double width, double height) {
        super(new Image(imagePath)); //load image
        //set the size and position
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
        setFitWidth(width);
        setFitHeight(height);
        setLayoutX(x);
        setLayoutY(y);
    }

    //getters for hazard position and size
    public double getHazardX() { return x; }
    public double getHazardY() { return y; }
    public double getWidth() { return width; }
    public double getHeight() { return height; }
}
