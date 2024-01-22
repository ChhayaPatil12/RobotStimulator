# Toy Robot Simulation
This application simulates the movement of a toy robot on a square tabletop.
## Overview
- The tabletop dimensions are 5 units x 5 units.
- The robot is prevented from falling off the table during movement.
- Valid commands:
  - `PLACE X,Y,F`
  - `MOVE`
  - `LEFT`
  - `RIGHT`
  - `REPORT`

## Instructions

### Running the Project

1. Clone the repository:

   ```bash
   git clone https://github.com/ChhayaPatil12/RobotStimulator.git
2. Open the project in Visual Studio 2022.

3. Build the solution.

4. Run the application.
   
### Input Commands
- Commands can be provided in a file or from standard input.
- Example Input File (commands.txt)
 - `PLACE 0,0,NORTH`
 - `MOVE`
 - `REPORT`
   
### Running with Input File
- ToyRobotSimulation.exe < commands.txt

### Constraints
- The toy robot must not fall off the table during movement.
- Any move that would cause the robot to fall is ignored.

### Development
- Developed in C# .NET 6 using Visual Studio 2022.
  
### Test Data
### Example Command

- **Input:**
 
  PLACE 0,0,NORTH

  MOVE

  REPORT


- **Output:**
  
  0,1,NORTH





