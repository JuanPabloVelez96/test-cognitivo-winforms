# test-cognitivo-winforms


Test Cognitivo - Memoria y Atención (WinForms)

Aplicación desarrollada en C# con Windows Forms que permite evaluar habilidades cognitivas básicas mediante dos tipos de pruebas interactivas: memoria visual y atención selectiva.

Descripción:

Este proyecto simula tests cognitivos utilizados en evaluaciones neuropsicológicas simples.
El usuario interactúa con estímulos visuales y el sistema registra automáticamente su desempeño.

Incluye:

Test de memoria (secuencias de colores)
Test de atención (respuesta a estímulos específicos)
Registro automático de resultados
Funcionalidades principales
Test de Memoria
Generación de secuencias de colores progresivas
Incremento de dificultad por nivel
Evaluación de aciertos y errores
Feedback visual (animaciones y efectos)

Test de Atención:
Aparición de colores aleatorios
El usuario debe responder solo ante estímulos específicos (color rojo)
Registro de:
Aciertos
Errores
Omisiones
Sistema de vidas (errores permitidos)
Resultados.

Al finalizar cada test, la aplicación muestra automáticamente:

Nivel alcanzado
Cantidad de aciertos y errores
Omisiones (en test de atención)
Tiempo total de ejecución
Precisión (%)

Además, los resultados se guardan en un archivo:

resultados.csv

Compatible con Excel o cualquier herramienta de análisis.

 Experiencia de usuario

El proyecto incluye mejoras visuales para simular una experiencia más moderna:

Animaciones de acierto (Glow)
Animaciones de error (Shake)
Feedback inmediato en pantalla
Medición de tiempo en tiempo real

Tecnologías utilizadas:
C#
Windows Forms (.NET)
Manejo de eventos y timers
Manipulación de archivos (CSV)
Programación asincrónica (async/await)


Estructura del proyecto:
Form1 → Menú principal
Form2 → Test de atención
Form3 → Test de memoria
resultados.csv → Registro de resultados

 
 Posibles mejoras futuras
Visualización de resultados en gráficos
Ranking de usuarios
Incorporación de sonidos
Nuevos tipos de tests cognitivos
Migración a WPF o aplicación web


Desarrollado por [Juan Pablo Velez]



Este proyecto es de uso educativo y puede ser reutilizado con fines de aprendizaje.
