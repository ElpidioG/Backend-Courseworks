#include <iostream>
#include<allegro.h>
#define mfilas 21
#define mcols 60

BITMAP *buffer;

BITMAP *mouse;
BITMAP *menu;
BITMAP *menu1;
BITMAP *menu2;
BITMAP *menu3;
BITMAP *menu4;


BITMAP *tile;
BITMAP *fondo;
BITMAP *spmario;
BITMAP *spmario1;
BITMAP *matai;
BITMAP *matam;
BITMAP *matad;

BITMAP *monta;
BITMAP *monta1;
BITMAP *monta2;
BITMAP *monta3;
BITMAP *monta4;
BITMAP *monta5;
BITMAP *monta6;
BITMAP *monta7;
BITMAP *monta8;


BITMAP *tubo;
BITMAP *tubo1;
BITMAP *tubo2;
BITMAP *tubo3;


BITMAP *nube;
BITMAP *nube2;
BITMAP *nube3;
BITMAP *nube4;
BITMAP *nube5;
BITMAP *nube6;


BITMAP *castillo;
BITMAP *paredes;
BITMAP *flag;

BITMAP *bloque;
BITMAP *randb;



BITMAP *mariocamider1;
BITMAP *mariocamiz;
BITMAP *mariosald;
BITMAP *mariosali;
MIDI *musica;
SAMPLE *coin = load_wav("coin.wav");

int x = 100;
int y = 400;

int mx = 30*12; int my = 30*18;

int px =0;
int py =0;


bool cerrar = false;
int arriba = 0;
bool salto = false;
float velosalto = 17;
float velx = 0, vely= 0;
const float gravedad = 1;
int direccion  = 1;


char mapa[mfilas][mcols] =
 {
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
 "IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII",
 };

void impresiones()
{


   fondo = load_bitmap("cielo.bmp",NULL);
   tile = load_bitmap("tile.bmp",NULL);

   spmario= load_bitmap("spmario.bmp",NULL);
   spmario1= load_bitmap("spmario1.bmp",NULL);
      mariocamider1= load_bitmap("corre.bmp",NULL);
   mariocamiz= load_bitmap("corre2.bmp",NULL);
   mariosald= load_bitmap("saltard.bmp",NULL);
   mariosali= load_bitmap("saltari.bmp",NULL);


   matai= load_bitmap("matai.bmp",NULL);
   matam= load_bitmap("matam.bmp",NULL);
   matad= load_bitmap("matad.bmp",NULL);

    monta= load_bitmap("monta.bmp",NULL);
    monta1= load_bitmap("monta1.bmp",NULL);
    monta2= load_bitmap("monta2.bmp",NULL);
    monta3= load_bitmap("monta3.bmp",NULL);
    monta4= load_bitmap("monta4.bmp",NULL);
    monta5= load_bitmap("monta5.bmp",NULL);
    monta6= load_bitmap("monta6.bmp",NULL);
    monta7= load_bitmap("monta7.bmp",NULL);
    monta8= load_bitmap("monta8.bmp",NULL);


    tubo= load_bitmap("tubo.bmp",NULL);
    tubo1= load_bitmap("tubo1.bmp",NULL);
    tubo2= load_bitmap("tubo2.bmp",NULL);
    tubo3= load_bitmap("tubo3.bmp",NULL);


    nube = load_bitmap("nube1.bmp",NULL);
    nube2 = load_bitmap("nube2.bmp",NULL);
    nube3 = load_bitmap("nube3.bmp",NULL);
    nube4 = load_bitmap("nube4.bmp",NULL);
    nube5 = load_bitmap("nube5.bmp",NULL);
    nube6 = load_bitmap("nube6.bmp",NULL);
    castillo = load_bitmap("castillo.bmp",NULL);
    flag = load_bitmap("bandera.bmp",NULL);


    bloque = load_bitmap("bloque.bmp",NULL);
    randb = load_bitmap("rand.bmp",NULL);
    paredes= load_bitmap("pared.bmp",NULL);
        mouse = load_bitmap ("mouse.bmp",NULL);

    menu1 = load_bitmap ("menu1.bmp",NULL);
    menu2 = load_bitmap ("menu2.bmp",NULL);
    menu3 = load_bitmap ("menu3.bmp",NULL);
    menu4 = load_bitmap ("menu4.bmp",NULL);
    musica = load_midi("mario.mid");

}

