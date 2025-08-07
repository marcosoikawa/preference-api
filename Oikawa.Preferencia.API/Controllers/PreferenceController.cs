using Microsoft.AspNetCore.Mvc;

namespace Oikawa.Preferencia.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreferenceController : ControllerBase
    {
        private readonly ILogger<PreferenceController> _logger;
        
        // Simulated database of preferences - readonly for GET only operations
        private static readonly Dictionary<string, PersonPreference> _preferences = new()
        {
            { "Nathalia", new PersonPreference { Name = "Nathalia", Preference = "Monet", Category = "Obras de Arte", Description = "Para obras de arte, prefere Monet" } },
            { "Marcos", new PersonPreference { Name = "Marcos", Preference = "Hokusai", Category = "Obras de Arte", Description = "Para obras de arte, prefere Hokusai" } },
            { "Iury", new PersonPreference { Name = "Iury", Preference = "Picasso", Category = "Obras de Arte", Description = "Para obras de arte, prefere Picasso" } },
            { "Filiputti", new PersonPreference { Name = "Filiputti", Preference = "Gogh", Category = "Obras de Arte", Description = "Para obras de arte, prefere Gogh" } }
        };

        public PreferenceController(ILogger<PreferenceController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{name}")]
        public ActionResult<PersonPreference> GetPreference(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Nome não pode estar vazio");
            }

            // Case insensitive search
            var foundPreference = _preferences.FirstOrDefault(p => 
                string.Equals(p.Key, name, StringComparison.OrdinalIgnoreCase));

            if (foundPreference.Value != null)
            {
                _logger.LogInformation($"Preferência encontrada para {name}: {foundPreference.Value.Preference}");
                return Ok(foundPreference.Value);
            }

            _logger.LogInformation($"Preferência não encontrada para {name}");
            return NotFound($"Preferência não encontrada para a pessoa: {name}");
        }
    }
}