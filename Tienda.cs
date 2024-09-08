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
        throw new Exception("Producto no encontrado");

    }
    public bool eliminar_producto(string nombre){
        foreach (var producto in this.inventario)
        {
            if(producto.Nombre == nombre){
                this.inventario.Remove(producto);
                return true;
            }
        }
        throw new Exception("No se elimino el producto");
    }

    public void aplicar_descuento(string nombre, int descuento){
        Producto producto = buscar_producto(nombre);
        if (descuento < 0 || descuento > 100) throw new Exception("Porcentaje invalido");
        producto.actualizar_precio(producto.Precio - producto.Precio * descuento / 100);
    }
}