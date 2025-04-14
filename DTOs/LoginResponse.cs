namespace PainForGlory_Common.DTOs
{
    public class LoginResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> Characters { get; set; }
    }
}
