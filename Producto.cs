namespace Clases;

public class Producto{
    private string nombre;
    private double precio;
    private string categoria;

    public Producto(string nombre, double precio, string categoria)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.categoria = categoria;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public double Precio { get => precio; set => precio = value; }
    public string Categoria { get => categoria; set => categoria = value; }

    public void actualizar_precio(double nuevoPrecio){
        if (nuevoPrecio < 0) throw new Exception("Precio negativo");
        this.precio = nuevoPrecio;
    }
}