using System;
using System.Collections.Generic;
using System.Linq;

namespace ParseHtmlLinks
{
    class Program
    {
        static void Main(string[] args)
        { 
            String urlToParse = ("http://www.dcs.bbk.ac.uk/~martin/sewn/ls3/");
            ParseHtmlLinks phl = new ParseHtmlLinks(urlToParse);

            Console.WriteLine("Parsing links from: " + phl.getUrlToParse());
            phl.parseHtmlLinks(urlToParse);

            Report report = new Report(phl.ReportList);
            report.CrawlReport = @"C:\Users\Public\Crawl.txt";
            report.ResultsReport = @"C:\Users\Public\Results.txt";
            report.generateReport();
            Console.Write("Report run, check \n" + report.CrawlReport + " and " + report.ResultsReport + "\nPress any key to exit");
            Console.Read();
        }
    }
}
