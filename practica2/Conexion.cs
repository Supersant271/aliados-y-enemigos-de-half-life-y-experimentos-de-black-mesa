using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("conexion")]
public class Conexion : Controller {
    
    [HttpGet("mongo")]
    public IActionResult ListarSalonesMongoDb(){
        return Ok("Me estoy conectando a MongoDB");
    }
}