void movimientos()
{

    //moverse a la derecha

        if (key[KEY_RIGHT] and salto)
    {

    draw_sprite(buffer,mariocamider1,px+20,py+540);
    px+=5;
    blit(buffer,screen,0,0,0,0,800,600);
    rest(3);

direccion = 1;

    }

    if (direccion == 1 and salto)
{

draw_sprite(buffer, spmario, px+15, py+542);

  blit(buffer,screen,0,0,0,0,1300,600);



}

//moverse a la izquierda
        if (key[KEY_LEFT] and salto)
    {

    draw_sprite(buffer,mariocamiz,px,py+540);
    px-=5;
    blit(buffer,screen,0,0,0,0,800,600);
    rest(3);
direccion = 0;


    }

    if (direccion == 0 and salto){
        draw_sprite(buffer, spmario1, px+5, py+542);
         blit(buffer,screen,0,0,0,0,800,600);

}

//salto
        if(key[KEY_SPACE] && salto)
        {

            vely -= velosalto;
            salto = false;
        }
         if(!salto)


            vely += gravedad;

            else

                velx = 0;
                px += velx;
                py += vely;
                salto = (py>= arriba);

            if(salto)
            {
                py = arriba;
            }

//salto mirando a derecha
if (!salto and direccion == 1)
{


    draw_sprite(buffer,mariosald,px+16,py+542);
    blit(buffer,screen,0,0,0,0,800,600);

    if (key[KEY_RIGHT])
    {
        px+=3;
    }
rest(1);
}


//salto mirando a izquierda
if (!salto and direccion == 0)
{


    draw_sprite(buffer,mariosali,px+16,py+542);
    blit(buffer,screen,0,0,0,0,800,600);

    if (key[KEY_LEFT])
    {
        px-=3;
    }
rest(1);
}

}

void montana(){

    draw_sprite(buffer, monta, x+320, y+82);
    draw_sprite(buffer, monta1, x+320, y+112);
    draw_sprite(buffer, monta2, x+320, y+142);

    draw_sprite(buffer, monta3, x+290, y+112);
    draw_sprite(buffer, monta1, x+290, y+142);
    draw_sprite(buffer, monta5, x+260, y+142);
    draw_sprite(buffer, monta6, x+350, y+112);
    draw_sprite(buffer, monta7, x+350, y+142);
    draw_sprite(buffer, monta8, x+380, y+142);

}

void planta(){



    //Plantas
    draw_sprite(buffer, matai, x+170, y+142);
    draw_sprite(buffer, matam, x+200, y+142);
    draw_sprite(buffer, matad, x+230, y+142);


            }

void tuberia(){

    draw_sprite(buffer, tubo, x+80, y+142);
    draw_sprite(buffer, tubo1, x+110, y+142);
    draw_sprite(buffer, tubo2, x+110, y+112);
    draw_sprite(buffer, tubo3, x+80, y+112);

}

