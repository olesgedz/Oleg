#include <string>
#include <cstring>
#include <vector>
#include <cstdlib>
#include <ctime>
#include <fstream>
#include <iostream>
#include <ncurses.h>
using namespace std;


// #ifdef WIN32 ///For the sleep()
// #include <windows.h>	//Sleep(miliseconds);
// #else
// #include <unistd.h>	//usleep(microseconds);
// #include <sys/types.h>
// #include <pwd.h>	//To get home directory
// #endif

#define WORLD_WIDTH 50
#define WORLD_HEIGHT 20
 
int main(int argc, char *argv[]) {
 
    WINDOW *snakeys_world;
    int offsetx, offsety;
 
    initscr();
    refresh();
 
    offsetx = (COLS - WORLD_WIDTH) / 2;
    offsety = (LINES - WORLD_HEIGHT) / 2;
 
    snakeys_world = newwin(WORLD_HEIGHT,
                           WORLD_WIDTH,
                           offsety,
                           offsetx);
 
    box(snakeys_world, 0 , 0);
 
    wrefresh(snakeys_world);
 
    getch();
 
    delwin(snakeys_world);
 
    endwin();
 
    return 0;
}

//https://rhardih.io/2010/04/using-ncurses-in-c-for-text-user-interfaces-featuring-xcode/
