README.md
Gestor de Datos de Estudiantes

Aplicación desarrollada en C# Windows Forms que permite gestionar información de estudiantes a través de archivos CSV.
El sistema permite cargar, visualizar, buscar, registrar, eliminar, guardar y enviar por correo electrónico la información de los estudiantes.

Funcionalidades
Cargar CSV: importar un archivo CSV con la información de estudiantes.
Visualizar datos: mostrar en una grilla (DataGridView) todos los registros cargados.
Buscar estudiante: localizar rápidamente un estudiante por nombre.
Registrar estudiante: agregar un nuevo estudiante con nombre, edad, notas, género y actividades extracurriculares.
Cálculo automático: el sistema calcula el promedio y determina si el estudiante está Aprobado o Reprobado, mostrando una imagen correspondiente.
Eliminar fila: con doble clic se puede eliminar un registro de la grilla.
Guardar CSV: guardar los cambios realizados (registro/eliminación) en un nuevo archivo CSV.
Enviar correo: enviar la ficha del estudiante seleccionando un archivo adjunto, con validación de dominio en el correo.

Requisitos
Visual Studio 2022 o superior
.NET 8.0

Librerías:
System.Net.Mail
System.Text.RegularExpressions
Proyecto auxiliar DataSerializers (DLL incluida)
Estructura del proyecto
GestorDatosSolution/
│
├── GestorDatos/              # Proyecto WinForms principal
├── DataSerializers/          # Librería de serialización CSV
│   └── bin/Debug/net8.0/     
│       └── DataSerializers.dll   # DLL compilada
│
├── estudiantes.csv           # Archivo de ejemplo con datos
├── Capturas/                 # Carpeta con capturas de funcionamiento
└── README.md                 # Instrucciones del proyecto

Ejecución
Abrir la solución GestorDatosSolution.sln en Visual Studio.
Compilar la solución (F5 o Ctrl+F5).

En el formulario:

Cargar CSV → selecciona estudiantes.csv.
Selecciona un estudiante → se muestran promedio y estado.
Registrar → agrega un nuevo estudiante.
Doble clic en fila → elimina el registro.
Guardar CSV → guarda cambios en un nuevo archivo.
Seleccionar adjunto + Enviar correo → prueba el envío (requiere configurar SMTP en variables de entorno).

Configuración de correo
Para enviar correos debes configurar las siguientes variables de entorno:
SMTP_HOST = smtp.gmail.com
SMTP_PORT = 587
SMTP_USER = tu_correo@gmail.com
SMTP_PASS = contraseña_de_aplicación (no la contraseña normal de Gmail)

Capturas requeridas
Incluidas en la carpeta Capturas/:
Formulario principal con los botones y campos.
Carga de CSV mostrando estudiantes en la grilla.
Selección de estudiante mostrando promedio, estado e imagen (aprobado/reprobado).
Búsqueda por nombre (fila resaltada).
Registro de nuevo estudiante (antes y después de registrar).
Eliminación de estudiante (mensaje de confirmación y log).
Guardado de CSV (mensaje en log).
Envío de correo (log mostrando "Envío realizado").
Correo recibido en Gmail (con asunto y adjunto).

Autor

Proyecto desarrollado por Jairo Cardona Guzmán para el parcial de Programación en la CUN.