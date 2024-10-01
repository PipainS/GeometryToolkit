GeometryToolkit

Overview

GeometryToolkit is a library designed to calculate the areas of various geometric shapes, including circles and triangles. This library provides a flexible and scalable solution for area calculations, adhering to best development practices.

Project Structure
MindBox.Kubernetes
├── geometry-toolkit-manifest.yaml       # Solution for assignment #3
tests
├── MindBox.AreaCalculator.Tests
│   ├── CircleTest                        # Unit tests for Circle
│   └── TriangleTest                      # Unit tests for Triangle
MindBox.AreaCalculator  # Solution for assignment #2
└── src
    └── ShapeLibrary
        ├── Constants
        │   └── ShapeConstants.cs          # Constant values for shapes
        ├── Factories
        │   └── ShapeFactory.cs            # Factory for shape creation
        ├── Shapes
        │   ├── Base
        │   │   ├── ShapeBase.cs           # Base class for shapes
        │   │   └── Struct
        │   │       └── Point.cs           # Struct for representing points
        │   ├── Interfaces
        │   │   └── IShape.cs              # Interface for shapes
        │   └── Models
        │       ├── Circle.cs              # Circle model
        │       └── Triangle.cs            # Triangle model
        └── Utils
            ├── CircleUtils.cs             # Utility methods for circles
            ├── TriangleUtils.cs           # Utility methods for triangles
            └── ValidationExtensions.cs    # Validation extension methods

Installation
https://github.com/PipainS/GeometryToolkit.git

Testing
Unit tests for the library can be found in the MindBox.AreaCalculator.Tests project. You can run the tests using the following command:
dotnet test
