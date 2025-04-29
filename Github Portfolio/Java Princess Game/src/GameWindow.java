import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

import javafx.animation.KeyFrame;
import javafx.animation.Timeline;
import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.layout.*;
import javafx.scene.paint.Color;
import javafx.scene.input.KeyCode;
import javafx.stage.Stage;
import javafx.util.Duration;
import javafx.scene.control.Label;
import javafx.geometry.Pos;
import javafx.geometry.Bounds;
import javafx.scene.layout.Region;

public class GameWindow extends Application {
	
	//initialize player and walking variables
    private ImageView player;
    private boolean isWalking = false;  //flag showing if the player is walking or not
    private int currentWalkImageIndex = 0; //index of the image currently displayed for walking
    private Image[] walkingImages; //walking images array
    private Image[] jumpingImages; //jumping images array
    private Image idleImage; //idle image (for when the character is standing still)
    
    //initialize score, player's lives, and timelines for animation
    private int score = 0; //score starts at 0
    private Label scoreLabel; //label for score
    private int lives = 3; //player starts with 3 lives
    private Label livesLabel;  //label showing lives
    private Pane root;  //root container
    private Timeline walkingAnimation;  //timeline for the walking animation
    private Timeline backgroundMovement;  //timeline for the background movement
    
    //variables for jumping
    private double velocityY = 0;
    private final double gravity = 0.5; //gravity so the character comes down when jumping
    private final double jumpStrength = -14; //how high they can jump
    private boolean isJumping = false; //flag showing if the player is jumping or not
    
    //set a default character just in case
    private String currentCharacter = "anna"; //make anna the default

    //set default character height and width
    private double playerWidth = 100;  
    private double playerHeight = 150; 
    
    @Override
    public void start(Stage primaryStage) {
        //StackPane for the character selection menu
        StackPane menu = new StackPane();
        
        //VBox to hold the buttons and the label
        VBox buttonContainer = new VBox(15);
        buttonContainer.setAlignment(Pos.CENTER);  //make sure everything is centered

        //padding because I want it to move down lower
        buttonContainer.setStyle("-fx-padding: 200px 50px 50px 50px;");

        //load and display the logo image
        Image logoImage = new Image("file:Princess Images/logo.png");
        ImageView logoImageView = new ImageView(logoImage);
        logoImageView.setFitWidth(510);
        logoImageView.setPreserveRatio(true); //keep the ratio so it doesn't go all wonky looking

        //spacer because I want the logo a little bit higher up
        Region spacer = new Region();
        spacer.setMinHeight(-70);

        //add the spacer and logo to a VBox
        VBox logoContainer = new VBox();
        logoContainer.setAlignment(Pos.TOP_CENTER);  //put the logo at the top center
        logoContainer.getChildren().addAll(spacer, logoImageView);

        //set the menu background and how I want it to look
        BackgroundImage backgroundImage = new BackgroundImage(
                new Image("file:Princess Images/CharacterMenu.jpg", 1000, 625, false, true),
                BackgroundRepeat.NO_REPEAT,
                BackgroundRepeat.NO_REPEAT,
                BackgroundPosition.CENTER,
                BackgroundSize.DEFAULT
        );

        //add the background to the Stack Pane
        menu.setBackground(new Background(backgroundImage));
        
        //add the logo container to the Stack Pane
        menu.getChildren().add(logoContainer);

        //label for character selection
        Label instructions = new Label("Choose Your Character:");
        instructions.setStyle("-fx-font-size: 30px; -fx-text-fill: darkblue; -fx-font-weight: bold; -fx-background-color: rgba(255, 255, 255, 0.6); -fx-padding: 5px;");
        buttonContainer.getChildren().add(instructions);

        //character selection buttons
        Button annaButton = new Button("Princess Anna");
        Button tianaButton = new Button("Princess Tiana");
        Button jasmineButton = new Button("Princess Jasmine");
        
        //button for instructions
        Button howToPlayButton = new Button("How to Play");
        
        //button styles
        annaButton.setStyle("-fx-background-color: #E7C6FF; -fx-text-fill: #A43B76; -fx-font-size: 28px; -fx-padding: 10px; -fx-font-weight: bold;");
        tianaButton.setStyle("-fx-background-color: #98FB98; -fx-text-fill: green; -fx-font-size: 28px; -fx-padding: 10px; -fx-font-weight: bold;");
        jasmineButton.setStyle("-fx-background-color: #66CCCC; -fx-text-fill: teal; -fx-font-size: 28px; -fx-padding: 10px; -fx-font-weight: bold;");
        howToPlayButton.setStyle("-fx-background-color: #FFB6C1; -fx-text-fill: darkred; -fx-font-size: 30px; -fx-padding: 8px; -fx-font-weight: bold;");

        //select Anna
        annaButton.setOnAction(e -> {
            currentCharacter = "anna";
            loadCharacterImages(); //load the images for Anna
            startGame(primaryStage); //start the game with Anna
        });

        //select Tiana
        tianaButton.setOnAction(e -> {
            currentCharacter = "tiana";
            loadCharacterImages(); //load the images for Tiana
            startGame(primaryStage); //start game with Tiana
        });

        //select Jasmine
        jasmineButton.setOnAction(e -> {
            currentCharacter = "jasmine";
            loadCharacterImages(); //load the images for Jasmine
            startGame(primaryStage); //start game with Jasmine
        });

        //show how to play instructions
        howToPlayButton.setOnAction(e -> showHowToPlay());

        //add the character buttons to the menu
        buttonContainer.getChildren().addAll(annaButton, tianaButton, jasmineButton);

        //add the label/button container
        menu.getChildren().add(buttonContainer);

        //position the How to Play button in the top right corner
        StackPane.setAlignment(howToPlayButton, Pos.TOP_RIGHT);
        howToPlayButton.setTranslateX(-40);
        howToPlayButton.setTranslateY(40);
        menu.getChildren().add(howToPlayButton);

        //set up and display the menu scene
        Scene menuScene = new Scene(menu, 1000, 625, Color.WHITE);
        primaryStage.setTitle("Welcome! Character Selection Menu");
        primaryStage.setScene(menuScene);
        primaryStage.show();
    }

