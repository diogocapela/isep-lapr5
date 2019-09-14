using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using production_planning_api.Services;
using Microsoft.AspNetCore.Mvc;
using Prolog;

namespace production_planning_api.Controllers
{
    [Route("api/query")]
    [ApiController]
    public class QueryController : ControllerBase
    {
        private readonly IQueryService _queryService;

        public QueryController(IQueryService queryService)
        {
            _queryService = queryService;
        }

        [HttpGet]
        [ProducesResponseType((int) HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int) HttpStatusCode.Forbidden)]
        public async Task<ActionResult> GetOperationsAsync()
        {
            List<string> ls = new List<string>();
            //IEnumerable<OutOperationDTO> lstOperationsDtos = new List<OutOperationDTO>();
            var prolog = new PrologEngine(persistentCommandHistory: false);

            // 'socrates' is human.
            prolog.Consult("sprint2_final.pl");
            //prolog.ConsultFromString("clientes([clA,clB,clC]).");
            
            // human is bound to die.
            //prolog.ConsultFromString("mortal(X) :- human(X).");
            
            // Question: Shall 'socrates' die?
            
            /*foreach (var sol in solutions.NextSolution)
            {
                ls.Add(sol.ToString());
            }*/

            return Ok(ls);
        }
    }
}