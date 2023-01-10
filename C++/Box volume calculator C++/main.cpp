#include <iostream>
using namespace std;

class Caja {
public:
    int Volume() {return m_ancho * m_altura * m_largo;}
private:
    int m_ancho { 3 };
    int m_altura { 5 };
    int m_largo { 4 };
};

int main() {
    Caja Caja1; // Invoke compiler-generated constructor
    cout << "Caja1.Volume: " << Caja1.Volume() << endl; // Outputs 0
}
