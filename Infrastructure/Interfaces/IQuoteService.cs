using Domain.Entities;
namespace Infrastructure.Interfaces;

public interface IQuoteService
{
    public Task<List<Quote>> GetQuotes();
    public Task<Quote> AddQuote(Quote quote);
}
