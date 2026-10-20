# Parqueo-LH1
1. Descripción del proyecto

El Sistema de Gestión de Parqueo es un proyecto académico desarrollado para el curso ISB-13 Programación II de la Universidad Internacional San Isidro Labrador (UISIL).

Su objetivo es facilitar el control de los vehículos que ingresan y salen de un parqueo, la administración de los espacios disponibles y el registro de la información de los clientes.

El proyecto se encuentra en desarrollo. Actualmente cuenta con una base de datos diseñada en SQL Server y un proyecto inicial de Windows Forms en C#.

2. Integrante

Leony Daniel Hidalgo Martínez.

3. Tecnologías utilizadas

Lenguaje de programación: C#.

Interfaz gráfica: Windows Forms.

Base de datos: Microsoft SQL Server Express.

Administración de la base de datos: SQL Server Management Studio (SSMS).

Entorno de desarrollo: Visual Studio.

Control de versiones: Git.

Repositorio remoto: GitHub.

4. Funcionalidades previstas

El sistema está diseñado para incluir las siguientes funcionalidades:

Registro, consulta, modificación y eliminación de clientes.

Administración de vehículos asociados a los clientes.

Administración de espacios del parqueo.

Registro de entradas y salidas de vehículos.

Consulta del historial de movimientos.

Control de espacios disponibles y ocupados.

Cálculo del tiempo de permanencia y del monto a cobrar.

Validación de datos para evitar errores y duplicados.

Estas funcionalidades se implementarán progresivamente durante el desarrollo del proyecto.

5. Requisitos para ejecutar el proyecto

Para desarrollar y ejecutar la aplicación se requiere:

Un equipo con Windows.

Visual Studio con soporte para C# y Windows Forms.

Una versión de .NET compatible con el proyecto creado en Visual Studio.

Microsoft SQL Server Express instalado.

SQL Server Management Studio para administrar la base de datos.

6. Base de datos

La base de datos se llama Parqueo y está formada por las siguientes tablas:

Cliente: almacena la identificación, el nombre y el teléfono de los clientes.

Vehiculo: registra la placa, el tipo, la marca, el color y el cliente asociado.

Espacio: almacena el número, el tipo de vehículo permitido y el estado del espacio.

Registro: conserva las entradas, las salidas y los montos pagados.

Las tablas se relacionan mediante llaves primarias y foráneas para mantener la integridad de la información.

Configuración de la base de datos

Instalar y abrir SQL Server Express.

Abrir SQL Server Management Studio y conectarse a la instancia local de SQL Server.

Abrir el archivo base de datos/Parqueo_base_datos.sql.

Revisar que el script corresponda a la base de datos de prueba y ejecutarlo para crear la estructura y cargar los datos de prueba.

Verificar que existan las tablas Cliente, Vehiculo, Espacio y Registro.


7. Instrucciones para abrir el proyecto

Descargar o clonar este repositorio.

Abrir la carpeta del proyecto en Windows.

Localizar el archivo de solución .sln de Visual Studio.

Abrir la solución y esperar a que Visual Studio cargue el proyecto.

Compilar y ejecutar la aplicación mediante Visual Studio.

Actualmente, el proyecto de Windows Forms se encuentra en su etapa inicial. La conexión entre C# y SQL Server y las operaciones CRUD se implementarán durante el desarrollo.

8. Credenciales de prueba

Actualmente no se han configurado usuarios ni contraseñas propios de la aplicación.

Para la administración de la base de datos se utilizará la autenticación de Windows de SQL Server cuando corresponda. No se deben publicar contraseñas ni datos personales reales en este repositorio.

9. Estructura general del proyecto

La estructura principal del repositorio incluye:

ParqueoApp/: proyecto de C# y archivos de Windows Forms.

base de datos/: script SQL de creación de la base de datos.

README.md: descripción e instrucciones del proyecto.

La documentación académica se mantendrá organizada junto con los demás archivos del proyecto.

10. Herramientas adicionales

Se utiliza GitHub Desktop como herramienta gráfica para administrar el repositorio local, registrar commits y publicar los avances en GitHub.

SQL Server Management Studio se utiliza para crear, consultar y administrar la base de datos.

No se han incorporado bibliotecas externas adicionales en la etapa inicial del proyecto.

11. Declaración del uso de inteligencia artificial

Se utilizó ChatGPT  y Claude como herramienta de apoyo para aclarar conceptos de programación, organizar la documentación y orientar la planificación del proyecto, especificamente en la creacion del repositorio de github y la conexion con sql y visual estudio

12. Repositorio

Repositorio de GitHub:

https://github.com/Leonymartinez/Parqueo-LH1
