using FindsExplorer.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace FindsExplorer.Models
{
    public class FindUploadingModel
    {
        [Required(ErrorMessage ="Поле не заполнено")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Длина названия должна быть от 2 до 30 символов")]
        [Display(Name="Название")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Поле не заполнено")]
        [Display(Name = "Период")]
        public string Period { get; set; }

        [Required(ErrorMessage = "Поле не заполнено")]
        [Display(Name = "Материал")]
        public string Material { get; set; }

        [Required(ErrorMessage ="Обязательное поле")]
        public IFormFile Photo1 { get; set; }
        public IFormFile Photo2 { get; set; }
        public IFormFile Photo3 { get; set; }

    }
}
