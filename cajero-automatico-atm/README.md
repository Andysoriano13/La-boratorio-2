Este es un proyecto de un mini-atm donde vamos practicando e implamentato
todo lo aprendido en las clases anteriores.


#FUNCIONALIDADES:
-VerInfo.
-Depositar.
-Retirar.
4-Salir.


# Reglas de negocio
- Saldo inicial: 10000
- La cuenta inicia inactiva; para operar se debe activar
- El depósito debe ser mayor a cero
- No se puede retirar más que el saldo disponible
- Al finalizar cada operación se pregunta si desea realizar otra


En esta version he mejorado el codigo haciendo una implementacion modular,
donde teniamos todas las funciones dentro del switch y cual se encuentra dentro 
del menu principal. Tambien corregi varios errores como:

# Cambios realizados (refactorización)
- Métodos extraídos del `Menu()` a métodos independientes
- `ActivarCuenta()` y `SeguirDentro()` para evitar código repetido
- Agregado `LeerMonto()` con validación mediante `TryParse`
- (agrega aquí lo que vayas haciendo)