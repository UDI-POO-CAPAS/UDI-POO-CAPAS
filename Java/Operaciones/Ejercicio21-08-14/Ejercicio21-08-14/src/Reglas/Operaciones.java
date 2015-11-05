

package Reglas;
 //@author usuario

public class Operaciones {
    
    int Numero1, Numero2;
    
    public Operaciones(){
        
        Numero1=0;
        Numero2=0;
        
    }// fin constructor
    
    
    public int getNumero1(){
        
        return Numero1;
        
    }// fin getnumero 1
    
    public int getNumero2(){
        
        return Numero2;
        
    }// fin get numero2
    
    
    public void setNumero1(int pNumero1){
        
         Numero1=pNumero1;
        
        
    }// fin set numero1
    
    
    public void setNumero2(int pNumero2){
        
        Numero2=pNumero2;
        
        
    }// fin set numero 2
    
    
    public int getSumar(){
        
        int suma=Numero1+Numero2;
        
        return suma;
        
    }// fin get complejo sumar
    
    
    public int getRestar(){
        
        int resta=Numero1-Numero2;
        
        return resta;
        
    }// fin get complejo resta
    
    
    public int getMultiplicar(){
        
        int mul=Numero1*Numero2;
        
        return mul;
        
    }// fin get complejo multiplicar
      
}// fin clase operaciones
