# Datos del alumno 
**Izetta Nicolas Denis** LU:461 DNI:44280726
> **Asignatura:** Programación de Videojuegos I 
> **Carrera:** Tecnicatura Universitaria en Diseño Integral de Videojuegos (TUDIVJ) — UNJu 
> **Trabajo Práctico N° 1:** Entorno Interactivo 3D, Temporizadores y Git/GitHub 
>**Equipo Docente:** Mg. Ing. Ariel Alejandro Vega | Tecn. Kevin Alexis Roman Llampa 


# Proyecto de Videojuego Unity

Este proyecto es un prototipo de videojuego desarrollado con Unity 6000.5.7f1. La base del juego incluye movimiento del personaje, interacción con objetos, zona de meta, power-ups y generación de obstáculos en tiempo real.

## Descripción general

El juego está orientado a una experiencia simple de exploración y objetivos: el jugador se desplaza por el escenario, recoge un objeto, llega a la meta y puede activar mejoras temporales para acelerar su movimiento.

## Características principales

- Movimiento del personaje en 3D
- Captura/selección de objetos con tecla de interacción
- Sistema de objetivo o zona de meta
- Power-up de velocidad temporal
- Spawn de obstáculos automatizado
- Uso de Input System y componentes de Unity

## Controles

- WASD: movimiento del personaje
- Space / Jump: posible desplazamiento vertical o movimiento extra según la configuración de la escena
- E: recoger o interactuar con objetos

> Los controles pueden ajustarse según la escena final o la configuración del proyecto en Unity.

## Objetivo del juego

1. Moverse por el mapa.
2. Recoger el objeto requerido.
3. Llevarlo hasta la zona de meta.
4. Aprovechar los power-ups para mejorar velocidad y avanzar con más facilidad.

## Estructura del proyecto

```text
Assets/
  Scenes/
  Scripts/
  Settings/
  materiales/
Packages/
ProjectSettings/
README.md
```

Los scripts principales se encuentran en `Assets/Scripts` y contienen la lógica de:

- movimiento del jugador
- entrega de objetos
- power-ups
- generación de obstáculos
- cámara

## Requisitos

- Unity Hub
- Unity 6000.5.7f1 o compatible
- Visual Studio o VS Code para edición de scripts


## Notas

Falta concretar algunas cosas, como el mobimiento de la camara con el mouse, y el spawn de obstaculos no funciona como se deveria 




