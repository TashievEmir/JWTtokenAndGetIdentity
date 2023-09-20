using System.ComponentModel.DataAnnotations;

namespace WebAppToken.Models
{
    public class otherParamUser: ParamUser
    {
        public string UserName { get; set; }
        public bool SeniorManager { get; set; } = false;

        [Required]
        public enumProfession Profession { get; set; }
    }
}
