using Microsoft.EntityFrameworkCore;
using PAK.BrodImalat.WebService.ModelsLogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAK.BrodImalat.WebService.Models
{
    public partial class GO3DbContext : DbContext
    {
        public GO3DbContext()
        {
        }
        public GO3DbContext(DbContextOptions<GO3DbContext> options)
           : base(options)
        {
        }

        public virtual DbSet<Lg00101Orfiche> Lg00101Orfiche { get; set; }
        public virtual DbSet<Lg00101Orfline> Lg00101Orfline { get; set; }

        public virtual DbSet<Lg001Clcard> Lg001Clcard { get; set; }

        public virtual DbSet<Lg001Specodes> Lg001Specodes { get; set; }
        public virtual DbSet<Lg001Items> Lg001Items { get; set; }



        public virtual DbSet<Lg001Unitsetf> Lg001Unitsetf { get; set; }
        public virtual DbSet<Lg001Unitset> Lg001Unitsetl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.;Database=GO;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lg00101Orfiche>(entity =>
            {
                entity.HasKey(e => e.Logicalref)
                   .HasName("I001_01_ORFICHE_I1");

                entity.ToTable("LG_001_01_ORFICHE");

                entity.HasIndex(e => e.Globalid)
                    .HasName("I001_01_ORFICHE_I7");

                entity.HasIndex(e => e.Guid)
                    .HasName("I001_01_ORFICHE_I8");

                entity.HasIndex(e => e.Trcode)
                    .HasName("I001_01_ORFICHE_I6");

                entity.HasIndex(e => new { e.Trcode, e.Ficheno })
                    .HasName("I001_01_ORFICHE_I2")
                    .IsUnique();

                entity.HasIndex(e => new { e.Salesmanref, e.Date, e.Time })
                    .HasName("I001_01_ORFICHE_I5");

                entity.HasIndex(e => new { e.Trcode, e.Date, e.Time })
                    .HasName("I001_01_ORFICHE_I3");

                entity.HasIndex(e => new { e.Clientref, e.Trcode, e.Date, e.Time })
                    .HasName("I001_01_ORFICHE_I4");

                entity.Property(e => e.Logicalref).HasColumnName("LOGICALREF");

                entity.Property(e => e.Accepteinvpublic).HasColumnName("ACCEPTEINVPUBLIC");

                entity.Property(e => e.Accountref).HasColumnName("ACCOUNTREF");

                entity.Property(e => e.Adddiscounts).HasColumnName("ADDDISCOUNTS");

                entity.Property(e => e.Addexpenses).HasColumnName("ADDEXPENSES");

                entity.Property(e => e.Addexpensesvat).HasColumnName("ADDEXPENSESVAT");

                entity.Property(e => e.Advancepaym).HasColumnName("ADVANCEPAYM");

                entity.Property(e => e.Affectcollatrl).HasColumnName("AFFECTCOLLATRL");

                entity.Property(e => e.Affectrisk).HasColumnName("AFFECTRISK");

                entity.Property(e => e.Altnr).HasColumnName("ALTNR");

                entity.Property(e => e.Approve).HasColumnName("APPROVE");

                entity.Property(e => e.Approvedate)
                    .HasColumnName("APPROVEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ataxexceptcode)
                    .HasColumnName("ATAXEXCEPTCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Ataxexceptreason)
                    .HasColumnName("ATAXEXCEPTREASON")
                    .HasMaxLength(201)
                    .IsUnicode(false);

                entity.Property(e => e.Branch).HasColumnName("BRANCH");

                entity.Property(e => e.Campaigncode)
                    .HasColumnName("CAMPAIGNCODE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cancelled).HasColumnName("CANCELLED");

                entity.Property(e => e.Cantcrededuct).HasColumnName("CANTCREDEDUCT");

                entity.Property(e => e.CapiblockCreadeddate)
                    .HasColumnName("CAPIBLOCK_CREADEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CapiblockCreatedby).HasColumnName("CAPIBLOCK_CREATEDBY");

                entity.Property(e => e.CapiblockCreatedhour).HasColumnName("CAPIBLOCK_CREATEDHOUR");

                entity.Property(e => e.CapiblockCreatedmin).HasColumnName("CAPIBLOCK_CREATEDMIN");

                entity.Property(e => e.CapiblockCreatedsec).HasColumnName("CAPIBLOCK_CREATEDSEC");

                entity.Property(e => e.CapiblockModifiedby).HasColumnName("CAPIBLOCK_MODIFIEDBY");

                entity.Property(e => e.CapiblockModifieddate)
                    .HasColumnName("CAPIBLOCK_MODIFIEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CapiblockModifiedhour).HasColumnName("CAPIBLOCK_MODIFIEDHOUR");

                entity.Property(e => e.CapiblockModifiedmin).HasColumnName("CAPIBLOCK_MODIFIEDMIN");

                entity.Property(e => e.CapiblockModifiedsec).HasColumnName("CAPIBLOCK_MODIFIEDSEC");

                entity.Property(e => e.Centerref).HasColumnName("CENTERREF");

                entity.Property(e => e.Checkamount).HasColumnName("CHECKAMOUNT");

                entity.Property(e => e.Checkprice).HasColumnName("CHECKPRICE");

                entity.Property(e => e.Checktotal).HasColumnName("CHECKTOTAL");

                entity.Property(e => e.Clientref).HasColumnName("CLIENTREF");

                entity.Property(e => e.Custordno)
                    .HasColumnName("CUSTORDNO")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Cyphcode)
                    .HasColumnName("CYPHCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE_")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deductionpart1).HasColumnName("DEDUCTIONPART1");

                entity.Property(e => e.Deductionpart2).HasColumnName("DEDUCTIONPART2");

                entity.Property(e => e.Defaultfiche).HasColumnName("DEFAULTFICHE");

                entity.Property(e => e.Deliverycode)
                    .HasColumnName("DELIVERYCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Department).HasColumnName("DEPARTMENT");

                entity.Property(e => e.Devir).HasColumnName("DEVIR");

                entity.Property(e => e.Dlvclient).HasColumnName("DLVCLIENT");

                entity.Property(e => e.Docode)
                    .HasColumnName("DOCODE")
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.Doctrackingnr)
                    .HasColumnName("DOCTRACKINGNR")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Einvoice).HasColumnName("EINVOICE");

                entity.Property(e => e.Einvoicetyp).HasColumnName("EINVOICETYP");

                entity.Property(e => e.Extenref).HasColumnName("EXTENREF");

                entity.Property(e => e.Factorynr).HasColumnName("FACTORYNR");

                entity.Property(e => e.Fcstatusref).HasColumnName("FCSTATUSREF");

                entity.Property(e => e.Ficheno)
                    .HasColumnName("FICHENO")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Genexctyp).HasColumnName("GENEXCTYP");

                entity.Property(e => e.Genexp1)
                    .HasColumnName("GENEXP1")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Genexp2)
                    .HasColumnName("GENEXP2")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Genexp3)
                    .HasColumnName("GENEXP3")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Genexp4)
                    .HasColumnName("GENEXP4")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Genexp5)
                    .HasColumnName("GENEXP5")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Genexp6)
                    .HasColumnName("GENEXP6")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Globalid)
                    .HasColumnName("GLOBALID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Grosstotal).HasColumnName("GROSSTOTAL");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasMaxLength(37)
                    .IsUnicode(false);

                entity.Property(e => e.Insteadofdesp).HasColumnName("INSTEADOFDESP");

                entity.Property(e => e.Lastrevision).HasColumnName("LASTREVISION");

                entity.Property(e => e.Leasingref).HasColumnName("LEASINGREF");

                entity.Property(e => e.Lineexctyp).HasColumnName("LINEEXCTYP");

                entity.Property(e => e.Nettotal).HasColumnName("NETTOTAL");

                entity.Property(e => e.Offaltref).HasColumnName("OFFALTREF");

                entity.Property(e => e.Offerref).HasColumnName("OFFERREF");

                entity.Property(e => e.Onlyonepayline).HasColumnName("ONLYONEPAYLINE");

                entity.Property(e => e.Opstat).HasColumnName("OPSTAT");

                entity.Property(e => e.Orglogicref).HasColumnName("ORGLOGICREF");

                entity.Property(e => e.Orglogoid)
                    .HasColumnName("ORGLOGOID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Paydefref).HasColumnName("PAYDEFREF");

                entity.Property(e => e.Paymenttype).HasColumnName("PAYMENTTYPE");

                entity.Property(e => e.Pofferbegdt)
                    .HasColumnName("POFFERBEGDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pofferenddt)
                    .HasColumnName("POFFERENDDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Printcnt).HasColumnName("PRINTCNT");

                entity.Property(e => e.Printdate)
                    .HasColumnName("PRINTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Projectref).HasColumnName("PROJECTREF");

                entity.Property(e => e.Publicbnaccref).HasColumnName("PUBLICBNACCREF");

                entity.Property(e => e.Rechash)
                    .HasColumnName("RECHASH")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recstatus).HasColumnName("RECSTATUS");

                entity.Property(e => e.Recvref).HasColumnName("RECVREF");

                entity.Property(e => e.Reportnet).HasColumnName("REPORTNET");

                entity.Property(e => e.Reportrate).HasColumnName("REPORTRATE");

                entity.Property(e => e.Revisnr)
                    .HasColumnName("REVISNR")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Salesmanref).HasColumnName("SALESMANREF");

                entity.Property(e => e.Sendcnt).HasColumnName("SENDCNT");

                entity.Property(e => e.Shipinforef).HasColumnName("SHIPINFOREF");

                entity.Property(e => e.Shpagncod)
                    .HasColumnName("SHPAGNCOD")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Shptypcod)
                    .HasColumnName("SHPTYPCOD")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Siteid).HasColumnName("SITEID");

                entity.Property(e => e.Slsactref).HasColumnName("SLSACTREF");

                entity.Property(e => e.Slscustref).HasColumnName("SLSCUSTREF");

                entity.Property(e => e.Slsopprref).HasColumnName("SLSOPPRREF");

                entity.Property(e => e.Sourcecostgrp).HasColumnName("SOURCECOSTGRP");

                entity.Property(e => e.Sourceindex).HasColumnName("SOURCEINDEX");

                entity.Property(e => e.Specode)
                    .HasColumnName("SPECODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Taxfreechx).HasColumnName("TAXFREECHX");

                entity.Property(e => e.Textinc).HasColumnName("TEXTINC");

                entity.Property(e => e.Time).HasColumnName("TIME_");

                entity.Property(e => e.Totaladdtax).HasColumnName("TOTALADDTAX");

                entity.Property(e => e.Totaldiscounted).HasColumnName("TOTALDISCOUNTED");

                entity.Property(e => e.Totaldiscounts).HasColumnName("TOTALDISCOUNTS");

                entity.Property(e => e.Totalexaddtax).HasColumnName("TOTALEXADDTAX");

                entity.Property(e => e.Totalexpenses).HasColumnName("TOTALEXPENSES");

                entity.Property(e => e.Totalexpensesvat).HasColumnName("TOTALEXPENSESVAT");

                entity.Property(e => e.Totalpromotions).HasColumnName("TOTALPROMOTIONS");

                entity.Property(e => e.Totalvat).HasColumnName("TOTALVAT");

                entity.Property(e => e.Tradinggrp)
                    .HasColumnName("TRADINGGRP")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Transferwithpay).HasColumnName("TRANSFERWITHPAY");

                entity.Property(e => e.Trcode).HasColumnName("TRCODE");

                entity.Property(e => e.Trcurr).HasColumnName("TRCURR");

                entity.Property(e => e.Trnet).HasColumnName("TRNET");

                entity.Property(e => e.Trrate).HasColumnName("TRRATE");

                entity.Property(e => e.Typ).HasColumnName("TYP");

                entity.Property(e => e.Updcurr).HasColumnName("UPDCURR");

                entity.Property(e => e.Updtrcurr).HasColumnName("UPDTRCURR");

                entity.Property(e => e.Vatexceptcode)
                    .HasColumnName("VATEXCEPTCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Vatexceptreason)
                    .HasColumnName("VATEXCEPTREASON")
                    .HasMaxLength(201)
                    .IsUnicode(false);

                entity.Property(e => e.Wflowcrdref).HasColumnName("WFLOWCRDREF");

                entity.Property(e => e.Wfstatus).HasColumnName("WFSTATUS");

                entity.Property(e => e.Withpaytrans).HasColumnName("WITHPAYTRANS");
            });

            modelBuilder.Entity<Lg00101Orfline>(entity =>
            {
                entity.HasKey(e => e.Logicalref)
                    .HasName("I001_01_ORFLINE_I1");

                entity.ToTable("LG_001_01_ORFLINE");

                entity.HasIndex(e => e.Bomrevref)
                    .HasName("I001_01_ORFLINE_I15");

                entity.HasIndex(e => e.Globalid)
                    .HasName("I001_01_ORFLINE_I12");

                entity.HasIndex(e => e.Guid)
                    .HasName("I001_01_ORFLINE_I13");

                entity.HasIndex(e => e.Prclistref)
                    .HasName("I001_01_ORFLINE_I11");

                entity.HasIndex(e => e.Uomref)
                    .HasName("I001_01_ORFLINE_I7");

                entity.HasIndex(e => new { e.Ordficheref, e.Lineno })
                    .HasName("I001_01_ORFLINE_I4");

                entity.HasIndex(e => new { e.Ordficheref, e.Parentlnref, e.Linetype })
                    .HasName("I001_01_ORFLINE_I14");

                entity.HasIndex(e => new { e.Ordficheref, e.Prevlineref, e.Prevlineno })
                    .HasName("I001_01_ORFLINE_I8");

                entity.HasIndex(e => new { e.Orglogicref, e.Logicalref, e.Siteid })
                    .HasName("I001_01_ORFLINE_I10")
                    .IsUnique();

                entity.HasIndex(e => new { e.Clientref, e.Date, e.Time, e.Trcode })
                    .HasName("I001_01_ORFLINE_I5");

                entity.HasIndex(e => new { e.Salesmanref, e.Stockref, e.Variantref, e.Trcode })
                    .HasName("I001_01_ORFLINE_I6");

                entity.HasIndex(e => new { e.Date, e.Time, e.Trcode, e.Stockref, e.Variantref, e.Ordficheref })
                    .HasName("I001_01_ORFLINE_I3");

                entity.HasIndex(e => new { e.Stockref, e.Variantref, e.Date, e.Time, e.Trcode, e.Ordficheref })
                    .HasName("I001_01_ORFLINE_I2");

                entity.Property(e => e.Logicalref).HasColumnName("LOGICALREF");

                entity.Property(e => e.Accountref).HasColumnName("ACCOUNTREF");

                entity.Property(e => e.Addtaxaccref).HasColumnName("ADDTAXACCREF");

                entity.Property(e => e.Addtaxamntisupd).HasColumnName("ADDTAXAMNTISUPD");

                entity.Property(e => e.Addtaxamount).HasColumnName("ADDTAXAMOUNT");

                entity.Property(e => e.Addtaxcenterref).HasColumnName("ADDTAXCENTERREF");

                entity.Property(e => e.Addtaxconvfact).HasColumnName("ADDTAXCONVFACT");

                entity.Property(e => e.Addtaxdiscamount).HasColumnName("ADDTAXDISCAMOUNT");

                entity.Property(e => e.Addtaxrate).HasColumnName("ADDTAXRATE");

                entity.Property(e => e.Addtaxvatmatrah).HasColumnName("ADDTAXVATMATRAH");

                entity.Property(e => e.Affectcollatrl).HasColumnName("AFFECTCOLLATRL");

                entity.Property(e => e.Affectrisk).HasColumnName("AFFECTRISK");

                entity.Property(e => e.Altpromflag).HasColumnName("ALTPROMFLAG");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Ataxexceptcode)
                    .HasColumnName("ATAXEXCEPTCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Ataxexceptreason)
                    .HasColumnName("ATAXEXCEPTREASON")
                    .HasMaxLength(201)
                    .IsUnicode(false);

                entity.Property(e => e.Billeditem).HasColumnName("BILLEDITEM");

                entity.Property(e => e.Bomref).HasColumnName("BOMREF");

                entity.Property(e => e.Bomrevref).HasColumnName("BOMREVREF");

                entity.Property(e => e.Bomtype).HasColumnName("BOMTYPE");

                entity.Property(e => e.Branch).HasColumnName("BRANCH");

                entity.Property(e => e.Calctype).HasColumnName("CALCTYPE");

                entity.Property(e => e.Campaignrefs1).HasColumnName("CAMPAIGNREFS1");

                entity.Property(e => e.Campaignrefs2).HasColumnName("CAMPAIGNREFS2");

                entity.Property(e => e.Campaignrefs3).HasColumnName("CAMPAIGNREFS3");

                entity.Property(e => e.Campaignrefs4).HasColumnName("CAMPAIGNREFS4");

                entity.Property(e => e.Campaignrefs5).HasColumnName("CAMPAIGNREFS5");

                entity.Property(e => e.Camppaydefref).HasColumnName("CAMPPAYDEFREF");

                entity.Property(e => e.Camppoint).HasColumnName("CAMPPOINT");

                entity.Property(e => e.Camppoints1).HasColumnName("CAMPPOINTS1");

                entity.Property(e => e.Camppoints2).HasColumnName("CAMPPOINTS2");

                entity.Property(e => e.Camppoints3).HasColumnName("CAMPPOINTS3");

                entity.Property(e => e.Camppoints4).HasColumnName("CAMPPOINTS4");

                entity.Property(e => e.Cancelled).HasColumnName("CANCELLED");

                entity.Property(e => e.Candeduct).HasColumnName("CANDEDUCT");

                entity.Property(e => e.Centerref).HasColumnName("CENTERREF");

                entity.Property(e => e.Clientref).HasColumnName("CLIENTREF");

                entity.Property(e => e.Closed).HasColumnName("CLOSED");

                entity.Property(e => e.Cmpglineref).HasColumnName("CMPGLINEREF");

                entity.Property(e => e.Cmpglinerefs1).HasColumnName("CMPGLINEREFS1");

                entity.Property(e => e.Cmpglinerefs2).HasColumnName("CMPGLINEREFS2");

                entity.Property(e => e.Cmpglinerefs3).HasColumnName("CMPGLINEREFS3");

                entity.Property(e => e.Cmpglinerefs4).HasColumnName("CMPGLINEREFS4");

                entity.Property(e => e.Conditionref).HasColumnName("CONDITIONREF");

                entity.Property(e => e.Cpacode)
                    .HasColumnName("CPACODE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cpstflag).HasColumnName("CPSTFLAG");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE_")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deductcode)
                    .HasColumnName("DEDUCTCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Deductionpart1).HasColumnName("DEDUCTIONPART1");

                entity.Property(e => e.Deductionpart2).HasColumnName("DEDUCTIONPART2");

                entity.Property(e => e.Delvrycode)
                    .HasColumnName("DELVRYCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Demficheref).HasColumnName("DEMFICHEREF");

                entity.Property(e => e.Dempeggedamnt).HasColumnName("DEMPEGGEDAMNT");

                entity.Property(e => e.Demtransref).HasColumnName("DEMTRANSREF");

                entity.Property(e => e.Department).HasColumnName("DEPARTMENT");

                entity.Property(e => e.Detline).HasColumnName("DETLINE");

                entity.Property(e => e.Devir).HasColumnName("DEVIR");

                entity.Property(e => e.Discper).HasColumnName("DISCPER");

                entity.Property(e => e.Distcost).HasColumnName("DISTCOST");

                entity.Property(e => e.Distdisc).HasColumnName("DISTDISC");

                entity.Property(e => e.Distexp).HasColumnName("DISTEXP");

                entity.Property(e => e.Distexpvat).HasColumnName("DISTEXPVAT");

                entity.Property(e => e.Distprom).HasColumnName("DISTPROM");

                entity.Property(e => e.Distreserved).HasColumnName("DISTRESERVED");

                entity.Property(e => e.Doreserve).HasColumnName("DORESERVE");

                entity.Property(e => e.Dref).HasColumnName("DREF");

                entity.Property(e => e.Duedate)
                    .HasColumnName("DUEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euvatstatus).HasColumnName("EUVATSTATUS");

                entity.Property(e => e.Exaddtaxamnt).HasColumnName("EXADDTAXAMNT");

                entity.Property(e => e.Exaddtaxconvf).HasColumnName("EXADDTAXCONVF");

                entity.Property(e => e.Exaddtaxrate).HasColumnName("EXADDTAXRATE");

                entity.Property(e => e.Eximamount).HasColumnName("EXIMAMOUNT");

                entity.Property(e => e.Extenref).HasColumnName("EXTENREF");

                entity.Property(e => e.Factorynr).HasColumnName("FACTORYNR");

                entity.Property(e => e.Faregref).HasColumnName("FAREGREF");

                entity.Property(e => e.Fctyp).HasColumnName("FCTYP");

                entity.Property(e => e.Globalid)
                    .HasColumnName("GLOBALID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Globtrans).HasColumnName("GLOBTRANS");

                entity.Property(e => e.Grossuinfo1).HasColumnName("GROSSUINFO1");

                entity.Property(e => e.Grossuinfo2).HasColumnName("GROSSUINFO2");

                entity.Property(e => e.Gtipcode)
                    .HasColumnName("GTIPCODE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasMaxLength(37)
                    .IsUnicode(false);

                entity.Property(e => e.Inuse).HasColumnName("INUSE");

                entity.Property(e => e.Itemasgref).HasColumnName("ITEMASGREF");

                entity.Property(e => e.Lineexp)
                    .HasColumnName("LINEEXP")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Linenet).HasColumnName("LINENET");

                entity.Property(e => e.Lineno).HasColumnName("LINENO_");

                entity.Property(e => e.Linetype).HasColumnName("LINETYPE");

                entity.Property(e => e.Netdiscamnt).HasColumnName("NETDISCAMNT");

                entity.Property(e => e.Netdiscflag).HasColumnName("NETDISCFLAG");

                entity.Property(e => e.Netdiscperc).HasColumnName("NETDISCPERC");

                entity.Property(e => e.Offerref).HasColumnName("OFFERREF");

                entity.Property(e => e.Offtransref).HasColumnName("OFFTRANSREF");

                entity.Property(e => e.Onvehicle).HasColumnName("ONVEHICLE");

                entity.Property(e => e.Operationref).HasColumnName("OPERATIONREF");

                entity.Property(e => e.Orderedamount).HasColumnName("ORDEREDAMOUNT");

                entity.Property(e => e.Orderparam).HasColumnName("ORDERPARAM");

                entity.Property(e => e.Ordficheref).HasColumnName("ORDFICHEREF");

                entity.Property(e => e.Orgamount).HasColumnName("ORGAMOUNT");

                entity.Property(e => e.Orgduedate)
                    .HasColumnName("ORGDUEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Orglogicref).HasColumnName("ORGLOGICREF");

                entity.Property(e => e.Orglogoid)
                    .HasColumnName("ORGLOGOID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Orgprice).HasColumnName("ORGPRICE");

                entity.Property(e => e.Parentlnref).HasColumnName("PARENTLNREF");

                entity.Property(e => e.Paydefref).HasColumnName("PAYDEFREF");

                entity.Property(e => e.Pointcampref).HasColumnName("POINTCAMPREF");

                entity.Property(e => e.Pointcamprefs1).HasColumnName("POINTCAMPREFS1");

                entity.Property(e => e.Pointcamprefs2).HasColumnName("POINTCAMPREFS2");

                entity.Property(e => e.Pointcamprefs3).HasColumnName("POINTCAMPREFS3");

                entity.Property(e => e.Pointcamprefs4).HasColumnName("POINTCAMPREFS4");

                entity.Property(e => e.Praccref).HasColumnName("PRACCREF");

                entity.Property(e => e.Prcenterref).HasColumnName("PRCENTERREF");

                entity.Property(e => e.Prclistref).HasColumnName("PRCLISTREF");

                entity.Property(e => e.Prcurr).HasColumnName("PRCURR");

                entity.Property(e => e.Prevlineno).HasColumnName("PREVLINENO");

                entity.Property(e => e.Prevlineref).HasColumnName("PREVLINEREF");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Projectref).HasColumnName("PROJECTREF");

                entity.Property(e => e.Promclasitemref).HasColumnName("PROMCLASITEMREF");

                entity.Property(e => e.Promref).HasColumnName("PROMREF");

                entity.Property(e => e.Prprice).HasColumnName("PRPRICE");

                entity.Property(e => e.Prrate).HasColumnName("PRRATE");

                entity.Property(e => e.Prvataccref).HasColumnName("PRVATACCREF");

                entity.Property(e => e.Prvatcenref).HasColumnName("PRVATCENREF");

                entity.Property(e => e.Publiccountryref).HasColumnName("PUBLICCOUNTRYREF");

                entity.Property(e => e.Purchoffnr).HasColumnName("PURCHOFFNR");

                entity.Property(e => e.Reasonfornotshp).HasColumnName("REASONFORNOTSHP");

                entity.Property(e => e.Recstatus).HasColumnName("RECSTATUS");

                entity.Property(e => e.Reflvataccref).HasColumnName("REFLVATACCREF");

                entity.Property(e => e.Reflvatothaccref).HasColumnName("REFLVATOTHACCREF");

                entity.Property(e => e.Reportrate).HasColumnName("REPORTRATE");

                entity.Property(e => e.Reserveamount).HasColumnName("RESERVEAMOUNT");

                entity.Property(e => e.Reservedate)
                    .HasColumnName("RESERVEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Routingref).HasColumnName("ROUTINGREF");

                entity.Property(e => e.Rprice).HasColumnName("RPRICE");

                entity.Property(e => e.Salesmanref).HasColumnName("SALESMANREF");

                entity.Property(e => e.Shippedamntsugg).HasColumnName("SHIPPEDAMNTSUGG");

                entity.Property(e => e.Shippedamount).HasColumnName("SHIPPEDAMOUNT");

                entity.Property(e => e.Siteid).HasColumnName("SITEID");

                entity.Property(e => e.Sourcecostgrp).HasColumnName("SOURCECOSTGRP");

                entity.Property(e => e.Sourceindex).HasColumnName("SOURCEINDEX");

                entity.Property(e => e.Specode)
                    .HasColumnName("SPECODE")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Specode2)
                    .HasColumnName("SPECODE2")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Stockref).HasColumnName("STOCKREF");

                entity.Property(e => e.Textinc).HasColumnName("TEXTINC");

                entity.Property(e => e.Time).HasColumnName("TIME_");

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.Trcode).HasColumnName("TRCODE");

                entity.Property(e => e.Trcurr).HasColumnName("TRCURR");

                entity.Property(e => e.Trgflag).HasColumnName("TRGFLAG");

                entity.Property(e => e.Trrate).HasColumnName("TRRATE");

                entity.Property(e => e.Uinfo1).HasColumnName("UINFO1");

                entity.Property(e => e.Uinfo2).HasColumnName("UINFO2");

                entity.Property(e => e.Uinfo3).HasColumnName("UINFO3");

                entity.Property(e => e.Uinfo4).HasColumnName("UINFO4");

                entity.Property(e => e.Uinfo5).HasColumnName("UINFO5");

                entity.Property(e => e.Uinfo6).HasColumnName("UINFO6");

                entity.Property(e => e.Uinfo7).HasColumnName("UINFO7");

                entity.Property(e => e.Uinfo8).HasColumnName("UINFO8");

                entity.Property(e => e.Underdeductlimit).HasColumnName("UNDERDEDUCTLIMIT");

                entity.Property(e => e.Uomref).HasColumnName("UOMREF");

                entity.Property(e => e.Usref).HasColumnName("USREF");

                entity.Property(e => e.Variantref).HasColumnName("VARIANTREF");

                entity.Property(e => e.Vat).HasColumnName("VAT");

                entity.Property(e => e.Vataccref).HasColumnName("VATACCREF");

                entity.Property(e => e.Vatamnt).HasColumnName("VATAMNT");

                entity.Property(e => e.Vatcenterref).HasColumnName("VATCENTERREF");

                entity.Property(e => e.Vatexceptcode)
                    .HasColumnName("VATEXCEPTCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Vatexceptreason)
                    .HasColumnName("VATEXCEPTREASON")
                    .HasMaxLength(201)
                    .IsUnicode(false);

                entity.Property(e => e.Vatinc).HasColumnName("VATINC");

                entity.Property(e => e.Vatmatrah).HasColumnName("VATMATRAH");

                entity.Property(e => e.Wfstatus).HasColumnName("WFSTATUS");

                entity.Property(e => e.Withpaytrans).HasColumnName("WITHPAYTRANS");

                entity.Property(e => e.Wsref).HasColumnName("WSREF");
            });


            modelBuilder.Entity<Lg001Items>(entity =>
            {
                entity.HasKey(e => e.Logicalref)
                    .HasName("I001_ITEMS_I1");

                entity.ToTable("LG_001_ITEMS");

                entity.HasIndex(e => e.Code)
                    .HasName("I001_ITEMS_I2")
                    .IsUnique();

                entity.HasIndex(e => e.Dominantrefs5)
                    .HasName("I001_ITEMS_I18");

                entity.HasIndex(e => e.Globalid)
                    .HasName("I001_ITEMS_I23");

                entity.HasIndex(e => e.Guid)
                    .HasName("I001_ITEMS_I24");

                entity.HasIndex(e => e.Logoid)
                    .HasName("I001_ITEMS_I15");

                entity.HasIndex(e => e.Name)
                    .HasName("I001_ITEMS_I3");

                entity.HasIndex(e => e.Producercode)
                    .HasName("I001_ITEMS_I4");

                entity.HasIndex(e => e.Stgrpcode)
                    .HasName("I001_ITEMS_I5");

                entity.HasIndex(e => e.Unitsetref)
                    .HasName("I001_ITEMS_I11");

                entity.HasIndex(e => new { e.Active, e.Cardtype })
                    .HasName("I001_ITEMS_I20");

                entity.HasIndex(e => new { e.Active, e.Code })
                    .HasName("I001_ITEMS_I16");

                entity.HasIndex(e => new { e.Active, e.Name })
                    .HasName("I001_ITEMS_I17");

                entity.HasIndex(e => new { e.Cardtype, e.Dominantrefs5 })
                    .HasName("I001_ITEMS_I19");

                entity.HasIndex(e => new { e.Classtype, e.Active, e.Code })
                    .HasName("I001_ITEMS_I6");

                entity.HasIndex(e => new { e.Classtype, e.Active, e.Name })
                    .HasName("I001_ITEMS_I7");

                entity.HasIndex(e => new { e.Classtype, e.Dominantrefs5, e.Logicalref })
                    .HasName("I001_ITEMS_I21")
                    .IsUnique();

                entity.HasIndex(e => new { e.Mtrlbrws, e.Classtype, e.Active, e.Code })
                    .HasName("I001_ITEMS_I10");

                entity.HasIndex(e => new { e.Mtrlbrws, e.Classtype, e.Active, e.Name })
                    .HasName("I001_ITEMS_I14");

                entity.HasIndex(e => new { e.Purchbrws, e.Classtype, e.Active, e.Code })
                    .HasName("I001_ITEMS_I8");

                entity.HasIndex(e => new { e.Purchbrws, e.Classtype, e.Active, e.Name })
                    .HasName("I001_ITEMS_I12");

                entity.HasIndex(e => new { e.Salesbrws, e.Classtype, e.Active, e.Code })
                    .HasName("I001_ITEMS_I9");

                entity.HasIndex(e => new { e.Salesbrws, e.Classtype, e.Active, e.Name })
                    .HasName("I001_ITEMS_I13");

                entity.HasIndex(e => new { e.Lowlevelcodes1, e.Lowlevelcodes2, e.Lowlevelcodes3, e.Lowlevelcodes4, e.Lowlevelcodes5, e.Lowlevelcodes6, e.Lowlevelcodes7, e.Logicalref })
                    .HasName("I001_ITEMS_I22")
                    .IsUnique();

                entity.Property(e => e.Logicalref).HasColumnName("LOGICALREF");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Addtaxref).HasColumnName("ADDTAXREF");

                entity.Property(e => e.Approve).HasColumnName("APPROVE");

                entity.Property(e => e.Approved).HasColumnName("APPROVED");

                entity.Property(e => e.Approvedate)
                    .HasColumnName("APPROVEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Appspevatmatrah).HasColumnName("APPSPEVATMATRAH");

                entity.Property(e => e.Autoincsl).HasColumnName("AUTOINCSL");

                entity.Property(e => e.Avrwhduration).HasColumnName("AVRWHDURATION");

                entity.Property(e => e.B2ccode)
                    .HasColumnName("B2CCODE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Camppoint).HasColumnName("CAMPPOINT");

                entity.Property(e => e.Canconfigure).HasColumnName("CANCONFIGURE");

                entity.Property(e => e.Candeduct).HasColumnName("CANDEDUCT");

                entity.Property(e => e.Canuseintrns).HasColumnName("CANUSEINTRNS");

                entity.Property(e => e.CapiblockCreadeddate)
                    .HasColumnName("CAPIBLOCK_CREADEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CapiblockCreatedby).HasColumnName("CAPIBLOCK_CREATEDBY");

                entity.Property(e => e.CapiblockCreatedhour).HasColumnName("CAPIBLOCK_CREATEDHOUR");

                entity.Property(e => e.CapiblockCreatedmin).HasColumnName("CAPIBLOCK_CREATEDMIN");

                entity.Property(e => e.CapiblockCreatedsec).HasColumnName("CAPIBLOCK_CREATEDSEC");

                entity.Property(e => e.CapiblockModifiedby).HasColumnName("CAPIBLOCK_MODIFIEDBY");

                entity.Property(e => e.CapiblockModifieddate)
                    .HasColumnName("CAPIBLOCK_MODIFIEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CapiblockModifiedhour).HasColumnName("CAPIBLOCK_MODIFIEDHOUR");

                entity.Property(e => e.CapiblockModifiedmin).HasColumnName("CAPIBLOCK_MODIFIEDMIN");

                entity.Property(e => e.CapiblockModifiedsec).HasColumnName("CAPIBLOCK_MODIFIEDSEC");

                entity.Property(e => e.Cardtype).HasColumnName("CARDTYPE");

                entity.Property(e => e.Categoryid)
                    .HasColumnName("CATEGORYID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Categoryname)
                    .HasColumnName("CATEGORYNAME")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Charsetref).HasColumnName("CHARSETREF");

                entity.Property(e => e.Classtype).HasColumnName("CLASSTYPE");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Comblotunits).HasColumnName("COMBLOTUNITS");

                entity.Property(e => e.Compkdvuse).HasColumnName("COMPKDVUSE");

                entity.Property(e => e.Conscoderef).HasColumnName("CONSCODEREF");

                entity.Property(e => e.Cpacode)
                    .HasColumnName("CPACODE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cyphcode)
                    .HasColumnName("CYPHCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Deductcode)
                    .HasColumnName("DEDUCTCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Demandmeetsortfld1)
                    .HasColumnName("DEMANDMEETSORTFLD1")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Demandmeetsortfld2)
                    .HasColumnName("DEMANDMEETSORTFLD2")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Demandmeetsortfld3)
                    .HasColumnName("DEMANDMEETSORTFLD3")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Demandmeetsortfld4)
                    .HasColumnName("DEMANDMEETSORTFLD4")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Demandmeetsortfld5)
                    .HasColumnName("DEMANDMEETSORTFLD5")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Deprclasstype)
                    .HasColumnName("DEPRCLASSTYPE")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Deprdur).HasColumnName("DEPRDUR");

                entity.Property(e => e.Deprdur2).HasColumnName("DEPRDUR2");

                entity.Property(e => e.Deprrate).HasColumnName("DEPRRATE");

                entity.Property(e => e.Deprrate2).HasColumnName("DEPRRATE2");

                entity.Property(e => e.Deprtype).HasColumnName("DEPRTYPE");

                entity.Property(e => e.Deprtype2).HasColumnName("DEPRTYPE2");

                entity.Property(e => e.Distamount).HasColumnName("DISTAMOUNT");

                entity.Property(e => e.Distlotunits).HasColumnName("DISTLOTUNITS");

                entity.Property(e => e.Distpoint).HasColumnName("DISTPOINT");

                entity.Property(e => e.Divlotsize).HasColumnName("DIVLOTSIZE");

                entity.Property(e => e.Dominantrefs1).HasColumnName("DOMINANTREFS1");

                entity.Property(e => e.Dominantrefs10).HasColumnName("DOMINANTREFS10");

                entity.Property(e => e.Dominantrefs11).HasColumnName("DOMINANTREFS11");

                entity.Property(e => e.Dominantrefs12).HasColumnName("DOMINANTREFS12");

                entity.Property(e => e.Dominantrefs2).HasColumnName("DOMINANTREFS2");

                entity.Property(e => e.Dominantrefs3).HasColumnName("DOMINANTREFS3");

                entity.Property(e => e.Dominantrefs4).HasColumnName("DOMINANTREFS4");

                entity.Property(e => e.Dominantrefs5).HasColumnName("DOMINANTREFS5");

                entity.Property(e => e.Dominantrefs6).HasColumnName("DOMINANTREFS6");

                entity.Property(e => e.Dominantrefs7).HasColumnName("DOMINANTREFS7");

                entity.Property(e => e.Dominantrefs8).HasColumnName("DOMINANTREFS8");

                entity.Property(e => e.Dominantrefs9).HasColumnName("DOMINANTREFS9");

                entity.Property(e => e.Eanbarcode)
                    .HasColumnName("EANBARCODE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Eximtax1).HasColumnName("EXIMTAX1");

                entity.Property(e => e.Eximtax2).HasColumnName("EXIMTAX2");

                entity.Property(e => e.Eximtax3).HasColumnName("EXIMTAX3");

                entity.Property(e => e.Eximtax4).HasColumnName("EXIMTAX4");

                entity.Property(e => e.Eximtax5).HasColumnName("EXIMTAX5");

                entity.Property(e => e.Expcategory)
                    .HasColumnName("EXPCATEGORY")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Expctgno)
                    .HasColumnName("EXPCTGNO")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Expense).HasColumnName("EXPENSE");

                entity.Property(e => e.Extaccessflags).HasColumnName("EXTACCESSFLAGS");

                entity.Property(e => e.Extcardflags).HasColumnName("EXTCARDFLAGS");

                entity.Property(e => e.Facostkeys).HasColumnName("FACOSTKEYS");

                entity.Property(e => e.Fausefullifecode)
                    .HasColumnName("FAUSEFULLIFECODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Fausefullifecode2)
                    .HasColumnName("FAUSEFULLIFECODE2")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Freightplace)
                    .HasColumnName("FREIGHTPLACE")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Freighttypcode1)
                    .HasColumnName("FREIGHTTYPCODE1")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Freighttypcode10)
                    .HasColumnName("FREIGHTTYPCODE10")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Freighttypcode2)
                    .HasColumnName("FREIGHTTYPCODE2")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Freighttypcode3)
                    .HasColumnName("FREIGHTTYPCODE3")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Freighttypcode4)
                    .HasColumnName("FREIGHTTYPCODE4")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Freighttypcode5)
                    .HasColumnName("FREIGHTTYPCODE5")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Freighttypcode6)
                    .HasColumnName("FREIGHTTYPCODE6")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Freighttypcode7)
                    .HasColumnName("FREIGHTTYPCODE7")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Freighttypcode8)
                    .HasColumnName("FREIGHTTYPCODE8")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Freighttypcode9)
                    .HasColumnName("FREIGHTTYPCODE9")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Globalid)
                    .HasColumnName("GLOBALID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Groupnr)
                    .HasColumnName("GROUPNR")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Gtipcode)
                    .HasColumnName("GTIPCODE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasMaxLength(37)
                    .IsUnicode(false);

                entity.Property(e => e.Image2inc).HasColumnName("IMAGE2INC");

                entity.Property(e => e.Imageinc).HasColumnName("IMAGEINC");

                entity.Property(e => e.Isonr)
                    .HasColumnName("ISONR")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Keyword1)
                    .HasColumnName("KEYWORD1")
                    .HasMaxLength(121)
                    .IsUnicode(false);

                entity.Property(e => e.Keyword2)
                    .HasColumnName("KEYWORD2")
                    .HasMaxLength(121)
                    .IsUnicode(false);

                entity.Property(e => e.Keyword3)
                    .HasColumnName("KEYWORD3")
                    .HasMaxLength(121)
                    .IsUnicode(false);

                entity.Property(e => e.Keyword4)
                    .HasColumnName("KEYWORD4")
                    .HasMaxLength(121)
                    .IsUnicode(false);

                entity.Property(e => e.Keyword5)
                    .HasColumnName("KEYWORD5")
                    .HasMaxLength(121)
                    .IsUnicode(false);

                entity.Property(e => e.Kklinesdisable).HasColumnName("KKLINESDISABLE");

                entity.Property(e => e.Lidconfirmed).HasColumnName("LIDCONFIRMED");

                entity.Property(e => e.Loctracking).HasColumnName("LOCTRACKING");

                entity.Property(e => e.Logoid)
                    .HasColumnName("LOGOID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Lostfactor).HasColumnName("LOSTFACTOR");

                entity.Property(e => e.Lowlevelcodes1).HasColumnName("LOWLEVELCODES1");

                entity.Property(e => e.Lowlevelcodes10).HasColumnName("LOWLEVELCODES10");

                entity.Property(e => e.Lowlevelcodes2).HasColumnName("LOWLEVELCODES2");

                entity.Property(e => e.Lowlevelcodes3).HasColumnName("LOWLEVELCODES3");

                entity.Property(e => e.Lowlevelcodes4).HasColumnName("LOWLEVELCODES4");

                entity.Property(e => e.Lowlevelcodes5).HasColumnName("LOWLEVELCODES5");

                entity.Property(e => e.Lowlevelcodes6).HasColumnName("LOWLEVELCODES6");

                entity.Property(e => e.Lowlevelcodes7).HasColumnName("LOWLEVELCODES7");

                entity.Property(e => e.Lowlevelcodes8).HasColumnName("LOWLEVELCODES8");

                entity.Property(e => e.Lowlevelcodes9).HasColumnName("LOWLEVELCODES9");

                entity.Property(e => e.Markref).HasColumnName("MARKREF");

                entity.Property(e => e.Minordamount).HasColumnName("MINORDAMOUNT");

                entity.Property(e => e.Mold).HasColumnName("MOLD");

                entity.Property(e => e.Moldfactor).HasColumnName("MOLDFACTOR");

                entity.Property(e => e.Moldlifeasratio).HasColumnName("MOLDLIFEASRATIO");

                entity.Property(e => e.Moldlifetracktype).HasColumnName("MOLDLIFETRACKTYPE");

                entity.Property(e => e.Moldmaintlife).HasColumnName("MOLDMAINTLIFE");

                entity.Property(e => e.Moldmaintlifetype).HasColumnName("MOLDMAINTLIFETYPE");

                entity.Property(e => e.Moldmaintnumber).HasColumnName("MOLDMAINTNUMBER");

                entity.Property(e => e.Moldusagelife).HasColumnName("MOLDUSAGELIFE");

                entity.Property(e => e.Mtrlbrws).HasColumnName("MTRLBRWS");

                entity.Property(e => e.Multiaddtax).HasColumnName("MULTIADDTAX");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Name2)
                    .HasColumnName("NAME2")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Name3)
                    .HasColumnName("NAME3")
                    .HasMaxLength(201)
                    .IsUnicode(false);

                entity.Property(e => e.Name4)
                    .HasColumnName("NAME4")
                    .HasMaxLength(201)
                    .IsUnicode(false);

                entity.Property(e => e.Orglogicref).HasColumnName("ORGLOGICREF");

                entity.Property(e => e.Orglogoid)
                    .HasColumnName("ORGLOGOID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Origin)
                    .HasColumnName("ORIGIN")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Packet).HasColumnName("PACKET");

                entity.Property(e => e.Partdep).HasColumnName("PARTDEP");

                entity.Property(e => e.Partdep2).HasColumnName("PARTDEP2");

                entity.Property(e => e.Paymentref).HasColumnName("PAYMENTREF");

                entity.Property(e => e.Pordamnttolerance).HasColumnName("PORDAMNTTOLERANCE");

                entity.Property(e => e.Prodcountry)
                    .HasColumnName("PRODCOUNTRY")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Producercode)
                    .HasColumnName("PRODUCERCODE")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Productlevel).HasColumnName("PRODUCTLEVEL");

                entity.Property(e => e.Projectref).HasColumnName("PROJECTREF");

                entity.Property(e => e.Publiccountryref).HasColumnName("PUBLICCOUNTRYREF");

                entity.Property(e => e.Purcdeductpart1).HasColumnName("PURCDEDUCTPART1");

                entity.Property(e => e.Purcdeductpart2).HasColumnName("PURCDEDUCTPART2");

                entity.Property(e => e.Purchbrws).HasColumnName("PURCHBRWS");

                entity.Property(e => e.Qccsetref).HasColumnName("QCCSETREF");

                entity.Property(e => e.Qprodamnt).HasColumnName("QPRODAMNT");

                entity.Property(e => e.Qproddepart).HasColumnName("QPRODDEPART");

                entity.Property(e => e.Qprodsrcindex).HasColumnName("QPRODSRCINDEX");

                entity.Property(e => e.Qprodsubamnt).HasColumnName("QPRODSUBAMNT");

                entity.Property(e => e.Qprodsubdepart).HasColumnName("QPRODSUBDEPART");

                entity.Property(e => e.Qprodsubsrcindex).HasColumnName("QPRODSUBSRCINDEX");

                entity.Property(e => e.Qprodsubuom).HasColumnName("QPRODSUBUOM");

                entity.Property(e => e.Qproduom).HasColumnName("QPRODUOM");

                entity.Property(e => e.Recstatus).HasColumnName("RECSTATUS");

                entity.Property(e => e.Returnprvat).HasColumnName("RETURNPRVAT");

                entity.Property(e => e.Returnvat).HasColumnName("RETURNVAT");

                entity.Property(e => e.Revalflag).HasColumnName("REVALFLAG");

                entity.Property(e => e.Revalflag2).HasColumnName("REVALFLAG2");

                entity.Property(e => e.Revdeprflag).HasColumnName("REVDEPRFLAG");

                entity.Property(e => e.Revdeprflag2).HasColumnName("REVDEPRFLAG2");

                entity.Property(e => e.Saledeductpart1).HasColumnName("SALEDEDUCTPART1");

                entity.Property(e => e.Saledeductpart2).HasColumnName("SALEDEDUCTPART2");

                entity.Property(e => e.Salesbrws).HasColumnName("SALESBRWS");

                entity.Property(e => e.Salvageval).HasColumnName("SALVAGEVAL");

                entity.Property(e => e.Salvageval2).HasColumnName("SALVAGEVAL2");

                entity.Property(e => e.Sellprvat).HasColumnName("SELLPRVAT");

                entity.Property(e => e.Sellvat).HasColumnName("SELLVAT");

                entity.Property(e => e.Shelfdate).HasColumnName("SHELFDATE");

                entity.Property(e => e.Shelflife).HasColumnName("SHELFLIFE");

                entity.Property(e => e.Siteid).HasColumnName("SITEID");

                entity.Property(e => e.Sordamnttolerance).HasColumnName("SORDAMNTTOLERANCE");

                entity.Property(e => e.Specode)
                    .HasColumnName("SPECODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Specode2)
                    .HasColumnName("SPECODE2")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Specode3)
                    .HasColumnName("SPECODE3")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Specode4)
                    .HasColumnName("SPECODE4")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Specode5)
                    .HasColumnName("SPECODE5")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Statecode)
                    .HasColumnName("STATECODE")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Statename)
                    .HasColumnName("STATENAME")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.Stgrpcode)
                    .HasColumnName("STGRPCODE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Textinc).HasColumnName("TEXTINC");

                entity.Property(e => e.Textinceng).HasColumnName("TEXTINCENG");

                entity.Property(e => e.Tool).HasColumnName("TOOL");

                entity.Property(e => e.Tracktype).HasColumnName("TRACKTYPE");

                entity.Property(e => e.Unitsetref).HasColumnName("UNITSETREF");

                entity.Property(e => e.Univid)
                    .HasColumnName("UNIVID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Usedinperiods).HasColumnName("USEDINPERIODS");

                entity.Property(e => e.Vat).HasColumnName("VAT");

                entity.Property(e => e.Wflowcrdref).HasColumnName("WFLOWCRDREF");

                entity.Property(e => e.Wfstatus).HasColumnName("WFSTATUS");
            });

            modelBuilder.Entity<Lg001Clcard>(entity =>
            {
                entity.HasKey(e => e.Logicalref)
                    .HasName("I001_CLCARD_I1");

                entity.ToTable("LG_001_CLCARD");

                entity.HasIndex(e => e.Code)
                    .HasName("I001_CLCARD_I2")
                    .IsUnique();

                entity.HasIndex(e => e.Definition)
                    .HasName("I001_CLCARD_I3");

                entity.HasIndex(e => e.Globalid)
                    .HasName("I001_CLCARD_I22");

                entity.HasIndex(e => e.Guid)
                    .HasName("I001_CLCARD_I23");

                entity.HasIndex(e => e.Logoid)
                    .HasName("I001_CLCARD_I6");

                entity.HasIndex(e => e.Taxnr)
                    .HasName("I001_CLCARD_I21");

                entity.HasIndex(e => new { e.Active, e.Cardtype })
                    .HasName("I001_CLCARD_I8");

                entity.HasIndex(e => new { e.Active, e.Code })
                    .HasName("I001_CLCARD_I4")
                    .IsUnique();

                entity.HasIndex(e => new { e.Active, e.Definition })
                    .HasName("I001_CLCARD_I5");

                entity.HasIndex(e => new { e.Cardtype, e.Parentclref })
                    .HasName("I001_CLCARD_I7");

                entity.HasIndex(e => new { e.Expbrws, e.Active, e.Code })
                    .HasName("I001_CLCARD_I13")
                    .IsUnique();

                entity.HasIndex(e => new { e.Expbrws, e.Active, e.Definition })
                    .HasName("I001_CLCARD_I18");

                entity.HasIndex(e => new { e.Finbrws, e.Active, e.Code })
                    .HasName("I001_CLCARD_I14")
                    .IsUnique();

                entity.HasIndex(e => new { e.Finbrws, e.Active, e.Definition })
                    .HasName("I001_CLCARD_I19");

                entity.HasIndex(e => new { e.Impbrws, e.Active, e.Code })
                    .HasName("I001_CLCARD_I12")
                    .IsUnique();

                entity.HasIndex(e => new { e.Impbrws, e.Active, e.Definition })
                    .HasName("I001_CLCARD_I17");

                entity.HasIndex(e => new { e.Purchbrws, e.Active, e.Code })
                    .HasName("I001_CLCARD_I10")
                    .IsUnique();

                entity.HasIndex(e => new { e.Purchbrws, e.Active, e.Definition })
                    .HasName("I001_CLCARD_I15");

                entity.HasIndex(e => new { e.Salesbrws, e.Active, e.Code })
                    .HasName("I001_CLCARD_I11")
                    .IsUnique();

                entity.HasIndex(e => new { e.Salesbrws, e.Active, e.Definition })
                    .HasName("I001_CLCARD_I16");

                entity.HasIndex(e => new { e.Active, e.Cardtype, e.Recstatus, e.Storecreditcardno })
                    .HasName("I001_CLCARD_I20");

                entity.HasIndex(e => new { e.Lowlevelcodes1, e.Lowlevelcodes2, e.Lowlevelcodes3, e.Lowlevelcodes4, e.Lowlevelcodes5, e.Lowlevelcodes6, e.Lowlevelcodes7, e.Logicalref })
                    .HasName("I001_CLCARD_I9")
                    .IsUnique();

                entity.HasIndex(e => new { e.Logicalref, e.Code, e.Definition, e.Isperscomp, e.Taxnr, e.Tckno, e.Postlabelcode, e.Senderlabelcode, e.Accepteinv, e.Profileid })
                    .HasName("DLG_001_CLCARD_IDX1");

                entity.Property(e => e.Logicalref).HasColumnName("LOGICALREF");

                entity.Property(e => e.Acceptedesp).HasColumnName("ACCEPTEDESP");

                entity.Property(e => e.Accepteinv).HasColumnName("ACCEPTEINV");

                entity.Property(e => e.Accepteinvpublic).HasColumnName("ACCEPTEINVPUBLIC");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Addr1)
                    .HasColumnName("ADDR1")
                    .HasMaxLength(201)
                    .IsUnicode(false);

                entity.Property(e => e.Addr2)
                    .HasColumnName("ADDR2")
                    .HasMaxLength(201)
                    .IsUnicode(false);

                entity.Property(e => e.Addtoreflist).HasColumnName("ADDTOREFLIST");

                entity.Property(e => e.Adressno)
                    .HasColumnName("ADRESSNO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Appleid)
                    .HasColumnName("APPLEID")
                    .HasMaxLength(121)
                    .IsUnicode(false);

                entity.Property(e => e.Arpquoteinc).HasColumnName("ARPQUOTEINC");

                entity.Property(e => e.Autopaidbank)
                    .HasColumnName("AUTOPAIDBANK")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Bankaccounts1)
                    .HasColumnName("BANKACCOUNTS1")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankaccounts2)
                    .HasColumnName("BANKACCOUNTS2")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankaccounts3)
                    .HasColumnName("BANKACCOUNTS3")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankaccounts4)
                    .HasColumnName("BANKACCOUNTS4")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankaccounts5)
                    .HasColumnName("BANKACCOUNTS5")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankaccounts6)
                    .HasColumnName("BANKACCOUNTS6")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankaccounts7)
                    .HasColumnName("BANKACCOUNTS7")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbcurrency1)
                    .HasColumnName("BANKBCURRENCY1")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbcurrency2)
                    .HasColumnName("BANKBCURRENCY2")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbcurrency3)
                    .HasColumnName("BANKBCURRENCY3")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbcurrency4)
                    .HasColumnName("BANKBCURRENCY4")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbcurrency5)
                    .HasColumnName("BANKBCURRENCY5")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbcurrency6)
                    .HasColumnName("BANKBCURRENCY6")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbcurrency7)
                    .HasColumnName("BANKBCURRENCY7")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbics1)
                    .HasColumnName("BANKBICS1")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbics2)
                    .HasColumnName("BANKBICS2")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbics3)
                    .HasColumnName("BANKBICS3")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbics4)
                    .HasColumnName("BANKBICS4")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbics5)
                    .HasColumnName("BANKBICS5")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbics6)
                    .HasColumnName("BANKBICS6")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbics7)
                    .HasColumnName("BANKBICS7")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbranchs1)
                    .HasColumnName("BANKBRANCHS1")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbranchs2)
                    .HasColumnName("BANKBRANCHS2")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbranchs3)
                    .HasColumnName("BANKBRANCHS3")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbranchs4)
                    .HasColumnName("BANKBRANCHS4")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbranchs5)
                    .HasColumnName("BANKBRANCHS5")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbranchs6)
                    .HasColumnName("BANKBRANCHS6")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbranchs7)
                    .HasColumnName("BANKBRANCHS7")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Bankcorrpacc1)
                    .HasColumnName("BANKCORRPACC1")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankcorrpacc2)
                    .HasColumnName("BANKCORRPACC2")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankcorrpacc3)
                    .HasColumnName("BANKCORRPACC3")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankcorrpacc4)
                    .HasColumnName("BANKCORRPACC4")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankcorrpacc5)
                    .HasColumnName("BANKCORRPACC5")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankcorrpacc6)
                    .HasColumnName("BANKCORRPACC6")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankcorrpacc7)
                    .HasColumnName("BANKCORRPACC7")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankibans1)
                    .HasColumnName("BANKIBANS1")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankibans2)
                    .HasColumnName("BANKIBANS2")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankibans3)
                    .HasColumnName("BANKIBANS3")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankibans4)
                    .HasColumnName("BANKIBANS4")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankibans5)
                    .HasColumnName("BANKIBANS5")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankibans6)
                    .HasColumnName("BANKIBANS6")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankibans7)
                    .HasColumnName("BANKIBANS7")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Banknames1)
                    .HasColumnName("BANKNAMES1")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Banknames2)
                    .HasColumnName("BANKNAMES2")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Banknames3)
                    .HasColumnName("BANKNAMES3")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Banknames4)
                    .HasColumnName("BANKNAMES4")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Banknames5)
                    .HasColumnName("BANKNAMES5")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Banknames6)
                    .HasColumnName("BANKNAMES6")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Banknames7)
                    .HasColumnName("BANKNAMES7")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankvoen1)
                    .HasColumnName("BANKVOEN1")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankvoen2)
                    .HasColumnName("BANKVOEN2")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankvoen3)
                    .HasColumnName("BANKVOEN3")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankvoen4)
                    .HasColumnName("BANKVOEN4")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankvoen5)
                    .HasColumnName("BANKVOEN5")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankvoen6)
                    .HasColumnName("BANKVOEN6")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Bankvoen7)
                    .HasColumnName("BANKVOEN7")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Blocked).HasColumnName("BLOCKED");

                entity.Property(e => e.Brokercomp).HasColumnName("BROKERCOMP");

                entity.Property(e => e.CapiblockCreadeddate)
                    .HasColumnName("CAPIBLOCK_CREADEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CapiblockCreatedby).HasColumnName("CAPIBLOCK_CREATEDBY");

                entity.Property(e => e.CapiblockCreatedhour).HasColumnName("CAPIBLOCK_CREATEDHOUR");

                entity.Property(e => e.CapiblockCreatedmin).HasColumnName("CAPIBLOCK_CREATEDMIN");

                entity.Property(e => e.CapiblockCreatedsec).HasColumnName("CAPIBLOCK_CREATEDSEC");

                entity.Property(e => e.CapiblockModifiedby).HasColumnName("CAPIBLOCK_MODIFIEDBY");

                entity.Property(e => e.CapiblockModifieddate)
                    .HasColumnName("CAPIBLOCK_MODIFIEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CapiblockModifiedhour).HasColumnName("CAPIBLOCK_MODIFIEDHOUR");

                entity.Property(e => e.CapiblockModifiedmin).HasColumnName("CAPIBLOCK_MODIFIEDMIN");

                entity.Property(e => e.CapiblockModifiedsec).HasColumnName("CAPIBLOCK_MODIFIEDSEC");

                entity.Property(e => e.Cardtype).HasColumnName("CARDTYPE");

                entity.Property(e => e.Cashref).HasColumnName("CASHREF");

                entity.Property(e => e.Ccurrency).HasColumnName("CCURRENCY");

                entity.Property(e => e.Cellphone)
                    .HasColumnName("CELLPHONE")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Citycode)
                    .HasColumnName("CITYCODE")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Cityid)
                    .HasColumnName("CITYID")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Clanguage).HasColumnName("CLANGUAGE");

                entity.Property(e => e.Clcrm).HasColumnName("CLCRM");

                entity.Property(e => e.Clordfreq).HasColumnName("CLORDFREQ");

                entity.Property(e => e.Closedatecount).HasColumnName("CLOSEDATECOUNT");

                entity.Property(e => e.Closedatetrack).HasColumnName("CLOSEDATETRACK");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Collectinvoicing).HasColumnName("COLLECTINVOICING");

                entity.Property(e => e.Conscoderef).HasColumnName("CONSCODEREF");

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Countrycode)
                    .HasColumnName("COUNTRYCODE")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Cratediffproc).HasColumnName("CRATEDIFFPROC");

                entity.Property(e => e.Createwhfiche).HasColumnName("CREATEWHFICHE");

                entity.Property(e => e.Curratetype).HasColumnName("CURRATETYPE");

                entity.Property(e => e.Cyphcode)
                    .HasColumnName("CYPHCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Dbsbankcurrency1).HasColumnName("DBSBANKCURRENCY1");

                entity.Property(e => e.Dbsbankcurrency2).HasColumnName("DBSBANKCURRENCY2");

                entity.Property(e => e.Dbsbankcurrency3).HasColumnName("DBSBANKCURRENCY3");

                entity.Property(e => e.Dbsbankcurrency4).HasColumnName("DBSBANKCURRENCY4");

                entity.Property(e => e.Dbsbankcurrency5).HasColumnName("DBSBANKCURRENCY5");

                entity.Property(e => e.Dbsbankcurrency6).HasColumnName("DBSBANKCURRENCY6");

                entity.Property(e => e.Dbsbankcurrency7).HasColumnName("DBSBANKCURRENCY7");

                entity.Property(e => e.Dbsbankno1).HasColumnName("DBSBANKNO1");

                entity.Property(e => e.Dbsbankno2).HasColumnName("DBSBANKNO2");

                entity.Property(e => e.Dbsbankno3).HasColumnName("DBSBANKNO3");

                entity.Property(e => e.Dbsbankno4).HasColumnName("DBSBANKNO4");

                entity.Property(e => e.Dbsbankno5).HasColumnName("DBSBANKNO5");

                entity.Property(e => e.Dbsbankno6).HasColumnName("DBSBANKNO6");

                entity.Property(e => e.Dbsbankno7).HasColumnName("DBSBANKNO7");

                entity.Property(e => e.Dbslimit1).HasColumnName("DBSLIMIT1");

                entity.Property(e => e.Dbslimit2).HasColumnName("DBSLIMIT2");

                entity.Property(e => e.Dbslimit3).HasColumnName("DBSLIMIT3");

                entity.Property(e => e.Dbslimit4).HasColumnName("DBSLIMIT4");

                entity.Property(e => e.Dbslimit5).HasColumnName("DBSLIMIT5");

                entity.Property(e => e.Dbslimit6).HasColumnName("DBSLIMIT6");

                entity.Property(e => e.Dbslimit7).HasColumnName("DBSLIMIT7");

                entity.Property(e => e.Dbsriskcntrl1).HasColumnName("DBSRISKCNTRL1");

                entity.Property(e => e.Dbsriskcntrl2).HasColumnName("DBSRISKCNTRL2");

                entity.Property(e => e.Dbsriskcntrl3).HasColumnName("DBSRISKCNTRL3");

                entity.Property(e => e.Dbsriskcntrl4).HasColumnName("DBSRISKCNTRL4");

                entity.Property(e => e.Dbsriskcntrl5).HasColumnName("DBSRISKCNTRL5");

                entity.Property(e => e.Dbsriskcntrl6).HasColumnName("DBSRISKCNTRL6");

                entity.Property(e => e.Dbsriskcntrl7).HasColumnName("DBSRISKCNTRL7");

                entity.Property(e => e.Dbstotal1).HasColumnName("DBSTOTAL1");

                entity.Property(e => e.Dbstotal2).HasColumnName("DBSTOTAL2");

                entity.Property(e => e.Dbstotal3).HasColumnName("DBSTOTAL3");

                entity.Property(e => e.Dbstotal4).HasColumnName("DBSTOTAL4");

                entity.Property(e => e.Dbstotal5).HasColumnName("DBSTOTAL5");

                entity.Property(e => e.Dbstotal6).HasColumnName("DBSTOTAL6");

                entity.Property(e => e.Dbstotal7).HasColumnName("DBSTOTAL7");

                entity.Property(e => e.Defbnaccref).HasColumnName("DEFBNACCREF");

                entity.Property(e => e.Definition)
                    .HasColumnName("DEFINITION_")
                    .HasMaxLength(201)
                    .IsUnicode(false);

                entity.Property(e => e.Definition2)
                    .HasColumnName("DEFINITION2")
                    .HasMaxLength(201)
                    .IsUnicode(false);

                entity.Property(e => e.Degactive).HasColumnName("DEGACTIVE");

                entity.Property(e => e.Degcurr).HasColumnName("DEGCURR");

                entity.Property(e => e.Deliveryfirm)
                    .HasColumnName("DELIVERYFIRM")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Deliverymethod)
                    .HasColumnName("DELIVERYMETHOD")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Discrate).HasColumnName("DISCRATE");

                entity.Property(e => e.Disctype).HasColumnName("DISCTYPE");

                entity.Property(e => e.District)
                    .HasColumnName("DISTRICT")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Districtcode)
                    .HasColumnName("DISTRICTCODE")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Dspsendemailaddr)
                    .HasColumnName("DSPSENDEMAILADDR")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Dspsendfaxnr)
                    .HasColumnName("DSPSENDFAXNR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Dspsendformat).HasColumnName("DSPSENDFORMAT");

                entity.Property(e => e.Dspsendmethod).HasColumnName("DSPSENDMETHOD");

                entity.Property(e => e.Duedatecontrol1).HasColumnName("DUEDATECONTROL1");

                entity.Property(e => e.Duedatecontrol10).HasColumnName("DUEDATECONTROL10");

                entity.Property(e => e.Duedatecontrol11).HasColumnName("DUEDATECONTROL11");

                entity.Property(e => e.Duedatecontrol12).HasColumnName("DUEDATECONTROL12");

                entity.Property(e => e.Duedatecontrol13).HasColumnName("DUEDATECONTROL13");

                entity.Property(e => e.Duedatecontrol14).HasColumnName("DUEDATECONTROL14");

                entity.Property(e => e.Duedatecontrol15).HasColumnName("DUEDATECONTROL15");

                entity.Property(e => e.Duedatecontrol2).HasColumnName("DUEDATECONTROL2");

                entity.Property(e => e.Duedatecontrol3).HasColumnName("DUEDATECONTROL3");

                entity.Property(e => e.Duedatecontrol4).HasColumnName("DUEDATECONTROL4");

                entity.Property(e => e.Duedatecontrol5).HasColumnName("DUEDATECONTROL5");

                entity.Property(e => e.Duedatecontrol6).HasColumnName("DUEDATECONTROL6");

                entity.Property(e => e.Duedatecontrol7).HasColumnName("DUEDATECONTROL7");

                entity.Property(e => e.Duedatecontrol8).HasColumnName("DUEDATECONTROL8");

                entity.Property(e => e.Duedatecontrol9).HasColumnName("DUEDATECONTROL9");

                entity.Property(e => e.Duedatecount).HasColumnName("DUEDATECOUNT");

                entity.Property(e => e.Duedatelimit).HasColumnName("DUEDATELIMIT");

                entity.Property(e => e.Duedatetrack).HasColumnName("DUEDATETRACK");

                entity.Property(e => e.Earcemailaddr1)
                    .HasColumnName("EARCEMAILADDR1")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Earcemailaddr2)
                    .HasColumnName("EARCEMAILADDR2")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Earcemailaddr3)
                    .HasColumnName("EARCEMAILADDR3")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Ebankno).HasColumnName("EBANKNO");

                entity.Property(e => e.Ebusdatasendtype).HasColumnName("EBUSDATASENDTYPE");

                entity.Property(e => e.Edino)
                    .HasColumnName("EDINO")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Einvcustom).HasColumnName("EINVCUSTOM");

                entity.Property(e => e.Einvoiceid)
                    .HasColumnName("EINVOICEID")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.Einvoicetyp).HasColumnName("EINVOICETYP");

                entity.Property(e => e.Einvoicetype).HasColumnName("EINVOICETYPE");

                entity.Property(e => e.Emailaddr)
                    .HasColumnName("EMAILADDR")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Emailaddr2)
                    .HasColumnName("EMAILADDR2")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Emailaddr3)
                    .HasColumnName("EMAILADDR3")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Expbrws).HasColumnName("EXPBRWS");

                entity.Property(e => e.Expbustypref).HasColumnName("EXPBUSTYPREF");

                entity.Property(e => e.Expdocno)
                    .HasColumnName("EXPDOCNO")
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.Expregno)
                    .HasColumnName("EXPREGNO")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Extaccessflags).HasColumnName("EXTACCESSFLAGS");

                entity.Property(e => e.Extenref).HasColumnName("EXTENREF");

                entity.Property(e => e.Extsendemailaddr)
                    .HasColumnName("EXTSENDEMAILADDR")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Extsendfaxnr)
                    .HasColumnName("EXTSENDFAXNR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Extsendformat).HasColumnName("EXTSENDFORMAT");

                entity.Property(e => e.Extsendmethod).HasColumnName("EXTSENDMETHOD");

                entity.Property(e => e.Facebookurl)
                    .HasColumnName("FACEBOOKURL")
                    .HasMaxLength(121)
                    .IsUnicode(false);

                entity.Property(e => e.Factorydivnr).HasColumnName("FACTORYDIVNR");

                entity.Property(e => e.Factorynr).HasColumnName("FACTORYNR");

                entity.Property(e => e.Faxcode)
                    .HasColumnName("FAXCODE")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Faxextnum)
                    .HasColumnName("FAXEXTNUM")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Faxnr)
                    .HasColumnName("FAXNR")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Fbasendemailaddr)
                    .HasColumnName("FBASENDEMAILADDR")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Fbasendfaxnr)
                    .HasColumnName("FBASENDFAXNR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Fbasendformat).HasColumnName("FBASENDFORMAT");

                entity.Property(e => e.Fbasendmethod).HasColumnName("FBASENDMETHOD");

                entity.Property(e => e.Fbssendemailaddr)
                    .HasColumnName("FBSSENDEMAILADDR")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Fbssendfaxnr)
                    .HasColumnName("FBSSENDFAXNR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Fbssendformat).HasColumnName("FBSSENDFORMAT");

                entity.Property(e => e.Fbssendmethod).HasColumnName("FBSSENDMETHOD");

                entity.Property(e => e.Finbrws).HasColumnName("FINBRWS");

                entity.Property(e => e.Globalid)
                    .HasColumnName("GLOBALID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Grpfirmnr).HasColumnName("GRPFIRMNR");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasMaxLength(37)
                    .IsUnicode(false);

                entity.Property(e => e.Imageinc).HasColumnName("IMAGEINC");

                entity.Property(e => e.Impbrws).HasColumnName("IMPBRWS");

                entity.Property(e => e.Incharge)
                    .HasColumnName("INCHARGE")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Incharge2)
                    .HasColumnName("INCHARGE2")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Incharge3)
                    .HasColumnName("INCHARGE3")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Ininvennr).HasColumnName("ININVENNR");

                entity.Property(e => e.Inistatusflags).HasColumnName("INISTATUSFLAGS");

                entity.Property(e => e.Insteadofdesp).HasColumnName("INSTEADOFDESP");

                entity.Property(e => e.Invprintcnt).HasColumnName("INVPRINTCNT");

                entity.Property(e => e.Invsendemailaddr)
                    .HasColumnName("INVSENDEMAILADDR")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Invsendfaxnr)
                    .HasColumnName("INVSENDFAXNR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Invsendformat).HasColumnName("INVSENDFORMAT");

                entity.Property(e => e.Invsendmethod).HasColumnName("INVSENDMETHOD");

                entity.Property(e => e.Isforeign).HasColumnName("ISFOREIGN");

                entity.Property(e => e.Ispercurr).HasColumnName("ISPERCURR");

                entity.Property(e => e.Isperscomp).HasColumnName("ISPERSCOMP");

                entity.Property(e => e.Kvkkanonydate)
                    .HasColumnName("KVKKANONYDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Kvkkanonystatus).HasColumnName("KVKKANONYSTATUS");

                entity.Property(e => e.Kvkkbegdate)
                    .HasColumnName("KVKKBEGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Kvkkcanceldate)
                    .HasColumnName("KVKKCANCELDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Kvkkenddate)
                    .HasColumnName("KVKKENDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Kvkkpermstatus).HasColumnName("KVKKPERMSTATUS");

                entity.Property(e => e.Labelinfo).HasColumnName("LABELINFO");

                entity.Property(e => e.Labelinfodesp).HasColumnName("LABELINFODESP");

                entity.Property(e => e.Lastsendremlev).HasColumnName("LASTSENDREMLEV");

                entity.Property(e => e.Latitute)
                    .HasColumnName("LATITUTE")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.Ldxfirmnr).HasColumnName("LDXFIRMNR");

                entity.Property(e => e.Lidconfirmed).HasColumnName("LIDCONFIRMED");

                entity.Property(e => e.Loangrpctrl).HasColumnName("LOANGRPCTRL");

                entity.Property(e => e.Logoid)
                    .HasColumnName("LOGOID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasColumnName("LONGITUDE")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.Lowlevelcodes1).HasColumnName("LOWLEVELCODES1");

                entity.Property(e => e.Lowlevelcodes10).HasColumnName("LOWLEVELCODES10");

                entity.Property(e => e.Lowlevelcodes2).HasColumnName("LOWLEVELCODES2");

                entity.Property(e => e.Lowlevelcodes3).HasColumnName("LOWLEVELCODES3");

                entity.Property(e => e.Lowlevelcodes4).HasColumnName("LOWLEVELCODES4");

                entity.Property(e => e.Lowlevelcodes5).HasColumnName("LOWLEVELCODES5");

                entity.Property(e => e.Lowlevelcodes6).HasColumnName("LOWLEVELCODES6");

                entity.Property(e => e.Lowlevelcodes7).HasColumnName("LOWLEVELCODES7");

                entity.Property(e => e.Lowlevelcodes8).HasColumnName("LOWLEVELCODES8");

                entity.Property(e => e.Lowlevelcodes9).HasColumnName("LOWLEVELCODES9");

                entity.Property(e => e.Ltrsendemailaddr)
                    .HasColumnName("LTRSENDEMAILADDR")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Ltrsendfaxnr)
                    .HasColumnName("LTRSENDFAXNR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Ltrsendformat).HasColumnName("LTRSENDFORMAT");

                entity.Property(e => e.Ltrsendmethod).HasColumnName("LTRSENDMETHOD");

                entity.Property(e => e.Mapid)
                    .HasColumnName("MAPID")
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Offsendemailaddr)
                    .HasColumnName("OFFSENDEMAILADDR")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Offsendfaxnr)
                    .HasColumnName("OFFSENDFAXNR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Offsendformat).HasColumnName("OFFSENDFORMAT");

                entity.Property(e => e.Offsendmethod).HasColumnName("OFFSENDMETHOD");

                entity.Property(e => e.Ordday).HasColumnName("ORDDAY");

                entity.Property(e => e.Ordpriority).HasColumnName("ORDPRIORITY");

                entity.Property(e => e.Ordsendemailaddr)
                    .HasColumnName("ORDSENDEMAILADDR")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Ordsendfaxnr)
                    .HasColumnName("ORDSENDFAXNR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Ordsendformat).HasColumnName("ORDSENDFORMAT");

                entity.Property(e => e.Ordsendmethod).HasColumnName("ORDSENDMETHOD");

                entity.Property(e => e.Orglogicref).HasColumnName("ORGLOGICREF");

                entity.Property(e => e.Orglogoid)
                    .HasColumnName("ORGLOGOID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Outinvennr).HasColumnName("OUTINVENNR");

                entity.Property(e => e.Overlapamnt).HasColumnName("OVERLAPAMNT");

                entity.Property(e => e.Overlapperc).HasColumnName("OVERLAPPERC");

                entity.Property(e => e.Overlaptype).HasColumnName("OVERLAPTYPE");

                entity.Property(e => e.Parentclref).HasColumnName("PARENTCLREF");

                entity.Property(e => e.Paymentproc).HasColumnName("PAYMENTPROC");

                entity.Property(e => e.Paymentprocbranch).HasColumnName("PAYMENTPROCBRANCH");

                entity.Property(e => e.Paymentref).HasColumnName("PAYMENTREF");

                entity.Property(e => e.Paymenttype).HasColumnName("PAYMENTTYPE");

                entity.Property(e => e.Personelcosts).HasColumnName("PERSONELCOSTS");

                entity.Property(e => e.Pieceordinflict).HasColumnName("PIECEORDINFLICT");

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Postlabelcode)
                    .HasColumnName("POSTLABELCODE")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Postlabelcodedesp)
                    .HasColumnName("POSTLABELCODEDESP")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Ppgroupcode)
                    .HasColumnName("PPGROUPCODE")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Ppgroupref).HasColumnName("PPGROUPREF");

                entity.Property(e => e.Profileid).HasColumnName("PROFILEID");

                entity.Property(e => e.Profileiddesp).HasColumnName("PROFILEIDDESP");

                entity.Property(e => e.Projectref).HasColumnName("PROJECTREF");

                entity.Property(e => e.Publicbnaccref).HasColumnName("PUBLICBNACCREF");

                entity.Property(e => e.Purchbrws).HasColumnName("PURCHBRWS");

                entity.Property(e => e.Purcorderprice).HasColumnName("PURCORDERPRICE");

                entity.Property(e => e.Purcorderstatus).HasColumnName("PURCORDERSTATUS");

                entity.Property(e => e.Qtydepduration).HasColumnName("QTYDEPDURATION");

                entity.Property(e => e.Qtyindepduration).HasColumnName("QTYINDEPDURATION");

                entity.Property(e => e.Recstatus).HasColumnName("RECSTATUS");

                entity.Property(e => e.Remsendformat).HasColumnName("REMSENDFORMAT");

                entity.Property(e => e.Rskagingcr).HasColumnName("RSKAGINGCR");

                entity.Property(e => e.Rskagingday).HasColumnName("RSKAGINGDAY");

                entity.Property(e => e.Rskduedatecr).HasColumnName("RSKDUEDATECR");

                entity.Property(e => e.Rsklimcr).HasColumnName("RSKLIMCR");

                entity.Property(e => e.Salesbrws).HasColumnName("SALESBRWS");

                entity.Property(e => e.Sameitemcodeuse).HasColumnName("SAMEITEMCODEUSE");

                entity.Property(e => e.Sectormainref).HasColumnName("SECTORMAINREF");

                entity.Property(e => e.Sectorsubref).HasColumnName("SECTORSUBREF");

                entity.Property(e => e.Senderlabelcode)
                    .HasColumnName("SENDERLABELCODE")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Senderlabelcodedesp)
                    .HasColumnName("SENDERLABELCODEDESP")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Sendmod).HasColumnName("SENDMOD");

                entity.Property(e => e.Shipbegtime1).HasColumnName("SHIPBEGTIME1");

                entity.Property(e => e.Shipbegtime2).HasColumnName("SHIPBEGTIME2");

                entity.Property(e => e.Shipbegtime3).HasColumnName("SHIPBEGTIME3");

                entity.Property(e => e.Shipendtime1).HasColumnName("SHIPENDTIME1");

                entity.Property(e => e.Shipendtime2).HasColumnName("SHIPENDTIME2");

                entity.Property(e => e.Shipendtime3).HasColumnName("SHIPENDTIME3");

                entity.Property(e => e.Siteid).HasColumnName("SITEID");

                entity.Property(e => e.Skypeid)
                    .HasColumnName("SKYPEID")
                    .HasMaxLength(121)
                    .IsUnicode(false);

                entity.Property(e => e.Slsorderprice).HasColumnName("SLSORDERPRICE");

                entity.Property(e => e.Slsorderstatus).HasColumnName("SLSORDERSTATUS");

                entity.Property(e => e.Specode)
                    .HasColumnName("SPECODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Specode2)
                    .HasColumnName("SPECODE2")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Specode3)
                    .HasColumnName("SPECODE3")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Specode4)
                    .HasColumnName("SPECODE4")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Specode5)
                    .HasColumnName("SPECODE5")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Statecode)
                    .HasColumnName("STATECODE")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Statename)
                    .HasColumnName("STATENAME")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.Storecreditcardno)
                    .HasColumnName("STORECREDITCARDNO")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Subcont).HasColumnName("SUBCONT");

                entity.Property(e => e.Subscriberext)
                    .HasColumnName("SUBSCRIBEREXT")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Subscriberstat).HasColumnName("SUBSCRIBERSTAT");

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Taxnr)
                    .HasColumnName("TAXNR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Taxoffcode)
                    .HasColumnName("TAXOFFCODE")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Taxoffice)
                    .HasColumnName("TAXOFFICE")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Tckno)
                    .HasColumnName("TCKNO")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Telcodes1)
                    .HasColumnName("TELCODES1")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Telcodes2)
                    .HasColumnName("TELCODES2")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Telextnums1)
                    .HasColumnName("TELEXTNUMS1")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Telextnums2)
                    .HasColumnName("TELEXTNUMS2")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Telnrs1)
                    .HasColumnName("TELNRS1")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Telnrs2)
                    .HasColumnName("TELNRS2")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Textinc).HasColumnName("TEXTINC");

                entity.Property(e => e.Textrefen).HasColumnName("TEXTREFEN");

                entity.Property(e => e.Textreftr).HasColumnName("TEXTREFTR");

                entity.Property(e => e.Town)
                    .HasColumnName("TOWN")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Towncode)
                    .HasColumnName("TOWNCODE")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Townid)
                    .HasColumnName("TOWNID")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Tradinggrp)
                    .HasColumnName("TRADINGGRP")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Twitterurl)
                    .HasColumnName("TWITTERURL")
                    .HasMaxLength(121)
                    .IsUnicode(false);

                entity.Property(e => e.Usedinperiods).HasColumnName("USEDINPERIODS");

                entity.Property(e => e.Vatnr)
                    .HasColumnName("VATNR")
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.Warnemailaddr)
                    .HasColumnName("WARNEMAILADDR")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.Warnfaxnr)
                    .HasColumnName("WARNFAXNR")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Warnmethod).HasColumnName("WARNMETHOD");

                entity.Property(e => e.Webaddr)
                    .HasColumnName("WEBADDR")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Wflowcrdref).HasColumnName("WFLOWCRDREF");

                entity.Property(e => e.Wfstatus).HasColumnName("WFSTATUS");
            });

            modelBuilder.Entity<Lg001Unitsetf>(entity =>
            {
                entity.HasKey(e => e.Logicalref)
                    .HasName("I001_UNITSETF_I1");

                entity.ToTable("LG_001_UNITSETF");

                entity.HasIndex(e => e.Code)
                    .HasName("I001_UNITSETF_I2")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("I001_UNITSETF_I3");

                entity.HasIndex(e => new { e.Cardtype, e.Code })
                    .HasName("I001_UNITSETF_I4")
                    .IsUnique();

                entity.HasIndex(e => new { e.Cardtype, e.Name })
                    .HasName("I001_UNITSETF_I5");

                entity.Property(e => e.Logicalref).HasColumnName("LOGICALREF");

                entity.Property(e => e.CapiblockCreadeddate)
                    .HasColumnName("CAPIBLOCK_CREADEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CapiblockCreatedby).HasColumnName("CAPIBLOCK_CREATEDBY");

                entity.Property(e => e.CapiblockCreatedhour).HasColumnName("CAPIBLOCK_CREATEDHOUR");

                entity.Property(e => e.CapiblockCreatedmin).HasColumnName("CAPIBLOCK_CREATEDMIN");

                entity.Property(e => e.CapiblockCreatedsec).HasColumnName("CAPIBLOCK_CREATEDSEC");

                entity.Property(e => e.CapiblockModifiedby).HasColumnName("CAPIBLOCK_MODIFIEDBY");

                entity.Property(e => e.CapiblockModifieddate)
                    .HasColumnName("CAPIBLOCK_MODIFIEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CapiblockModifiedhour).HasColumnName("CAPIBLOCK_MODIFIEDHOUR");

                entity.Property(e => e.CapiblockModifiedmin).HasColumnName("CAPIBLOCK_MODIFIEDMIN");

                entity.Property(e => e.CapiblockModifiedsec).HasColumnName("CAPIBLOCK_MODIFIEDSEC");

                entity.Property(e => e.Cardtype).HasColumnName("CARDTYPE");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cyphcode)
                    .HasColumnName("CYPHCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasMaxLength(37)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Orglogicref).HasColumnName("ORGLOGICREF");

                entity.Property(e => e.Recstatus).HasColumnName("RECSTATUS");

                entity.Property(e => e.Siteid).HasColumnName("SITEID");

                entity.Property(e => e.Specitem).HasColumnName("SPECITEM");

                entity.Property(e => e.Specode)
                    .HasColumnName("SPECODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Wfstatus).HasColumnName("WFSTATUS");
            });

            modelBuilder.Entity<Lg001Unitset>(entity =>
            {
                entity.HasKey(e => e.Logicalref)
                    .HasName("I001_UNITSETL_I1");

                entity.ToTable("LG_001_UNITSETL");

                entity.HasIndex(e => e.Code)
                    .HasName("I001_UNITSETL_I2");

                entity.HasIndex(e => e.Name)
                    .HasName("I001_UNITSETL_I3");

                entity.HasIndex(e => new { e.Unitsetref, e.Linenr })
                    .HasName("I001_UNITSETL_I4");

                entity.Property(e => e.Logicalref).HasColumnName("LOGICALREF");

                entity.Property(e => e.Area).HasColumnName("AREA");

                entity.Property(e => e.Arearef).HasColumnName("AREAREF");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Convfact1).HasColumnName("CONVFACT1");

                entity.Property(e => e.Convfact2).HasColumnName("CONVFACT2");

                entity.Property(e => e.Divunit).HasColumnName("DIVUNIT");

                entity.Property(e => e.Globalcode)
                    .HasColumnName("GLOBALCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Height).HasColumnName("HEIGHT");

                entity.Property(e => e.Heightref).HasColumnName("HEIGHTREF");

                entity.Property(e => e.Length).HasColumnName("LENGTH");

                entity.Property(e => e.Lengthref).HasColumnName("LENGTHREF");

                entity.Property(e => e.Linenr).HasColumnName("LINENR");

                entity.Property(e => e.Mainunit).HasColumnName("MAINUNIT");

                entity.Property(e => e.Measurecode)
                    .HasColumnName("MEASURECODE")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Unitsetref).HasColumnName("UNITSETREF");

                entity.Property(e => e.Volume).HasColumnName("VOLUME_");

                entity.Property(e => e.Volumeref).HasColumnName("VOLUMEREF");

                entity.Property(e => e.Weight).HasColumnName("WEIGHT");

                entity.Property(e => e.Weightref).HasColumnName("WEIGHTREF");

                entity.Property(e => e.Width).HasColumnName("WIDTH");

                entity.Property(e => e.Widthref).HasColumnName("WIDTHREF");
            });

            modelBuilder.Entity<Lg001Unitset>(entity =>
            {
                entity.HasKey(e => e.Logicalref)
                    .HasName("I001_UNITSETL_I1");

                entity.ToTable("LG_001_UNITSETL");

                entity.HasIndex(e => e.Code)
                    .HasName("I001_UNITSETL_I2");

                entity.HasIndex(e => e.Name)
                    .HasName("I001_UNITSETL_I3");

                entity.HasIndex(e => new { e.Unitsetref, e.Linenr })
                    .HasName("I001_UNITSETL_I4");

                entity.Property(e => e.Logicalref).HasColumnName("LOGICALREF");

                entity.Property(e => e.Area).HasColumnName("AREA");

                entity.Property(e => e.Arearef).HasColumnName("AREAREF");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Convfact1).HasColumnName("CONVFACT1");

                entity.Property(e => e.Convfact2).HasColumnName("CONVFACT2");

                entity.Property(e => e.Divunit).HasColumnName("DIVUNIT");

                entity.Property(e => e.Globalcode)
                    .HasColumnName("GLOBALCODE")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Height).HasColumnName("HEIGHT");

                entity.Property(e => e.Heightref).HasColumnName("HEIGHTREF");

                entity.Property(e => e.Length).HasColumnName("LENGTH");

                entity.Property(e => e.Lengthref).HasColumnName("LENGTHREF");

                entity.Property(e => e.Linenr).HasColumnName("LINENR");

                entity.Property(e => e.Mainunit).HasColumnName("MAINUNIT");

                entity.Property(e => e.Measurecode)
                    .HasColumnName("MEASURECODE")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Unitsetref).HasColumnName("UNITSETREF");

                entity.Property(e => e.Volume).HasColumnName("VOLUME_");

                entity.Property(e => e.Volumeref).HasColumnName("VOLUMEREF");

                entity.Property(e => e.Weight).HasColumnName("WEIGHT");

                entity.Property(e => e.Weightref).HasColumnName("WEIGHTREF");

                entity.Property(e => e.Width).HasColumnName("WIDTH");

                entity.Property(e => e.Widthref).HasColumnName("WIDTHREF");
            });


            modelBuilder.Entity<Lg001Specodes>(entity =>
            {
                entity.HasKey(e => e.Logicalref)
                    .HasName("I001_SPECODES_I1");

                entity.ToTable("LG_001_SPECODES");

                entity.HasIndex(e => e.Globalid)
                    .HasName("I001_SPECODES_I4");

                entity.HasIndex(e => e.Specode)
                    .HasName("I001_SPECODES_I3");

                entity.HasIndex(e => new { e.Codetype, e.Specodetype, e.Specode })
                    .HasName("I001_SPECODES_I2");

                entity.Property(e => e.Logicalref).HasColumnName("LOGICALREF");

                entity.Property(e => e.Codetype).HasColumnName("CODETYPE");

                entity.Property(e => e.Color).HasColumnName("COLOR");

                entity.Property(e => e.Definition)
                    .HasColumnName("DEFINITION_")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.Definition2)
                    .HasColumnName("DEFINITION2")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.Definition3)
                    .HasColumnName("DEFINITION3")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.Globalid)
                    .HasColumnName("GLOBALID")
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Orglogicref).HasColumnName("ORGLOGICREF");

                entity.Property(e => e.Recstatus).HasColumnName("RECSTATUS");

                entity.Property(e => e.Siteid).HasColumnName("SITEID");

                entity.Property(e => e.Specode)
                    .HasColumnName("SPECODE")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.Specodetype).HasColumnName("SPECODETYPE");

                entity.Property(e => e.Spetyp1).HasColumnName("SPETYP1");

                entity.Property(e => e.Spetyp2).HasColumnName("SPETYP2");

                entity.Property(e => e.Spetyp3).HasColumnName("SPETYP3");

                entity.Property(e => e.Spetyp4).HasColumnName("SPETYP4");

                entity.Property(e => e.Spetyp5).HasColumnName("SPETYP5");

                entity.Property(e => e.Wincolor).HasColumnName("WINCOLOR");
            });


            OnModelCreatingPartial(modelBuilder);


        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }

}


