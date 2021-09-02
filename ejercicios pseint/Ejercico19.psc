Proceso Ejercico19
	//Pedir dos números y decir si uno es múltiplo del otro.
	
	//variables
	definir num_1 como entero;
	definir num_2 como entero;
	
	//entradas
	escribir "Write the number";
	Leer num_1;
	Escribir "Write the other number";
	leer num_2;
	
	//salidas
	si num_1>num_2 Entonces
		si num_1 mod num_2=0 entonces 
			Escribir "The number" ,num_1, "is a multiple of" ,num_2;
		SiNo
			Escribir "The number" ,num_1, "is not a multiple of" ,num_2;
			
		FinSi
	sino 
		si num_2 MOD num_1=0 Entonces
			Escribir "The number" ,num_2, "is a multiple of" ,num_1;
		SiNo
			Escribir "The number" ,num_2,"is not a multiple of" ,num_1;
		FinSi
	FinSi
FinProceso