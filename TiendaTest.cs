namespace TP1;
using Clases;
using Moq;
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
        
        Assert.True(eliminado);

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

    [Fact]
    public void AplicarDescuento_CalculaCorrectamenteDescuento()
    {
        string nombreProducto = "Manzana";
        double precioProducto = 1000;
        string categoria = "Fruta";
        int porcentajeDescuento = 10;
        var mockProducto = new Mock<Producto>(nombreProducto, precioProducto, categoria); // Creo el mock de producto
        var tienda = new Tienda();

        tienda.agregar_producto(mockProducto.Object); // Agrego el producto simulado en la tienda
        tienda.aplicar_descuento(nombreProducto, porcentajeDescuento);

        mockProducto.Verify(p => p.actualizar_precio(900), Times.Once); // Verifico que el metodo actualizar_precio fue llamado con el argumento correcto (precio con descuento aplicado) una sola vez
    }
}