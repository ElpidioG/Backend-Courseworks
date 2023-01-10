#include<iostream>
#include<string>
#include<cstdlib>
#include<ctime>
#include<stdlib.h>//para el system("pause")

using namespace std;

class Rectangulo{//la clase no es una funcion, por ende no se le pone () despues de nombrarlo
 private:
  float largo;
  float ancho;

 public://
  Rectangulo(float,float);
  float area();
  float perimetro();


};

Rectangulo::Rectangulo(float _largo, float _ancho){// mi constructor
 largo=_largo;
 ancho=_ancho;

}

float Rectangulo::area(){//tengo que decir de donde sale esta area. Se le declara Rectangulo::area
 return largo*ancho;
}

float Rectangulo::perimetro(){
 return 2*(largo+ancho);
}

int main(){
 float largo_,ancho_;
 cout<<"Ingrese el largo"<<endl;
 cin>>largo_;
 cout<<"Ingrese el ancho"<<endl;
 cin>>ancho_;

 Rectangulo r1(largo_,ancho_);
 cout<<"Area: "<<r1.area()<<endl;
 cout<<"Perimetro: "<<r1.perimetro()<<endl;




 system("pause");//para que el programa no se cierre
 return 0;
}
