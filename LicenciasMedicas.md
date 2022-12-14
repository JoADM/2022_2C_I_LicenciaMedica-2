# Licencias Medicas 馃摉

## Objetivos 馃搵
Desarrollar un sistema de de Licencias M茅dicas para una empresa Pyme, que permita la administraci贸n y uso de ella. 
De cara a los empleados de RRHH: Empleados, Medicos, Licencias, Visita, etc. 
De cara a los empleados: solo visualizar sus licencias. 
Utilizar Visual Studio 2019 preferentemente y crear una aplicaci贸n utilizando ASP.NET MVC Core (versi贸n a definir por el docente 3.1 o 6.0).

<hr />

### Proceso de ejecuci贸n en alto nivel
 - Crear un nuevo proyecto en [visual studio](https://visualstudio.microsoft.com/en/vs/).
 - Adicionar todos los modelos dentro de la carpeta Models cada uno en un archivo separado.
 - Especificar todas las restricciones y validaciones solicitadas a cada una de las entidades. [DataAnnotations](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=netcore-3.1).
 - Crear las relaciones entre las entidades
 - Crear una carpeta Data que dentro tendr谩 al menos la clase que representar谩 el contexto de la base de datos DbContext. 
 - Agregar los DbSet para cada una de las entidades en el DbContext.
 - Aplicar las adecuaciones y validaciones necesarias en los controladores.  
 - Realizar un sistema de login con al menos los roles equivalentes a <Usuario Cliente> y <Usuario Administrador> (o con permisos elevados).
 - Si el proyecto lo requiere, generar el proceso de registraci贸n. 
 - Un administrador podr谩 realizar todas tareas que impliquen interacci贸n del lado del negocio (ABM "Alta-Baja-Modificaci贸n" de las entidades del sistema y configuraciones en caso de ser necesarias).
 - El <Usuario Cliente> s贸lo podr谩 tomar acci贸n en el sistema, en base al rol que tiene.
 - Realizar todos los ajustes necesarios en los modelos y/o funcionalidades.
 - Realizar los ajustes requeridos del lado de los permisos.
 - Todo lo referido a la presentaci贸n de la aplicai贸n (cuestiones visuales).
 
<hr />

## Entidades 馃搫

- Usuario
- Empleado
- Medico
- Licencia
- Prestadora

`Importante: Todas las entidades deben tener su identificador unico. Id o <ClassNameId>`

`
Las propiedades descriptas a continuaci贸n, son las minimas que deben tener las entidades. Uds. pueden agregar las que consideren necesarias.
De la misma manera Uds. deben definir los tipos de datos asociados a cada una de ellas, como as铆 tambi茅n las restricciones.
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

**Licencia**
```
- FechaSolicitud
- Descipcion
- Empleado
- FechaInicio
- FechaFin
- Activa
- Medico
- FechayHoraVisita
- Diagnostico (Ej. Lumbalgia)
- CantidadDias
```




**NOTA:** aqu铆 un link para refrescar el uso de los [Data annotations](https://www.c-sharpcorner.com/UploadFile/af66b7/data-annotations-for-mvc/).

<hr />

## Caracter铆sticas y Funcionalidades 鈱笍
`Todas las entidades, deben tener implementado su correspondiente ABM, a menos que sea implicito el no tener que soportar alguna de estas acciones.`


**Usuario**
- Los Empleados pueden autoregistarse, y si corresponde deben tomar el rol de RRHH.

**Empleado**
    - Tambi茅n se le asignar谩 a estas cuentas el rol de empleado y adicionalmente el de RRHH si corresponde.
    - Lo mismo ocurrir谩 para dar de alta medicos, solo los empleados con el Rol de RRHH, pueden realizar esta tarea.
- Un empleado puede consultar todas sus licencias medicas y estado de las mismas.
- Un empleado puede solicitar una licencia medica por la web.
- Solo puede tener una licencia medica activa. 

**Empleado RRHH**
- Se distingue solo por un rol, que le da los permisos para gestionar toda la informaci贸n del sistema. 

- Podr谩 listar a todos los empleados.
    - Al acceder al empleado, vera el detalle de sus datos y todas las licencias medicas solicitadas, en orden descendente por Fecha.
- Podr谩 Modificar el Medico asignado a una licencia, siempre y cuando, la licencia no est茅 en estado completada.


**Medico**
- Un medico, solo puede ver las licencias asignadas a 茅l. En el detalle, ver谩 no solo la informaci贸n a cargar de la misma, sino tambi茅n, los datos del Empleado para ir a su domicilio y datos de contacto.
- Nunca puede eliminar las licencias.
- Puede cargar un diagnostico de una licencia y cerrarla. Esto habilita al empleado a solicitar otra licencia medica.

**Aplicaci贸n General**
- Informaci贸n institucional, en base a la informaci贸n de la Empresa, con su respectiva imagen (Logo)
- Nadie, puede eliminar las visitas, ni licencias medicas. 
- Los accesos a las funcionalidades y/o capacidades, debe estar basada en los roles que tenga cada individuo o tipo.
