using MongoDB.Bson.Serialization.Attributes;

public class PersonajeMongo {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

    public string? Id { get; set; }
    public string? Id_experimento { get; set; }
    public string Nombre { get; set; }
    public bool Nombre_enemigo { get; set; }
    public bool cientifico_principal { get; set; }
    public string? nivel_peligro { get; set; }
    public string Rol { get; set; }
    public string Genero { get; set; }
    public int? Edad { get; set; }
    public decimal descripcion { get; set; }
    public string estado { get; set; }
    public bool armadura { get; set; }
    public bool salud { get; set; }
    public bool velocidad { get; set; }
    public bool daño { get; set; }
    public bool es_jefe { get; set; }
    public bool es_volador { get; set; }
    public bool agresivo { get; set; }
    public bool fecha_realizacion { get; set; }
    public bool exitoso { get; set; }
    public bool costo { get; set; }
    
}