    //method for loading selected character images
    private void loadCharacterImages() {
    	
    	//for Anna
        if (currentCharacter.equals("anna")) {
        	
        	//idle
            idleImage = new Image("file:Princess Images/Anna/AnnaIdle.png");
            
            //walking
            walkingImages = new Image[3];
            walkingImages[0] = new Image("file:Princess Images/Anna/AnnaWalk1.png");
            walkingImages[1] = new Image("file:Princess Images/Anna/AnnaWalk2.png");
            walkingImages[2] = new Image("file:Princess Images/Anna/AnnaWalk3.png");

            //jumping
            jumpingImages = new Image[3];
            jumpingImages[0] = new Image("file:Princess Images/Anna/AnnaJumpCrouch.png");
            jumpingImages[1] = new Image("file:Princess Images/Anna/AnnaJumpInAir.png");
            jumpingImages[2] = new Image("file:Princess Images/Anna/AnnaJumpLanding.png");

            //set Anna's height and width
            playerWidth = 130;
            playerHeight = 200;
          
        //for Tiana
        } else if (currentCharacter.equals("tiana")) {
        	
        	//idle
            idleImage = new Image("file:Princess Images/Tiana/TianaIdle.png");
            
            //walking
            walkingImages = new Image[3];
            walkingImages[0] = new Image("file:Princess Images/Tiana/TianaWalk1.png");
            walkingImages[1] = new Image("file:Princess Images/Tiana/TianaWalk2.png");
            walkingImages[2] = new Image("file:Princess Images/Tiana/TianaWalk3.png");

            //jumping
            jumpingImages = new Image[3];
            jumpingImages[0] = new Image("file:Princess Images/Tiana/TianaJumpCrouch.png");
            jumpingImages[1] = new Image("file:Princess Images/Tiana/TianaJumpInAir.png");
            jumpingImages[2] = new Image("file:Princess Images/Tiana/TianaJumpLanding.png");

            //set Tiana's height and width
            playerWidth = 155;
            playerHeight = 200;
            
        //for Jasmine
        } else if (currentCharacter.equals("jasmine")) {
        	
        	//idle
            idleImage = new Image("file:Princess Images/Jasmine/JasmineIdle.png");
            
            //walking
            walkingImages = new Image[3];
            walkingImages[0] = new Image("file:Princess Images/Jasmine/JasmineWalk1.png");
            walkingImages[1] = new Image("file:Princess Images/Jasmine/JasmineWalk2.png");
            walkingImages[2] = new Image("file:Princess Images/Jasmine/JasmineWalk3.png");

            //jumping
            jumpingImages = new Image[3];
            jumpingImages[0] = new Image("file:Princess Images/Jasmine/JasmineJumpCrouch.png");
            jumpingImages[1] = new Image("file:Princess Images/Jasmine/JasmineJumpInAir.png");
            jumpingImages[2] = new Image("file:Princess Images/Jasmine/JasmineJumpLanding.png");

            //set Jasmine's height and width
            playerWidth = 122;
            playerHeight = 200;
        }
    }

