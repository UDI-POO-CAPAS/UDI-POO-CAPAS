

package Presentacion;

/**
 *
 * @author usuario
 */

import Reglas.Operaciones;
import javax.swing.JOptionPane;

public class Main {

  
    public static void main(String[] args) {
        
           Interfaz i= new Interfaz();
           Operaciones op= new Operaciones();
            
       op=i.Capturar();
       i.Presentar(op);
       
        
    }
    
}
