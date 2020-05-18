namespace SalaVItual.Services.Services
{
    public interface ISingInClassService
    {
        bool Connect(string email, string codigoSala, string numeroIdentificacao);
    }
}