    //starting the game (level 1)
    private void startGame(Stage primaryStage) {
        //create a new Level with a background image for the level
        Level level1 = new Level("Princess Images/forest.png", "Princess Images/forest.png");

        //create the player
        player = new ImageView(idleImage);

        //set the player's size based on which one is selected
        player.setFitWidth(playerWidth);
        player.setFitHeight(playerHeight);
        
        //set the player's position
        player.setLayoutX(100);
        player.setLayoutY(240);

        //get the root container for level 1
        root = level1.getRoot();
        
        //platforms
        Platform longPlatform = new Platform("Princess Images/longplatform.png", 950, 245, 375, 43);
        Platform shortPlatform = new Platform("Princess Images/shortplatform.png", 650, 290, 180, 40);
        Platform shortPlatform2 = new Platform("Princess Images/shortplatform.png", 1690, 260, 180, 40);
        Platform shortPlatform3 = new Platform("Princess Images/shortplatform.png", 2550, 220, 180, 40);
        Platform longPlatform2 = new Platform("Princess Images/longplatform.png", 2040, 310, 375, 43);
        Platform shortPlatform4 = new Platform("Princess Images/shortplatform.png", 3000, 320, 180, 40);
        Platform longPlatform3 = new Platform("Princess Images/longplatform.png", 3200, 200, 375, 43);
        Platform shortPlatform5 = new Platform("Princess Images/shortplatform.png", 4000, 250, 180, 40);
        Platform longPlatform4 = new Platform("Princess Images/longplatform.png", 4750, 310, 375, 43);
        Platform shortPlatform6 = new Platform("Princess Images/shortplatform.png", 5185, 150, 180, 40);

        //add platforms to the level
        level1.addPlatform(longPlatform);
        level1.addPlatform(shortPlatform);
        level1.addPlatform(shortPlatform2);
        level1.addPlatform(shortPlatform3);
        level1.addPlatform(longPlatform2);
        level1.addPlatform(shortPlatform4);
        level1.addPlatform(longPlatform3);
        level1.addPlatform(shortPlatform5);
        level1.addPlatform(longPlatform4);
        level1.addPlatform(shortPlatform6);
        
        //collectibles
        Collectible coin1 = new Collectible("Princess Images/mickey coin.png", 770, 267, 30, 30);
        Collectible coin2 = new Collectible("Princess Images/mickey coin.png", 400, 400, 30, 30);
        Collectible coin3 = new Collectible("Princess Images/mickey coin.png", 1110, 220, 30, 30);
        Collectible coin4 = new Collectible("Princess Images/mickey coin.png", 1800, 240, 30, 30);
        Collectible candle = new Collectible("Princess Images/candle.png", 2000, 400, 20, 50);
        Collectible coin5 = new Collectible("Princess Images/mickey coin.png", 2190, 285, 30, 30);
        Collectible coin6 = new Collectible("Princess Images/mickey coin.png", 2600, 196, 30, 30);
        Collectible chest1 = new Collectible("Princess Images/chest.png", 3500, 158, 55, 50);
        Collectible coin7 = new Collectible("Princess Images/mickey coin.png", 4100, 225, 30, 30);
        Collectible coin8 = new Collectible("Princess Images/mickey coin.png", 4470, 395, 30, 30);
        Collectible chest2 = new Collectible("Princess Images/chest.png", 5252, 110, 55, 50);
        Collectible coin9 = new Collectible("Princess Images/mickey coin.png", 5600, 400, 30, 30);
        
        //add collectibles to the level
        level1.addCollectible(coin1);
        level1.addCollectible(coin2);
        level1.addCollectible(coin3);
        level1.addCollectible(coin4);
        level1.addCollectible(candle);
        level1.addCollectible(coin5);
        level1.addCollectible(coin6);
        level1.addCollectible(chest1);
        level1.addCollectible(coin7);
        level1.addCollectible(coin8);
        level1.addCollectible(chest2);
        level1.addCollectible(coin9);

        //label for the score
        scoreLabel = new Label("Score: " + score);
        scoreLabel.setStyle("-fx-font-size: 20px; -fx-text-fill: white; -fx-font-weight: bold;");
        //position the score label on the screen
        scoreLabel.setLayoutX(20);
        scoreLabel.setLayoutY(27);  
        //add the score label to the root container
        root.getChildren().add(scoreLabel);

        //hazards
        Hazard hazard1 = new Hazard("file:Princess Images/apple.png", 1200, 210, 40, 40);
        Hazard hazard2 = new Hazard("file:Princess Images/apple.png", 800, 400, 40, 40);
        Hazard hazard3 = new Hazard("file:Princess Images/apple.png", 1550, 400, 40, 40);
        Hazard hazard4 = new Hazard("file:Princess Images/thorns.png", 2790, 375, 107, 57);
        Hazard hazard5 = new Hazard("file:Princess Images/apple.png", 3110, 290, 40, 40);
        Hazard hazard6 = new Hazard("file:Princess Images/apple.png", 3700, 400, 40, 40);
        Hazard hazard7 = new Hazard("file:Princess Images/thorns.png", 4200, 370, 118, 63);
        Hazard hazard8 = new Hazard("file:Princess Images/thorns.png", 1050, 380, 130, 73);
        Hazard hazard9 = new Hazard("file:Princess Images/thorns.png", 5750, 300, 312, 175);
        Hazard hazard10 = new Hazard("file:Princess Images/thorns.png", 6100, 300, 312, 175);

        //add hazards to the level
        level1.addHazard(hazard1);
        level1.addHazard(hazard2);
        level1.addHazard(hazard3);
        level1.addHazard(hazard4);
        level1.addHazard(hazard5);
        level1.addHazard(hazard6);
        level1.addHazard(hazard7);
        level1.addHazard(hazard8);
        level1.addHazard(hazard9);
        level1.addHazard(hazard10);
        
        //add hazards to the root layout
        root.getChildren().add(hazard1);
        root.getChildren().add(hazard2);
        root.getChildren().add(hazard3);
        root.getChildren().add(hazard4);
        root.getChildren().add(hazard5);
        root.getChildren().add(hazard6);
        root.getChildren().add(hazard7);
        root.getChildren().add(hazard8);
        root.getChildren().add(hazard9);
        root.getChildren().add(hazard10);

        //label for lives
        livesLabel = new Label("Lives: " + lives);
        livesLabel.setStyle("-fx-font-size: 22px; -fx-text-fill: red; -fx-font-weight: bold;");
        //position the label
        livesLabel.setLayoutX(20);
        livesLabel.setLayoutY(0);
        //add lives label to the root container
        root.getChildren().add(livesLabel);

        //add the player to the root container
        root.getChildren().add(player);
        
        //set up the game scene
        Scene gameScene = new Scene(root, 800, 600, Color.WHITE);

        //key press events for walking and jumping
        gameScene.setOnKeyPressed(event -> {
            switch (event.getCode()) {
                case RIGHT: //the screen scrolls, so the character can only "move" in 1 direction - so right arrow key only
                    isWalking = true; //start walking when the key is pressed
                    break;
                case SPACE: //spacebar to jump
                    if (!isJumping) {
                        velocityY = jumpStrength;
                        isJumping = true;
                        //set jumping images based on selected character
                        if (currentCharacter.equals("anna") || currentCharacter.equals("tiana") || currentCharacter.equals("jasmine")) {
                            player.setImage(jumpingImages[0]);
                        }
                    }
                    break;
            }
        });

        //key release event to stop the character moving
        gameScene.setOnKeyReleased(event -> {
            if (event.getCode() == KeyCode.RIGHT) {
                isWalking = false; //stop walking when key is released
                player.setImage(idleImage); //player returns to idle image
            }
        });

        //walking animation timeline
        walkingAnimation = new Timeline(new KeyFrame(Duration.millis(100), e -> {
            if (isWalking) {
            	//cycle through the 3 walking images
                currentWalkImageIndex = (currentWalkImageIndex + 1) % walkingImages.length;
                player.setImage(walkingImages[currentWalkImageIndex]);
            }
        }));
        walkingAnimation.setCycleCount(Timeline.INDEFINITE); //no set end for the timeline
        walkingAnimation.play(); //play the animation

        //jumping animation timeline
        Timeline jumpAnimation = new Timeline(new KeyFrame(Duration.millis(16), e -> {
            //account for platforms that the player can jump on
            boolean onPlatform = false;
            for (Platform platform : level1.getPlatforms()) {
                //get platform bounds so we know where the edges of the platform are
                double platformTop = platform.localToScene(platform.getBoundsInLocal()).getMinY();
                double platformLeft = platform.localToScene(platform.getBoundsInLocal()).getMinX();
                double platformRight = platform.localToScene(platform.getBoundsInLocal()).getMaxX();
                
                //get player bounds (to determine contact with platform)
                double playerBottom = player.localToScene(player.getBoundsInLocal()).getMaxY();
                double playerLeft = player.localToScene(player.getBoundsInLocal()).getMinX();
                double playerRight = player.localToScene(player.getBoundsInLocal()).getMaxX();
                
                //check if player is on platform
                if (Math.abs(playerBottom - platformTop) < 5 && // Small threshold for being on platform
                    playerRight > platformLeft && 
                    playerLeft < platformRight) {
                    onPlatform = true;
                    break;
                }
            }

            //fall if not on platform or the ground (in air character jumping image)
            if (!onPlatform && !isJumping && player.getLayoutY() < 240) {
                isJumping = true;
                velocityY = 0;
                if (currentCharacter.equals("anna") || currentCharacter.equals("tiana") || currentCharacter.equals("jasmine")) {
                    player.setImage(jumpingImages[1]);
                }
            }

            //apply gravity if jumping (gravity and velocity about killed me. I suck at physics lol)
            if (isJumping) {
                velocityY += gravity;
                player.setLayoutY(player.getLayoutY() + velocityY);

                //update jump animation based on velocity
                if (currentCharacter.equals("anna") || currentCharacter.equals("tiana") || currentCharacter.equals("jasmine")) {
                    if (velocityY < 0) {
                        //in air image if player is going up
                        player.setImage(jumpingImages[1]);
                    } else if (velocityY > 0) {
                        //landing image if player is going down/landing
                        player.setImage(jumpingImages[2]);
                    }
                }

                //check for platform collision while falling
                for (Platform platform : level1.getPlatforms()) {
                    //get platform bounds again
                    Bounds platformBounds = platform.localToScene(platform.getBoundsInLocal());
                    double platformTop = platformBounds.getMinY();
                    double platformLeft = platformBounds.getMinX();
                    double platformRight = platformBounds.getMaxX();
                    
                    //get player bounds again
                    Bounds playerBounds = player.localToScene(player.getBoundsInLocal());
                    double playerBottom = playerBounds.getMaxY();
                    double playerLeft = playerBounds.getMinX();
                    double playerRight = playerBounds.getMaxX();
                    
                    //check if player is falling over platform
                    if (velocityY > 0 && //falling
                        Math.abs(playerBottom - platformTop) < 15 && //buffer of within 15 pixels of the top of the platform
                        playerRight > platformLeft + 20 &&
                        playerLeft < platformRight - 20) {
                        
                        //position player on platform
                        player.setLayoutY(platformTop - playerHeight + 10); //10 pixel buffer to make it look more natural
                        
                        //reset jump flag and velocity
                        isJumping = false;
                        velocityY = 0;
                        
                        //set player image based on what they are doing
                        if (currentCharacter.equals("anna") || currentCharacter.equals("tiana") || currentCharacter.equals("jasmine")) {
                            if (isWalking) {
                                player.setImage(walkingImages[currentWalkImageIndex]);
                            } else {
                                player.setImage(idleImage);
                            }
                        }
                        break;
                    }
                }

                //check for ground collision (if no platform)
                if (player.getLayoutY() >= 240) { //ground level
                    player.setLayoutY(240);
                    isJumping = false;
                    velocityY = 0;
                    if (currentCharacter.equals("anna") || currentCharacter.equals("tiana") || currentCharacter.equals("jasmine")) {
                        if (isWalking) {
                            player.setImage(walkingImages[currentWalkImageIndex]);
                        } else {
                            player.setImage(idleImage);
                        }
                    }
                }
            }
        }));
        jumpAnimation.setCycleCount(Timeline.INDEFINITE); //no set end for timeline
        jumpAnimation.play(); //play jump animation

        //background animation timeline
        backgroundMovement = new Timeline(
            new KeyFrame(Duration.seconds(0.016), e -> {
                if (isWalking || isJumping) {
                    //get both background images (from the level class)
                    ImageView background1 = level1.getBackground1();
                    ImageView background2 = level1.getBackground2();

                    //scroll the backgrounds left
                    double currentX1 = background1.getTranslateX();
                    double currentX2 = background2.getTranslateX();

                    //move both backgrounds to the left at 2 pixels when walking, 3 pixels when jumping
                    double scrollSpeed = isJumping ? 3 : 2;
                    background1.setTranslateX(currentX1 - scrollSpeed);
                    background2.setTranslateX(currentX2 - scrollSpeed);

                    //move all elements at the same speed so the scene moves together
                    for (Platform platform : level1.getPlatforms()) {
                        //update platform positions
                        double newX = platform.getLayoutX() - scrollSpeed;
                        platform.setLayoutX(newX);
                        
                        //reset translation
                        platform.setTranslateX(0);
                    }
                    for (Collectible collectible : level1.getCollectibles()) {
                        collectible.setTranslateX(collectible.getTranslateX() - scrollSpeed);
                    }
                    for (Hazard hazard : level1.getHazards()) {
                        hazard.setTranslateX(hazard.getTranslateX() - scrollSpeed);
                    }

                    //iff background 1 has passed, reset it to the right
                    if (background1.getTranslateX() <= -background1.getFitWidth()) {
                        background1.setTranslateX(background2.getTranslateX() + background2.getFitWidth());
                    }

                    //if background 2 has passed, reset it to the right (so they alternate)
                    if (background2.getTranslateX() <= -background2.getFitWidth()) {
                        background2.setTranslateX(background1.getTranslateX() + background1.getFitWidth());
                    }

                    //get the player's Y position and height for the bottom half of the player
                    //**I only want to do the bottom half, so that the player won't accidentally collect coins or hazards on platforms they are not on
                    double playerBottomY = player.getLayoutY() + playerHeight / 2;

                    //check for item collection with iterator
                    Iterator<Collectible> coinIterator = level1.getCollectibles().iterator();
                    while (coinIterator.hasNext()) {
                        Collectible coin = coinIterator.next();
                        double playerCenterX = player.localToScene(player.getBoundsInLocal()).getCenterX();
                        double coinCenterX = coin.localToScene(coin.getBoundsInLocal()).getCenterX();
                        double coinTopY = coin.localToScene(coin.getBoundsInLocal()).getMinY();
                        double coinBottomY = coin.localToScene(coin.getBoundsInLocal()).getMaxY();
                        double horizontalThreshold = 50;

                        //the item is "collected" or removed if the bottom half of the player intersects it
                        if (Math.abs(playerCenterX - coinCenterX) < horizontalThreshold) {
                            if (coinBottomY > playerBottomY && coinTopY < playerBottomY + playerHeight / 2) {
                                root.getChildren().remove(coin);
                                coinIterator.remove();
                                
                                //check what type of collectible it is
                                //if it's the treasure chest
                                if (coin.getImage().getUrl().contains("chest.png")) {
                                    score += 300; //update the score - chest is worth 300 points
                                //if it's the candle
                                } else if (coin.getImage().getUrl().contains("candle.png")) {
                                    lives++; //candle gives an extra life
                                    livesLabel.setText("Lives: " + lives); //update lives label
                                //if it's just a regular coin
                                } else {
                                    score += 100; //update the score - regular coins are worth 100 points
                                }
                                
                                scoreLabel.setText("Score: " + score); //update score label
                                
                                //check for win condition- player gets 1000 points, they win the level!
                                if (score >= 1000) {
                                    winGame();
                                }
                            }
                        }
                    }

                    //check for hazard collision
                    Iterator<Hazard> hazardIterator = level1.getHazards().iterator();
                    while (hazardIterator.hasNext()) {
                        Hazard hazard = hazardIterator.next();
                        double playerCenterX = player.localToScene(player.getBoundsInLocal()).getCenterX();
                        double hazardCenterX = hazard.localToScene(hazard.getBoundsInLocal()).getCenterX();
                        double hazardTopY = hazard.localToScene(hazard.getBoundsInLocal()).getMinY();
                        double hazardBottomY = hazard.localToScene(hazard.getBoundsInLocal()).getMaxY();
                        double horizontalThreshold = 50;

                        //same as with coins, it is removed if the bottom half of the player intersects it
                        if (Math.abs(playerCenterX - hazardCenterX) < horizontalThreshold) {
                            if (hazardBottomY > playerBottomY && hazardTopY < playerBottomY + playerHeight / 2) {
                                root.getChildren().remove(hazard);
                                hazardIterator.remove();
                                
                                //check if it's the thorns
                                if (hazard.getImage().getUrl().contains("thorns.png")) {
                                    lives -= 2; //update lives - thorns take 2
                                } else {
                                    lives--; //update lives - apples only take 1
                                }
                                
                                livesLabel.setText("Lives: " + lives); //update lives label
                                //if the player runs out of lives, the game is over
                                if (lives <= 0) {
                                    gameOver();
                                    return;
                                }
                            }
                        }
                    }
                }
            })
        );

        backgroundMovement.setCycleCount(Timeline.INDEFINITE); //no set end for background movement timeline
        backgroundMovement.play(); //play the animation

        //set and display title and scene - game name
        primaryStage.setTitle("Enchanted Kingdoms: Princess Adventure");
        primaryStage.setScene(gameScene);
        primaryStage.show();

        //request focus is for keyboard press and releases
        root.setFocusTraversable(true);
        root.requestFocus();
    }
    
