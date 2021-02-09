# Backend  
The project solution was developed under a layered architecture. The frameworks and practices used were the following:
- .Net Core 3
- SqlLite
- Swagger
- Entity Framework
- Clean code practices

# Instructions to run the API
1. Open the solution using visual studio 2019 
4. To enable CORS in the rest api. The connection of the front url must be allowed. Therefore, open the Startup class file and change the following line of code builder.WithOrigins ("http://localhost:4210").AllowAnyMethod().AllowAnyHeader();
5. When you run the application, you will get the swagger UI as shown below:
http://{ip}:{port}/swagger/index.html
![alt text](https://i.ibb.co/ZThfVcQ/esquema.png)
