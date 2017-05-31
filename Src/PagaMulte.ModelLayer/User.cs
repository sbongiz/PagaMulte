using System;

namespace PagaMulte.ModelLayer
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public DateTime DataExpired { get; set; } 
    }
}
