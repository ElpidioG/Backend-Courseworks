#include <iostream>
#include <allegro.h>


int monto = 100;
using namespace std;

int main()
{
        allegro_init();
        install_keyboard();
        set_color_depth(32);
        set_gfx_mode(GFX_AUTODETECT_WINDOWED, 600,400,0,0);

        BITMAP *buffer = create_bitmap(600,400);
        clear_to_color(buffer, 0xffffff);

        textout(buffer, font, "mi primer texto en allegro", 80, 100, 0x0000ff);


        textout_centre_ex(buffer, font, "segundo texto en allegro", 110, 130, 0x00ff00, 0xffffff);
       blit(buffer, screen, 0, 0, 0, 0, 600, 400);
       while(!key[KEY_ESC])
       {

        textprintf_ex(screen, font,150,180, makecol(110,0,0), -1, "Total: %d", monto);
        textprintf_ex(screen, font,350,200, 0x00ff00, -1, "Total: %d", monto);
rest(10000);
        blit(buffer, screen, 0, 0, 0, 0, 600, 400);
       }


        readkey();

}
END_OF_MAIN()



