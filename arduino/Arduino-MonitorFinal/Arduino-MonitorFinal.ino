#include <LiquidCrystal_I2C.h>
#include <Wire.h>

LiquidCrystal_I2C lcd(0x27, 20, 4); //Intializes LCD on proper I2C Address and screen resolution of 20x4 bits.
int bLED = 10;  //Variable for LEDs
int rLED = 9;  //Fail safe if alarm fails
int buzzer_pin = 5; 




//Structure to facilitate parsing of buzzer alarm and keep track of timing and frequency
struct buzzer
{
  bool active = false;  //Buzzer intially off
  int pin = 5;  //Buzzer pin
  int freq = 1000; //sets frequency
  unsigned long current_micro = 0;  //Datatype for Micros()
  unsigned long next_micro = 0; //Datatype for Micros()
};
buzzer alarm;



char c; // Sets up Variable
int  whichLine; // to keep track of which line of data we are parsing
int maxTemp = 85;  //Max Temperature (****CAN CHANGE TO ANY VALUE***)

// Structure to facilitate parsing of serial data and keep track of temps
struct temp
{
  char runningBuff[3];
  char snapshot[3];
  int  intOne = 0;
  int  intTwo = 0;
  int  value = 0;
};
temp lineOne;
temp lineTwo;



void setup()
{
  pinMode(bLED, OUTPUT); //sets LED as output
  pinMode(rLED, OUTPUT); //Sets LED as output
  pinMode (alarm.pin, OUTPUT); //Sets Buzzer as output
  lcd.init(); //Installs LCD
  lcd.backlight(); //Turns on LCD backlight
  lcd.print("Hello!");  //Shows LCD is working by displaying hello before anything else.
  delay(10);
  lcd.clear();  //Clears screen
  Serial.begin(9600); //Sets bit rate of serial monitor same as C# GUI.

  pinMode(buzzer_pin, OUTPUT);
}

void loop()
{
  read_serial();
  extract_temp();
  update_io();
  //debug();  //Debugging loop, remove "//" to enable debug
  //buzzer();
}

void debug()
{
  lcd.setCursor(0,3);
  lcd.print(lineOne.snapshot[1]);
}



// function to update the LEDs and sound the buzzer
void update_io()
{
  if (lineOne.value >= maxTemp)
  {
    // alarmy stuff!
    digitalWrite(rLED, HIGH); //Fail safe if alarm fails
    //alarm.active = true;
    analogWrite(buzzer_pin, 127);
  }

  else if (lineTwo.value >= maxTemp)
  {
    // alarmy stuff!
    digitalWrite(rLED, HIGH); //Fail safe if alarm fails
    //alarm.active = false;
    analogWrite(buzzer_pin, 127);
  }

  else
  {
    // turn off the alarmy stuff!
    digitalWrite(rLED, LOW); //Fail safe if alarm fails
    //alarm.active = false;
    digitalWrite(buzzer_pin, LOW);
  }
}







//Alarm Function
void buzzer()
{
  if (alarm.active) //active alarm function
  {
    alarm.current_micro = micros(); //Keeps track of alarm time

    if(alarm.current_micro >= alarm.next_micro)
    {
      alarm.pin ^= 1; //XOR Gate
      alarm.next_micro = micros()+((1000000/alarm.freq)/2);
    }
  }

  else
  {
    digitalWrite(alarm.pin, LOW);
  }
}







// function to parse the character data and get an integer value for temperature
void extract_temp()
{
  // convert the characers in snapshots to their respective integers
  lineOne.intOne = lineOne.snapshot[0] - '0';   // subtract the ascii value for zero to convert to integer
  lineOne.intTwo = lineOne.snapshot[1] - '0';

  lineTwo.intOne = lineTwo.snapshot[0] - '0';
  lineTwo.intTwo = lineTwo.snapshot[1] - '0';

  // combine the two individual int values into a single integer
  lineOne.value = lineOne.intOne*10 + lineOne.intTwo;
  lineTwo.value = lineTwo.intOne*10 + lineTwo.intTwo;

  //Used for debugging below
  //lineOne.value = lineOne.intOne + lineOne.intTwo*10;
  //lineTwo.value = lineTwo.intOne + lineTwo.intTwo*10;

// Swapped (used for debugging issues)
  //lineOne.value = lineOne.intTwo*10 + lineOne.intOne;
  //lineTwo.value = lineTwo.intTwo*10 + lineTwo.intOne;
}


// function to read in the serial data
void read_serial()
{
  if (Serial.available() > 0) //If serial is reading any information it will run loop program below.
  {
    //delay(100);
    //lcd.clear(); //Clears screen again
    lcd.setCursor(0, 0); //sets characters on top left of LCD
    whichLine = 1;    // Just started reading so currently working on the first line
    int charCount = 1;



    while (Serial.available() > 0)
    {
      digitalWrite (bLED, HIGH); //If reading LED will turn on    TODO: turn this off when done reading
      c = Serial.read();  //Serial Reading set as variable "c"


      // keep track of the previous two characters that were read on each line
       if ( whichLine == 1 )
      {
        lineOne.runningBuff[0] = lineOne.runningBuff[1];
        lineOne.runningBuff[1] = lineOne.runningBuff[2];
        lineOne.runningBuff[2] = c;
      }
      else if ( whichLine == 2 )
      {
        lineTwo.runningBuff[0] = lineTwo.runningBuff[1];
        lineTwo.runningBuff[1] = lineTwo.runningBuff[2];
        lineTwo.runningBuff[2] = c;
      }


      if(charCount <=33)
      {
        if (c == '-') //If string has "-"
        {
          lcd.setCursor(0, 1); //Lowers cursor down and lets Line 2 be read right below
          whichLine = 2;       // set to other line
        }
        else if(c == '_') //if line has "_'
        {
          lcd.print((char)223); //Prints Degree Symbol


          if ( whichLine == 1 )
          {
            lineOne.snapshot[0] = lineOne.runningBuff[0];
            lineOne.snapshot[1] = lineOne.runningBuff[1];
          }
          else if ( whichLine = 2 )
          {
            lineTwo.snapshot[0] = lineTwo.runningBuff[0];
            lineTwo.snapshot[1] = lineTwo.runningBuff[1];
          }

        }
        else if(c == '#')
        {
          lcd.print((char)35);
        }
        else
        {
          lcd.write(c);
        }
      }
    }
  }
}
