using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("conexion")]
public class Conexion : Controller {
    
    [HttpGet("mongo")]
    public IActionResult ListarSalonesMongoDb(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("practica1_Clemente_Santiago");
        var collection = db.GetCollection<PersonajeMongo>("aliados y enemigos de half life y experimentos de black mesa");

        var lista = collection.Find(FilterDefinition<PersonajeMongo>.Empty).ToList();

        return Ok(lista);
    }
}
