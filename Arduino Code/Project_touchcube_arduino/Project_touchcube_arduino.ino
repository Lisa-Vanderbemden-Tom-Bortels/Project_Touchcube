
int lees = A0;
int lees1 = A1;
int lees2 = A2;
int lees3 = A3;
int lees4 = A4;
int lees5 = A5;
int lees6 = A6;
int lees7 = A7;
int lees8 = A8;
int lees9 = A9;
int lees10 = A10;
int lees11 = A11;
int lees12 = A12;
int lees13 = A13;

int sensorvalue = 0;

int sensormin[14];
int i;

String waarde = "";

void setup(){
  pinMode(lees,INPUT);
  pinMode(lees1,INPUT);
  pinMode(lees2,INPUT);
  pinMode(lees3,INPUT);
  pinMode(lees4,INPUT);
  pinMode(lees5,INPUT);
  pinMode(lees6,INPUT);
  pinMode(lees7,INPUT);
  pinMode(lees8,INPUT);
  pinMode(lees9,INPUT);
  pinMode(lees10,INPUT);
  pinMode(lees11,INPUT);
  pinMode(lees12,INPUT);
  pinMode(lees13,INPUT);
  
  for(i=0;i<14;i++){
    sensormin[i] = 1023;
  }
  
  //calibration
  while(millis()<5000){
    sensorvalue = analogRead(lees);
    if(sensorvalue<sensormin[0]){
      sensormin[0] = sensorvalue;
    }
      sensorvalue = analogRead(lees1);
    if(sensorvalue<sensormin[1]){
      sensormin[1] = sensorvalue;
    }
    
      sensorvalue = analogRead(lees2);
    if(sensorvalue<sensormin[2]){
      sensormin[2] = sensorvalue;
    }
    
      sensorvalue = analogRead(lees3);
    if(sensorvalue<sensormin[3]){
      sensormin[3] = sensorvalue;
    }
    
      sensorvalue = analogRead(lees4);
    if(sensorvalue<sensormin[4]){
      sensormin[4] = sensorvalue;
    }
    
      sensorvalue = analogRead(lees5);
    if(sensorvalue<sensormin[5]){
      sensormin[5] = sensorvalue;
    }
    
      sensorvalue = analogRead(lees6);
    if(sensorvalue<sensormin[6]){
      sensormin[6] = sensorvalue;
    }
    
      sensorvalue = analogRead(lees7);
    if(sensorvalue<sensormin[7]){
      sensormin[7] = sensorvalue;
    }
    
      sensorvalue = analogRead(lees8);
    if(sensorvalue<sensormin[8]){
      sensormin[8] = sensorvalue;
    }
    
      sensorvalue = analogRead(lees9);
    if(sensorvalue<sensormin[9]){
      sensormin[9] = sensorvalue;
    }
    
      sensorvalue = analogRead(lees10);
    if(sensorvalue<sensormin[10]){
      sensormin[10] = sensorvalue;
    }
    
      sensorvalue = analogRead(lees11);
    if(sensorvalue<sensormin[11]){
      sensormin[11] = sensorvalue;
    }
    
      sensorvalue = analogRead(lees12);
    if(sensorvalue<sensormin[12]){
      sensormin[12] = sensorvalue;
    }
    
      sensorvalue = analogRead(lees13);
    if(sensorvalue<sensormin[13]){
      sensormin[13] = sensorvalue;
    }
    
    
  }
  
  
  Serial.begin(9600);
}

void loop(){
  waarde = "";
  waarde += "ptc:";
  
  //DT
  sensorvalue = analogRead(lees3);
  sensorvalue = map(sensorvalue,sensormin[3],1023,0,255);
  sensorvalue = constrain(sensorvalue,0,255);
  waarde+=(String(sensorvalue)+":");
  //DB
   sensorvalue = analogRead(lees10);
   sensorvalue = map(sensorvalue,sensormin[10],1023,0,255);
   sensorvalue = constrain(sensorvalue,0,255);
  waarde+=(String(sensorvalue)+":");
  //WT
   sensorvalue = analogRead(lees);
   sensorvalue = map(sensorvalue,sensormin[0],1023,0,255);
   sensorvalue = constrain(sensorvalue,0,255);
  waarde+=(String(sensorvalue)+":");
  //WM
   sensorvalue = analogRead(lees12);
   sensorvalue = map(sensorvalue,sensormin[12],1023,0,255);
   sensorvalue = constrain(sensorvalue,0,255);
  waarde+=(String(sensorvalue)+":");
  //WB
   sensorvalue = analogRead(lees1);
   sensorvalue = map(sensorvalue,sensormin[1],1023,0,255);
   sensorvalue = constrain(sensorvalue,0,255);
  waarde+=(String(sensorvalue)+":");
  //MT
   sensorvalue = analogRead(lees9);
   sensorvalue = map(sensorvalue,sensormin[9],1023,0,255);
   sensorvalue = constrain(sensorvalue,0,255);
  waarde+=(String(sensorvalue)+":");
  //MM
   sensorvalue = analogRead(lees6);
   sensorvalue = map(sensorvalue,sensormin[6],1023,0,255);
   sensorvalue = constrain(sensorvalue,0,255);
 waarde+=(String(sensorvalue)+":");
 //MB
   sensorvalue = analogRead(lees11);
   sensorvalue = map(sensorvalue,sensormin[11],1023,0,255);
   sensorvalue = constrain(sensorvalue,0,255);
  waarde+=(String(sensorvalue)+":");
  //RT
   sensorvalue = analogRead(lees5);
   sensorvalue = map(sensorvalue,sensormin[5],1023,0,255);
   sensorvalue = constrain(sensorvalue,0,255);
  waarde+=(String(sensorvalue)+":");
  //RM
   sensorvalue = analogRead(lees13);
   sensorvalue = map(sensorvalue,sensormin[13],1023,0,255);
   sensorvalue = constrain(sensorvalue,0,255);
  waarde+=(String(sensorvalue)+":");
  //RB
   sensorvalue = analogRead(lees4);
   sensorvalue = map(sensorvalue,sensormin[4],1023,0,255);
   sensorvalue = constrain(sensorvalue,0,255);
  waarde+=(String(sensorvalue)+":");
  //PT
   sensorvalue = analogRead(lees8);
   sensorvalue = map(sensorvalue,sensormin[8],1023,0,255);
   sensorvalue = constrain(sensorvalue,0,255);
  waarde+=(String(sensorvalue)+":");
  //PM
   sensorvalue = analogRead(lees2);
   sensorvalue = map(sensorvalue,sensormin[2],1023,0,255);
   sensorvalue = constrain(sensorvalue,0,255);
  waarde+=(String(sensorvalue)+":");
  //PB
   sensorvalue = analogRead(lees7);
   sensorvalue = map(sensorvalue,sensormin[7],1023,0,255);
   sensorvalue = constrain(sensorvalue,0,255);
  waarde+=(String(sensorvalue)+":");
  
  waarde+="ptc";
  
  
  Serial.println(waarde);
  
  delay(2000);
  
}
