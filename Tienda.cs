namespace Clases;

public class Tienda{
    private List<Producto> inventario;
    public Tienda (){
        this.inventario = new List<Producto>();
    }
    public void agregar_producto(Producto producto){
        this.inventario.Add(producto);
    }
    public Producto buscar_producto(string nombre){
        foreach (var producto in this.inventario)
        {
            if(producto.Nombre == nombre) return producto;
        }
        return null;
    }
    public bool eliminar_producto(string nombre){
        foreach (var producto in this.inventario)
        {
            if(producto.Nombre == nombre){
                this.inventario.Remove(producto);
                return true;
            }
        }
        return false;
    }
}