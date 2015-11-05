package modelo;

import javax.swing.JOptionPane;

import modelo.dao.ClienteDao;
import modelo.vo.ClienteVo;
import controlador.Coordinador;

public class Logica {
	
	private Coordinador miCoordinador;
	public static boolean consultaCliente=false;
	public static boolean modificaCliente=false;
	
	public void setCoordinador(Coordinador miCoordinador) {
		this.miCoordinador=miCoordinador;
		
	}

	public void validarRegistro(ClienteVo miCliente) {
		ClienteDao miClienteDao;
		if (miCliente.getIdCliente() > 99) {
			miClienteDao = new ClienteDao();
			miClienteDao.registrarCliente(miCliente);						
		}else {
			JOptionPane.showMessageDialog(null,"El documento del cliente debe ser mas de 3 digitos","Advertencia",JOptionPane.WARNING_MESSAGE);
			
		}
		
	}

	public ClienteVo validarConsulta(String codigoCliente) {
		ClienteDao miClienteDao;
		
		try {
			int codigo=Integer.parseInt(codigoCliente);	
			if (codigo > 99) {
				miClienteDao = new ClienteDao();
				consultaCliente=true;
				return miClienteDao.buscarCliente(codigo);						
			}else{
				JOptionPane.showMessageDialog(null,"El documento del cliente debe ser mas de 3 digitos","Advertencia",JOptionPane.WARNING_MESSAGE);
				consultaCliente=false;
			}
			
		}catch (NumberFormatException e) {
			JOptionPane.showMessageDialog(null,"Debe ingresar un dato numerico","Error",JOptionPane.ERROR_MESSAGE);
			consultaCliente=false;
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null,"Se ha presentado un Error","Error",JOptionPane.ERROR_MESSAGE);
			consultaCliente=false;
		}
					
		return null;
	}

	public void validarModificacion(ClienteVo miCliente) {
		ClienteDao miClienteDao;
		if (miCliente.getNombreCliente().length()>5) {
			miClienteDao = new ClienteDao();
			miClienteDao.modificarCliente(miCliente);	
			modificaCliente=true;
		}else{
			JOptionPane.showMessageDialog(null,"El nombre del cliente debe ser mayor a 5 digitos","Advertencia",JOptionPane.WARNING_MESSAGE);
			modificaCliente=false;
		}
	}

	public void validarEliminacion(String codigo) {
		ClienteDao miClienteDao=new ClienteDao();
		miClienteDao.eliminarCliente(codigo);
	}



}
