using Domain.Entities;
using Infrastructure.Context;
using Infrastructure.Interfaces;
namespace Infrastructure.Services;

public class QuoteService : IQuoteService
{
    private readonly DataContext _context;

    public QuoteService(DataContext context)
    {
        _context = context;
    }

    public async Task<Quote> AddQuote(Quote quote)
    {
       _context.Quotes.Add(quote);
       _context.SaveChanges();
       return quote;
    }

    public async Task<List<Quote>> GetQuotes()
    {
        return _context.Quotes.ToList();
    }
}
