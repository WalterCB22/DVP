# DVP API CRUD prueba tecnica Double V Partners
***
API que permite crear, eliminar, editar y recuperar tickets. Permitere recuperar todos lo tickets o filtrar por uno específico.
consta de dos tablas, la tabla Usuario contiene los campos Id, Nombre y Email y la tabla Ticket Id, FechaDeCreacion, FechaDeActualizacion, Estado, UsuarioID, Descripcion. 
Los ticket tienen un id, un usuario, una fecha de creación, una fecha de actualización y un estatus (abierto/cerrado).

* [Technologie .net core](https://dotnet.microsoft.com/download): Version 5.0
* [Technologie Entity Framework Core]
* [Tecnologie Swagger Open API]

Proyecto listo para la ejecucion en Docker.
desde la consola de comandos unbicandonos en la carpeta raiz ejecutamos el comando 

...
$ dotnet run
...

ejecutar desde la ruta dada como respues en la consola y agregar los endpoints "/swagger/index.html"
Ejemplo:

https://localhost:5001/swagger/index.html

Ejemplo de uso de PUT
...
${
$  "id": 1,
$  "estado": false,
$  "usuario": {
$    "id": 1,
$  },
$  "usuarioId": 1,
$  "descripcion": "Hola Modificacion"
$}
...


