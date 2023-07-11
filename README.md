# MyApp DotNet

This is a simple .NET application which is part of the `<Your-App-Name>` solution.

## Prerequisites

- .NET 5.0 or higher
- Docker (for containerization)

## Directory Structure

- `/src`: The source code of the application.
    - `<MyApp>/`: The application code.
    - `<MyApp>.Tests/`: The test code for the application.
    - `<MyApp>.sln`: The solution file which includes the application and the tests.
- `/.github/workflows`: Contains the GitHub Actions workflow file(s) for Continuous Integration.
- `Dockerfile`: The Dockerfile for building a Docker image of the application.

## Local Development

1. Navigate to the `src` directory:

    ```bash
    cd src
    ```

2. Restore the .NET solution:

    ```bash
    dotnet restore
    ```

3. Build the solution:

    ```bash
    dotnet build
    ```

4. Run the tests:

    ```bash
    dotnet test
    ```

5. Run the application:

    ```bash
    dotnet run --project <Your-App-Name>/<Your-App-Name>.csproj
    ```

## Dockerization

1. Build the Docker image:

    ```bash
    docker build -t <Your-Docker-Image-Name>:latest .
    ```

2. Run the Docker container:

    ```bash
    docker run -p 8080:80 <Your-Docker-Image-Name>:latest
    ```

Note: This will run the application and expose it on port 8080 of your machine.

## Continuous Integration

We use GitHub Actions for Continuous Integration. Check the `.github/workflows` directory for workflow configurations.

The CI pipelines perform the following tasks:

- Linting and code formatting checks
- Building the application
- Running unit tests
- Scanning for vulnerabilities and code quality using CodeQL
- Building and pushing Docker images to Azure Container Registry
- Deploying the application to Azure Kubernetes Service

