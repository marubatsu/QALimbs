# QA Limbs
Proyecto para realizar pruebas al sitio Limbs.earth.

## Lenguaje y herramientas
* C#
* Selenium WebDriver
* NUnit
* ReportUnit

## Configuración
Modificar archivo **App.config** para:
* Cambiar browser.
* Cambiar usuarios.
* Ingresar una ruta y nombre de archivo de imagen para ser subida en un pedido.

## Ejecución de las pruebas

**En Visual Studio:**
1. Abrir el proyecto
2. Ir a Menú "Test" > Windows > Test Explorer
3. Seleccionar pruebas a ser ejecutadas, o ejecutarlas todas.

**A través de consola:**
1. En la consola, ir al directorio
```	
..\QALimbs\packages\NUnit.ConsoleRunner.3.10.0\tools
```

2. Ejecutar:
```	
nunit3-console.exe "(directorio donde está el proyecto)\QALimbs\QALimbs\bin\Debug\QALimbs.exe" --where "Priority == Critical"
```	
Con esto se muestran los resultados por consola, y además se genera un XML.
Si se quiere ejecutar todas las pruebas, borrar  _--where "Priority == Critical"_

3. Ir al directorio 
```	
"(directorio donde está el proyecto)\QALimbs\packages\ReportUnit.1.2.1\tools"
```	
4. Ejecutar:
```	
ReportUnit.exe "(directorio donde está el proyecto)\QALimbs\packages\NUnit.ConsoleRunner.3.10.0\tools"
```	
Con esto se genera un reporte HTML en el mismo directorio del archivo XML general por ConsoleRunner.

## Coverage
**Iniciar sesión:**
1. Critical - Iniciar sesión con usuario prótesis registrado con email.
2. High - Iniciar sesión con usuario embajador registrado con email.
2. Low - Ingresar contraseña incorrecta menos de 5 veces.
3. Low - Ingresar contraseña incorrecta 5 veces.
4. Low - Ingresar con email no registrado en la plataforma.

**Cerrar sesión:**
1. Critical - Cerrar sesión.

**Registrarse:**
1. Critical - Registrarse con email en la plataforma.

**Solicitar pedido:**
1. Critical - Solicitar pedido con diseño (8 combinaciones).
2. Medium - Solicitar pedido sin diseño (8 combinaciones).

## Otras notas
* La ruta de imagen a ser cargada durante un pedido se puede modificar en App.config.
* Por ahora las pruebas solo se ejecutan Firefox. Se puede modificar manualmente a Chrome en archivo App.config.
* La prueba de registrar un nuevo usuario a veces falla debido a la aparición del Captcha.
* Solo se puede hacer registro de email antes de confirmar correo. Para hacer pruebas de finalización de registro, se necesitarían emails que ya hayan sido confirmados.