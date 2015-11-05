
package Presentacion;

import Reglas.Operaciones;
import javax.swing.JOptionPane;

public class Interfaz {
    
  
    public Interfaz(){
        
        
    }// fin constructor
    
    
    
    public Operaciones Capturar(){
        
          Operaciones rOperaciones=new Operaciones();
        
        rOperaciones.setNumero1(Integer.parseInt(JOptionPane.showInputDialog("ingrese el primer valor")));
        rOperaciones.setNumero2(Integer.parseInt(JOptionPane.showInputDialog("ingrese el segundo valor")));
        
        return rOperaciones;// retorna el objeto 
        
    }// fin capturar
    
    
   
    public void Presentar(Operaciones pOperaciones){
        
        // int numero=0;
        
        JOptionPane.showMessageDialog(null, "El Primer numero es = " + pOperaciones.getNumero1() + "\n" +
                                            "El segundo numero es = " + pOperaciones.getNumero2() + "\n" +
                                            "El Resultado de la Suma es = " + pOperaciones.getSumar() + "\n" +
                                            "El Resultado de la Resta es = " + pOperaciones.getRestar() + "\n" +
                                            "El resultado de la Multiplicacion es = " + pOperaciones.getMultiplicar()); 
        
    }// fin presentar
         
}// fin interfaz


// String texto final;

//textofinal = "el atributo es 1 = " + poperaciones.getAtributo1()+ "\n";

// JOptionPane.showMessageDialog(null, textofinal);


 