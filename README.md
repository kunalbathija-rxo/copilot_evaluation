# copilot_evaluation

## Table of Contents
- [Introduction](#introduction)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Running the Application](#running-the-application)
- [Testing](#testing)
- [API Endpoints](#api-endpoints)
- [Contributing](#contributing)
- [License](#license)

## Introduction
This project is a .NET Core Web API application created for evaluating GitHub Copilot. The application provides a simple RESTful API for managing resources.

## Prerequisites
- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 3.1 or later)
- [Visual Studio](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)
- [Postman](https://www.postman.com/) or a similar tool for testing API endpoints (optional)

## Installation
1. **Clone the repository:**
    ```bash
    git clone https://github.com/yourusername/your-repo-name.git
    cd your-repo-name
    ```

2. **Restore the dependencies:**
    ```bash
    dotnet restore
    ```

3. **Build the project:**
    ```bash
    dotnet build
    ```

## Running the Application
1. **Run the application:**
    ```bash
    dotnet run
    ```

2. The API will be available at `https://localhost:5001` or `http://localhost:5000`.

## Testing
You can use [Postman](https://www.postman.com/) or a similar tool to test the API endpoints. Alternatively, you can run the unit tests using the following command:

```bash
dotnet test
