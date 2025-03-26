using MongoDB.Bson.Serialization.Attributes;

public class PersonajeMongo {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id { get; set; }

    public int? id_experimento { get; set; }
    public string nombre { get; set; } = "";
    public string cientifico { get; set; }
    public int? peligro { get; set; }
    public string? eguridad { get; set; }
    public string rol { get; set; } = "";
    public string genero { get; set; } = "";
    public int? edad { get; set; }
    public string descripcion { get; set; } = "";
    public string estado { get; set; } = "";
    public int? armadura { get; set; }
    public int salud { get; set; }
    public decimal? velocidad { get; set; }
    public int? daño { get; set; }
    public bool jefe { get; set; }
    public bool? es_volador { get; set; }
    public bool? volador { get; set; }
    public bool agresivo { get; set; }
    public string fecha { get; set; }
    public bool exitoso { get; set; }
    public decimal costo { get; set; }
    public bool hacking { get; set; }
    public bool aliado { get; set; }
    public string? aparicion { get; set; }
    public string? paradero { get; set; }
    public string? trabajo { get; set; }
    public string? apariciones { get; set; }
    public string? habilidades { get; set; }
    public decimal riesgo { get; set; }
    public int? seguridad { get; set; }
}
