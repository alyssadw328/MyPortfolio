import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.text.SimpleDateFormat;
import java.util.Timer;
import java.util.TimerTask;

//Alyssa Walker
//CPT 236- A80S
//Lab 7- Clock/Timer/Stopwatch

public class ClockTimer extends JFrame {
	//Java added this as an error fix- I guess to show this is the specific version of this class, so that it won't cause issues if/when the class is changed
    private static final long serialVersionUID = 1L;
    
    //create gui labels, buttons, field
    private JLabel clockLabel;
    private JLabel timerLabel;
    private JLabel stopwatchLabel;
    private JButton startStopwatchButton, resetStopwatchButton, startTimerButton, stopTimerButton;
    private JTextField timerField;
    
    //initialize variables
    private int stopwatchSeconds = 0;
    private boolean stopwatchRunning = false;
    private Timer stopwatchTimer;
    private int timerSeconds = 0;  
    private int initialTimerSeconds = 0;  
    private Timer timerTask;
    private Timer clockUpdater;

    public ClockTimer() {
    	//title 
        setTitle("Clock/Timer/Stopwatch");
        //gui display size
        setSize(400, 280);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        //set layout with 3 rows and 1 column
        setLayout(new GridLayout(3, 1));
        //make the background pink just because I like pink
        getContentPane().setBackground(Color.PINK);
        
        //clock
        //set the clock label
        clockLabel = new JLabel("Clock", SwingConstants.CENTER);
        //set clock format
        clockLabel.setFont(new Font("Serif", Font.BOLD, 30));
        //add the clock to the gui display
        add(clockLabel);
        
        //timer
        //create a new timer panel
        JPanel timerPanel = new JPanel();
        //set the layout
        timerPanel.setLayout(new FlowLayout());
        //create label and field for timer
        timerLabel = new JLabel("Timer: 00:00");
        timerField = new JTextField("00:00", 5);
        //make the timer editable so the user can input the time
        timerField.setEditable(true);
        //create buttons for timer
        startTimerButton = new JButton("Start Timer");
        stopTimerButton = new JButton("Stop Timer");
        //stop timer button is not enabled while the timer is not running
        stopTimerButton.setEnabled(false);

        //add action listener to start timer button to respond to user click actions on the button, and create new action listener object
        startTimerButton.addActionListener(new ActionListener() {
        	//call the start timer method when the (button click) action is performed
            public void actionPerformed(ActionEvent e) {
                startTimer();
            }
        });

        //do the same thing for the stop timer button
        stopTimerButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                stopTimer();
            }
        });

        //add label/field/buttons to timer panel
        timerPanel.add(timerLabel);
        timerPanel.add(timerField);
        timerPanel.add(startTimerButton);
        timerPanel.add(stopTimerButton);
        //display the timer panel on gui
        add(timerPanel);
        
        //stopwatch
        //create a new stopwatch panel
        JPanel stopwatchPanel = new JPanel();
        //set the layout
        stopwatchPanel.setLayout(new FlowLayout());
        //create label and buttons
        stopwatchLabel = new JLabel("Stopwatch: 00:00");
        startStopwatchButton = new JButton("Start Stopwatch");
        resetStopwatchButton = new JButton("Reset Stopwatch");
        //add an action listener, same as with the timer
        startStopwatchButton.addActionListener(new ActionListener() {
        	//call the start stopwatch method when the (button click) action is performed
            public void actionPerformed(ActionEvent e) {
                startStopwatch();
            }
        });
        //do the same for reset stopwatch
        resetStopwatchButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                resetStopwatch();
            }
        });
        //add label and buttons to panel
        stopwatchPanel.add(stopwatchLabel);
        stopwatchPanel.add(startStopwatchButton);
        stopwatchPanel.add(resetStopwatchButton);
        //add stopwatch panel to gui display
        add(stopwatchPanel);
        
        //make the timer and stopwatch panels cyan because I think it's pretty
        timerPanel.setBackground(Color.cyan);
        stopwatchPanel.setBackground(Color.cyan);
        
        //update clock so it stays correct
        updateClock();
    }

    //update clock method
    private void updateClock() {
    	//create a new timer to act as the clock
        clockUpdater = new Timer();
        //set the clock to run at a fixed (time) rate
        clockUpdater.scheduleAtFixedRate(new TimerTask() {
            public void run() {
            	//set the hour/minute/second format (with am/pm)
                SimpleDateFormat sdf = new SimpleDateFormat("hh:mm:ss a");
                String time = sdf.format(System.currentTimeMillis());
                //display the time as the clock label
                clockLabel.setText(time);
            }
        }, 0, 1000); //no delay to execute task, execute every second (1000 ms)
    }

    //start timer method
    private void startTimer() {
        try {
            //allow user to input time into timer
            String inputTime = timerField.getText().trim();
            //split the string input by : delimiter
            String[] timeParts = inputTime.split(":");

            //make sure the input is in the correct time format (mins:secs)
            if (timeParts.length != 2) {
            	//error message if format is incorrect
                JOptionPane.showMessageDialog(this, "Invalid time format! Please use mm:ss.");
                return;
            }

            //first part split by delimiter is minutes
            int userMinutes = Integer.parseInt(timeParts[0]);
            //second part split by delimiter is seconds
            int userSeconds = Integer.parseInt(timeParts[1]);

            //make sure the value is a valid time amount (no negatives or seconds >= 60)
            if (userMinutes < 0 || userSeconds < 0 || userSeconds >= 60) {
            	//error message if time value is incorrect
                JOptionPane.showMessageDialog(this, "Invalid time values! Minutes and seconds must be valid.");
                return;
            }

            //convert minutes and seconds into only seconds
            timerSeconds = (userMinutes * 60) + userSeconds;
            //keep initial time entered for resetting the timer
            initialTimerSeconds = timerSeconds;  
        } catch (NumberFormatException e) {
        	//show error message if the user input is invalid
            JOptionPane.showMessageDialog(this, "Invalid input! Please enter a valid time.");
            return;
        }

        //create a new timer task
        timerTask = new Timer();
        //run timer at fixed rate/interval
        timerTask.scheduleAtFixedRate(new TimerTask() {
            public void run() {
            	//run the timer - begin counting down by seconds
                if (timerSeconds > 0) {
                    timerSeconds--;
                    //calculate mins by dividing secs by 60
                    int minutes = timerSeconds / 60;
                    //calculate remaining seconds using mod
                    int seconds = timerSeconds % 60;
                    //update the timer field with current mins and secs as it counts down
                    timerField.setText(String.format("%02d:%02d", minutes, seconds));
                } else {
                    //when the time runs out at 0, stop the timer and display a message
                    stopTimer();
                    JOptionPane.showMessageDialog(null, "Time is up!"); 
                }
            }
        }, 0, 1000); //no delay, execute every second (1000 ms)

        //disable and enable the start start and stop buttons respectively (timer is started)
        startTimerButton.setEnabled(false);
        stopTimerButton.setEnabled(true);
    }

    //stop timer method
    private void stopTimer() {
    	//if timer task is not null, cancel (stop) the timer from running
        if (timerTask != null) {
            timerTask.cancel();
        }
        //enable and disable the start and stop buttons when timer is stopped
        startTimerButton.setEnabled(true);
        stopTimerButton.setEnabled(false);
    }

    //reset timer method
    private void resetTimer() {
    	//reset to the initial value
        timerSeconds = initialTimerSeconds;  
        //calculate minutes and remaining seconds
        int minutes = timerSeconds / 60;
        int seconds = timerSeconds % 60;
        //update the timer filed with current mins and seconds
        timerField.setText(String.format("%02d:%02d", minutes, seconds));
    }

    //start stopwatch method
    private void startStopwatch() {
        if (stopwatchRunning) {
            //pause it if it's running
            stopStopwatch();
        } else {
            //start it if it's not running
            stopwatchRunning = true;
            //change the button text from start to pause
            startStopwatchButton.setText("Pause Stopwatch");
            //create a new stopwatch timer task
            stopwatchTimer = new Timer();
            //run at fixed interval
            stopwatchTimer.scheduleAtFixedRate(new TimerTask() {
                public void run() {
                	//run the stopwatch - begin counting up by seconds
                    if (stopwatchRunning) {
                        stopwatchSeconds++;
                        //calculate mins and remaining secs
                        int minutes = stopwatchSeconds / 60;
                        int seconds = stopwatchSeconds % 60;
                        //update stopwatch with mins and secs as it counts up
                        stopwatchLabel.setText(String.format("Stopwatch: %02d:%02d", minutes, seconds));
                    }
                }
            }, 0, 1000); //no delay, 1 second interval (1000 ms)
        }
    }

    //pause stopwatch method
    private void stopStopwatch() {
    	//stop running the stopwatch
        stopwatchRunning = false;
        //change the button text to resume
        startStopwatchButton.setText("Resume Stopwatch");
        //stop the stopwatch timer from updating
        stopwatchTimer.cancel();
    }

    //reset stopwatch method
    private void resetStopwatch() {
    	//reset seconds to 0
        stopwatchSeconds = 0;
        stopwatchLabel.setText("Stopwatch: 00:00");
    }

    public static void main(String[] args) {
    	//use this to make sure the gui runs and updates properly
        SwingUtilities.invokeLater(new Runnable() {
            public void run() {
            	//create new clock timer instance
                ClockTimer app = new ClockTimer();
                //make it visible to display
                app.setVisible(true);
            }
        });
    }
}