Proceso Ejercico19
	//Pedir dos números y decir si uno es múltiplo del otro.
	
	//variables
	definir num_1 como entero;
	definir num_2 como entero;
	definir residuo Como Entero;
	//entradas
	escribir "Write the number";
	Leer num_1;
	Escribir "Write the other number";
	leer num_2;
	
	//salidas
	si num_1>num_2 Entonces
		residuo = num_1 mod num_2;
		si ( residuo ==0 ) entonces 
			Escribir "The number" ,num_1, "is a multiple of" ,num_2;
		SiNo
			Escribir "The number" ,num_1, "is not a multiple of" ,num_2;
			
		FinSi
	sino 
		residuo = num_2 mod num_1;
		si ( residuo ==0) Entonces
			Escribir "The number" ,num_2, "is a multiple of" ,num_1;
		SiNo
			Escribir "The number" ,num_2,"is not a multiple of" ,num_1;
		FinSi
	FinSi
FinProceso