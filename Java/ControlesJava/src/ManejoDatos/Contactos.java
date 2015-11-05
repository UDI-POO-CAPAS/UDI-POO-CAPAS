/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ManejoDatos;


import java.sql.ResultSet;
import java.sql.SQLException;
/**
 *
 * @author hdueñas
 */
public class Contactos {
    
 private long idRemitente;
 
 private String  nombRemitente;
 
 private String  nombDestinatario;

 private String  mailDestinatario;
 
 private String  asunto;
 
 private String  cuerpoMensaje;
 
 public Contactos(){
 
 }
 
 
 public Contactos(ResultSet rs) throws SQLException, ClassNotFoundException {
       
     try {
            idRemitente = rs.getLong("ID_REMITENTE");
        } catch (SQLException error) {
            idRemitente = 0;
        }
        
        try {
            nombRemitente = rs.getString("NOMB_REMITENTE");
        } catch (SQLException error) {
            nombRemitente = "";
        }
        
        try {
            nombDestinatario = rs.getString("NOMB_DESTINATARIO");
        } catch (SQLException error) {
            nombDestinatario = "";
        }
        
        try {
            mailDestinatario = rs.getString("MAIL_DESTINATARIO");
        } catch (SQLException error) {
            mailDestinatario = "";
        }
        
        try {
            asunto = rs.getString("ASUNTO");
        } catch (SQLException error) {
            asunto = "";
        }
        
        try {
            cuerpoMensaje = rs.getString("CUERPO_MENSAJE");
        } catch (SQLException error) {
            cuerpoMensaje = "";
        }
 
 }
 public long getIdRemitente() {
        return idRemitente;
 }
    
    public String getNombProducto() {
        return nombRemitente;
    }
    
    public String getCodiPrd() {
        return nombRemitente;
    }
    
    public String getTablaPuenteTmp() {
        return nombRemitente != null ? nombRemitente : "";
    }
         
    
}
