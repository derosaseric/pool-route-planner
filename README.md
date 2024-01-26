# Pool Route Planner

This C# program implements a pool route planner with classes for Pool, Temperature, and Location. The system allows for the maintenance of pool temperatures within a specified range and provides a route for a maintenance crew to visit all pools efficiently.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Classes](#classes)
  - [Temperature](#temperature)
  - [Location](#location)
  - [Pool](#pool)
- [Functionality](#functionality)
- [Driver Program](#driver-program)
- [Contributing](#contributing)
- [License](#license)

## Installation

1. Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.

2. Clone the repository to your local machine:

   ```bash
   git clone https://github.com/derosaseric/pool-route-planner.git
   ```

## Usage

Build the project:

```bash
dotnet build
```

Run the program:

```bash
dotnet run
```

Follow the on-screen instructions to interact with the program.

**Example Output**

After running the program, you should see output similar to the following:

```plaintext
Initial Pool Count: 0

Visiting pool A: (x, y) >> Pool with temperature at 100.5 F >>

...

Final Pool Count: 7
```

### Notes

- This program was developed as a final project, and every line of code is authored by the project owner.
- Ensure you have the .NET SDK installed before attempting to build and run the program.

## Classes

### Temperature
The `Temperature` class represents the temperature of a pool. It has properties for degree and scale.

### Location
The `Location` class defines the location of a pool with 'x' and 'y' coordinates.

### Pool
The `Pool` class represents a swimming pool, containing objects of Temperature and Location. It includes methods for finding distance between pools, setting temperatures, and generating random temperatures and locations.

## Functionality

- The program ensures that the temperature for each pool is within the range of 98&deg;F and 104&deg;F.
- A maintenance crew can visit all pools, starting from location (0,0), and setting temperatures in a route that minimizes distance.
- The program displays the route taken by the maintenance crew.

## Driver Program

The driver program in Program.cs demonstrates the usage of the classes and the specified functionality. It prints the initial and final pool counts and displays the route taken by the maintenance crew.

## Contributing

1. Fork the project.
2. Create your feature branch (git checkout -b feature/YourFeature).
3. Commit your changes (git commit -m 'Add some feature').
4. Push to the branch (git push origin feature/YourFeature).
5. Open a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
