package mvc3nraya;

import vista.interfaz;
import controlador.controlador;
import modelo.juego;
/**
 * 
 */
public class Main {

    public static void main(String[] args) {
         //nuevas instancias de clase
        juego modelo = new juego();
        interfaz vista = new interfaz();
        controlador controlador = new controlador( vista , modelo );
        controlador.iniciar_vista();
        vista.setVisible(true);
    }

}
