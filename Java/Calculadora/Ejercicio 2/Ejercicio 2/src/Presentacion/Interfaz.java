
package Presentacion;

import javax.swing.JOptionPane;
import Reglas.Operaciones;


 
 // @author leonardo
 
public class Interfaz {
    
    
    int n1, n2, numero;
    
    public void cargar(){
        
        
        n1=Integer.parseInt(JOptionPane.showInputDialog("Ingrese el Primer numero"));
        n2=Integer.parseInt(JOptionPane.showInputDialog("Ingrese el Segundo numero"));
        
        
    }
    
    
    public void menu(){
        
       
        
        Operaciones o=new Operaciones();
      
        
        
        
        do{
          
           numero=Integer.parseInt(JOptionPane.showInputDialog(" Que operacion desea realizar \n 1. Sumar \n 2. Restar \n 3. Multiplicar \n 4. Salir " ));
          
           
            switch (numero){
                
                case 1:
                    
                    cargar();
                    JOptionPane.showMessageDialog(null, "El resultado de la suma es " + o.getSumar(n1, n2));

                    break;
                    
                case 2:
                    
                    cargar();
                     if (n1<n2){
                         
                         JOptionPane.showMessageDialog(null, "La operacion da resultado negativo");
                         
                     }else{
                         if(n1>n2){
                             JOptionPane.showMessageDialog(null, "El resultado de la Resta es " + o.getRestar(n1, n2));
                         }
                     }// fin so
                    
                    break;
                    
                case 3:
                    
                    cargar();
                    JOptionPane.showMessageDialog(null, "El resultado de la Multiplicacion es " + o.getMultiplicar(n1, n2));

                    break;
                    
                case 4:
                    
                   
                    JOptionPane.showMessageDialog(null,  " Gracias por utilizarlo " );

                    break;
                    
            }// fin switch
               
        }while(numero!=4);
        
    }// fin menu
    
    public static void main (String [] args){
        
        Interfaz i=new Interfaz();
        
        i.menu();

    }// fin main 
    
    
}
