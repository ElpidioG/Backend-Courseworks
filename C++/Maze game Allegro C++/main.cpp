#include <iostream>
#include<allegro.h>
#define mfilas 21
#define mcols 31
#define maxcols 31
#define maxfilas 20

BITMAP *buffer;
BITMAP *player;
BITMAP *playerder;
BITMAP *playeriz;
BITMAP *playerabaj;
BITMAP *muro;
BITMAP *camino;

int px =30 * 6;
int py =30 * 19;

int dire = 0;

    char mapa[mfilas][mcols] = {
    "FFFFFFFFFFFFFFIFFFFFFFFFFFFF",
    "FIIIIIIIIIIIIIIIIIIIIIIIIIIF",
    "FIFFFFIFFFFFFFFFFIFFFFFFIFIF",
    "FIIIIIIIIIIIIIFFFIFFFFFFIIIF",
    "FIFFFFIFFFFFIIIIIIIIIFFFIFFF",
    "FIFFFFIFFFFFIIIIIIIIIFFFIFFF",
    "FIFFFFIFFFFFFFIFFFFFIIIIIIIF",
    "FIFFFFIIIIFFFFIFFFFFFFFFFFIF",
    "FIFFFFFFFIFFFFIFFFFFFFFFFFIF",
    "IIIIIIIIIIFFFFIFFFFFIIIIIIII",
    "FIFFFFFFIIFFFFIFFFFFFFFIIIIF",
    "FIFFFFFFIIFFFFIFFFFFFFFIFFIF",
    "FIFFFIIIIIIIIIIIIIIIIIIIFFIF",
    "FIFFFIIFFFFFFIFFFFFFIFFFFFIF",
    "FIFFFIIFFFFFFIIIIIIIIIIIIIIF",
    "FIFFFIIFFFFFFIFFFFFFIFFFFFIF",
    "FIFFFIIFFFFFFIFFFFFFIFFFFFIF",
    "FIFFFIIFFFFFFIFFFFFFIFFFFFIF",
    "FIIIIIIIIIIIIIIIIIIIIIIIIIIF",
    "FIIIIIIIIIIIIIIIIIIIIIIIIIIF",
    "FFFFFFFFFFFFFFIFFFFFFFFFFFFF"

    };


void pintarmapa()
{

    int fila, columna;
    for (fila = 0; fila < mfilas; fila++){
        for (columna = 0; columna < mcols; columna++){
            if (mapa[fila][columna] == 'F')
            {
                draw_sprite(buffer,muro,columna*30,fila*30);


            } else if (mapa[fila][columna] == 'I')
        {
                draw_sprite(buffer,camino,columna*30,fila*30);


        }


        }
    }

}


void movimientos()
{

    //moverse a la derecha

        if (key[KEY_RIGHT])
    {
        if(mapa[py/30][(px+30)/30] != 'F')
        {
            dire = 2;
            px+=30 ;

        }


    }
    //arriba

    if (key[KEY_UP])
{
    if(mapa[(py-30)/30][px/30] != 'F')
        {
            dire = 0;
            py-=30;

        }
}

//moverse a la izquierda
        if (key[KEY_LEFT])
    {
        if(mapa[py/30][(px-30)/30] != 'F')
        {
            dire = 3;
            px-=30;

        }
    }
    //abajo
    if (key[KEY_DOWN]){
    if(mapa[(py+30)/30][px/30] != 'F')
        {
            dire = 1;
            py+=30;

        }
}

if (px<=- 30) px = 840;
else if (px>= 840) px = 30;



if (py<=- 30) py = 630;
else if (py>= 630) py = 30;
pintarmapa();
rest(30);
if (dire == 0)
{
    draw_sprite(buffer,player,px,py);


}

if (dire == 1)
{
    draw_sprite(buffer,playerabaj,px,py);

}
if (dire == 2)
{
    draw_sprite(buffer,playerder,px,py);


}
if (dire == 3)
{
    draw_sprite(buffer,playeriz,px,py);

}
}


using namespace std;

int main()
{
    allegro_init();
    install_keyboard();
    install_mouse();
    set_color_depth(32);
    set_gfx_mode(GFX_AUTODETECT_WINDOWED,840,630,0,0);

        if (install_sound(DIGI_AUTODETECT, MIDI_AUTODETECT, NULL) != 0)
    { allegro_message("Error: inicializando sistema de sonido\n%s\n", allegro_error);
     return 1;
    }
buffer = create_bitmap(840,630);

player = load_bitmap("player.bmp",NULL);
playerder = load_bitmap("playerder.bmp",NULL);
playeriz = load_bitmap("playeriz.bmp",NULL);
playerabaj = load_bitmap("playerabaj.bmp",NULL);
muro = load_bitmap("muro.bmp",NULL);
camino = load_bitmap("camino.bmp",NULL);


while(!key[KEY_ESC]){

 blit(buffer, screen,0,0,0,0,840,630);

movimientos();

}

}
END_OF_MAIN()
