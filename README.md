# ASP.Net Core 6 API + React + Typescript

This solution is pre-configured with an ASP.Net Core 6 API backend and a react/typescript frontend.

### Backend (WebAPI project):

- Bare minimum ASP.Net Core 6 API template created by Visual Studio
- .NET 6.0
- C# 10.0
- Swagger

### Frontend (React/Typescript):

- Bare minimum react app with typescript created by create-react-app
- Found in the WebAPI/clientapp/ directory
- React 18.2.0

## Development

The backend and frontend need to be run independently.

#### Start the frontend
1. Navigate to /WebAPI/clientapp
2. Run 'npm install'
3. Run 'npm start'
4. The development server will start at localhost:3000

#### Start the backend
1. Run the WebAPI project from your IDE or run 'dotnet run' from the WebAPI directory.
2. Swagger is available at localhost:7064/swagger/index.html
3. Navigating to any endpoint that does not start with /api/ will display the react app.

## Publish

When publishing the WebAPI project it will ensure the clientapp is freshly built and the necessary files copied to the publish directory.

You can run WebAPI.exe from the publish directory and the react app will load.

## Notes

You must make sure all backend routes start with /api.
The API project will redirect all routes that do not start with /api to the react app.

This can be changed in program.cs.