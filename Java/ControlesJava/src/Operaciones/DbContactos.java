/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Operaciones;


import ManejoDatos.Contactos;
import java.sql.CallableStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Types;
import java.util.ArrayList;
import oracle.jdbc.OracleTypes;
/**
 *
 * @author hdueñas
 */
public class DbContactos extends DbConexion{
    
     // Consulta SQL
   public ArrayList<Contactos> getListaContactos() throws Exception {
       
        try {
            String sql =
                        "SELECT * " +
                        "FROM fiscal.tmp_personas_correo " +
                        "ORDER BY id_remitente ";
                        
            ArrayList<Contactos> listaProductos = new ArrayList<Contactos>();
            crearConexion();
            pstm = conn.prepareStatement(sql);
            rst = pstm.executeQuery();
            while (rst.next()) {
                Contactos productoAux = new Contactos(rst);
                listaProductos.add(productoAux);
            }
            rst.close();
            if (listaProductos.size() > 0) {
                return listaProductos;
            } else {
                return null;
            }
            
        } catch (Exception e) {
            System.out.println("Excepcion al consultar productos por estado " + e);
            return null;
        } finally {
            cerrarConexion();
        }
   }
   
   
   // Consulta SQL
   public boolean insertProducto(String NombProducto, String codiProducto, byte prdActivo) throws Exception {
        int idProducto = 0;
        String lsSql = "";
        try {
            crearConexion();
            lsSql =
                "SELECT MAX(ID_PRODUCTO) + 1 AS ID_PRODUCTO " +
                "FROM admoncontrol.productos";
            pstm = conn.prepareStatement(lsSql);
            rst = pstm.executeQuery();
            if (rst.next()) {
                idProducto = rst.getInt("ID_PRODUCTO");
            }
            if (idProducto == 0) {
                idProducto = 1;
            }
            rst.close();
            System.out.println("Excepcion al insertar el producto " + idProducto);
            String sql =
                        "INSERT INTO admoncontrol.productos " +
                        "(id_producto, nomb_producto, codi_prd, prd_activo) " +
                        "VALUES(" + idProducto + ",'" + NombProducto + "', '" + codiProducto + "', " + prdActivo + ")";
                        
            crearConexion();
            pstm = conn.prepareStatement(sql);
            if (pstm.executeUpdate() > 0) {
                return true;
            } else {
                return false;
            }
        } catch (Exception e) {
            System.out.println("Excepcion al insertar el producto " + e);
            return false;
        } finally {
            cerrarConexion();
        }
   }
    
}