    //method for when the player loses the game
    private void gameOver() {
        //stop all game animations so they cannot continue
        walkingAnimation.stop();
        backgroundMovement.stop();
        
        //remove keyboard event handlers so they cannot press anymore keys
        root.getScene().setOnKeyPressed(null);
        root.getScene().setOnKeyReleased(null);
        
        //display Game Over message on screen
        Label gameOverLabel = new Label("Game Over!");
        gameOverLabel.setStyle("-fx-font-size: 60px; -fx-text-fill: darkred; -fx-font-weight: bold;");
        //set label position
        gameOverLabel.setLayoutX(250);
        gameOverLabel.setLayoutY(200);

        //Restart Game button
        Button restartButton = new Button("Restart Game");
        restartButton.setStyle("-fx-background-color: #99C68E; -fx-text-fill: teal; -fx-font-size: 24px; -fx-padding: 10px; -fx-font-weight: bold;");
        //set button position
        restartButton.setLayoutX(325);
        restartButton.setLayoutY(300);

        //Exit Game button
        Button exitButton = new Button("Exit Game");
        exitButton.setStyle("-fx-background-color: #FFB6C1; -fx-text-fill: darkred; -fx-font-size: 24px; -fx-padding: 10px; -fx-font-weight: bold;");
        //set button position
        exitButton.setLayoutX(345);
        exitButton.setLayoutY(370);

        //add action - make the button work
        restartButton.setOnAction(e -> {
            //close the current game window
            Stage currentStage = (Stage) root.getScene().getWindow();
            currentStage.close();
            
            //relaunch the game
            GameWindow newGame = new GameWindow();
            newGame.start(new Stage());
        });

        //add exit action
        exitButton.setOnAction(e -> {
            //close the current game window
            Stage currentStage = (Stage) root.getScene().getWindow();
            currentStage.close();
        });

        //add the label and buttons to the root container
        root.getChildren().addAll(gameOverLabel, restartButton, exitButton);
    }

