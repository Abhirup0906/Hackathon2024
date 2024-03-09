using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SpeechRecognitionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoiceRecognitionController : ControllerBase
    {
        [HttpPost("CreateVoiceProfile")]
        public bool CreateVoiceProfile(IFormFile voice, string userId, string userName)
        {
            return true;
        }

        [HttpPost("UpdateVoiceProfile")]
        public bool UpdateVoiceProfile(IFormFile oldVoicePrint, IFormFile newVoicePrint, IFormFile confirmVoicePrint, string userId)
        {
            return true;
        }

        [HttpPost("VerifyVoiceProfile")]
        public string VerifyVoiceProfile(IFormFile voicePrint)
        {
            return "Employee: uid";
        }
    }
}
