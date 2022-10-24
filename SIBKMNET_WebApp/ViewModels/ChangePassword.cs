using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKMNET_WebApp.ViewModels
{
    public class ChangePassword
    {
        [Key]
        public string CurrentPass { get; set; }
        public string NewPass { get; set; }
        [Compare("NewPass", ErrorMessage = "Konfirmasi kata sandi baru tidak cocok")]
        public string ConfirmPass { get; set; }
    }
}
