using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgil.API.Model;


namespace ProAgil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[] {
                new Evento(){
                    EventoId= 1,
                    Tema = "Angular e .NET Core",
                    Local = "Belo Horizonte",
                    Lote ="1º Lote",
                    QtdPessoas = 200,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    Imagem = "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwi0qeKB1Y_kAhUEK7kGHcq-CQ4QjRx6BAgBEAQ&url=%2Furl%3Fsa%3Di%26source%3Dimages%26cd%3D%26ved%3D%26url%3Dhttps%253A%252F%252Fdocs.microsoft.com%252Fpt-br%252Fdotnet%252F%26psig%3DAOvVaw3CBMAUwlKEtPZScT3p7xA5%26ust%3D1566329168970222&psig=AOvVaw3CBMAUwlKEtPZScT3p7xA5&ust=1566329168970222"

                },
                new Evento(){
                    EventoId= 2,
                    Tema = "Angular e suas novidades",
                    Local = "São Paulo",
                    Lote ="3º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    Imagem = "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwjA8Mav1Y_kAhWbGLkGHeYbCdEQjRx6BAgBEAQ&url=%2Furl%3Fsa%3Di%26source%3Dimages%26cd%3D%26ved%3D%26url%3Dhttps%253A%252F%252Fpt.wikipedia.org%252Fwiki%252FAngular_(framework)%26psig%3DAOvVaw1sFAdC9EY98WCwYs0CwgxT%26ust%3D1566329266324494&psig=AOvVaw1sFAdC9EY98WCwYs0CwgxT&ust=1566329266324494"
                }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return new Evento[] {
                new Evento(){
                    EventoId= 1,
                    Tema = "Angular e .NET Core",
                    Local = "Belo Horizonte",
                    Lote ="1º Lote",
                    QtdPessoas = 200,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    Imagem = "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwi0qeKB1Y_kAhUEK7kGHcq-CQ4QjRx6BAgBEAQ&url=%2Furl%3Fsa%3Di%26source%3Dimages%26cd%3D%26ved%3D%26url%3Dhttps%253A%252F%252Fdocs.microsoft.com%252Fpt-br%252Fdotnet%252F%26psig%3DAOvVaw3CBMAUwlKEtPZScT3p7xA5%26ust%3D1566329168970222&psig=AOvVaw3CBMAUwlKEtPZScT3p7xA5&ust=1566329168970222"

                },
                new Evento(){
                    EventoId= 2,
                    Tema = "Angular e suas novidades",
                    Local = "São Paulo",
                    Lote ="3º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    Imagem = "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwjA8Mav1Y_kAhWbGLkGHeYbCdEQjRx6BAgBEAQ&url=%2Furl%3Fsa%3Di%26source%3Dimages%26cd%3D%26ved%3D%26url%3Dhttps%253A%252F%252Fpt.wikipedia.org%252Fwiki%252FAngular_(framework)%26psig%3DAOvVaw1sFAdC9EY98WCwYs0CwgxT%26ust%3D1566329266324494&psig=AOvVaw1sFAdC9EY98WCwYs0CwgxT&ust=1566329266324494"

                }
            }.FirstOrDefault(x => x.EventoId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
