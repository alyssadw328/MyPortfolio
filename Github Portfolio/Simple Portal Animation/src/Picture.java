
public class Picture
{
    private Square portal;
    private Square portal2;
    private Circle roundPortal;
    private Circle roundPortal2;
    private Person dude;
    private boolean drawn;

    /**
     * Constructor for objects of class Picture
     */
    public Picture()
    {
        portal = new Square();
        portal2 = new Square();
        roundPortal = new Circle();
        roundPortal2 = new Circle();
        dude = new Person();
        drawn = false;
    }

    /**
     * Draw this picture.
     */
    public void draw()
    {
        if(!drawn) {
            portal.moveHorizontal(75);
            portal.moveVertical(30);
            portal.changeSize(90);
            portal.makeVisible();
            
            dude.makeVisible();
            
            portal2.moveHorizontal(300);
            portal2.moveVertical(100);
            portal2.changeColor("magenta");
            portal2.changeSize(150);
            
            roundPortal.changeSize(75);
            roundPortal.changeColor("green");
            roundPortal.moveHorizontal(250);
            
            roundPortal2.changeSize(75);
            roundPortal2.moveVertical(80);
            drawn = true;
        }
    }
    
    

    /**
     * Change this picture to use color display
     */
    public void setColor()
    {
        portal.changeColor("red");
    }
    public void animate()
    {
        drawn = false;
        reset();
        draw();
        dude.slowMoveHorizontal(150);
        portal.changeColor("yellow");
        dude.changeColor("magenta");
        dude.slowMoveHorizontal(65);
        dude.changeColor("green");
        portal.makeInvisible();
        dude.changeSize(70, 40);
        dude.slowMoveHorizontal(10);
        
        dude.changeSize(80, 50);
        dude.slowMoveHorizontal(10);
        
        dude.changeSize(100, 70);
        dude.slowMoveHorizontal(10);
        dude.changeSize(125, 90);
        dude.slowMoveHorizontal(10);
        
        portal2.makeVisible();
        
        dude.slowMoveHorizontal(10);
        dude.slowMoveVertical(25);
        dude.slowMoveHorizontal(10);
        dude.slowMoveVertical(25);
        dude.slowMoveHorizontal(10);
        dude.slowMoveVertical(30);
        dude.slowMoveHorizontal(120);
        
        portal2.changeColor("blue");
        dude.changeColor("magenta");
        dude.slowMoveVertical(-140);
        dude.changeSize(100, 70);
        dude.changeColor("yellow");
        dude.changeSize(80, 50);
        portal2.makeInvisible();
        dude.slowMoveVertical(-25);
        dude.changeSize(70, 40);
        dude.slowMoveVertical(-20);
        dude.changeSize(60, 30);
        dude.slowMoveHorizontal(-25);
        dude.slowMoveVertical(33);
        dude.slowMoveHorizontal(-75);
        
        roundPortal.makeVisible();
        dude.slowMoveHorizontal(-65);
        
        dude.makeInvisible();
        roundPortal.makeInvisible();
        
        try {
			Thread.sleep(300);
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
        
        roundPortal2.makeVisible();
        
        dude.moveHorizontal(-250);
        dude.moveVertical(80);
        dude.makeVisible();
        
        try {
			Thread.sleep(500);
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
        
        roundPortal2.makeInvisible();
        try {
			Thread.sleep(200);
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
        dude.slowMoveVertical(350);
        
        dude.makeInvisible();
        dude.moveHorizontal(160);
        dude.moveVertical(-600);
        dude.makeVisible();
        dude.slowMoveVertical(100);
        portal.changeColor("red");
        portal.makeVisible();
        dude.slowMoveVertical(135);
        dude.changeColor("black");
        
    }
    public void reset()
    {

        portal.makeInvisible();
        
    }
}
