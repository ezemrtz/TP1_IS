namespace TP1;
using Clases;
using Moq;
public class TiendaTest : IClassFixture<TiendaFixture>
{
    private TiendaFixture fixture;

    public TiendaTest(TiendaFixture fixture){
        this.fixture = fixture;
    }

    [Fact]
    public void AgregarProducto_AgregadoCorrectamente()
    {
        
        fixture.Tienda.agregar_producto(new Producto("Queso", 1000, "Lacteo"));
        var productoEncontrado = fixture.Tienda.buscar_producto("Queso");
        
        Assert.NotNull(productoEncontrado);  
    }

    [Fact]
    public void BuscarProducto_EncuentraProductoCorrecto()
    {
        var productoEncontrado = fixture.Tienda.buscar_producto("Manzana");
        
        Assert.NotNull(productoEncontrado);
        Assert.Equal("Manzana", productoEncontrado.Nombre);
        Assert.Equal(1000, productoEncontrado.Precio);
        Assert.Equal("Fruta", productoEncontrado.Categoria);
    }

    [Fact]
    public void BuscarProducto_NoEncuentraProducto_LanzaExcepcion()
    {
        string nombreBuscar = "Pera";

        Assert.Throws<Exception>(() => fixture.Tienda.buscar_producto(nombreBuscar));
    
    }

    [Fact]
    public void EliminarProducto_EliminaProductoCorrecto()
    {
        string nombre = "Manzana";
        
        var eliminado = fixture.Tienda.eliminar_producto(nombre);
        
        Assert.True(eliminado);

    }

    [Fact]
    public void EliminarProducto_NoElimina_LanzaExcepcion()
    {
        string nombreBuscar = "Pera";

        Assert.Throws<Exception>(() => fixture.Tienda.eliminar_producto(nombreBuscar));
    
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

    [Fact]
    public void CalcularTotalCarrito_FlujoCompleto_RetornaValorCorrecto(){

        List<string> carrito = new();

        fixture.Tienda.agregar_producto(new("Puerta", 6000, "Mueble"));
        carrito.Add(fixture.Tienda.buscar_producto("Manzana").Nombre);
        carrito.Add(fixture.Tienda.buscar_producto("Martillo").Nombre);
        carrito.Add(fixture.Tienda.buscar_producto("Kiwi").Nombre);

        fixture.Tienda.eliminar_producto("Puerta");
        fixture.Tienda.aplicar_descuento("Manzana", 20);
        var total = fixture.Tienda.calcular_total_carrito(carrito);
        
        Assert.Equal(6500, total);
        
    }
}