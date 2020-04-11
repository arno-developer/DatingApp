using System.ComponentModel.DataAnnotations;
namespace DatingApp.API.Helpers
{
    public class UserParams
    {
        private const int MaxPageSize = 50;
        private const int MinPageSize = 1;
        private int pageSize = 10;
        
        public int PageNumber { get; set; } = 1;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : (value < MinPageSize) ? MinPageSize : value; }
        }
        
        public int UserId { get; set; }
        public string Gender { get; set; }
        public int MinAge { get; set; } = 18;
        public int MaxAge { get; set; } = 99;
        public string OrderBy { get; set; }
        public bool likees { get; set; } = false;
        public bool likers { get; set; } = false;
    }
}