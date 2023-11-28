# Introduction to CapRoverSampleNetCoreApp

A sample application which can easily be deployed on **CapRover** without much hassle of configuring stuff.

## Setting the application up

1. Fork this repository
2. Configure the Auto Deploy for your forked repository on CapRover following the steps
   on    [CapRoverDoc](https://caprover.com/docs/deployment-methods.html#automatic-deploy-using-github-bitbucket-and-etc)
3. Update the `Container HTTP Port` to `8080` since the DockerFile's default port is not `80`
4. The Migrations are going to fail if you have configured the connection to the Postgres Database. To do that you have
   to deploy an instance of the Postgres on the `One Click Apps` section, and on the .Net App set the Environment
   variables to Key `ConnectionStrings__DefaultConnection` and
   Value `User ID=postgres;Password=YourPassword;Host=YourInternalHostNameGeneratedByCapRover(Default=srv-captain--postgres);Port=5432;Database=postgres`
5. After saving and the app restarting the migrations should be initialized and you should be able to access your app.