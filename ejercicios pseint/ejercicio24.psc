Proceso ejercicio24
	//Pedir un número entre 0 y 9.999 y decir cuántas cifras tiene.
	Definir num Como Entero;
	
	Escribir " digite un numero entre el 0 y el 9999 " ;
	leer num ;
	si num < 0 Entonces
		Escribir ' este nnumero es negativo ';
	SiNo
		si num < 10 Entonces
			Escribir " tiene una cifra " ;
		SiNo
			si num > 9 y num < 100 Entonces
				Escribir " tiene dos cifras ";
			SiNo
				si num > 99 y num < 1000 Entonces
					Escribir " tine tres cifras ";
				SiNo
					si num > 999 y num < 10000 Entonces
						Escribir " tiene cuatro cifras " ;
					sino 
						Escribir ' este numro tiene 5 o mas cifras ';
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi
	
	
	
	
		
FinProceso
