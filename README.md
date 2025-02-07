# Keyboard Runner

**Keyboard Runner** es un videojuego educativo tipo arcade diseñado para mejorar las habilidades de mecanografía mientras los jugadores disfrutan de una aventura emocionante.

**Keyboard Runner** is an educational arcade video game designed to improve typing skills while players enjoy an exciting adventure.

---

## Tabla de Contenidos / Table of Contents
- [Descripción del Proyecto / Project Description](#descripción-del-proyecto--project-description)
- [Características Principales / Key Features](#características-principales--key-features)
- [Requisitos del Sistema / System Requirements](#requisitos-del-sistema--system-requirements)
- [Instalación y Ejecución / Installation and Execution](#instalación-y-ejecución--installation-and-execution)
- [Estructura del Proyecto / Project Structure](#estructura-del-proyecto--project-structure)
- [Contribuciones / Contributions](#contribuciones--contributions)
- [Licencia / License](#licencia--license)

---

## Descripción del Proyecto / Project Description

**Keyboard Runner** combina mecánicas de juego rápidas con un enfoque educativo. Los jugadores deben presionar las teclas correctas en pantalla para superar obstáculos, evitar peligros y avanzar por niveles cada vez más desafiantes.

**Keyboard Runner** combines fast-paced gameplay mechanics with an educational focus. Players must press the correct keys on the screen to overcome obstacles, avoid dangers, and progress through increasingly challenging levels.

- **Género / Genre:** Arcade / Educativo / Educational.
- **Plataforma / Platform:** PC (Windows, macOS, Linux). Adaptaciones futuras a web y dispositivos móviles / Future adaptations for web and mobile devices.
- **Motor / Engine:** Unity (versión 2023 o superior / version 2023 or later).
- **Audiencia / Audience:** Todas las edades, especialmente interesados en mecanografía / All ages, especially those interested in typing.

---

## Características Principales / Key Features

1. **Juego educativo / Educational gameplay:** Mejora tus habilidades de mecanografía mientras te diviertes / Improve your typing skills while having fun.
2. **Estilo artístico 2D / 2D art style:** Gráficos vibrantes y animaciones fluidas / Vibrant graphics and smooth animations.
3. **Progresión por niveles / Level progression:** Aumenta la dificultad conforme avanzas / Increases difficulty as you progress.
4. **Interfaz amigable / User-friendly interface:** Letras flotantes y sistema de puntuación visual / Floating letters and visual scoring system.
5. **Mecánicas simples pero desafiantes / Simple yet challenging mechanics:**
   - Salta obstáculos presionando teclas correctas / Jump over obstacles by pressing the correct keys.
   - Evita colisiones para mantener la partida activa / Avoid collisions to stay in the game.
6. **Sistema de puntuación / Scoring system:** Guarda y muestra las mejores puntuaciones / Saves and displays high scores.

---

## Requisitos del Sistema / System Requirements

- **Resolución mínima / Minimum resolution:** 1280x720.
- **Sistema operativo / Operating system:** Windows, macOS, Linux.
- **Hardware recomendado / Recommended hardware:**
  - Procesador / Processor: Intel i3 o superior / Intel i3 or higher.
  - Memoria RAM / RAM: 4GB.
  - GPU: Compatible con OpenGL 4.5 / Compatible with OpenGL 4.5.

---

## Instalación y Ejecución / Installation and Execution

1. Clona este repositorio / Clone this repository:
   ```bash
   git clone https://github.com/tu-usuario/keyboard-runner.git
2. Abre el proyecto en Unity (versión 2023 o superior / version 2023 or later).
3. Asegúrate de configurar las dependencias necesarias / Ensure all dependencies are configured.
4. Compila y ejecuta el proyecto desde Unity o exporta el juego para la plataforma deseada / Build and run the project from Unity or export the game to the desired platform.

---

## Estructura del Proyecto / Project Structure

### Archivos principales / Main Files

1. **PlayVideo.cs**  
   Maneja la reproducción de videos y la transición entre escenas.  
   Handles video playback and scene transitions.

2. **ObstacleMovement.cs**  
   Controla el desplazamiento de los obstáculos y su destrucción fuera de pantalla.  
   Controls obstacle movement and destruction off-screen.

3. **ObstacleSpawner.cs**  
   Genera obstáculos de forma continua con intervalos ajustables.  
   Continuously spawns obstacles at adjustable intervals.

4. **PlayerController.cs**  
   Gestiona el movimiento del jugador, teclas aleatorias y colisiones.  
   Manages player movement, random key generation, and collisions.

5. **ScrollingGround.cs**  
   Controla el desplazamiento del fondo para simular movimiento.  
   Controls background scrolling to simulate movement.

6. **GameManager.cs**  
   Gestiona el flujo del juego: pausa, reinicio y puntuaciones.  
   Manages game flow: pause, restart, and scoring.

### Carpeta de Recursos / Resources Folder

- **Sprites:** Gráficos del personaje, obstáculos y entorno / Character, obstacle, and environment graphics.
- **Sonidos / Sounds:** Música de fondo y efectos de sonido / Background music and sound effects.
- **Prefabs:** Plantillas reutilizables de obstáculos y otros elementos / Reusable templates for obstacles and other elements.

---

## Contribuciones / Contributions

Actualmente, este proyecto es desarrollado exclusivamente por Mateo Galvis Guayana.  
This project is currently developed solely by Mateo Galvis Guayana.

Si deseas contribuir, abre un issue o crea un pull request con tus propuestas.  
If you'd like to contribute, open an issue or submit a pull request with your proposals.

---

## Licencia / License

Este proyecto está bajo la licencia [MIT](LICENSE).  
This project is licensed under the [MIT License](LICENSE).

Puedes usar, modificar y distribuir este software bajo los términos de la licencia.  
You can use, modify, and distribute this software under the terms of the license.

---

**¡Gracias por jugar Keyboard Runner y mejorar tus habilidades de mecanografía mientras te diviertes!**  
**Thank you for playing Keyboard Runner and improving your typing skills while having fun!**

