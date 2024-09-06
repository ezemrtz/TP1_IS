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

    [Fact]
    public void ActualizarPrecioProducto_ActualizadoCorrectamente(){
        string nombre = "Monitor";
        double precio = 10000;
        string categoria = "Tecnologia";

        Producto producto = new Producto(nombre, precio, categoria);
        double nuevoPrecio = 5000;
        producto.actualizar_precio(nuevoPrecio);

        Assert.Equal(nuevoPrecio, producto.Precio);
    }

    [Fact]
    public void ActualizarPrecioProducto_PrecioNegativo_LanzaExcepcion(){
        string nombre = "Monitor";
        double precio = 10000;
        string categoria = "Tecnologia";

        Producto producto = new Producto(nombre, precio, categoria);
        double nuevoPrecio = -5000;
    
        var excepcion = Assert.Throws<Exception>(() => producto.actualizar_precio(nuevoPrecio));
        Assert.Equal("Precio negativo", excepcion.Message);
    }
}