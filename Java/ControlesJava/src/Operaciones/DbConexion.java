/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Operaciones;

import java.io.*;
import java.sql.*;
import java.util.*;
import javax.sql.DataSource;

/**
 *
 * @author hdueñas
 */
public class DbConexion {
protected Statement stm = null;
protected ResultSet rst = null;
protected ResultSet rst1 = null;
protected PreparedStatement pstm = null;
protected PreparedStatement psti = null;
protected Connection conn = null;
   
String IP = "172.16.221.152";
String puerto = "1521";
String nombreDB = "igeneral";
String usuario = "fiscal";
String password = "fiscal";


public void crearConexion() throws Exception {
    try {
         Class.forName("oracle.jdbc.driver.OracleDriver");
         conn = DriverManager.getConnection("jdbc:oracle:thin:@" + this.IP + ":" + this.puerto + ":" + this.nombreDB + "", "" + this.usuario + "", "" + this.password + "");
         System.out.println("Coneccion exitosa a la Base de datos ");
         
    } catch (Exception e) {
         System.out.println("Excepcion en la conexion" + e);
    }
}


public void cerrarConexion() throws SQLException {
        try {
            if (conn != null && !conn.isClosed()) { // if 1
                if (pstm != null) { // if 2
                    pstm.close();
                }
                if (rst != null) { // if 3
                    rst.close();
                }
                if (conn != null) { // if 4
                    conn.close();
                }
            }
        } catch (Exception e) {
            System.out.println("Excepcion en la cerrarConexion" + e);
        }
}
    
    
}
