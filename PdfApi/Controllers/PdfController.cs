using PdfSharp;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace PdfApi.Controllers
{
    public class PdfController : ApiController
    {
        //[HttpGet]
        //public HttpResponseMessage Test()
        //{
        //    var doc = PdfSharpConvert();
        //    MemoryStream ms = new MemoryStream();
        //    doc.Save(ms, false);
        //    ms.Position = 0;
        //    var response = new HttpResponseMessage(HttpStatusCode.OK);
        //    response.Content = new StreamContent(ms);
        //    response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
        //    var fileName = "Test.pdf";

        //    response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
        //    {
        //        FileName = fileName
        //    };

        //    return response;
        //}

        //public PdfDocument PdfSharpConvert()
        //{

        //    DataTable dt = new DataTable();
        //    dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id", typeof(int)),
        //            new DataColumn("Name", typeof(string)),
        //            new DataColumn("Country",typeof(string)) });
        //    dt.Rows.Add(1, "John Hammond", "United States United States United States United States United States United States United States United States");
        //    dt.Rows.Add(2, "Mudassar Khan", "India");
        //    dt.Rows.Add(3, "Suzanne Mathews", "France United States United States United States");
        //    dt.Rows.Add(4, "Robert Schidner", "Russia");
        //    dt.Rows.Add(5, "John Hammond", "United States");
        //    dt.Rows.Add(6, "Mudassar Khan United States United States United States", "India");
        //    dt.Rows.Add(7, "Suzanne Mathews", "France");
        //    dt.Rows.Add(8, "Robert Schidner", "Russia");
        //    dt.Rows.Add(9, "John Hammond", "United States");
        //    dt.Rows.Add(10, "Mudassar Khan", "India");
        //    dt.Rows.Add(11, "Suzanne Mathews", "France");
        //    dt.Rows.Add(12, "Robert Schidner", "Russia");
        //    dt.Rows.Add(13, "John Hammond", "United States");
        //    dt.Rows.Add(14, "Mudassar Khan", "India");
        //    dt.Rows.Add(15, "Suzanne Mathews", "France");
        //    dt.Rows.Add(16, "John Hammond", "United States");
        //    dt.Rows.Add(17, "Mudassar Khan", "India");
        //    dt.Rows.Add(18, "Suzanne Mathews", "France");
        //    dt.Rows.Add(19, "John Hammond", "United States");
        //    dt.Rows.Add(20, "Mudassar Khan", "India");
        //    dt.Rows.Add(21, "Suzanne Mathews", "France");
        //    dt.Rows.Add(22, "Robert Schidner", "Russia");
        //    dt.Rows.Add(23, "Mudassar Khan", "India");
        //    dt.Rows.Add(24, "Suzanne Mathews", "France");
        //    dt.Rows.Add(25, "Robert Schidner", "Russia");
        //    dt.Rows.Add(26, "Mudassar Khan", "India");
        //    dt.Rows.Add(27, "Suzanne Mathews", "France");
        //    dt.Rows.Add(28, "Robert Schidner", "Russia");
        //    dt.Rows.Add(29, "Mudassar Khan", "India");
        //    dt.Rows.Add(30, "Suzanne Mathews", "France");
        //    dt.Rows.Add(31, "Robert Schidner", "Russia");
        //    dt.Rows.Add(32, "Mudassar Khan", "India");
        //    dt.Rows.Add(33, "Suzanne Mathews", "France");
        //    dt.Rows.Add(34, "Robert Schidner", "Russia");
        //    dt.Rows.Add(35, "Mudassar Khan", "India");
        //    dt.Rows.Add(36, "Suzanne Mathews", "France");
        //    dt.Rows.Add(37, "Robert Schidner", "Russia");
        //    dt.Rows.Add(38, "Mudassar Khan", "India");
        //    dt.Rows.Add(39, "Suzanne Mathews", "France");
        //    dt.Rows.Add(40, "Robert Schidner", "Russia");
        //    dt.Rows.Add(41, "Mudassar Khan", "India");
        //    dt.Rows.Add(42, "Suzanne Mathews", "France");
        //    dt.Rows.Add(43, "Robert Schidner", "Russia");
        //    dt.Rows.Add(44, "Mudassar Khan", "India");
        //    dt.Rows.Add(45, "Suzanne Mathews", "France");
        //    dt.Rows.Add(46, "Robert Schidner", "Russia");
        //    dt.Rows.Add(47, "Mudassar Khan", "India");
        //    dt.Rows.Add(48, "Suzanne Mathews", "France");
        //    dt.Rows.Add(49, "Robert Schidner", "Russia");
        //    dt.Rows.Add(50, "Mudassar Khan", "India");
        //    dt.Rows.Add(51, "Suzanne Mathews", "France");
        //    dt.Rows.Add(52, "Robert Schidner", "Russia");
        //    dt.Rows.Add(53, "Mudassar Khan", "India");
        //    dt.Rows.Add(54, "Suzanne Mathews", "France");
        //    dt.Rows.Add(55, "Robert Schidner", "Russia");
        //    dt.Rows.Add(56, "Mudassar Khan", "India");


        //    StringBuilder sb = new StringBuilder();
        //    //Table start.
        //    sb.Append("<HTML>");
        //    sb.Append("<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:Arial'>");

        //    //Adding HeaderRow.
        //    sb.Append("<tr>");
        //    foreach (DataColumn column in dt.Columns)
        //    {
        //        sb.Append("<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.ColumnName + "</th>");
        //    }
        //    sb.Append("</tr>");


        //    //Adding DataRow.
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        sb.Append("<tr>");
        //        foreach (DataColumn column in dt.Columns)
        //        {
        //            sb.Append("<td style='width:30%;border: 1px solid #ccc'>" + row[column.ColumnName].ToString() + "</td>");
        //        }
        //        sb.Append("</tr>");
        //    }

        //    //Table end.
        //    sb.Append("</table>");

        //    sb.Append("<br>");
        //    sb.AppendLine("Hello World");
        //    sb.Append("<br>");
        //    sb.AppendLine("How are you");
        //    sb.Append("<br>");
        //    sb.Append("</HTML>");

        //    string sHtml = sb.ToString();
        //    PdfDocument pdf = PdfGenerator.GeneratePdf(sHtml, PageSize.A4);
        //    return pdf;
        //}



        [HttpGet]
        public HttpResponseMessage Test2()
        {
            var doc = PdfSharpConvert2();
            MemoryStream ms = new MemoryStream();
            doc.Save(ms, false);
            ms.Position = 0;
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StreamContent(ms);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
            var fileName = "Test.pdf";

            response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
            {
                FileName = fileName
            };

            return response;
        }


        public PdfDocument PdfSharpConvert2()
        {
            StringBuilder sb = new StringBuilder();
            //Table start.
            sb.Append("<HTML>");
            sb.Append("<head>");
            // sb.Append("<link href='~/Content/Pdf.css' rel='stylesheet'/>");
            sb.Append("<style>");

            sb.Append(".Table{ display: table;width: 100 %;  table - layout: fixed;  }  ");
            sb.Append(".Title{  display: table-caption;text-align: center;font-weight: bold;font-size: larger;  }  ");
            sb.Append(".Heading{ display: table-row;font-weight: bold;text-align: center;  }  ");
            sb.Append(".Row{ display: table-row;  }  ");
            sb.Append(".Cell{ display: table-cell;border: solid;border-width: thin;padding-left: 5px;padding-right: 5px;  }  ");

            sb.Append("</style>");
            sb.Append("</head>");

            sb.Append("<body>");

            sb.Append("<p><b>Colleague Role </b></p>");

            sb.Append("<p>Director,QA&BA.</p><div style = 'margin-bottom:2%;'></div>");
            sb.Append("<p><b>Project(s) </b></p>");

            sb.Append("<p>(Testing)</p>");

            sb.Append("<div style='margin-bottom:2%;'></div><div class='Table'><div class='Heading'><div class='Cell'><p>Deliverable/Accomplishment</p></div><div class='Cell'><p>Measure of Success</p></div><div class='Cell'><p>Results</p></div><div class='Cell'><p>Testing Result</p></div></div><div class='Row'><div class='Cell'><p>Ensure all Mohawk work is fully tested prior to deployment.</p></div><div class='Cell'><p>Ensure all Mohawk work is fully tested prior to deployment.</p></div><div class='Cell'><p>Ensure all Mohawk work is fully tested prior to deployment.</p></div><div class='Cell'><p>I have collaborated with PM's toensure estimates are in placeto fully test all applications on the specified platforms.Along with program management, we have worked with the PM's to ensure that they have properresourcing through our groupand DDC where needed.The team has commented that Ihave continuously foundhistorical issues</p></div></div><div class='Row'><div class='Cell'><p>Ensure all Mohawk work is fully tested prior to deployment.</p></div><div class='Cell'><p>Ensure all Mohawk work is fully tested prior to deployment.</p></div><div class='Cell'><p>I have collaborated with PM's toensure estimates are in placeto fully test all applications on the specified platforms.Along with program management, we have worked with the PM's to ensure that they have properresourcing through our groupand DDC where needed.The team has commented that Ihave continuously foundhistorical issues</p></div></div><div class='Row'><div class='Cell'><p>Ensure all Mohawk work is fully tested prior to deployment.</p></div><div class='Cell'><p>Ensure all Mohawk work is fully tested prior to deployment.</p></div><div class='Cell'><p>I have collaborated with PM's toensure estimates are in placeto fully test all applications on the specified platforms.Along with program management, we have worked with the PM's to ensure that they have properresourcing through our groupand DDC where needed.The team has commented that Ihave continuously found historical issues they have properresourcing through our groupand DDC where needed.The team has commented that Ihave continuously found historical issues< they have properresourcing through our groupand DDC where needed.The team has commented that Ihave continuously found historical issues/they have properresourcing through our groupand DDC where needed.The team has commented that Ihave continuously found historical issues</p></div></div></div>");
    



            sb.Append("<div style = 'margin-bottom:2%;'></div>");
            sb.Append("<div><p><b> Christopher Oropeza(Self - evaluation comments) </b></p>");
            sb.AppendLine("<p>Comments</p>");
            sb.Append("<div style = 'margin-bottom:2%;'></div><div><h3><b>Execution</b></h3><p style='background-color:gray; color: white'><b>Customer Focused - Was committed to meeting or exceeding customer satisfaction by accurately scoping work and ensuring agreed to commitments were met (provided quality work in a timely, cost effective manner).</b></p></div>");
            sb.AppendLine("</body>");
            sb.Append("</HTML>");

            string sHtml = sb.ToString();
            PdfDocument pdf = PdfGenerator.GeneratePdf(sHtml, PageSize.A4);
            return pdf;
        }


    }
}