    //method for when the player wins the game
    private void winGame() {
        //stop all game animations
        walkingAnimation.stop();
        backgroundMovement.stop();
        
        //remove keyboard event handlers
        root.getScene().setOnKeyPressed(null);
        root.getScene().setOnKeyReleased(null);
        
        //display winning message
        Label winLabel = new Label("You Win!");
        winLabel.setStyle("-fx-font-size: 70px; -fx-text-fill: darkgreen; -fx-font-weight: bold;");
        //set label position
        winLabel.setLayoutX(250);
        winLabel.setLayoutY(200);

        //create a play again button
        Button playAgainButton = new Button("Play Again!");
        playAgainButton.setStyle("-fx-background-color: #99C68E; -fx-text-fill: teal; -fx-font-size: 24px; -fx-padding: 10px; -fx-font-weight: bold;");
        //position the button on the screen
        playAgainButton.setLayoutX(325);
        playAgainButton.setLayoutY(300);

        //create another exit button
        Button exitButton = new Button("Exit Game");
        exitButton.setStyle("-fx-background-color: #FFB6C1; -fx-text-fill: darkred; -fx-font-size: 24px; -fx-padding: 10px; -fx-font-weight: bold;");
        //position the button on the screen
        exitButton.setLayoutX(332);
        exitButton.setLayoutY(370);

        //add action to make the play again button work
        playAgainButton.setOnAction(e -> {
            //close the current game window
            Stage currentStage = (Stage) root.getScene().getWindow();
            currentStage.close();
            
            //restart game
            GameWindow newGame = new GameWindow();
            newGame.start(new Stage());
        });

        //add action for the exit button
        exitButton.setOnAction(e -> {
            //close the current game window
            Stage currentStage = (Stage) root.getScene().getWindow();
            currentStage.close();
        });
		
        //add the buttons and label to the root container
        root.getChildren().addAll(winLabel, playAgainButton, exitButton);
    }

