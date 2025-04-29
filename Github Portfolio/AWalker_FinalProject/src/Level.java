import javafx.scene.image.Image;
import java.util.ArrayList;
import java.util.List;
import javafx.scene.image.ImageView;
import javafx.scene.layout.Pane;

import javafx.scene.layout.StackPane;

//level class
public class Level {
	//initialize background images and root
    private ImageView background1;
    private ImageView background2;
    private Pane root;
    
    //create lists to hold platforms, collectibles, and hazards
    private List<Platform> platforms = new ArrayList<>();
    private List<Collectible> collectibles = new ArrayList<>();
    private List<Hazard> hazards = new ArrayList<>();

    //update constructor for 2 background images to alternate
    public Level(String backgroundImagePath1, String backgroundImagePath2) {
        //load the background images
        background1 = new ImageView(new Image("file:" + backgroundImagePath1));
        background2 = new ImageView(new Image("file:" + backgroundImagePath2));

        //set background size (both the same to fit properly on the screen)
        background1.setFitWidth(1737); 
        background1.setFitHeight(600); 
        background2.setFitWidth(1737); 
        background2.setFitHeight(600); 

        //set 2nd background to appear directly after 1st
        background2.setTranslateX(background1.getFitWidth());

        //create a root container for the level and add both backgrounds
        root = new Pane();
        root.getChildren().addAll(background1, background2);
    }
    
    //get the root container
    public Pane getRoot() {
        return root;
    }

    //get the backgrounds
    public ImageView getBackground1() {
        return background1;
    }

    public ImageView getBackground2() {
        return background2;
    }
    //add platforms
    public void addPlatform(Platform platform) {
        platforms.add(platform);
        root.getChildren().add(platform);
    }
    //get platforms
    public List<Platform> getPlatforms() {
        return platforms;
    }
    //add collectibles
    public void addCollectible(Collectible collectible) {
        collectibles.add(collectible);
        root.getChildren().add(collectible);
    }
    //get collectibles
    public List<Collectible> getCollectibles() {
        return collectibles;
    }
    //add hazards
    public void addHazard(Hazard hazard) {
        hazards.add(hazard);
    }
    //get hazards
    public List<Hazard> getHazards() {
        return hazards;
    }
}
