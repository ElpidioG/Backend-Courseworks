#include < iostream.h >
using namespace std;

class cubo {
public:
    int Volume() {return m_ancho * m_altura * m_largo;}
private:
    int m_ancho { 3 };
    int m_altura { 5 };
    int m_largo { 4 };
};

int main() {
    cubo cubo1; // Invoke compiler-generated constructor
    cout << "Cubo1.Volume: " << cubo1.Volume() << endl; // Outputs 0
}