    //method to show how to play instructions
    private void showHowToPlay() {
        //create a new window for instructions
        Stage instructionStage = new Stage();
        StackPane instructionPane = new StackPane();
        
        //create a VBox to hold the instructions
        VBox instructionBox = new VBox(20);
        instructionBox.setAlignment(Pos.CENTER);
        instructionBox.setStyle("-fx-padding: 20px; -fx-background-color: rgba(255, 255, 255, 0.9);");
        
        //title
        Label titleLabel = new Label("How to Play");
        titleLabel.setStyle("-fx-font-size: 40px; -fx-text-fill: darkblue; -fx-font-weight: bold;");
        
        //instructions
        Label instruction1 = new Label("• Use the RIGHT ARROW key to move forward");
        Label instruction2 = new Label("• Press SPACEBAR to jump");
        Label instruction3 = new Label("• Collect coins as you go - each coin is worth 100 points!");
        Label instruction4 = new Label("• Treasure chests are worth 300 points each!");
        Label instruction5 = new Label("• Collect candles to gain extra lives");
        Label instruction6 = new Label("• Avoid apples and thorns - they take away lives");
        Label instruction7 = new Label("• Collect 1000 points to win!");
        
        //style the instruction labels
        String instructionStyle = "-fx-font-size: 24px; -fx-text-fill: darkblue;";
        instruction1.setStyle(instructionStyle);
        instruction2.setStyle(instructionStyle);
        instruction3.setStyle(instructionStyle);
        instruction4.setStyle(instructionStyle);
        instruction5.setStyle(instructionStyle);
        instruction6.setStyle(instructionStyle);
        instruction7.setStyle(instructionStyle);
        
        //close button
        Button closeButton = new Button("Close");
        closeButton.setStyle("-fx-background-color: #66CCCC; -fx-text-fill: teal; -fx-font-size: 24px; -fx-padding: 10px; -fx-font-weight: bold;");
        closeButton.setOnAction(e -> instructionStage.close());
        
        //add all elements to the instruction box
        instructionBox.getChildren().addAll(titleLabel, instruction1, instruction2, instruction3, instruction4, instruction5, instruction6, instruction7, closeButton);
        
        //add the instruction box to the pane
        instructionPane.getChildren().add(instructionBox);
        
        //set the background
        BackgroundImage backgroundImage = new BackgroundImage(
                new Image("file:Princess Images/CharacterMenu.jpg", 1000, 625, false, true),
                BackgroundRepeat.NO_REPEAT,
                BackgroundRepeat.NO_REPEAT,
                BackgroundPosition.CENTER,
                BackgroundSize.DEFAULT
        );
        instructionPane.setBackground(new Background(backgroundImage));
        
        //create and show the scene
        Scene instructionScene = new Scene(instructionPane, 800, 600);
        instructionStage.setTitle("How to Play");
        instructionStage.setScene(instructionScene);
        instructionStage.show();
    }

    //main method, launch the game
    public static void main(String[] args) {
        launch(args);
    }
}
