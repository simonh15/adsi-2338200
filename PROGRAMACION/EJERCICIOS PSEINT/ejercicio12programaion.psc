Proceso ejercicio12
	//Hacer un algoritmo que lea el nombre de una persona, el valor de la hora trabajada y el número de
	//horas que trabajó. Se debe mostrar el nombre y el pago de la persona.
	
	// definir variables 
	definir name_person Como caracter;
	definir value_hour_worked Como entero;
	definir number_hour_worked Como entero;
	definir total_pay Como Entero;
	
	//operacion de entrada
	escribir " write the name of person :" ;
	leer name_person ;
	escribir " write  the hour worked value : " ;
	leer value_hour_worked ;
	escribir " write the hours worked number : " ;
	leer number_hour_worked;
	
	//proceso 
	total_pay = value_hour_worked * number_hour_worked ;
	
	//operacion de salida 
	escribir " the name of person is : " , name_person , " the person payment is : " , total_pay;
	
	
FinProceso
