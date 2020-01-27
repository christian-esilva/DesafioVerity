namespace DesafioVerity.Dominio.Utils
{
    public class ConfiguracoesJwt
    {
        public string Secret { get; set; }
        public int Expiration { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
    }
}
