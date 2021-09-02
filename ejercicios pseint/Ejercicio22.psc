Proceso Ejercicio22
	//Pedir dos números y mostrarlos ordenados de mayor a menor.
	
	//variables
	Definir num1 Como Entero;
	Definir num2 Como Entero;
	
	//Entradas
	Escribir 'Escribir el numero 1 :';
	leer num1;
	Escribir 'Escribir el numero 2 :';
	Leer num2;
	
	si num1>num2 Entonces
		Escribir 'es mayor el ' ,num1, ' y menor el ' ,num2;
	SiNo
		si num2 > num1 Entonces
			Escribir 'es mayor el ' ,num2, ' y menor el ' ,num1;
		sino 
			Escribir ' los numeros son iguales ' ;
		FinSi
		
	FinSi
FinProceso