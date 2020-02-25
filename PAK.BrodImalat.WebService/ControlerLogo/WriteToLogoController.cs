using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAK.BrodImalat.WebService.Data;
using PAK.BrodImalat.WebService.Models;
using PAK.BrodImalat.WebService.ModelsLogo;
using PAK.BrodImalat.WebService.Controllers;
using Microsoft.AspNetCore.Cors;

namespace PAK.BrodImalat.WebService.ControlerLogo
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class WriteToLogoController : ControllerBase
    {
        private readonly GO3DbContext context;
        private readonly AppIdenittyDbContext apicontext;
        public WriteToLogoController(GO3DbContext context, AppIdenittyDbContext apicontext)
        {
            this.context = context;
            this.apicontext = apicontext;

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWriteToLogoAsync(int ID)
        {
            OrdersController ordersController = new OrdersController(apicontext);
            Order order = new Order();
            order = ordersController.GetOrderByOrder(ID);


            OrderDetailsController orderDetailsController = new OrderDetailsController(apicontext);
            List<OrderDetail> orderDetail = new List<OrderDetail>();
            orderDetail = orderDetailsController.GetOrderDetailByOrder(ID);

            Lg00101StficheController stficheController = new Lg00101StficheController(context);
            Lg00101Stfiche stfiche = new Lg00101Stfiche();
            stfiche.Ficheno = order.FicheNo;
            stfiche.Date = DateTime.Now;
            stfiche.Docode = "";
            stfiche.Clientref = order.ClientId;
            stfiche.CapiblockCreadeddate = DateTime.Now;
            stfiche.CapiblockCreatedhour = Convert.ToInt16(DateTime.Now.Hour);
            stfiche.CapiblockCreatedmin = Convert.ToInt16(DateTime.Now.Minute);
            stfiche.CapiblockCreatedsec = Convert.ToInt16(DateTime.Now.Second);

            var utku = stficheController.PostLg00101Stfiche(stfiche);
            Console.WriteLine(utku);

            Int16 LineCounter = 0;
            foreach (var item in orderDetail)
            {
                Lg00101StlineController stlineController = new Lg00101StlineController(context);
                Lg00101Stline stline = new Lg00101Stline();
                stline.Stockref = item.ItemId;
                stline.Stficheref = utku;
                stline.Linetype = 0;
                stline.Date = DateTime.Now;
                stline.Clientref = order.ClientId;
                stline.Amount = item.Amount;
                stline.Uomref = item.AltUnitId;
                stline.Stfichelnno = LineCounter;

                stlineController.PostLg00101Stline(stline);
                LineCounter++;

            }

            return Ok();

        }



    }
}