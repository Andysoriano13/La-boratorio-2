
Este proyecto es la segunda versión de mi cajero automático en consola, hecho en C# (.NET 8). Partí del Mini ATM V1 y lo evolucioné en dos etapas: primero reorganicé el código en métodos, y después agregué un historial de movimientos.

#Qué hace el programa

El programa muestra un menú que se repite hasta que el usuario elige salir:

Consultar saldo
Depositar dinero
Retirar dinero
Consultar movimientos
Salir

Empieza con un saldo de RD$5,000.00 y una cuenta activa. Todos los montos usan decimal, porque es el tipo adecuado para dinero.

#Lo que hice

Etapa 1: dividir el código en métodos

En la V1 casi toda la lógica estaba junta. Ahora cada tarea tiene su propio método:

MostrarMenu(): muestra el menú y controla el ciclo que lo repite.
ConsultarSaldo(): muestra el saldo actual.
LeerMonto(): pide un monto y lo vuelve a pedir hasta que el usuario escriba un número válido.
Depositar() y Retirar(): validan la operación, actualizan el saldo y registran el movimiento.
ActivarCuenta(): permite activar la cuenta cuando está inactiva (lo conservé de la V1).

#Además hice estos cambios:

Cambié decimal.Parse por decimal.TryParse, para que escribir letras en lugar de un monto no cierre el programa.
Quité la recursión (métodos que se llamaban a sí mismos o volvían a abrir el menú). Ahora solo el ciclo de MostrarMenu() decide cuándo se repite.
Quité Environment.Exit(0). El programa termina cuando el ciclo del menú termina.

Etapa 2: historial de movimientos
Agregué una lista List<string> movimientos que guarda cada operación exitosa.
RegistrarMovimiento() recibe el monto y el tipo de operación, y guarda un texto con el tipo, el monto y la fecha y hora.
MostrarMovimientos() recorre la lista y la muestra en el orden en que se hicieron las operaciones. Si no hay ninguna, avisa que no hay movimientos.
Solo se registran los depósitos y retiros que se completan. Las operaciones rechazadas no se guardan.
Reglas que cumple

El saldo nunca queda negativo.
Un depósito debe ser mayor que cero.
Un retiro debe ser mayor que cero y no puede superar el saldo.
Con la cuenta inactiva no se puede depositar ni retirar. La comprobación se hace antes de pedir el monto.
El historial vive solo mientras el programa está abierto, sin base de datos ni archivos.