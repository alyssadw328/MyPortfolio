import javafx.scene.image.Image;
import javafx.scene.image.ImageView;

//class for collectibles, like coins
public class Collectible extends ImageView {
    public Collectible(String imagePath, double x, double y, double width, double height) {
        super(new Image("file:" + imagePath)); //load image
        //set image size/position
        this.setFitWidth(width);
        this.setFitHeight(height);
        this.setTranslateX(x);
        this.setTranslateY(y);
    }
}
