# Bank Account TDD Project

A C# project demonstrating Test-Driven Development (TDD) with unit tests for a Bank Account application.

## Project Structure

```
Lab8/
├── src/
│   └── BankApp/
│       ├── BankAccount.cs          # Main BankAccount class
│       └── BankApp.csproj          # BankApp project file
├── tests/
│   └── BankApp.Tests/
│       ├── AccountTest.cs          # Unit tests for BankAccount
│       └── BankApp.Tests.csproj    # Test project file
└── Lab8-TDD.sln                    # Solution file
```

## Prerequisites

- .NET 9.0 or higher
- Visual Studio, VS Code, or another C# IDE
- Git

## Getting Started

### Clone the Repository
```bash
git clone https://github.com/tannguyen888/C-FunTest.git
cd Lab8/Bank
```

### Build the Project
```bash
dotnet build
```

### Run the Tests
```bash
dotnet test
```

## Project Description

This project implements a `BankAccount` class that manages customer bank accounts with the following features:

- **Customer Name**: Store the name of the account holder
- **Balance**: Track the account balance
- **Credit**: Add funds to the account
  - Accepts only positive amounts
  - Throws `ArgumentOutOfRangeException` for negative amounts

## Test Coverage

The unit tests in `AccountTest.cs` verify:

1. **Credit_WithValidAmount_UpdatesBalance**: Ensures that crediting a valid positive amount correctly updates the account balance
2. **Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange**: Ensures that attempting to credit a negative amount throws an exception

## Usage Example

```csharp
// Create a new account
BankAccount account = new BankAccount("John Doe", 100.00);

// Credit the account
account.Credit(50.00);

// Check the balance
double currentBalance = account.Balance; // Returns 150.00
```

## Technologies

- **Language**: C#
- **Framework**: .NET 9.0
- **Testing Framework**: MSTest
- **Version Control**: Git

## Contributing

Feel free to fork this project and submit pull requests for any improvements.

## Author

Tan Phat Nguyen

## License

This project is for educational purposes.
