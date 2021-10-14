Proceso ejercicio28
	// Un trabajador recibe su pago, según la cantidad de horas trabajadas y su valor. Si la cantidad de
	//horas trabajadas es mayor que 40, éstas se consideran horas extra, y tienen un incremento de $10000
    //(diez mil) sobre el valor de la hora. Calcular y mostrar el salario (pago) del trabajador. Nota: leer horas
	//trabajadas y valor de la hora.
	definir cantidad_horas_trabajadas Como Entero;
	Definir valor_hora_paga Como real ;
	definir pago_total como real ; 
	definir horas_extras_trabajadas Como Entero;
	Definir pago_horas_extras Como Real;
	
	escribir " ingrese cuantas horas a trabajado " ;
	leer cantidad_horas_trabajadas;
	Escribir " ingrese valor por hora trabajada ";
	leer valor_hora_paga ;
	
	pago_total = cantidad_horas_trabajadas * valor_hora_paga ;
	horas_extras_trabajadas = 0;
	si (cantidad_horas_trabajadas > 40) Entonces
		horas_extras_trabajadas = cantidad_horas_trabajadas - 40;
		pago_horas_extras = 10000 * horas_extras_trabajadas ;
		pago_total = pago_total + pago_horas_extras ;
		escribir " su salario total fue " , pago_total , " incluido el pago de horas extra " ;
	FinSi
	Escribir  ' su pago es: ' , pago_total;
	Escribir  ' horas extras trabajadas: ' , horas_extras_trabajadas ;
	
	

FinProceso
