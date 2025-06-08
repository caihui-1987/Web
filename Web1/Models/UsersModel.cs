using Azure.Identity;

namespace Web1.Models
{
    public class UsersModel
    {
        
        public int UserID { get; set; } = 0;//用户ID 默认值为0
        public string UserName {get;set;}="";//用户名 默认值为空
        public string Phone { get; set; } = "";//手机号 默认值为空
        public string PassWord { get; set; } ="";//密码 默认值为空
        public string IP { get; set; } = "";//IP 默认值为空
        public DateTime CreateDate { get; set; }//创建时间
        public int Stature { get; set; } = 0;//状态0正常，1冻结，默认值为0
    } 
}
