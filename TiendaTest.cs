namespace TP1;
using Clases;
public class TiendaTest
{
    [Fact]
    public void AgregarProducto_AgregadoCorrectamente()
    {
        string nombre = "Manzana";
        double precio = 500;
        string categoria = "Fruta";
        Producto producto = new Producto(nombre, precio, categoria);

        Tienda tienda = new Tienda();
        tienda.agregar_producto(producto);

        var productoEncontrado = tienda.buscar_producto(nombre);
        
        Assert.NotNull(productoEncontrado);  
    }

    [Fact]
    public void BuscarProducto_EncuentraProductoCorrecto()
    {
        string nombre = "Manzana";
        double precio = 500;
        string categoria = "Fruta";
        Producto producto = new Producto(nombre, precio, categoria);

        Tienda tienda = new Tienda();
        tienda.agregar_producto(producto);

        var productoEncontrado = tienda.buscar_producto(nombre);
        
        Assert.NotNull(productoEncontrado);
        Assert.Equal(producto.Nombre, productoEncontrado.Nombre);
        Assert.Equal(producto.Precio, productoEncontrado.Precio);
        Assert.Equal(producto.Categoria, productoEncontrado.Categoria);
    }

    [Fact]
    public void BuscarProducto_NoEncuentraProducto_LanzaExcepcion()
    {
        string nombre = "Manzana";
        double precio = 500;
        string categoria = "Fruta";
        Producto producto = new Producto(nombre, precio, categoria);

        Tienda tienda = new Tienda();
        tienda.agregar_producto(producto);

        string nombreBuscar = "Pera";

        Assert.Throws<Exception>(() => tienda.buscar_producto(nombreBuscar));
    
    }

    [Fact]
    public void EliminarProducto_EliminaProductoCorrecto()
    {
        string nombre = "Manzana";
        double precio = 500;
        string categoria = "Fruta";
        Producto producto = new Producto(nombre, precio, categoria);

        Tienda tienda = new Tienda();
        tienda.agregar_producto(producto);

        var eliminado = tienda.eliminar_producto(nombre);
        // var productoEncontrado = tienda.buscar_producto(nombre);
        
        Assert.True(eliminado);
        // Assert.Null(productoEncontrado);

    }

    [Fact]
    public void EliminarProducto_NoElimina_LanzaExcepcion()
    {
        string nombre = "Manzana";
        double precio = 500;
        string categoria = "Fruta";
        Producto producto = new Producto(nombre, precio, categoria);

        Tienda tienda = new Tienda();
        tienda.agregar_producto(producto);

        string nombreBuscar = "Pera";
        Assert.Throws<Exception>(() => tienda.eliminar_producto(nombreBuscar));
    
    }

}