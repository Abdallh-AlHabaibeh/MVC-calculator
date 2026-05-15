# ASP.NET MVC Calculator

An expression-based calculator web application built with ASP.NET Core MVC and C#.

## Features

* Expression-based calculations
* MVC architecture
* Service-layer logic separation
* Dependency Injection
* Responsive web interface

## Technologies Used

* ASP.NET Core MVC
* C#
* Bootstrap
* HTML/CSS
* Git & GitHub

## Project Architecture

```text
Controllers/   -> Request handling
Models/        -> Data structures
Services/      -> Business logic
Views/         -> User interface
```

## How to Run

```bash
dotnet restore
dotnet run
```

Then open the localhost URL shown in the terminal.

## Current Validation Features

* Prevents users from entering letters or invalid characters
* Detects and rejects invalid operator sequences
* Handles division-by-zero cases safely
* Handles malformed expressions safely

## Future Improvements

* Scientific calculator functions
* Calculation history
* Dark mode UI
* Live deployment
* Python ML integration
