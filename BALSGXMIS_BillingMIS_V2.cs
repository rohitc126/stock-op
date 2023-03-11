using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


public class BALSGXMIS_BillingMIS_V2
{
    public BALSGXMIS_BillingMIS_V2()
    {

    }

    // For Fill Product Master
    // By : Sunil Kumar Singh
    // Date : 23-03-2012
    public DataTable fillProduct()
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.fillProduct();
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    // For Fill Location
    // By : Sunil Kumar Singh
    // Date : 23-03-2012
    public DataTable fillLocation(string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.fillLocation(emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    // For Fill Location
    // By : Sunil Kumar Singh
    // Date : 23-02-2013
    public DataTable fillBr(string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.fillBr(emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    // For Fill Customer Group
    // By : Sunil Kumar Singh
    // Date : 23-03-2012
    public DataTable fillCustGroup()
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.fillCustGroup();
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    // For Fill Customer Master List
    // By : Sunil Kumar Singh
    // Date : 23-03-2012
    public DataTable fillCustomer(string loc,string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.fillCustomer(loc,emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    public DataTable rpt_billMis_1(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string Status,string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_1(prodoct, loc, grp, cust, fdt, tdt, Status,emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    public DataTable rpt_billMis_2(string prodoct, string loc, string grp, string cust,string fdt,string edt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_2(prodoct, loc, grp, cust,fdt,edt,emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    public DataTable rpt_billMis_3(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string Status, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_3(prodoct, loc, grp, cust, fdt, tdt, Status, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    // Added By : Sunil Singh
    // Date : 04-04-2012
    // Used For: rpt_billMis_4
    public DataTable rpt_billMis_4(string prodoct, string loc, string cust, string fdt, string edt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_4(prodoct, loc,cust,fdt,edt,emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }
    // Added By : Sunil Singh
    // Date : 04-04-2012
    // Used For: rpt_billMis_5
    public DataTable rpt_billMis_5(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_5(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    // Added By : Sunil Singh
    // Date : 02-08-2013
    // Used For: rpt_billMis_5_D
    public DataTable rpt_billMis_5_D(string region,string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_5_D(region,prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }


    // Added By : Sunil Singh
    // Date : 02-08-2013
    // Used For: rpt_billMis_5_C
    public DataSet rpt_billMis_5_C(string region, string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_5_C(region, prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    // Added By : Sunil KumaR Singh
    // Date : 23/04/2012
    // Used For: MIS -  rpt_billMis_6
    public DataTable rpt_billMis_6(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_6(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    // Added By : Sunil KumaR Singh
    // Date : 13/04/2013
    // Used For: MIS -  rpt_billMis_6_A
    public DataTable rpt_billMis_6_A(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_6_A(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }


    // Added By : Sunil Singh
    // Date : 23-04-2012
    // Used For: rpt_billMis_7
    public DataTable rpt_billMis_7(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_7(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    // Added By : Sunil Singh
    // Date : 23-08-2012
    // Used For: Monthly Customer Wise Collection Summary
    public DataTable MonthlyCustColl(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.MonthlyCustColl(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    // Added By : Sunil KumaR Singh
    // Date : 23/04/2012
    // Used For: MIS -  rpt_billMis_8
    public DataTable rpt_billMis_8(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_8(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    public DataTable rpt_billMis_9(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_9(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    // Added By : Sunil Singh
    // Date : 14-07-2012
    // Used For: rpt_bussReg
    public DataTable rpt_bussReg(string Yr, string mth, string loc,string prod)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_bussReg(Yr, mth, loc,prod);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    public DataTable rpt_billMis_1_B(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string Status, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_1_B(prodoct, loc, grp, cust, fdt, tdt, Status, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    public DataTable rpt_billMis_3_A(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string Status, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_3_A(prodoct, loc, grp, cust, fdt, tdt, Status, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    // Added By : Sunil Singh
    // Date : 25-09-2012
    // Used For: rpt_billMis_5_A
    public DataTable rpt_billMis_5_A(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_5_A(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    public DataTable rpt_billMis_10_11(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string Status, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_10_11(prodoct, loc, grp, cust, fdt, tdt, Status, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    public DataTable rpt_billMis_12(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_12(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    public DataTable rpt_billMis_14(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_14(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    // Added By : Sunil Singh
    // Date : 26-09-2012
    // Used For: rpt_billMis_15
    public DataTable rpt_billMis_15(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_15(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    public DataTable rpt_billMis_16(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_16(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    public DataTable rpt_billMis_18(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_18(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    public DataTable rpt_billMis_19(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_19(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    public DataTable rpt_billMis_19_M(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.rpt_billMis_19_M(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    // Added By : Sunil Singh
    // Date : 04-10-2012
    // Used For: SGXRPT0023
    public DataTable SGXRPT0023(string prodoct, string loc, string grp, string cust, string fdt, string edt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.SGXRPT0023(prodoct, loc, grp, cust, fdt, edt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    public DataTable SGXRPT0027(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.SGXRPT0027(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    public DataTable SGXRPT0028(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.SGXRPT0028(prodoct, loc, grp, cust, fdt, tdt, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    //----- Added By    : Ashish Kalsarpe --- Date : 03/10/2022 ---
    //----- Description : Customer-wise Volumes - PO vs. Actuals
    public DataTable SGXRPT0029(string prodoct, string loc, string grp, string cust, string fdt, string tdt)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.SGXRPT0029(prodoct, loc, grp, cust, fdt, tdt);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }

    // For Fill Product Master
    // By : Rohit Chaurasiya
    // Date : 28-02-2023
    public DataTable Fill_PROD_Master()
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.Fill_PROD_Master();
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }
    public DataTable FillProo()
    {
        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.FillProo();
        }
        catch { throw; }
        finally { rpt = null; }
    }

    public DataTable Fill_location(string emp)
    {

        DALSGXMIS_BillingMIS_V2 rpt = new DALSGXMIS_BillingMIS_V2();
        try
        {
            return rpt.Fill_location(emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            rpt = null;
        }
    }
    

}


