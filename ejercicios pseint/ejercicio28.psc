Proceso ejercicio28
	// Un trabajador recibe su pago, según la cantidad de horas trabajadas y su valor. Si la cantidad de
	//horas trabajadas es mayor que 40, éstas se consideran horas extra, y tienen un incremento de $10000
    //(diez mil) sobre el valor de la hora. Calcular y mostrar el salario (pago) del trabajador. Nota: leer horas
	//trabajadas y valor de la hora.
	definir cantidad_horas_trabajadas Como Entero;
	Definir valor_hora_paga Como Entero;
	definir pago_total como entero ; 
	definir horas_extras_trabajadas Como Entero;
	
	escribir " ingrese cuantas horas a trabajado " ;
	leer cantidad_horas_trabajadas;
	Escribir " ingrese valor por hora trabajada ";
	leer valor_hora_paga ;
	Escribir  " ingrese horas extras trabajadas ";
	leer horas_extras_trabajadas ;
	
	si (cantidad_horas_trabajadas > 40) Entonces
		pago_total = (valor_hora_paga * cantidad_horas_trabajadas) + ( ( horas_extras_trabajadas * valor_hora_paga) + ( 10000 * horas_extras_trabajadas)) ;
		
		escribir " su salario total fue " , pago_total , " incluido el pago de horas extra " ;
	SiNo
		pago_total = ( valor_hora_paga * cantidad_horas_trabajadas ) ;
		escribir " su salario total fue de " , pago_total ;
		
		
	FinSi
	

FinProceso
