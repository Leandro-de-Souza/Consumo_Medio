#include <stdio.h>


int main()
{

     int distancia;
     double combustivel, consumo;

     printf("Distancia percorrida: ");
     scanf("%d", &distancia);
     printf("Combustivel gasto: ");
     scanf("%lf", &combustivel);

     consumo = (double) distancia / combustivel;

     printf("Consumo medio = %.3lf", consumo);



    return 0;
}
