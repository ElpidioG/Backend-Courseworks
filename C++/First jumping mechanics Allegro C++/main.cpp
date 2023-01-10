#include <iostream>
#include <allegro.h>
#include <stdlib.h>

using namespace std;



int x[5] = {260,10, 200, 400, 600};
int y[5] = {300,360, 320, 280, 230};


 int arriba = 400;
bool salto = false;
float velosalto = 17;
float velx = 0, vely= 0;
const float gravedad = 1;



void movimientos()
{

             if (key[KEY_RIGHT] and x[0] < 670)
    {
        x[0]+=5;
    }
        if (key[KEY_LEFT] and x[0] > 1)
    {
        x[0]-=5;
    }

        if(key[KEY_SPACE] && salto)
        {
            vely -= velosalto;
            salto = false;
        }
         if(!salto)


            vely += gravedad;

            else

                velx = 0;
                x[0] += velx;
                y[0] += vely;
                salto = (y[0]>= arriba);

            if(salto)
            {
                y[0] = arriba;
            }
}


void plataformas()
{

//si se cae
if ((x[0] > x[1] + 100 and x[0]+30 <  x[2]) or (x[0] > x[2] + 100 and x[0]+30 <  x[3]) or (x[0] > x[3] + 100 and x[0]+30 <  x[4]))
{
    arriba = 400;


}

// si esta en el suelo
  if (arriba == 400)
  {

      velosalto = 16;
  }


// si toca la primera plataforma
if ( ((x[0] >= x[1] or x[0]+30 >= x[1])  and (x[0] <= x[1]+100 or x[0]+30 <= x[1]+100)) and (y[0] < y[1]))

{
        arriba = y[1] - 30;
    velosalto= 19;
}


// si esta debajo de la parte de abajo de la primera plataforma
  if (  (y[0] > y[1]) and ((x[0] >= x[1] or x[0]+30 >= x[1])  and (x[0] <= x[1]+100 or x[0]+30 <= x[1]+100)))
  {

    salto = false;


  }

  // si toca la segunda plataforma
if ( ((x[0] >= x[2] or x[0]+30 >= x[2])  and (x[0] <= x[2]+100 or x[0]+30 <= x[2]+100)) and (y[0] < y[2]))
{
        arriba = y[2] - 30;
    velosalto= 20;
}

// si esta debajo de la parte de abajo de la SEGUNDA plataforma
  if ( (y[0] > y[2] )and ((x[0] >= x[2] or x[0]+30 >= x[2])  and (x[0] <= x[2]+100 or x[0]+30 <= x[2]+100)))
  {

 salto = false;

  }

 // si toca la tercera plataforma
if ( ((x[0] >= x[3] or x[0]+30 >= x[3])  and (x[0] <= x[3]+100 or x[0]+30 <= x[3]+100)) and (y[0] < y[3]))
{
        arriba = y[3] - 30;
    velosalto= 20.5;
}

// si esta debajo de la parte de abajo de la TERCERA plataforma
  if ( (y[0] > y[3] )and ((x[0] >= x[3] or x[0]+30 >= x[3])  and (x[0] <= x[3]+100 or x[0]+30 <= x[3]+100)))
  {

 salto = false;

  }

 // si toca la cuarta plataforma
if ( ((x[0] >= x[4] or x[0]+30 >= x[4])  and (x[0] <= x[4]+100 or x[0]+30 <= x[4]+100)) and (y[0] < y[4]))
{
        arriba = y[4] - 30;
    velosalto= 21;
}

// si esta debajo de la parte de abajo de la cuarta plataforma
  if ( (y[0] > y[4] )and ((x[0] >= x[4] or x[0]+30 >= x[4])  and (x[0] <= x[4]+100 or x[0]+30 <= x[4]+100)))
  {

 salto = false;

  }



}


int main()
{

    allegro_init();

    install_keyboard();
    set_color_depth(32);
BITMAP *buffer = create_bitmap(700,500);
    set_gfx_mode(GFX_AUTODETECT_WINDOWED,700,500,0,0);
    clear_to_color(buffer, 0xFFFFFF);

// pantalla


    while(!key[KEY_ESC])
    {

        //plataformas
        rectfill(buffer, x[4],y[4],x[4]+100,y[4]+25, 0x05009E);
        rectfill(buffer, x[3],y[3],x[3]+100,y[3]+25,0x05009E);
        rectfill(buffer, x[2],y[2],x[2]+100,y[2]+25, 0x05009E);
        rectfill(buffer, x[1],y[1],x[1]+100,y[1]+25, 0x05009E);

        //cuadro
        rectfill(buffer, x[0],y[0],x[0]+30 ,y[0]+30, 0x05009E);

        //pantalla
        blit (buffer,screen,0,0,0,0,700,700);
        clear_to_color(buffer,0xffffff);


plataformas();
movimientos();
rest(1);


    }

}
END_OF_MAIN()
