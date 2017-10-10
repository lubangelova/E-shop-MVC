using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_shop_MVC.Web.InputModels.Message
{
    public class MessageInputModel
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [AllowHtml]
        [Display(Name = "Content")]
        [DataType("tinymce_full")]
        [UIHint("tinymce_full")]
        public string Content { get; set; }

        [Required]
        [Display(Name ="RecipientId")]
        public string RecipientId { get; set; }


        [Required]
        [Display(Name = "SenderId")]
        public string SenderId { get; set; }
    }
}