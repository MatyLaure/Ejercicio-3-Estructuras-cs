Cliente cliente = new Cliente("Matias Garcia", 42588896, "San carlos 548", "garcialaurematias93@gmail.com", true);
Console.WriteLine(cliente);

public struct Cliente { 
    public Cliente(string nombreCompleto, int telefono, string direccion, string email, bool esNuevoCliente)
    {
    Nombre = nombreCompleto;
    Telefono = telefono;
    Direccion = direccion;
    Email = email;
    ClienteNuevo = esNuevoCliente;
    }
    public string Nombre { get; }
    public int Telefono { get; }
    public string Direccion { get; }
    public string Email { get; }
    public bool ClienteNuevo { get; }

    public override string ToString() => $"({Nombre}, {Telefono}, {Direccion}, {Email}, {ClienteNuevo})";


}