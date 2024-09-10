using Moq;

namespace Clases;

public class TiendaFixture : IDisposable {
    private Tienda tienda;

    public Tienda Tienda { get => tienda; set => tienda = value; }

    public TiendaFixture(){
        tienda = new();
        tienda.agregar_producto(new Producto("Manzana", 1000, "Fruta"));
        tienda.agregar_producto(new Producto("Martillo", 5000, "Herramienta"));
        tienda.agregar_producto(new Producto("Leche", 500, "Lacteo"));
        tienda.agregar_producto(new Producto("Naranja", 400, "Fruta"));
        tienda.agregar_producto(new Producto("Kiwi", 700, "Fruta"));
        tienda.agregar_producto(new Producto("Destornillador", 2000, "Herramienta"));
        tienda.agregar_producto(new Producto("Frutilla", 800, "Fruta"));

    }

    public void Dispose(){
        tienda = null;
    }
}