# Gestión de Productos en C# Aplicación de consola desarrollada en C# que modela un producto de inventario mediante programación orientada a objetos. Permite registrar los datos de un producto, mostrarlos en una tabla formateada en consola y calcular el valor total que representa su stock.

¿Que se ha implementado?

##Una clase `Producto` con cuatro propiedades (código, nombre, precio y cantidad). – 
##Un método para **mostrar la información** del producto en una tabla alineada. – 
##Un método para **calcular el valor total** del producto en inventario. –
##Un programa principal que crea **tres productos**, muestra su información y su total, y ##demuestra que los datos pueden **modificarse** después de creados.


METODOS:

### `MostrarInformacion()` - **Retorno:** `void` (escribe directamente en consola). – 

**Qué hace:** imprime un bloque con una línea de asteriscos como separador, una fila de encabezados y una fila con los datos actuales del producto. 
- **Formato:** utiliza *composite formatting* con especificadores de ancho:

### `ConsultarValorTotal()` - **Retorno:** `decimal`. - **
Qué hace:** multiplica el precio unitario por la cantidad en stock (`Precio * Cantidad`). – 
**Nota:** el valor se calcula en el momento de la llamada, por lo que siempre refleja los datos actuales del objeto.
