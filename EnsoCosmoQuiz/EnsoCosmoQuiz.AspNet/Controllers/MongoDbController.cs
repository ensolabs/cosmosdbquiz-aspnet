﻿using System.Threading.Tasks;
using System.Web.Http;
using EnsoCosmoQuiz.AspNet.Repository;

namespace EnsoCosmoQuiz.AspNet.Controllers
{
    public class MongoDbController : ApiController
    {
        private MongoDbRepository _repository = new MongoDbRepository();
        
        [HttpGet]
        [ActionName("task1")]
        public async Task<IHttpActionResult> GetNumberOfProductionCompanies()
        {
            var result = await _repository.GetVoteCountOfHighestRatedMovie();
            return Ok(result);
        }
    }
}
