# Calculadora Básica en C#

Proyecto de consola desarrollado en C# que simula una calculadora básica
con un menú interactivo. Permite realizar operaciones matemáticas con
números decimales y repetir el proceso sin cerrar el programa.

## Operaciones disponibles
- Sumar
- Restar
- Dividir
- Multiplicar
- Salir

## Cómo funciona
1. Al iniciar, se muestra el menú de operaciones.
2. El usuario escribe el nombre de la operación (por ejemplo: `sumar`).
3. El programa pide dos valores y muestra el resultado.
4. Al terminar pregunta si se desea realizar otra operación (`si` / `no`).
5. Si la respuesta es `si`, vuelve al menú; de lo contrario, el programa se cierra.

## Estructura del código
Cada operación está implementada en un método independiente:
- `menu()`: muestra el menú y recibe la opción elegida.
- `Sumar()`: suma dos valores.
- `Restar()`: resta dos valores.
- `Dividir()`: divide dos valores.
- `Multiplicar()`: multiplica dos valores.
- `Salir()`: muestra un mensaje de despedida y cierra el programa.

## Validaciones
- La opción del menú no distingue mayúsculas de minúsculas.
- Si la opción no es válida, se muestra un mensaje de aviso.
- En la división, ambos números deben ser mayores a cero; si no,
  se vuelven a solicitar los valores.