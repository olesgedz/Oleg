#include <iostream>
using namespace std;
class Vagon{

    bool seats[6];
    int number;
    bool empty;
  
    public:
      Vagon(){
        
        };
       void fill_seat(int n)
        {
            seats[n] = true;
        }
        void empty_seat(int n)
        {
            seats[n] = false;
        }
        void print_vagon()
        {
           for(int i = 0; i < 6; i++)
            cout << "seat: " << i+1 << " " << (seats[i] == true ? "busy" : "empty") << endl;  
        }
        void fill()
        {
            for (int i = 0; i < 6; i++)
                seats[i] = true;
        }
        bool check_if_empty()
        {
            for(int i = 0; i < 6; i++)
            {
                if(seats[i] == true)
                   return empty = false;
            }
            return empty = true;
        }
};
class Train {
    Vagon vagons[9];
    public:
         Train(){
             fill_everything();
         };
    void  fill_everything()
    {
        for(int i = 0; i < 9; i++)
        {
            vagons[i].fill();
        }
    }
    void print_train()
    {
        for(int i = 0; i < 9; i++)
        {
           cout << "Vagon" << " " << i + 1 << endl;
            vagons[i].print_vagon();
        }
    }
    void empty_seats(int n)
    {
        int vagon = n % 4 == 0 ? n / 4 - 1 : n / 4;
        if (n < 37)
        { 
            //if (n % 2 == 0)
                n -=1;
            vagons[vagon].empty_seat(n - vagon * 4);
        }else
        {
            vagons[((54 - n) / 2)].empty_seat( 4 + n%2);
        }
        
    }

    void find_empty_vagons()
    {
        for(int i = 0; i < 9; i++)
        {
           if ( vagons[i].check_if_empty())
            cout << "Vagon "<< i+1<< " is empty"<<endl;
        }
    }
};
int main()
{
    Train train = Train();
    //train.print_train();
    int n;

    cin >> n;
    int seat;
    for (int i = 0; i < n; i++)
    {
        cin >> seat;
        train.empty_seats(seat);
    }
    cout << endl;
    train.print_train();

    train.find_empty_vagons();
}