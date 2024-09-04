namespace TP1;
using Clases;
public class ProductoTest
{
    [Fact]
    public void CrearProducto_InicializadoCorrectamente()
    {
        string nombre = "Monitor";
        double precio = 10000;
        string categoria = "Tecnologia";

        Producto producto = new Producto(nombre, precio, categoria);

        Assert.NotNull(producto);
        Assert.Equal(nombre, producto.Nombre);
        Assert.Equal(precio, producto.Precio);
        Assert.Equal(categoria, producto.Categoria);
    }
}