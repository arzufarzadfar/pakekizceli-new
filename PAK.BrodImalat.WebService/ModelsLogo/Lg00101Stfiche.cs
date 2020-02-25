using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.ModelsLogo
{
    public class Lg00101Stfiche
    {

        public int Logicalref { get; set; }
        public short? Grpcode { get; set; } = 2;
        public short? Trcode { get; set; } = 8;
        public short? Iocode { get; set; } = 3;
        public string Ficheno { get; set; }
        public DateTime? Date { get; set; }
        public int? Ftime { get; set; } = 168179043;
        public string Docode { get; set; }
        public string Invno { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; } = "";
        public int? Invoiceref { get; set; }
        public int? Clientref { get; set; }
        public int? Recvref { get; set; } = null;
        public int? Accountref { get; set; } = null;
        public int? Centerref { get; set; } = null;
        public int? Prodorderref { get; set; } = 0;
        public string Porderficheno { get; set; } = "";
        public short? Sourcetype { get; set; } = 0;
        public short? Sourceindex { get; set; } = 0;
        public int? Sourcewsref { get; set; } = 0;
        public int? Sourcepolnref { get; set; } = 0;
        public short? Sourcecostgrp { get; set; } = 0;
        public short? Desttype { get; set; } = 0;
        public short? Destindex { get; set; } = 0;
        public int? Destwsref { get; set; } = 0;
        public int? Destpolnref { get; set; } = 0;
        public short? Destcostgrp { get; set; } = 0;
        public short? Factorynr { get; set; } = 0;
        public short? Branch { get; set; } = 0;
        public short? Department { get; set; } = 0;
        public short? Compbranch { get; set; } = 0;
        public short? Compdepartment { get; set; } = 0;
        public short? Compfactory { get; set; } = 0;
        public short? Prodstat { get; set; } = 0;
        public short? Devir { get; set; } = 0;
        public short? Cancelled { get; set; } = 0;
        public short? Billed { get; set; } = 0;
        public short? Accounted { get; set; } = 0;
        public short? Updcurr { get; set; } = 0;
        public short? Inuse { get; set; } = 0;
        public short? Invkind { get; set; } = 0;
        public double? Adddiscounts { get; set; } = 0;
        public double? Totaldiscounts { get; set; } = 0;
        public double? Totaldiscounted { get; set; } = 0;
        public double? Addexpenses { get; set; } = null;
        public double? Totalexpenses { get; set; } = null;
        public double? Totaldepozito { get; set; } = null;
        public double? Totalpromotions { get; set; } = null;
        public double? Totalvat { get; set; } = 0;
        public double? Grosstotal { get; set; } = 0;
        public double? Nettotal { get; set; } = 0;
        public string Genexp1 { get; set; } = null;
        public string Genexp2 { get; set; } = null;
        public string Genexp3 { get; set; } = null;
        public string Genexp4 { get; set; } = null;
        public string Genexp5 { get; set; } = null;
        public string Genexp6 { get; set; } = null;
        public double? Reportrate { get; set; } = 1;
        public double? Reportnet { get; set; } = 0;
        public int? Extenref { get; set; } = 0;
        public int? Paydefref { get; set; } = 0;
        public short? Printcnt { get; set; } = 0;
        public short? Fichecnt { get; set; } = 1;
        public int? Accficheref { get; set; } = 0;
        public short? CapiblockCreatedby { get; set; } = 1;
        public DateTime? CapiblockCreadeddate { get; set; } = DateTime.Now;
        public short? CapiblockCreatedhour { get; set; }
        public short? CapiblockCreatedmin { get; set; }
        public short? CapiblockCreatedsec { get; set; }
        public short? CapiblockModifiedby { get; set; }
        public DateTime? CapiblockModifieddate { get; set; }
        public short? CapiblockModifiedhour { get; set; }
        public short? CapiblockModifiedmin { get; set; }
        public short? CapiblockModifiedsec { get; set; }
        public int? Salesmanref { get; set; } = 0;
        public short? Cancelledacc { get; set; } = 0;
        public string Shptypcod { get; set; }
        public string Shpagncod { get; set; }
        public string Tracknr { get; set; }
        public short? Genexctyp { get; set; } = 2;
        public short? Lineexctyp { get; set; } = 0;
        public string Tradinggrp { get; set; }
        public short? Textinc { get; set; } = 0;
        public short? Siteid { get; set; } = 0;
        public short? Recstatus { get; set; } = 1;
        public int? Orglogicref { get; set; } = 0;
        public int? Wfstatus { get; set; } = 0;
        public int? Shipinforef { get; set; } = 0;
        public int? Distorderref { get; set; } = 0;
        public short? Sendcnt { get; set; } = 0;
        public short? Dlvclient { get; set; } = 0;
        public string Doctrackingnr { get; set; }
        public short? Addtaxcalc { get; set; } = 0;
        public double? Totaladdtax { get; set; } = 0;
        public string Ugirtrackingno { get; set; }
        public int? Qprodfcref { get; set; }
        public int? Vaaccref { get; set; } = 0;
        public int? Vacenterref { get; set; } = 0;
        public string Orglogoid { get; set; }
        public short? Fromexim { get; set; } = 0;
        public string Frgtypcod { get; set; }
        public short? Trcurr { get; set; } = 0;
        public double? Trrate { get; set; } = 0;
        public double? Trnet { get; set; } = 0;
        public int? Eximwhfcref { get; set; } = 0;
        public short? Eximfctype { get; set; } = 0;
        public int? Mainstfcref { get; set; } = 0;
        public short? Fromordwithpay { get; set; } = 0;
        public int? Projectref { get; set; } = 0;
        public int? Wflowcrdref { get; set; } = 0;
        public short? Status { get; set; } = 0;
        public short? Updtrcurr { get; set; } = 0;
        public double? Totalexaddtax { get; set; } = 0;
        public short? Affectcollatrl { get; set; } = 0;
        public short? Deductionpart1 { get; set; } = 2;
        public short? Deductionpart2 { get; set; } = 3;
        public short? Grpfirmtrans { get; set; } = 0;
        public short? Affectrisk { get; set; } = 1;
        public short? Dispstatus { get; set; } = 1;
        public short? Approve { get; set; } = 0;
        public DateTime? Approvedate { get; set; }
        public short? Cantcrededuct { get; set; } = 0;
        public DateTime? Shipdate { get; set; }
        public int? Shiptime { get; set; } = 0;
        public short? Entrustdevir { get; set; } = 0;
        public int? Reltransfcref { get; set; } = 0;
        public short? Fromtransfer { get; set; } = 0;
        public string Guid { get; set; }
        public string Globalid { get; set; }
        public int? Compstfcref { get; set; } = 0;
        public int? Compinvref { get; set; } = 0;
        public double? Totalservices { get; set; } = 0;
        public string Campaigncode { get; set; }
        public int? Offerref { get; set; } = 0;
        public short? Einvoicetyp { get; set; } = 0;
        public short? Einvoice { get; set; } = 0;
        public short? Nocalculate { get; set; } = 0;
        public short? Prodordertyp { get; set; } = 0;
        public short? Qprodfctyp { get; set; } = 0;
        public DateTime? Printdate { get; set; }
        public short? Prdordslplnreserve { get; set; } = 0;
        public short? Controlinfo { get; set; } = 0;
        public short? Edespatch { get; set; } = 0;
        public DateTime? Docdate { get; set; } = DateTime.Now;
        public int? Doctime { get; set; }
        public short? Edespstatus { get; set; } = 0;
        public short? Profileid { get; set; } = 0;
        public string Deliverycode { get; set; }
        public short? Deststatus { get; set; } = 0;
        public string Cancelexp { get; set; }
        public string Undoexp { get; set; }
        public DateTime? Canceldate { get; set; }
        public string Rechash { get; set; }
        public string Ataxexceptcode { get; set; }
        public string Vatexceptreason { get; set; }
        public short? Taxfreechx { get; set; }
        public string Ataxexceptreason { get; set; }
        public int? Publicbnaccref { get; set; }
        public short? Createwhere { get; set; }
        public string Vatexceptcode { get; set; }
        public short? Accepteinvpublic { get; set; }
    }

}