void nubes(){


draw_sprite(buffer, nube, x+100, 62);
draw_sprite(buffer, nube2, x+130, 62);
draw_sprite(buffer, nube3, x+160, 62);
draw_sprite(buffer, nube4, x+100, 92);
draw_sprite(buffer, nube5, x+130, 92);
draw_sprite(buffer, nube6, x+160, 92);




draw_sprite(buffer, nube, x+300, 22);
draw_sprite(buffer, nube2, x+330, 22);
draw_sprite(buffer, nube3, x+360, 22);
draw_sprite(buffer, nube4, x+300, 52);
draw_sprite(buffer, nube5, x+330, 52);
draw_sprite(buffer, nube6, x+360, 52);




draw_sprite(buffer, nube, x+500, 42);
draw_sprite(buffer, nube2, x+530, 42);
draw_sprite(buffer, nube3, x+560, 42);
draw_sprite(buffer, nube4, x+500, 72);
draw_sprite(buffer, nube5, x+530, 72);
draw_sprite(buffer, nube6, x+560, 72);


}

void castilloa()
{
    draw_sprite(buffer, castillo, x+500, 390);
    draw_sprite(buffer, flag, x+584, 363);


}

void bloques()
{
    draw_sprite(buffer, bloque, x+80, 392);
    draw_sprite(buffer, bloque, x+110, 392);
    draw_sprite(buffer, randb, x+140, 392);
    draw_sprite(buffer, bloque, x+170,392);
    draw_sprite(buffer, bloque, x+200, 392);



    draw_sprite(buffer, bloque, x+300, 342);
    draw_sprite(buffer, bloque, x+330, 342);
    draw_sprite(buffer, randb, x+360, 342);
    draw_sprite(buffer, bloque, x+390,342);
    draw_sprite(buffer, bloque, x+420, 342);



}

void pintarmapa()
{

    int fila, columna;
    for (fila = 0; fila < mfilas; fila++){
        for (columna = 0; columna < mcols; columna++){
            if (mapa[fila][columna] == 'F')
            {
                draw_sprite(buffer,fondo,columna*30,fila*30);

            } else if (mapa[fila][columna] == 'I')
        {
                draw_sprite(buffer,tile,columna*30,fila*30);

        }


        }
    }

}


void pared(){
int    a = 270;
for (int i = 0; i< 10; i++)
{
    draw_sprite(buffer,paredes,570,a);

    a= a+30;

}

for (int i = 0; i< 4; i++)
{
    draw_sprite(buffer,paredes,a-400,270);

    a= a+30;

}



}


void juego()
{
pintarmapa();
planta();
montana();

tuberia();
nubes();
castilloa();
bloques();
pared();
movimientos();
}

void menus()
{

//clear_to_color(buffer,0xffffff);
//draw_sprite(buffer, mouse, mouse_x, mouse_y);
blit(menu2, buffer,0,0,0,0,800,600);


if ((mouse_x <= 373 and mouse_x>=199) and (mouse_y <= 450 and mouse_y>=311))
{
    blit(menu3, buffer,0,0,0,0,800,600);
    if (mouse_b &1 ){


        while(!key[KEY_ESC]){
            juego();
        }

rest(1);

}

}
else if ((mouse_x <= 637 and mouse_x>=508) and (mouse_y <= 448 and mouse_y>=308)    )
{
blit(menu1, buffer,0,0,0,0,800,600);
if (mouse_b &1 ){
        cerrar = true;
}

}

}

void set_mouse_range (int x1=1, int y1=1, int x2=780, int y2=570);
using namespace std;

int main()
{

    allegro_init();
    install_keyboard();
    install_mouse();
    set_color_depth(32);
    set_gfx_mode(GFX_AUTODETECT_WINDOWED,800,600,0,0);


    if (install_sound(DIGI_AUTODETECT, MIDI_AUTODETECT, NULL) != 0)
    { allegro_message("Error: inicializando sistema de sonido\n%s\n", allegro_error);
     return 1;
    }
    set_volume(70, 70);
    buffer = create_bitmap(800,600);

impresiones();



play_midi(musica, 1);
while(!key[KEY_ESC] and cerrar == false){


menus();
 masked_blit(mouse,buffer,0,0,mouse_x,mouse_y,30,30);
 set_mouse_range();
 blit(buffer, screen,0,0,0,0,800,600);
rest(1);

}
}

END_OF_MAIN()
