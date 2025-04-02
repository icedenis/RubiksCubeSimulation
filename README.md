# Rubik's Cube Simulator

A console application that simulates a 3x3 Rubik's cube with the ability to perform standard face rotations.



## Features

- Accurate simulation of a 3x3 Rubik's cube
- Implementation of all standard face rotations (clockwise and counter-clockwise)
- Console-based visualization showing the state of the cube
- Proper edge and corner piece tracking during rotations
  
## How to Build and Run

### Prerequisites
- .NET 6.0 SDK or higher
- Windows PC

### Building the Application
1. Clone this repository
2. Open a command prompt in the project directory
3. Run `dotnet build`

### Running the Application
1. After building, run `dotnet run` in the project directory
2. The application will:
   - Display the initial solved cube state
   - Apply the rotation sequence: F R' U B' L D'
   - Display the final cube state after rotations
  ### Cube Coordinate System

The cube uses a coordinate system where each position on a face is identified by [row, column] coordinates:

![Cube Output](https://github.com/username/RubiksCubeSimulation/blob/main/cube_output.png)

*Figure 1: Coordinate system for each face of the cube*

### Output Example

The application produces an output showing the state of the cube after applying the specified rotations:

![Cube Output](cube_output.png)

*Figure 2: Console output showing the solved cube and the cube after rotations*
