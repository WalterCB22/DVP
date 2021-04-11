# DVP API CRUD 
* (Prueba tecnica Double V Partners)
***

La API permite crear, eliminar, editar y recuperar tickets. Las consultas permiten la recuperacion de ticket especificas o el contenido de todas las tablas.
Consta de dos tablas relacionadas: 
* la tabla **Usuario** contiene los campos Id, Nombre y Email.
* La tabla **Ticket** Id, FechaDeCreacion, FechaDeActualizacion, Estado, UsuarioID, Descripcion. 
* La tabla esta incilizada con tres usuarios. 

Esquematicos de las tablas: 
![image](https://user-images.githubusercontent.com/30899756/114290981-45d7e900-9a49-11eb-824f-dbde487436cf.png)
![image](https://user-images.githubusercontent.com/30899756/114290988-56885f00-9a49-11eb-85b2-9bd8157cfe21.png)

### Se utilizaron las Tecnologias: 

* [Technologie .net core](https://dotnet.microsoft.com/download): Version 5.0
* [Technologie Entity Framework Core]
* [Tecnologie Swagger Open API]

Proyecto listo para la ejecucion en Docker.
Desde la consola de comandos unbicandonos en la carpeta raiz del proyecto ejecutamos el comando 

```
$ dotnet run
```
Tendremos como respuesta:

![image](https://user-images.githubusercontent.com/30899756/114291080-1aa1c980-9a4a-11eb-8013-2dc1feeee554.png)

Ejecutar desde el navegador la ruta dada como respuesta en la consola y agregamo los endpoints en caso de que se quiera utlizar swagger "/swagger/index.html"
Ejemplo:
```
https://localhost:5001/swagger/index.html
```
* Endpoint para consultar toda la tabla
![image](https://user-images.githubusercontent.com/30899756/114290510-d7455c00-9a45-11eb-993a-69c432885a76.png)

* Endpoint para agregar datos a la tabla
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
* Endpoint para consultar un solo dato por id
![image](https://user-images.githubusercontent.com/30899756/114290683-f85a7c80-9a46-11eb-9e0c-c235d5e790e2.png)

* Endpoint para modificar datos
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
* Endpoint para uso de DELETE
![image](https://user-images.githubusercontent.com/30899756/114290772-8c2c4880-9a47-11eb-85ff-805d77c6d059.png)


