namespace cp2.Models;

public abstract class Pagamento
{
    public decimal Valor { get; set; }
    public DateTime Data { get; set; } = DateTime.Now;

    public abstract string ProcessarPagamento();
}