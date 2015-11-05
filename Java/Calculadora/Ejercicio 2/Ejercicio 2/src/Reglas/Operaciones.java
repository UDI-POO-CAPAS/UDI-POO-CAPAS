
package Reglas;
  //@author leonardo

import javax.swing.JOptionPane;
 
public class Operaciones {
    
    int x=0;
    int y=0;
    
    public int  getSumar(int x, int y){
        
        int suma=0;
        
        suma=x+y;
        
        return suma;
   
    }// fin suma
    
    public int getRestar(int x, int y){
        
        int resta=x-y;
        
        return resta;
        
    }// fin resta
    
    
    public int getMultiplicar(int x, int y){
        
        
        int mul=x*y;
        
        return mul;
 
    }// fin multiplicar
    
    
    
}
