C
C     CALCULATIONS FOR THE DIFFERENTIAL COLUMN
C
C     THIS PROGRAM WILL CALCULATE THE STANTON AND BIOT NUMBER
C     FOR SPECIFIC SET OF CIRCUMSTANCES.  THE COLUMN DIAMETER
C     WILL AUTOMATICALLY BE CHANGED.
C
C     WRITTEN BY:  THOMAS SPETH
C
C     VARIBLE DEFINITION
C 
C     AREA    = CROSSSECTIONAL AREA OF COLUMN (cm**2)
C     BI      = BIOT NUMBER (dimensionless)
C     BULKDEN = BULK DENSITY (gm/ml)
C     CARBON  = WEIGHT OF CARBON NEEDED (gm)
C     COLDIA  = DIAMETER OF COLUMN (cm)
C     COMP    = NAME OF COMPOUND (<20 LETTERS)
C     CONC    = INITIAL CONCENTRATION (ug/L)
C     DENLIQ  = LIQUID DENSITY (gm/ml)
C     DEPTH   = BED DEPTH OF CARBON (cm)
C     DG      = SURFACE SOLUTE DISTRIBUTION PARAMETER (dimensionless)
C     DL      = LIQUID DIFFUSIVITY (cm**2/sec)
C     DS      = SURFACE DIFFUSIVITY (cm**2/sec)
C     E       = BED VOID FRACTION (EPSILON)   
C     FLOW    = FLOW RATE (L/min)
C     KF      = MASS TRANSFER COEFFICIENT (cm/sec)
C     QE      = SOLID PHASE CONCENTRATION AT INITIAL CONC (ug/g)
C     QEQ     = SOLID PHASE CONCENTRATION AT EQUILIBRIUM (ug/g)
C     QUES    = QUESTION TO RERUN THE PROGRAM (yes/no)
C     RAD     = RADIUS OF CARBON PARTICLE (cm)
C     SC      = SCHMIDT NUMBER (dimensionless)
C     SIZE    = VOLUME OF SYSTEM (L)
C     ST      = STANTON NUMBER (dimensionless)
C     VB      = MOLAL VOLUME (ml/gmoL)
C     VISC    = LIQUID VISCOSITY (gm/sec/cm)
C     VOL     = VOLUME OF CARBON BED (ml)
C     WTCOMP  = WEIGHT OF COMPOUND TO BE REMOVED (mg)
C     XK      = FREUNDLICH K (mg/g)(L/mg)**1/N
C     XN      = FREUNDLICH 1/n (dimensionless)
C
C     PROGRAM
C
      IMPLICIT DOUBLE PRECISION(A-H,O-Z)
      DOUBLE PRECISION KF
      CHARACTER*3 QUES
      CHARACTER*30 COMP
C
      OPEN(7,FILE='DIFFCALC.OUT')
C
C     CONSTANTS
C
      E=0.45D0
      VISC=0.00984D0
      BULKDEN=0.47D0
      DENLIQ=0.998D0
C  
C     READ INPUT
C
      PRINT*, 'WHAT IS THE COMPOUNDS NAME ? '
      READ(*,5) COMP
5     FORMAT(A30) 
      PRINT*, 'WHAT IS THE FREUNDLICH K (mg/g)(L/mg)**2) ? '
      READ(*,*) XK
      PRINT*, 'WHAT IS THE FREUNDLICH 1/n ? '
      READ(*,*) XN
      PRINT*, 'WHAT IS THE SURFACE DIFFUSION COEFFICIENT (cm**2/sec)'
      READ(*,*) DS
      PRINT*, 'WHAT IS THE MOLAL VOLUME (ml/gmol) ? '
      READ(*,*) VB
10    PRINT*, 'WHAT IS THE VOLUME OF THE SYSTEM (L) ? '
      READ(*,*) SIZE
      PRINT*, 'WHAT IS THE FLOW RATE (L/min) ? '
      READ(*,*) FLOW
C
      SIZE=SIZE*1000.0D0
      FLOW=FLOW*1000.0D0/60.0D0
      COLDIA=0.80D0
C
      PRINT*, 'WHAT IS THE RADIUS OF THE CARBON PARTICLE (cm) ? '
      READ(*,*) RAD
      PRINT*, 'WHAT IS THE INITIAL CONCENTRATION (ug/L) ? '
      READ(*,*) CONC     
      PRINT*, 'WHAT IS THE FINAL CONCENTRATION (ug/L) ? '
      READ(*,*) SHOOT
