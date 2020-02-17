using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAK.BrodImalat.WebService.Controllers;
using PAK.BrodImalat.WebService.Data;
using PAK.BrodImalat.WebService.Models;

namespace PAK.BrodImalat.WebService.ControlerLogo
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadLogoController : ControllerBase
    {

        private readonly GO3DbContext context;
        private readonly AppIdenittyDbContext _context;

        public ReadLogoController(GO3DbContext context, AppIdenittyDbContext _context)
        {
            this.context = context;
            this._context = _context;
        }

        [HttpGet]
        public IActionResult Get()
        {
             
            var query = from h in context.Lg00101Orfiche
                         join y in context.Lg00101Orfline on h.Logicalref equals y.Ordficheref
                        join r in context.Lg001Clcard on h.Clientref equals r.Logicalref
                        join x in context.Lg001Items on y.Stockref equals x.Logicalref
                        join q in context.Lg001Unitsetf on y.Usref equals q.Logicalref
                        join z in context.Lg001Unitsetl on y.Uomref equals z.Logicalref
                        join w in context.Lg001Specodes.Where(p => p.Spetyp1 == 1) on x.Specode equals w.Specode into ej
                        from w in ej.DefaultIfEmpty()
                        join e in context.Lg001Specodes.Where(p => p.Spetyp2 == 1) on x.Specode2 equals e.Specode into ed
                        from e in ed.DefaultIfEmpty()

                        join a in context.Lg001Specodes.Where(p => p.Spetyp3 == 1) on x.Specode3 equals a.Specode into ey from a in ey.DefaultIfEmpty()
                        join b in context.Lg001Specodes.Where(p => p.Spetyp4 == 1) on x.Specode4 equals b.Specode into ek
                        from b in ek.DefaultIfEmpty()
                        join g in context.Lg001Specodes.Where(p => p.Spetyp5 == 1) on x.Specode5 equals g.Specode into eo from g in eo.DefaultIfEmpty()
                         

                       select new
                        {
                            Logicalref = h.Logicalref,
                            Sipdetay = y.Logicalref,
                            Main = new
                            {
                                MainCode = q.Code,
                                MainName = q.Name,
                                MainLogicalRef = q.Logicalref,
                                MainCreatedTime = q.CapiblockCreadeddate,
                                MainModifiedTime = q.CapiblockModifieddate

                            },
                            Alt = new
                            {
                               
                                AltCode = z.Code,
                                AltName = z.Name,
                                AltId = z.Logicalref,
                                AltMainID = z.Unitsetref
                              
                            },
                           Item = new
                            {
                                ItemId = x.Logicalref,
                                ItemCode = x.Code,
                                ItemName = x.Name,
                                ItemColor = w.Definition,
                                ItemFloor = e.Definition,
                                ItemPattern = a.Definition,
                                ItemRope = b.Definition,
                                ItemStrike = g.Definition,
                                ItemCreatedTime = x.CapiblockCreadeddate,
                                ItemModifiedTime = x.CapiblockModifieddate

                            },
                        
                                Client = new {
                            ClientId = r.Logicalref,
                            ClientName = r.Definition,
                            ClientCode = r.Code
                             },

                           Order = new
                           {

                               orderId = h.Logicalref,
                               FicheNo = h.Ficheno,
                               clientid = r.Logicalref


                           },

                           Orderdetail = new
                          {

                               OrderId = h.Logicalref,
                               amount = y.Amount,
                               altunitId= z.Logicalref,
                               itemId= x.Logicalref


                           },


                          

                           Ficheno = h.Ficheno,
                            Date = h.Date,
                            Time = h.Time,
                            Stockref = y.Stockref,
                            specode1 = w.Definition,
                            specode2 = e.Definition,
                            specode3 = a.Definition,
                            specode4 = b.Definition,
                            specode5 = g.Definition,
                           
                            Musteri= h.Clientref,
                            musterino= r.Code,
                            birim =  y.Usref

                        };
            foreach (var item in query)
            {
                //client oluşturma
                ClientsController clientsController = new ClientsController(_context);
                Client client = new Client();
                client.Name = item.Client.ClientName;
                client.ClientCode = item.Client.ClientCode;
                client.Id = item.Client.ClientId;


                clientsController.PostClient(client);

                //item oluşturma
                ItemsController itemsController = new ItemsController(_context);
                Item item1 = new Item();
                item1.Id = item.Item.ItemId;
                item1.Code = item.Item.ItemCode;
                item1.Name = item.Item.ItemName;
                item1.Color = item.Item.ItemColor;
                item1.Floor = item.Item.ItemFloor;
                item1.Pattern = item.Item.ItemPattern;
                item1.Rope = item.Item.ItemRope;
                item1.Strike = item.Item.ItemStrike;
                item1.LogicCreatedDate = item.Item.ItemCreatedTime;
                item1.LogicModifiedDate = item.Item.ItemModifiedTime;
                itemsController.PostItem(item1);

                //mainunit
                MainUnitsController mainUnit = new MainUnitsController(_context);
                MainUnit  main= new MainUnit();
                main.Code = item.Main.MainCode.ToString();
                main.Name = item.Main.MainName;
                main.Id = item.Main.MainLogicalRef;
                main.LogicCreatedDate = item.Main.MainCreatedTime;
                main.LogicModifiedDate = item.Main.MainModifiedTime;
                mainUnit.PostMainUnit(main);

                //altUnit

                AltUnitsController altUnit = new AltUnitsController(_context);
                AltUnit alt = new AltUnit();
                alt.Id = item.Alt.AltId;
                alt.Code = item.Alt.AltCode;
                alt.Name = item.Alt.AltName;
               
                alt.MainUnitId = item.Alt.AltMainID;
                //altUnit.PostAltUnit(alt);
                altUnit.PostAltUnit(alt);



                //order

                OrdersController order1 = new OrdersController(_context);
                Order order = new Order();
                order.Id = item.Order.orderId;
                order.FicheNo = item.Order.FicheNo;
                order.ClientId = item.Order.clientid;
                order.Statu = 0;
                order1.PostOrder(order);



                //orderdetail

                OrderDetailsController orderDetail = new OrderDetailsController(_context);
                OrderDetail orderd = new OrderDetail();
                orderd.OrderId = item.Orderdetail.OrderId;
                orderd.Amount = item.Orderdetail.amount;
                orderd.AltUnitId = item.Orderdetail.altunitId;
                orderd.ItemId = item.Orderdetail.itemId;
                orderDetail.PostOrderDetail(orderd);

              



            }



            return Ok(query);
        }








    }
}