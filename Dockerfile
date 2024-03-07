# Use the official .NET SDK image as a base image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory in the container
WORKDIR /app

# Copy the project files to the working directory
COPY *.csproj ./
RUN dotnet restore

# Copy the remaining source code to the working directory
COPY . .

# Build the application
RUN dotnet publish -c Release -o out

# Use the official ASP.NET Core runtime image as a base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory in the container
WORKDIR /app

# Copy the built application from the build stage
COPY --from=build /app/out .

COPY entrypoint.sh /app
# Expose the port the app runs on
EXPOSE 80

VOLUME [ "/data" ]
ENV PATH="${PATH}:/root/.dotnet/tools"
# Run the application
ENTRYPOINT ["sh", "/app/entrypoint.sh"]
