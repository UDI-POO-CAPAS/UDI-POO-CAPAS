package jc_mvc_demo;

import controller.controlador;
import model.modelo;
import view.vista_2;

public class Main {
    
    public static void main(String[] args) {

        //nuevas instancias de clase
        modelo modelo = new modelo();
        vista_2 vista = new vista_2();        
        controlador controlador = new controlador(vista , modelo );
        //se inicia la vista
        controlador.iniciar_vista();

        vista.setVisible(true);

    }

}
