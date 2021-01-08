This application has been written to use docker-compose that holds both the app and a db for local development purposes.

To start with you'll need to navigate to root directory of the application and execute the following:\
`docker-compose up reciperepodb -d`

With the local server up and running, you can initialise the database.\
Navigate to root_app_dir\RecipeRepo and execute the following:\
`dotnet ef database update --connection "Server=localhost,1433;User id=SA;Password=S00p3r53cr3t;Trusted_Connection=False;MultipleActiveResultSets=True;Connect Timeout=300000;Database=RecipeRepo"`