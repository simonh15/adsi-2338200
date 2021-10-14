Proceso ejercicio30
	//Leer dos números y calcular su división, teniendo en cuenta que el denominador no debe ser 0 (cero)
	
	
	Definir num1 Como real;
	Definir num2 Como real;
	definir total Como Real;
	
	
	Escribir 'Digite el primer numero ';
	Leer num1;
	Escribir 'Digite el divisor numero';
	Leer num2;
	
	
	si ( num2 == 0 ) Entonces
		Escribir 'la operacion es incorecta ';
	SiNo
		total= num1/ num2 ;
		Escribir ' el total de la division es: ' , total ;
	FinSi
	
	
FinProceso
