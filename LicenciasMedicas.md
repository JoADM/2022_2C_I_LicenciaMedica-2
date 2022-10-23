# Licencias Medicas 📖

## Objetivos 📋
Desarrollar un sistema de de Licencias Médicas para una empresa Pyme, que permita la administración y uso de ella. 
De cara a los empleados de RRHH: Empleados, Medicos, Licencias, Visita, etc. 
De cara a los empleados: solo visualizar sus licencias. 
Utilizar Visual Studio 2019 preferentemente y crear una aplicación utilizando ASP.NET MVC Core (versión a definir por el docente 3.1 o 6.0).

<hr />

### Proceso de ejecución en alto nivel
 - Crear un nuevo proyecto en [visual studio](https://visualstudio.microsoft.com/en/vs/).
 - Adicionar todos los modelos dentro de la carpeta Models cada uno en un archivo separado.
 - Especificar todas las restricciones y validaciones solicitadas a cada una de las entidades. [DataAnnotations](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=netcore-3.1).
 - Crear las relaciones entre las entidades
 - Crear una carpeta Data que dentro tendrá al menos la clase que representará el contexto de la base de datos DbContext. 
 - Agregar los DbSet para cada una de las entidades en el DbContext.
 - Aplicar las adecuaciones y validaciones necesarias en los controladores.  
 - Realizar un sistema de login con al menos los roles equivalentes a <Usuario Cliente> y <Usuario Administrador> (o con permisos elevados).
 - Si el proyecto lo requiere, generar el proceso de registración. 
 - Un administrador podrá realizar todas tareas que impliquen interacción del lado del negocio (ABM "Alta-Baja-Modificación" de las entidades del sistema y configuraciones en caso de ser necesarias).
 - El <Usuario Cliente> sólo podrá tomar acción en el sistema, en base al rol que tiene.
 - Realizar todos los ajustes necesarios en los modelos y/o funcionalidades.
 - Realizar los ajustes requeridos del lado de los permisos.
 - Todo lo referido a la presentación de la aplicaión (cuestiones visuales).
 
<hr />

## Entidades 📄

- Usuario
- Empleado
- Medico
- Licencia
- Prestadora

`Importante: Todas las entidades deben tener su identificador unico. Id o <ClassNameId>`

`
Las propiedades descriptas a continuación, son las minimas que deben tener las entidades. Uds. pueden agregar las que consideren necesarias.
De la misma manera Uds. deben definir los tipos de datos asociados a cada una de ellas, como así también las restricciones.
`

**Usuario**
```
- Nombre
- Email
- FechaAlta
- Password
```

**Empleado**
```
- Nombre
- Apellido
- DNI
- Telefono
- Direccion
- FechaAlta
- Email 
- ObraSocial
- Legajo
- EmpleadoActivo
- Licencias
```

**Medico**
```
- Nombre
- Apellido
- DNI
- Matricula
- Telefono
- FechaAlta
- Email 
- Prestadora
- Licencias
```

**Telefono**
```
- Numero
- TipoTelefono
```

**Licencia**
```
- FechaSolicitud
- Descipcion
- Empleado
- FechaInicioSolicitada
- FechaFinSolicitada
- FechaInicio
- FechaFin
- Activa
- Medico
- FechayHoraVisita
- Diagnostico (Ej. Lumbalgia)
- CantidadDias
```




**NOTA:** aquí un link para refrescar el uso de los [Data annotations](https://www.c-sharpcorner.com/UploadFile/af66b7/data-annotations-for-mvc/).

<hr />

## Características y Funcionalidades ⌨️
`Todas las entidades, deben tener implementado su correspondiente ABM, a menos que sea implicito el no tener que soportar alguna de estas acciones.`


**Usuario**
- Los Empleados pueden autoregistarse, y si corresponde deben tomar el rol de RRHH.

**Empleado**
    - También se le asignará a estas cuentas el rol de empleado y adicionalmente el de RRHH si corresponde.
    - Lo mismo ocurrirá para dar de alta medicos, solo los empleados con el Rol de RRHH, pueden realizar esta tarea.
- Un empleado puede consultar todas sus licencias medicas y estado de las mismas.
- Un empleado puede solicitar una licencia medica por la web.
- Solo puede tener una licencia medica activa. 

**Empleado RRHH**
- Se distingue solo por un rol, que le da los permisos para gestionar toda la información del sistema. 

- Podrá listar a todos los empleados.
    - Al acceder al empleado, vera el detalle de sus datos y todas las licencias medicas solicitadas, en orden descendente por Fecha.
- Podrá Modificar el Medico asignado a una licencia, siempre y cuando, la licencia no esté en estado completada.


**Medico**
- Un medico, solo puede ver las licencias asignadas a él. En el detalle, verá no solo la información a cargar de la misma, sino también, los datos del Empleado para ir a su domicilio y datos de contacto.
- Nunca puede eliminar las licencias.
- Puede cargar un diagnostico de una licencia y cerrarla. Esto habilita al empleado a solicitar otra licencia medica.

**Aplicación General**
- Información institucional, en base a la información de la Empresa, con su respectiva imagen (Logo)
- Nadie, puede eliminar las visitas, ni licencias medicas. 
- Los accesos a las funcionalidades y/o capacidades, debe estar basada en los roles que tenga cada individuo o tipo.
