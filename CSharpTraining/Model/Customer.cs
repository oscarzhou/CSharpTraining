using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Serializable()]
    public class Customer
    {
        [DisplayName("User Name")]
        [Required(ErrorMessage="{0}不得为空")]
        public string LoginId { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "{0} is not allowed null")]
        [StringLength(18, MinimumLength = 6,ErrorMessage = "{0}长度必须在{2}和{1}之间")]
        public string LoginPwd { get; set; }

        [DisplayName("重复密码")]
        [Required(ErrorMessage = "{0}不得为空")]
        [Compare("LoginPwd", ErrorMessage = "两次输入密码不一致！")]
        public string PasswordConfirm { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "{0}不得为空")]
        public string Name { get; set; }

        [DisplayName("年龄")]
        [Required(ErrorMessage = "{0}不得为空")]
        [Range(18,60,ErrorMessage = "{0}必须在{1}和{2}之间")]
        public int? Age { get; set; }

        [DisplayName("地址")]
        [Required(ErrorMessage = "{0}不得为空")]
        public string Address { get; set; }

        [DisplayName("电话")]
        [Required(ErrorMessage = "{0}不得为空")]
        [StringLength(11,MinimumLength = 7,ErrorMessage = "{0}必须是{2}和{1}之间")]
        public string Phone { get; set; }

        [DisplayName("电子邮件")]
        [Required(ErrorMessage = "{0}不得为空")]
        [RegularExpression(@"^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$", ErrorMessage = "请输入正确的{0}")]
        public string Email { get; set; }


    }
}
