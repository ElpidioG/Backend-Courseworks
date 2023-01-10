#include<stdio.h>
#include<conio.h>

int main()

{
printf("\t \t \t------------------------\n");
printf("\t \t \t| Datos de Estudiantes |\n");
printf("\t \t \t------------------------\n \n");

char nombre1[50];
char curso1[50];	
char fecha_de_nacimiento1[50];	
char nombre2[50];	
char curso2[50];
char fecha_de_nacimiento2[50];
char nombre3[50];
char curso3[50];
char fecha_de_nacimiento3[50];	

printf("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
printf("+ Introduce el nombre del primer estudiante: ");
scanf("%s",&nombre1);
	
printf("\n+ Introduce el curso del primer estudiante: ");
scanf("%s",&curso1);

printf("\n+ Introduce la fecha de nacimiento del primer estudiante: ");
scanf("%s",&fecha_de_nacimiento1);
printf("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
getch ();



printf("\n*********************************************************************");
printf("\n* Introduce el nombre del segundo estudiante: ");
scanf("%s",&nombre2);

	
printf("\n* Introduce el curso del segundo estudiante: ");
scanf("%s",&curso2);

	
printf("\n* Introduce la fecha de nacimiento del segundo estudiante: ");
scanf("%s",&fecha_de_nacimiento2);
printf("*********************************************************************\n");
getch ();


printf    ("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ "); printf    ("\t\t+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
printf    ("+                        Primer Estudiante                      +  "); printf    ("\t\t+                       Segundo Estudiante                      +\n");
printf    ("+ Nombre: %s                                                      ",nombre1);   printf    ("\t\t+ Nombre: %s                                                             \n",nombre2);    
printf    ("+ Curso: %s                                                      ",curso1);     printf    ("\t\t+ Curso: %s                                                               \n",curso2);
printf    ("+ Fecha de nacimiento: %s                                        ",fecha_de_nacimiento1); printf    ("\t\t+ Fecha de nacimiento: %s                                           \n",fecha_de_nacimiento2);
printf    ("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++   ");printf    ("\t\t+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++   \n");







}




