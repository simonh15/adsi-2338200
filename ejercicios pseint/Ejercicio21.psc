Proceso Ejercicio21
	//Pedir dos números y decir cuál es el mayor o si son iguales.
	
	//variables
	Definir num1 Como Entero;
	Definir num2 Como Entero;
	
	//entrada
	Escribir 'Escribir el numero 1 :';
	leer num1;
	Escribir 'Escribir el numero 2 :';
	Leer num2;
	
	//Salida
	si num1==num2 Entonces
		Escribir ' los numeros son iguales ';
	SiNo
		
		si num1 > num2 Entonces
			Escribir ' el numero ', num1 , ' es mayor que el numero ' , num2;
			
		SiNo
			Escribir ' el numero ', num2 , ' es mayor que el numero ' , num1;
			
		FinSi
	FinSi
	
FinProceso