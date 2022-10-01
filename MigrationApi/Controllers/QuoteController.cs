using Domain.Entities;
using Infrastructure.Context;
using Infrastructure.Interfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace MigrationApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuoteController : ControllerBase
{
    private readonly IQuoteService _quoteService;
    public QuoteController(IQuoteService quoteService)
    {
        _quoteService = quoteService;
    }

    [HttpGet]
    public async Task<List<Quote>> GetQuotes()
    {
        return await _quoteService.GetQuotes();
    }

    [HttpPost]
    public async Task<Quote> AddQuote(Quote quote)
    {
        return await _quoteService.AddQuote(quote);
    }
}

