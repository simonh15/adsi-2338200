Proceso ejercicio06
	//Hacer un algoritmo que lea el nombre de un artículo, el valor unitario, la cantidad a comprar y muestre
	//el nombre y el total a pagar.
	
	//definicion variables 
	Definir name_article Como Caracter;
	definir unit_value Como Entero;
	Definir quantity_buy Como Entero;
	definir total_pay Como Real;
	
	//operacion de entrada 
	Escribir " the name of article is : ";
	leer name_article;
	Escribir  " the unit value is :";
	leer unit_value;
	escribir "quantity to buy is : ";
	Leer quantity_buy;
	// procedimiento
	total_pay= unit_value * quantity_buy ;
	
	//operacion de salida 
	escribir " the product name is : " , name_article, " the total to pay is : " , total_pay ;
FinProceso
