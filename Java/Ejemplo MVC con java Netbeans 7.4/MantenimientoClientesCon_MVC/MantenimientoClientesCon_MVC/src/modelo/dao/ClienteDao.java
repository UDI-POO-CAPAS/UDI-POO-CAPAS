package modelo.dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import javax.swing.JOptionPane;
import modelo.conexion.Conexion;

import modelo.vo.ClienteVo;




/**
 * Clase que permite el acceso a la base de datos
 * @author chenao
 *
 */
public class ClienteDao
{

	public void registrarCliente(ClienteVo miCliente)
	{
		Conexion conex= new Conexion();
		
		try {
			Statement estatuto = conex.getConnection().createStatement();
			estatuto.executeUpdate("INSERT INTO cliente VALUES ('"+miCliente.getIdCliente()+"', '"
					+miCliente.getNombreCliente()+"', '"+miCliente.getEdadCliente()+"', '"
					+miCliente.getProfesionCliente()+"', '"+miCliente.getTelefonoCliente()+"')");
			JOptionPane.showMessageDialog(null, "Se ha registrado Exitosamente","Informacion",JOptionPane.INFORMATION_MESSAGE);
			estatuto.close();
			conex.desconectar();
			
		} catch (SQLException e) {
            System.out.println(e.getMessage());
			JOptionPane.showMessageDialog(null, "No se Registro");
		}
	}

	public ClienteVo buscarCliente(int codigo) 
	{
		Conexion conex= new Conexion();
		ClienteVo cliente= new ClienteVo();
		boolean existe=false;
		try {
			//Statement estatuto = conex.getConnection().createStatement();
			PreparedStatement consulta = conex.getConnection().prepareStatement("SELECT * FROM cliente where id = ? ");
			consulta.setInt(1, codigo);
			ResultSet res = consulta.executeQuery();
			while(res.next()){
				existe=true;
				cliente.setIdCliente(Integer.parseInt(res.getString("id")));
				cliente.setNombreCliente(res.getString("nombre"));
				cliente.setEdadCliente(Integer.parseInt(res.getString("edad")));
				cliente.setProfesionCliente(res.getString("profesion"));
				cliente.setTelefonoCliente(Integer.parseInt(res.getString("telefono")));
			 }
			res.close();
			conex.desconectar();
					
					
			} catch (SQLException e) {
					JOptionPane.showMessageDialog(null, "Error, no se conecto");
					System.out.println(e);
			}
		
			if (existe) {
				return cliente;
			}
			else return null;				
	}

	public void modificarCliente(ClienteVo miCliente) {
		
		Conexion conex= new Conexion();
		try{
			String consulta="UPDATE cliente SET id= ? ,nombre = ? , edad=? , profesion=? , telefono= ? WHERE id= ? ";
			PreparedStatement estatuto = conex.getConnection().prepareStatement(consulta);
			
            estatuto.setInt(1, miCliente.getIdCliente());
            estatuto.setString(2, miCliente.getNombreCliente());
            estatuto.setInt(3, miCliente.getEdadCliente());
            estatuto.setString(4, miCliente.getProfesionCliente());
            estatuto.setInt(5,miCliente.getTelefonoCliente());
            estatuto.setInt(6, miCliente.getIdCliente());
            estatuto.executeUpdate();

          JOptionPane.showMessageDialog(null, " Se ha Modificado Correctamente ","Confirmacion",JOptionPane.INFORMATION_MESSAGE);
         

        }catch(SQLException	 e){

            System.out.println(e);
            JOptionPane.showMessageDialog(null, "Error al Modificar","Error",JOptionPane.ERROR_MESSAGE);

        }
	}

	public void eliminarCliente(String codigo)
	{
		Conexion conex= new Conexion();
		try {
			Statement estatuto = conex.getConnection().createStatement();
			estatuto.executeUpdate("DELETE FROM cliente WHERE id='"+codigo+"'");
            JOptionPane.showMessageDialog(null, " Se ha Eliminado Correctamente","Informacion",JOptionPane.INFORMATION_MESSAGE);
			estatuto.close();
			conex.desconectar();
			
		} catch (SQLException e) {
            System.out.println(e.getMessage());
			JOptionPane.showMessageDialog(null, "No se Elimino");
		}
	}

}
