Proceso ejercicio25
	//Pedir una nota de 0 a 5 y mostrarla de la forma: Insuficiente (0 ? 2,9), Suficiente (3 ? 4,5) y Bien (4,6
	//? 5)
	Definir num Como Real;
	Leer num ; 
	
	si ( num < 0 ) o ( num > 5 ) Entonces
		Escribir ' esta nota es invalida ';
	SiNo
		si num < 3 Entonces
			Escribir  "su nota es insuficiente ";
		SiNo
			si num > 2.9 y num < 4.5 Entonces
				Escribir " su nota es suficiente " ;
			SiNo
					Escribir " su nota es bien " ;
			FinSi
		FinSi
	FinSi
FinProceso
