Proceso ejercicio24
	//Pedir un número entre 0 y 9.999 y decir cuántas cifras tiene.
	Definir num Como Entero;
	
	Escribir " digite un numero entre el 0 y el 9999 " ;
	leer num ;
	
	si num < 10 Entonces
		Escribir " tiene una cifra " ;
	FinSi
	si num > 9 y num < 100 Entonces
		Escribir " tiene dos cifras ";
	FinSi
	si num > 99 y num < 1000 Entonces
		Escribir " tine tres cifras ";
	FinSi
	si num > 999 y num < 10000 Entonces
		Escribir " tiene cuatro cifras " ;
	FinSi
FinProceso
