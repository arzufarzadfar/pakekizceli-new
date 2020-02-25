using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.ModelsLogo
{
    public partial class Lg00101Stline
    {
        public int Logicalref { get; set; }
        public int? Stockref { get; set; }
        public short? Linetype { get; set; }
        public int? Prevlineref { get; set; } = 0;
        public short? Prevlineno { get; set; } = 0;
        public short? Detline { get; set; } = 0;
        public short? Trcode { get; set; } = 8;
        public DateTime? Date { get; set; } = DateTime.Now;
        public int? Ftime { get; set; }
        public short? Globtrans { get; set; } = 0;
        public short? Calctype { get; set; } = 0;
        public int? Prodorderref { get; set; } = 0;
        public short? Sourcetype { get; set; } = 0;
        public short? Sourceindex { get; set; } = 0;
        public short? Sourcecostgrp { get; set; } = 0;
        public int? Sourcewsref { get; set; } = 0;
        public int? Sourcepolnref { get; set; } = 0;
        public short? Desttype { get; set; } = 0;
        public short? Destindex { get; set; } = 0;
        public short? Destcostgrp { get; set; } = 0;
        public int? Destwsref { get; set; } = 0;
        public int? Destpolnref { get; set; } = 0;
        public short? Factorynr { get; set; } = 0;
        public short? Iocode { get; set; } = 4;
        public int? Stficheref { get; set; }
        public short? Stfichelnno { get; set; }
        public int? Invoiceref { get; set; } = 0;
        public short? Invoicelnno { get; set; } = 0;
        public int? Clientref { get; set; }
        public int? Ordtransref { get; set; } = 0;
        public int? Ordficheref { get; set; } = 0;
        public int? Centerref { get; set; } = 0;
        public int? Accountref { get; set; } = 0;
        public int? Vataccref { get; set; } = 0;
        public int? Vatcenterref { get; set; } = 0;
        public int? Praccref { get; set; } = 0;
        public int? Prcenterref { get; set; } = 0;
        public int? Prvataccref { get; set; } = 0;
        public int? Prvatcenref { get; set; } = 0;
        public int? Promref { get; set; } = 0;
        public int? Paydefref { get; set; } = 0;
        public string Specode { get; set; } = "APM";
        public string Delvrycode { get; set; }
        public double? Amount { get; set; }
        public double? Price { get; set; } = 0;
        public double? Total { get; set; } = 0;
        public short? Prcurr { get; set; } = 0;
        public double? Prprice { get; set; } = 0;
        public short? Trcurr { get; set; } = 0;
        public double? Trrate { get; set; } = 0;
        public double? Reportrate { get; set; }
        public double? Distcost { get; set; } = 0;
        public double? Distdisc { get; set; } = 0;
        public double? Distexp { get; set; } = 0;
        public double? Distprom { get; set; } = 0;
        public double? Discper { get; set; } = 0;
        public string Lineexp { get; set; }
        public int? Uomref { get; set; }
        public int? Usref { get; set; } = 5;/////////////////////7
        public double? Uinfo1 { get; set; } = 0;
        public double? Uinfo2 { get; set; } = 0;
        public double? Uinfo3 { get; set; } = 0;
        public double? Uinfo4 { get; set; } = 0;
        public double? Uinfo5 { get; set; } = 0;
        public double? Uinfo6 { get; set; } = 0;
        public double? Uinfo7 { get; set; } = 0;
        public double? Uinfo8 { get; set; } = 0;
        public double? Plnamount { get; set; } = 0;
        public short? Vatinc { get; set; } = 0;
        public double? Vat { get; set; } = 0;
        public double? Vatamnt { get; set; } = 0;
        public double? Vatmatrah { get; set; }
        public int? Billeditem { get; set; } = 0;
        public short? Billed { get; set; } = 0;
        public short? Cpstflag { get; set; } = 0;
        public short? Retcosttype { get; set; } = 0;
        public int? Sourcelink { get; set; } = 0;
        public double? Retcost { get; set; } = 0;
        public double? Retcostcurr { get; set; } = 0;
        public double? Outcost { get; set; } = 0;
        public double? Outcostcurr { get; set; } = 0;
        public double? Retamount { get; set; } = 0;
        public int? Faregref { get; set; } = 0;
        public short? Faattrib { get; set; } = 0;
        public short? Cancelled { get; set; } = 0;
        public double? Linenet { get; set; } = 0;
        public double? Distaddexp { get; set; } = 0;
        public int? Fadaccref { get; set; } = 0;
        public int? Fadcenterref { get; set; } = 0;
        public int? Faraccref { get; set; }
        public int? Farcenterref { get; set; } = 0;
        public double? Diffprice { get; set; } = 0;
        public double? Diffprcost { get; set; }
        public short? Decprdiff { get; set; } = 0;
        public short? Lprodstat { get; set; } = 0;
        public double? Prdexptotal { get; set; } = 0;
        public double? Diffrepprice { get; set; } = 0;
        public double? Diffprcrcost { get; set; } = 0;
        public int? Salesmanref { get; set; } = 0;
        public int? Faplaccref { get; set; } = 0;
        public int? Faplcenterref { get; set; } = 0;
        public string Outputidcode { get; set; } = "";
        public int? Dref { get; set; } = 0;
        public double? Costrate { get; set; } = 0;
        public short? Xpriceupd { get; set; } = 0;
        public double? Xprice { get; set; } = 0;
        public double? Xreprate { get; set; } = 0;
        public double? Distcoef { get; set; } = 0;
        public short? Transqcok { get; set; } = 0;
        public short? Siteid { get; set; } = 0;
        public short? Recstatus { get; set; } = 2;
        public int? Orglogicref { get; set; } = 0;
        public int? Wfstatus { get; set; } = 0;
        public int? Polineref { get; set; } = 0;
        public int? Plnsttransref { get; set; } = 0;
        public short? Netdiscflag { get; set; } = 0;
        public double? Netdiscperc { get; set; } = 0;
        public double? Netdiscamnt { get; set; } = 0;
        public double? Vatcalcdiff { get; set; } = 0;
        public int? Conditionref { get; set; } = 0;
        public int? Distorderref { get; set; } = 0;
        public int? Distordlineref { get; set; } = 0;
        public int? Campaignrefs1 { get; set; } = 0;
        public int? Campaignrefs2 { get; set; } = 0;
        public int? Campaignrefs3 { get; set; } = 0;
        public int? Campaignrefs4 { get; set; } = 0;
        public int? Campaignrefs5 { get; set; } = 0;
        public int? Pointcampref { get; set; } = 0;
        public double? Camppoint { get; set; } = 0;
        public int? Promclasitemref { get; set; } = 0;
        public int? Cmpglineref { get; set; } = 0;
        public int? Plnsttranspernr { get; set; } = 0;
        public double? Pordclsplnamnt { get; set; } = 0;
        public double? Vendcomm { get; set; } = 0;
        public double? Previousoutcost { get; set; } = 0;
        public int? Costofsaleaccref { get; set; } = 0;
        public int? Purchaccref { get; set; } = 0;
        public int? Costofsalecntref { get; set; } = 0;
        public int? Purchcentref { get; set; } = 0;
        public double? Prevoutcostcurr { get; set; } = 0;
        public double? Abvatamount { get; set; } = 0;
        public int? Abvatstatus { get; set; } = 0;
        public double? Prrate { get; set; } = 0;
        public double? Addtaxrate { get; set; }
        public double? Addtaxconvfact { get; set; }
        public double? Addtaxamount { get; set; }
        public double? Addtaxprcost { get; set; }
        public double? Addtaxretcost { get; set; }
        public double? Addtaxretcostcurr { get; set; } = 0;
        public double? Grossuinfo1 { get; set; } = 0;
        public double? Grossuinfo2 { get; set; } = 0;
        public double? Addtaxprcostcurr { get; set; } = 0;
        public int? Addtaxaccref { get; set; } = 0;
        public int? Addtaxcenterref { get; set; } = 0;
        public short? Addtaxamntisupd { get; set; } = 0;
        public double? Infidx { get; set; } = 0;
        public int? Addtaxcosaccref { get; set; } = 0;
        public int? Addtaxcoscntref { get; set; } = 0;
        public double? Previousataxprcost { get; set; } = 0;
        public double? Prevataxprcostcurr { get; set; } = 0;
        public double? Prdordtotcoef { get; set; } = 0;
        public double? Dempeggedamnt { get; set; } = 0;
        public double? Stdunitcost { get; set; } = 0;
        public double? Stdrpunitcost { get; set; } = 0;
        public int? Costdiffaccref { get; set; } = 0;
        public int? Costdiffcenref { get; set; } = 0;
        public short? Textinc { get; set; } = 0;
        public double? Addtaxdiscamount { get; set; } = 0;
        public string Orglogoid { get; set; } = "";
        public string Eximficheno { get; set; } = "";
        public short? Eximfctype { get; set; } = 0;
        public short? Transexpline { get; set; } = 0;
        public short? Insexpline { get; set; } = 0;
        public int? Eximwhfcref { get; set; } = 0;
        public int? Eximwhlnref { get; set; } = 0;
        public int? Eximfileref { get; set; } = 0;
        public short? Eximprocnr { get; set; } = 0;
        public short? Eisrvdsttyp { get; set; } = 0;
        public int? Mainstlnref { get; set; } = 0;
        public short? Madeofshred { get; set; } = 0;
        public short? Fromordwithpay { get; set; } = 0;
        public int? Projectref { get; set; } = 0;
        public short? Status { get; set; } = 0;
        public short? Doreserve { get; set; }
        public int? Pointcamprefs1 { get; set; } = 0;
        public int? Pointcamprefs2 { get; set; } = 0;
        public int? Pointcamprefs3 { get; set; } = 0;
        public int? Pointcamprefs4 { get; set; } = 0;
        public double? Camppoints1 { get; set; } = 0;
        public double? Camppoints2 { get; set; } = 0;
        public double? Camppoints3 { get; set; } = 0;
        public double? Camppoints4 { get; set; } = 0;
        public int? Cmpglinerefs1 { get; set; } = 0;
        public int? Cmpglinerefs2 { get; set; } = 0;
        public int? Cmpglinerefs3 { get; set; } = 0;
        public int? Cmpglinerefs4 { get; set; } = 0;
        public int? Prclistref { get; set; } = 0;
        public short? Pordsymoutln { get; set; } = 0;
        public short? Month { get; set; } = Convert.ToInt16(DateTime.Now.Month);
        public short? Year { get; set; } = Convert.ToInt16(DateTime.Now.Year);
        public double? Exaddtaxrate { get; set; } = 0;
        public double? Exaddtaxconvf { get; set; } = 0;
        public int? Exaddtaxaref { get; set; } = 0;
        public int? Exaddtaxcref { get; set; } = 0;
        public int? Othraddtaxaref { get; set; } = 0;
        public int? Othraddtaxcref { get; set; } = 0;
        public double? Exaddtaxamnt { get; set; } = 0;
        public short? Affectcollatrl { get; set; } = 0;
        public short? Altpromflag { get; set; } = 0;
        public short? Eidistflnnr { get; set; } = 0;
        public short? Eximtype { get; set; } = 0;
        public int? Variantref { get; set; } = 0;
        public short? Candeduct { get; set; } = 0;
        public double? Outremamnt { get; set; } = 0;
        public double? Outremcost { get; set; } = 0;
        public double? Outremcostcurr { get; set; } = 0;
        public int? Reflvataccref { get; set; } = 0;
        public int? Reflvatothaccref { get; set; } = 0;
        public int? Parentlnref { get; set; } = 0;
        public short? Affectrisk { get; set; } = 0;
        public short? Ineffectivecost { get; set; } = 0;
        public double? Addtaxvatmatrah { get; set; } = 0;
        public int? Reflaccref { get; set; } = 0;
        public int? Reflothaccref { get; set; } = 0;
        public int? Camppaydefref { get; set; } = 0;
        public DateTime? Faregbinddate { get; set; } = null;
        public int? Reltranslnref { get; set; } = 0;
        public short? Fromtransfer { get; set; } = 0;
        public double? Costdistprice { get; set; } = 0;
        public double? Costdistrepprice { get; set; } = 0;
        public double? Diffpriceufrs { get; set; } = 0;
        public double? Diffreppriceufrs { get; set; } = 0;
        public double? Outcostufrs { get; set; } = 0;
        public double? Outcostcurrufrs { get; set; } = 0;
        public double? Diffprcostufrs { get; set; } = 0;
        public double? Diffprcrcostufrs { get; set; } = 0;
        public double? Retcostufrs { get; set; } = 0;
        public double? Retcostcurrufrs { get; set; } = 0;
        public double? Outremcostufrs { get; set; } = 0;
        public double? Outremcostcurrufrs { get; set; } = 0;
        public double? Infidxufrs { get; set; } = 0;
        public double? Adjpriceufrs { get; set; } = 0;
        public double? Adjreppriceufrs { get; set; } = 0;
        public double? Adjprcostufrs { get; set; } = 0;
        public double? Adjprcrcostufrs { get; set; } = 0;
        public double? Costdistpriceufrs { get; set; } = 0;
        public double? Costdistreppriceufrs { get; set; } = 0;
        public int? Purchaccrefufrs { get; set; } = 0;
        public int? Purchcentrefufrs { get; set; } = 0;
        public int? Cosaccrefufrs { get; set; } = 0;
        public int? Coscntrefufrs { get; set; } = 0;
        public double? Proutcostufrsdiff { get; set; } = 0;
        public double? Proutcostcrufrsdiff { get; set; } = 0;
        public short? Underdeductlimit { get; set; } = 0;
        public string Globalid { get; set; } = "";
        public short? Deductionpart1 { get; set; } = 2;
        public short? Deductionpart2 { get; set; } = 3;
        public string Guid { get; set; }
        public string Specode2 { get; set; } = "";
        public int? Offerref { get; set; } = 0;
        public int? Offtransref { get; set; } = 0;
        public string Vatexceptreason { get; set; } = "";
        public string Plndefserilotno { get; set; } = "";
        public double? Plnunrsrvamount { get; set; } = 0;
        public double? Pordclsplnunrsrvamnt { get; set; } = 0;
        public short? Lprodrsrvstat { get; set; } = 0;
        public short? Falinktype { get; set; } = 0;
        public string Deductcode { get; set; }
        public short? Updthisline { get; set; } = 0;
        public string Vatexceptcode { get; set; }
        public string Porderficheno { get; set; }
        public int? Qprodfcref { get; set; } = 0;
        public int? Reltransfcref { get; set; } = 0;
        public string Ataxexceptreason { get; set; }
        public string Ataxexceptcode { get; set; }
        public short? Prodordertyp { get; set; } = 0;
        public int? Subcontorderref { get; set; } = 0;
        public short? Qprodfctyp { get; set; } = 0;
        public short? Prdordslplnreserve { get; set; } = 0;
        public DateTime? Infdate { get; set; }
        public short? Deststatus { get; set; } = 0;
        public int? Regtypref { get; set; } = 0;
        public int? Faprofitaccref { get; set; }
        public int? Faprofitcentref { get; set; }
        public int? Falossaccref { get; set; }
        public int? Falosscentref { get; set; }
        public int? Futmonthbegdate { get; set; }
        public int? Qctransferref { get; set; }
        public double? Qctransferamnt { get; set; }
        public string Gtipcode { get; set; }
        public string Cpacode { get; set; }
        public int? Publiccountryref { get; set; }
        public short? Futmonthcnt { get; set; }
        public short? Qproditemtype { get; set; }

    }
}
