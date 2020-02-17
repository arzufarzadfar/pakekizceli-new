using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PAK.BrodImalat.WebService.Data;
using Zen.Barcode;

namespace PAK.BrodImalat.WebService.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class BarcodeController : ControllerBase
    {
        private readonly AppIdenittyDbContext _context;

        public BarcodeController(AppIdenittyDbContext context)
        {
            _context = context;
        }

        [Route("barcodes")]
        [HttpGet]
        public byte[] Get([FromHeader] int id)
        {

            var metere = _context.altUnits
                .Include(p => p.MainUnitId)
                .FirstOrDefault();


            var result = _context.orderDetails
                .Where(p => p.OrderId == id)
                .Include(p=>p.Item)
                
                .FirstOrDefault();
            string barkodTasarim = result.OrderId.ToString() +"_"+ result.Item.Pattern.ToString() + result.Item.Rope.ToString() + result.Item.Strike.ToString();
            var draw = new Code128BarcodeDraw(Code128Checksum.Instance);
            var image = draw.Draw(barkodTasarim, 70, 1);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Unauthorized);


            byte[] arr;
            using (var memStream = new MemoryStream())
            {
                image.Save(memStream, ImageFormat.Png);
                arr = memStream.ToArray();
            }

            response.Content = new StreamContent(new MemoryStream(arr));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/png");
            return arr;
        }
    }
}
