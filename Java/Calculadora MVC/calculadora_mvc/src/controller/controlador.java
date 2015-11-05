package controller;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import model.modelo;
import view.vista_2;

public class controlador implements ActionListener{

    private vista_2 vista;
    private modelo modelo;

    //En el constructor inicializamos nuestros objetos y tambien
    //añadimos el ActionListener al boton "cmdsumar" de la VISTA
    public controlador( vista_2 vista , modelo modelo){
        this.vista = vista;
        this.modelo = modelo;
        this.vista.cmdsumar.addActionListener(this);
    }

    //Inicia los valores del jFrame VISTA con los datos del MODELO
    public void iniciar_vista(){
        vista.setTitle( "Ejemplo MVC * Calculadora Sencilla" );
        vista.setLocationRelativeTo(null);
        vista.vtxt1.setText( "" );
        vista.vtxt2.setText( "" );
        vista.vtxt3.setText( String.valueOf(modelo.get_total()) );
    }

    //La accion del boton de la VISTA es capturado, asi como los valores de
    //los jtextbox, entonces se realiza la funcion SUMAR y se actualiza
    //el jtextbox correspondiente al resultado
    public void actionPerformed(ActionEvent e) {
        modelo.set_valor1( Integer.valueOf( vista.vtxt1.getText() ) );
        modelo.set_valor2( Integer.valueOf( vista.vtxt2.getText() ) );
        modelo.sumar();
        vista.vtxt3.setText( String.valueOf(modelo.get_total()) );
    }

}
