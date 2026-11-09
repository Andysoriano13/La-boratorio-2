Clase	Responsabilidad	Propiedades	Métodos
Cuenta	Mantener datos y responsabilidades de una cuenta	NumeroCuenta, Saldo, Activa	ConsultarSaldo(),
Depositar(), Retirar()


Transacción	Representar los datos de una operación	Tipo, Monto, Fecha	MostrarDetalles()

Pantalla	Presentar mensaje y resultado	No tiene estado propio	MostrarMensaje(),
MostrarSaldo()

Teclado	Capturar los datos que escribe un usuario	No tiene estado propio	LeerMonto(),
LeerOpcion();
			
			
Descripción:
Incorporación en clases del sistema atm incorporado durante todo el transcurso del curso de c#, 
donde se implantan clases las cuales se instancian para ver el funcionamiento de cada una


Qué hace el programa
1.	Crea una Cuenta con saldo inicial de 1,000, número 1111 y estado activo, y un Teclado y una Pantalla.
2.	La pantalla muestra el mensaje de bienvenida y el saldo actual.
3.	El teclado pide un monto y la cuenta intenta depositarlo. Si la operación se realiza, se crea una Transacción, se muestran sus detalles y se vuelve a mostrar el saldo.
4.	El teclado pide otro monto y la cuenta intenta retirarlo, con el mismo procedimiento.

Si el monto no es un número, el teclado lo vuelve a pedir hasta que sea válido.


Decisiones de diseño
•	Teclado solo comprueba que lo escrito sea un número. Las reglas del negocio (monto mayor que cero, 
	fondos suficientes) las aplica Cuenta, porque son distintas para depositar y para retirar.
•	Cuenta recibe el monto como parámetro. No conoce al Teclado: quien coordina es Program.cs, que lee el monto y se lo pasa.
•	La Transacción solo se crea si la operación se realizó. Depositar y Retirar devuelven el monto movido, o 0 si rechazaron la operación,
	 y Program.cs lo comprueba antes de crear el objeto.
•	Saldo es privada. Se consulta con ConsultarSaldo().









