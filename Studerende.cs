
namespace ProgramMedStudent
{

public class Studerende{

// Atributter
string _navn;
int _alder;
int _karakter;

// properties
public string Navn {
    get {return _navn;}
    set {_navn = value;}
}

public int Alder{
    get {return _alder;}
    set{_alder = value;}
}

public int Karakter{
    get{return _karakter;}
    set{ _karakter = value;}
}


// constructor
// når new benyttes - til at tildele ny værdier til objektet
public Studerende(string navn, int alder, int karakter){
    _navn = navn;
    _alder = alder;
    _karakter = karakter;
}

public Studerende(){
    _navn = "";
    _alder = 0;
    _karakter = -3;
}



}
}