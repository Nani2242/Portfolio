using Portfolio.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GudiPortfolio.Pages;

public class ProjectsModel : PageModel
{
    public List<ProjectItem> Projects { get; private set; } = [];

    public void OnGet()
    {
        Projects =
        [
            new()
            {
                Title = "Etravos – Travel Booking Platform",
                Category = "TRAVEL TECHNOLOGY",
                Description = "Travel booking workflows covering flight, bus, hotel and third-party API integrations.",
                Technologies = ["C#", ".NET Core", "Web API", "SQL Server"]
            },

            new()
            {
                Title = "TravelConsole – Travel Management System",
                Category = "TRAVEL TECHNOLOGY",
                Description = "A travel management application developed using ASP.NET MVC and .NET Core, with SQL Server for database operations.",
                Technologies = ["ASP.NET MVC", ".NET Core", "SQL Server"]
            },

            new()
            {
                Title = "eKYC Integration",
                Category = "IDENTITY VERIFICATION",
                Description = "API integration work supporting end-to-end eKYC workflows, token handling and request/response troubleshooting.",
                Technologies = ["ASP.NET", "C#", "Web API", "JSON"]
            },

            new()
            {
                Title = "AI Chatbot – Gemini API",
                Category = "GENERATIVE AI",
                Description = "A chatbot prototype that sends prompts to Google Gemini API and displays AI-generated responses.",
                Technologies = ["Gemini API", "C#", "API Integration"]
            }
        ];
    }
}