C
C     CALCULATE THE AMOUNT OF CARBON NEEDED
C
      WTCOMP=SIZE/1000.0D0*(CONC-SHOOT)/1000.0D0
      QEQ=XK*(SHOOT/1000.0D0)**XN
      CARBON=WTCOMP/QEQ
      VOL=CARBON/BULKDEN  
C
C     CALCULATE STANTON
C
20    AREA=3.14159*(COLDIA/2.0D0)**2.0D0
      DEPTH=VOL/AREA
      DL=13.26D-5/(VISC*100.0D0)**1.14/VB**0.589
      SC=VISC/DENLIQ/DL
      KF=2.40D0*FLOW/AREA/(2.0D0*RAD*FLOW*DENLIQ/AREA/VISC/E)**0.66D0
     $/SC**0.58D0
      ST=KF*VOL*(1.0D0-E)/FLOW/RAD/E
C
C     CALCULATE BIOT
C 
      QE=XK*(CONC/1000.0D0)**XN
      DG=DENLIQ*QE*(1.0D0-E)*1000.0D0/E/CONC*1000.0D0
      BI=KF*RAD*(1.0D0-E)/DS/DG/E           
C
C     WRITE OUTPUT
C
      IF (COLDIA .EQ. 0.8D0) THEN
       WRITE(7,100) COMP,VB,DS,XK,XN,CONC,SHOOT,SIZE/1000.0D0,
     $ FLOW*60.0D0/1000.0D0,RAD,CARBON,DL,SC,DG
100    FORMAT(///,1X,'COMPOUND ',T20,A30,/,
     $ 1X,'MOLAL VOLUME (ml/gmol) ',T40,F8.3,/,
     $ 1X,'SURFACE DIFFUSION COEFFICIENT (cm**2/sec) ',T50,G15.5,/,
     $ 1X,'FREUNDLICH K (mg/g)(L/mg)**1/n',T40,F9.3,/,
     $ 1X,'FREUNDLICH 1/n ',T40,F12.4,/,
     $ 1X,'INITIAL CONCENTRATION (ug/L)',T40,F9.3,/,
     $ 1X,'FINAL CONCENTRATION (ug/L)',T40,F9.3,/,
     $ 1X,'VOLUME OF SYSTEM (L)',T40,F9.3,/,
     $ 1X,'FLOW RATE (L/min)',T40,F9.2,/,
     $ 1X,'RADIUS OF PARTICLE (cm)',T40,F12.4,/,
     $ 1X,'WEIGHT OF CARBON NEEDED (gm)',T40,F12.5,/,
     $ 1X,'LIQUID DIFFUSIVITY (cm**2/sec)',T40,G20.10,/,
     $ 1X,'SCHMIDT NUMBER ',T40,F9.1,/,
     $ 1X,'SURFACE SOLUTE DISTRIBUTION PARAMETER',T40,G20.10,///,
     $ 1X,'COLUMN DIA (cm)',T20,'Bed Depth (cm)',T35,'Kf (cm/sec)',
     $ T50,'STANTON',T65,'BIOT',/)
       WRITE(*,110)
110    FORMAT(1X,'COLUMN DIA (cm)',T20,'STANTON',T40,'BIOT',/)
      ENDIF
      WRITE(*,120) COLDIA,ST,BI
120   FORMAT(1X,F7.3,T17,F9.4,T35,F9.2)
      WRITE(7,130) COLDIA,DEPTH,KF,ST,BI
130   FORMAT(1X,F7.3,T17,F9.3,T32,F12.5,T46,F9.4,T60,F9.2)
C
C     LOOP
C
      IF (COLDIA .EQ. 2.50D0) GOTO 200
      IF (COLDIA .EQ. 1.50D0) COLDIA=2.50D0
      IF (COLDIA .EQ. 1.10D0) COLDIA=1.50D0
      IF (COLDIA .EQ. 0.80D0) COLDIA=1.10D0
      GOTO 20
C
C     RUN AGAIN?
C
200   PRINT*, ' '
      PRINT*, 'DO YOU WANT TO RUN THIS PROGRAM AGAIN WITH DIFFERENT'
      PRINT*, ' '
      PRINT*, 'FLOW RATE '
      PRINT*, 'PARTICLE SIZE  '
      PRINT*, 'CONCENTRATION '
      PRINT*, 'OR CARBOY SIZE ?  '
      READ(*,210) QUES
210   FORMAT(A3)
      IF (QUES .EQ. 'YES' .OR. QUES .EQ. 'yes') GOTO 10 
C
      STOP
      END

           