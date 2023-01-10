 #include <stdio.h>
#include <conio.h>

int main()
{

char nombre[50],apellido[50],fechanacimiento[50],direccion[50],telefono[50],email[50];
char fechacontratacion[100],cargo[100],departamento[100];
float salario;
printf("------------------------\n");
printf("| Datos de un empleado |\n");
printf("------------------------\n\n");

printf("Datos personales\n");
printf("************************************************************\n\n");
printf("* Introduce tu nombre: ");
scanf("%s",&nombre);
printf("* Introduce tu apellido: ");
scanf("%s",&apellido);
printf("* Introduce tu fecha de nacimiento: ");
scanf("%s",&fechanacimiento);
printf("* Introduce tu direccion: ");
scanf("%s",&direccion);
printf("* Introduce tu telefono: ");
scanf("%s",&telefono);
printf("* Introduce tu email: ");
scanf("%s",&email);
printf("\n************************************************************\n\n");
getch();
printf("Datos Laborales\n");
printf("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n\n");
printf("+ Introduce la fecha en la que te contrataron: ");
scanf("%s",&fechacontratacion);
printf("+ Introduce tu cargo: ");
scanf("%s",&cargo);
printf("+ Introduce el departamento en el que trabajas: ");
scanf("%s",&departamento);
printf("+ Introduce el salario: ");
scanf("%f",&salario);
printf("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n\n");
getch();

printf("**************************************************************************************\n");
printf("********************************Reporte del empleado**********************************\n");
printf("**************************************************************************************\n\n");
printf("|\t%s %s                                                            |\n",nombre,apellido);
printf("|\tFecha de nacimiento: %s                                              |\n",fechanacimiento);
printf("|\tDireccion: %s",direccion); 
printf(" \tTelefono: %s               |\n",telefono);
printf("|\tCorreo: %s                                                     |\n\n",email);


printf("| Datos Laborales \n");
printf("| ----------------------------\n\n");
printf("|\tFecha de contratacion: %s",fechacontratacion); printf("\tCargo: %s                       |\n",cargo);
printf("|\tDepartamento: %s                                                 |\n",departamento);
printf("|\tSalario: $%.1f                                                            |\n\n\n",salario);
printf("**************************************************************************************\n");
printf("**************************************************************************************\n");
printf("**************************************************************************************\n\n");

}










