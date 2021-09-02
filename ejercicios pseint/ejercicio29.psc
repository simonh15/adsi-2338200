Proceso ejercicio29
	//Dado un monto, calcular el descuento considerando que por encima de 100 el descuento es del 10%
	//y por debajo de 100, el descuento es del 2%.
	Definir monto Como Entero;
	leer monto ;
	Definir descuento Como Real;
	
	si monto > 100 Entonces
		Escribir " el descuento es de : ", monto * 0.10 ;
	SiNo
		Escribir " el descuento es de : " , monto * 0.02 ;
	FinSi
	
	
FinProceso
