using AspNetCore.Reporting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthWindMVC.Data;

namespace NorthWindMVC.Pages.Reports
{
    public class ProductSalesModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ProductSalesModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public FileContentResult OnGet()
        {
            // Register encoding provider (required for some environments)
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            // Path to the RDL file
            string reportPath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "ProductSales.rdl");
            // Load the report
            LocalReport report = new LocalReport(reportPath);

            // Optionally, add data sources here

            var salesData = _context.ProductSalesFor1997s.ToList();
                
            // The first parameter must match the DataSet name in your RDL file (e.g., "DataSet1")
            report.AddDataSource("DataSet1", salesData);

            // Render the report to PDF
            var result = report.Execute(RenderType.Pdf, 1, null, null);

            // Return the PDF file
            return File(result.MainStream, "application/pdf", "ProductSales.pdf");
        }
    }
}

    