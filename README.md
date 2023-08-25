# Gestion de la Configuracion
## Instalacion Guiada para Cat Crush Saga!
### Instalacion Para sistema operativo **Windous 11**. 
### Intalacion de [Git](https://github.com/JuandavidLondo/gestion-de-la-configuracion/wiki/Git)
1. Busca la página oficial de git.
1. Dentro de la página de git, Buscar la opción de “Descargas”, y de ahi, selecciona la opción de windows. 
1. Luego selecciona el instalador independiente de 64 bits para windows.
1. Después de descargarse, darle click al instalador.
1. Dentro de la pantalla de información, seleccionar next.
1. Elige la ubicación donde deseas instalar git y selecciona “Next”.
1. Luego de esto, dejar la configuración recomendada, una vez se haya instalado desmarcar ambas opciones, y seleccionar “Finish”.
1. Abre Git Bash.
### Clonar El repositorio de github
1. Para clonar el repositorio, es recomendable crear una carpeta en el escritorio, abrirla y copiar la dirección de la carpeta.
1. En el menú de Windows, escribir “Símbolo del sistema” o “CMD” y abrirlo.
1. Una vez abierto el símbolo del sistema, escribir el comando: `cd direccion_de_carpeta`.
1. Abre GitHub en tu navegador web y accede a la página del repositorio que contiene el proyecto de Unity que deseas descargar y copiar el link que aparece en la parte de `<>Code`.
1. Volviendo al CMD, escribe el siguiente codigo y pega el link del github: “git clone -b Juan_David_Londono_Lorena_Cadavid https://github.com/JuandavidLondo/gestion-de-la-configuracion.git” y esperamos a que termine la clonacion.
### Instalacion de [Unity](https://github.com/JuandavidLondo/gestion-de-la-configuracion/wiki/Unity)
1. Visita la página web oficial de Unity.
1. Haz clic en el botón “Descargar” y seleccionas la versión para windows.
1. Se descargará un archivo de instalación en tu ordenador. Haz doble clic en el archivo para abrirlo.
1. Se abrirá una ventana emergente de instalación. Haz clic en “Aceptar” para continuar.
1. Elige lugar de instalación y haz clic en “Instalar”.
1. Espera a que se complete la instalación y haz clic en “Terminar”.
1. Abra Unity Hub, dentro de este, busque la pestaña de `instalaciones` o `Isntalls`.
1. en instalaciones, en la parte superior derecha de la ventana hay un botón azul que dice “install editor”, dale click y en las opciones que te aparecen, darle click al botón install de la opción recomendada.
1. En esta, presiona “install” y espera a que termine la instalación.
### Abrir Unity para poder compilar el juego
1. Luego de que termine la instalación, desde la misma pestaña de install, presione Click en el engranaje  que está en una esquina de la versión que instalamos y le damos a la opción “Show in Explorer ”
1. Se nos abrira el explorador de archivos con un archivo llamado Unity seleccionado, a este le damos click derecho y seleccionamos la opcion “Copiar como ruta de acceso"
1. luego de esto, Volvemos al cmd  y dentro de este, pegas lo que acabamos de copiar con Ctrl + V, pones el siguiente codigo: “-projectPath "Proyecto" -executeMethod StandaloneWindous64" Donde la parte “Proyecto” es la dirección de la carpeta que se clonó de github.
  - Esta se encuentra entrando a la carpeta donde clonamos el repositorio, y dentro de ella hay una carpeta llamada “Cat Crush Saga!”, abrimos esa carpeta y copiamos su dirección.
1. el comando debe quedar tal que asi: `"C:\Program Files\Unity\Hub\Editor\2020.3.17f1\Editor\Unity.exe"  -projectPath "C:\Users\juand\Desktop\g\gestion-de-la-configuracion\Cat Crush Saga!" -executeMethod StandaloneWindous64`, donde la primera parte es la ruta hacia el archivo unity y la segunda es la ruta a la carpeta clonada del repositorio de github.
1. Luego ejecutamos el comando anterior y este nos abrirá una nueva ventana la cual será el juego en el entrono de desarollo de unity.
1. Luego de que cargue por completo le damos a “File” en la esquina superior izquierda de la pantalla, después de que se despliegue  el menú, le damos a la opción “Build settings”.
1. Al seleccionar “build setting” se nos abrirá una pestaña dentro de unity, en la cual nos fijamos si en platform, la opción “Pc, Mac & Linux StandAlone” está seleccionada en azul, si no es así, la seleccionamos.
1. Para finalizar, le damos a la opción Build, seleccionamos la carpeta donde queremos que se compile el juego y esperamos.
1. Luego de que pase el tiempo de instalación, podemos entrar a la carpeta donde compilamos el juego, y dentro de esta, le damos doble click al archivo llamado “Cat Crush Saga!” y disfrutamos el juego
> [!IMPORTANT]
> Como nota aclaratoria, el juego no tiene botón de salida, asi que si queremos salir del mismo, tendremos que hacer la combinación de teclas “Alt + F4”.


