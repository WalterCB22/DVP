# DVP API CRUD prueba tecnica Double V Partners
***
API que permite crear, eliminar, editar y recuperar tickets. Permitere recuperar todos lo tickets o filtrar por uno específico.
consta de dos tablas, la tabla Usuario contiene los campos Id, Nombre y Email y la tabla Ticket Id, FechaDeCreacion, FechaDeActualizacion, Estado, UsuarioID, Descripcion. 
Los ticket tienen un id, un usuario, una fecha de creación, una fecha de actualización y un estatus (abierto/cerrado).

La tabla esta incilizada con tres usuarios. 

* [Technologie .net core](https://dotnet.microsoft.com/download): Version 5.0
* [Technologie Entity Framework Core]
* [Tecnologie Swagger Open API]

Esquematico de las tablas: 
![image](https://user-images.githubusercontent.com/30899756/114290981-45d7e900-9a49-11eb-824f-dbde487436cf.png)
![image](https://user-images.githubusercontent.com/30899756/114290988-56885f00-9a49-11eb-85b2-9bd8157cfe21.png)



Proyecto listo para la ejecucion en Docker.
Desde la consola de comandos unbicandonos en la carpeta raiz ejecutamos el comando 

```
$ dotnet run
```

Ejecutar desde la ruta dada como respuesta en la consola y agregar los endpoints "/swagger/index.html"
Ejemplo:
```
https://localhost:5001/swagger/index.html
```
Endpoint para consultar toda la tabla
![image](https://user-images.githubusercontent.com/30899756/114290510-d7455c00-9a45-11eb-993a-69c432885a76.png)

Endpoint para agregar datos a la tabla
![image](https://user-images.githubusercontent.com/30899756/114290598-5cc90c00-9a46-11eb-8751-ee859d158ced.png)
Ejemplo de uso de POST

```
{
  "estado": true,
  "usuario": {
    "id": 0,
    "nombre": "string",
    "email": "string"
  },
  "descripcion": "string"
}
```
Endpoint para consultar un solo dato por id
![image](https://user-images.githubusercontent.com/30899756/114290683-f85a7c80-9a46-11eb-9e0c-c235d5e790e2.png)

Endpoint para modificar datos
![image](https://user-images.githubusercontent.com/30899756/114290759-77e84b80-9a47-11eb-9f84-cd8734f2395f.png)

Ejemplo de uso de PUT
```
{
  "id": 1,
  "estado": false,
  "usuario": {
    "id": 1,
  },
  "usuarioId": 1,
  "descripcion": "Hola Modificacion"
}
```
Endpoint para uso de DELETE
![image](https://user-images.githubusercontent.com/30899756/114290772-8c2c4880-9a47-11eb-85ff-805d77c6d059.png)


