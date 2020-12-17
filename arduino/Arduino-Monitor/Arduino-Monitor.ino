#include <LiquidCrystal_I2C.h>
#include <Wire.h>

LiquidCrystal_I2C lcd(0x27, 20, 4); //Intializes LCD on proper I2C Address and screen resolution of 20x4 bits.
int bLED = 10;  //Variable for LEDs
int rLED = 9;

byte mando[8] = //Byte Character
{
  B01110,
  B11111,
  B10001,
  B11011,
  B11011,
  B11111,
  B00000,
};

char c; // Sets up Variable 

void setup()
{
  lcd.createChar(0, mando); //Creates character from boolean
  pinMode(bLED, OUTPUT); //sets LED as output
  pinMode(rLED, OUTPUT); //Sets LED as output
  lcd.init(); //Installs LCD
  lcd.backlight(); //Turns on LCD backlight
  lcd.print("Hello!");  //Shows LCD is working by displaying hello before anything else.
  delay(1000);
  lcd.clear();  //Clears screen
  Serial.begin(9600); //Sets bit rate of serial monitor same as C# GUI.
}

void loop()
{
  if (Serial.available() > 0) //If serial is reading any information it will run loop program below.
  {
    delay(100);
    lcd.clear(); //Clears screen again
    lcd.setCursor(0, 0); //sets characters on top left of LCD
    int charCount = 1;
    while (Serial.available() > 0)
    {
      bLED = HIGH; //If reading LED will turn on
      c = Serial.read();  //Serial Reading set as variable "c"
      if(charCount <=33)
      {
        if (c == '-') //If string has "-"
        {
          lcd.setCursor(0, 1); //Lowers cursor down and lets Line 2 be read right below
        }
        else if(c == '_') //if line has "_'
        {
          lcd.print((char)223); //Prints Degree Symbol
        }
        else if(c == '#')
        {
          lcd.write(byte(0));
        }
        else
        {
          lcd.write(c);
        }
      }
    }
  }
} 
