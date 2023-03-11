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
using System.Data.SqlClient;

public class DALSGXMIS_BillingMIS_V2
{
    string connStr = ConfigurationManager.ConnectionStrings["DBConnSGX"].ToString();

    public DALSGXMIS_BillingMIS_V2()
    {

    }

    // For Fill Product Master
    // By : Sunil Kumar Singh
    // Date : 23-03-2012
    // Use in : All Report having customer drop down 
    public DataTable fillProduct()
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectProduct", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@empCode", HttpContext.Current.Session["LogIn_Code"].ToString());
            dAd.Fill(dSet, "tbl_SelectProduct");
            return dSet.Tables["tbl_SelectProduct"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // For Fill Location
    // By : Sunil Kumar Singh
    // Date : 23-02-2013
    // Use in : All Report having customer drop down 
    public DataTable fillBr(string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_br", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@empCode", emp);
            dAd.Fill(dSet, "tbl_br");
            return dSet.Tables["tbl_br"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // For Fill Location
    // By : Sunil Kumar Singh
    // Date : 23-03-2012
    // Use in : All Report having customer drop down 
    public DataTable fillLocation(string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_Fill_Location", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@empCode", emp);
            dAd.Fill(dSet, "tbl_Fill_Location");
            return dSet.Tables["tbl_Fill_Location"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }


    // For Fill Product Master
    // By : Sunil Kumar Singh
    // Date : 23-03-2012
    // Use in : All Report having customer drop down 
    public DataTable fillCustGroup()
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectCustomerGroup_Mst", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.Fill(dSet, "tbl_CustomerGroup_Mst");
            return dSet.Tables["tbl_CustomerGroup_Mst"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // For Fill Customer Master List
    // By : Sunil Kumar Singh
    // Date : 23-03-2012
    // Use in : All Report having customer drop down 
    public DataTable fillCustomer(string loc, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_FillCustomer", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);

            dAd.Fill(dSet, "tbl_FillCustomer");
            return dSet.Tables["tbl_FillCustomer"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    public DataTable rpt_billMis_1(string prodoct, string loc, string grp, string cust, string fdt, string tdt,string Status,string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_1", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@Status", Status);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);
            dAd.Fill(dSet, "tbl_rpt_billMis_1");
            return dSet.Tables["tbl_rpt_billMis_1"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    public DataTable rpt_billMis_2(string prodoct, string loc, string grp, string cust,string fdt,string edt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_2", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@edt", edt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);

            dAd.Fill(dSet, "tbl_rpt_billMis_2");
            return dSet.Tables["tbl_rpt_billMis_2"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    public DataTable rpt_billMis_3(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string Status, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_3", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@Status", Status);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);
            dAd.Fill(dSet, "tbl_rpt_billMis_1");
            return dSet.Tables["tbl_rpt_billMis_1"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil Singh
    // Date : 04-04-2012
    // Used For: rpt_billMis_4
    public DataTable rpt_billMis_4(string prodoct, string loc,string cust,string fdt,string edt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_4", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@edt", edt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);

            dAd.Fill(dSet, "tbl_rpt_billMis_4");
            return dSet.Tables["tbl_rpt_billMis_4"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }
    // Added By : Sunil Singh
    // Date : 04-04-2012
    // Used For: rpt_billMis_5
    public DataTable rpt_billMis_5(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_5", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);
            dAd.Fill(dSet, "tbl_rpt_billMis_5");
            return dSet.Tables["tbl_rpt_billMis_5"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil Singh
    // Date : 02-08-2013
    // Used For: rpt_billMis_5_D
    public DataTable rpt_billMis_5_D(string region,string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_5_D", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Region", region);
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);
            dAd.Fill(dSet, "tbl_rpt_billMis_5");
            return dSet.Tables["tbl_rpt_billMis_5"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil Singh
    // Date : 02-08-2013
    // Used For: rpt_billMis_5_C
    public DataSet rpt_billMis_5_C(string region, string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_5_C", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Region", region);
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);

            dAd.Fill(dSet, "rpt_billMis_5_C");
            return dSet;
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil KumaR Singh
    // Date : 23/04/2012
    // Used For: MIS -  rpt_billMis_6
    public DataTable rpt_billMis_6(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_6", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);

            dAd.Fill(dSet, "tbl_rpt_billMis_6");
            return dSet.Tables["tbl_rpt_billMis_6"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil KumaR Singh
    // Date : 13/04/2013
    // Used For: MIS -  rpt_billMis_6_A
    public DataTable rpt_billMis_6_A(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_6_A", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);

            dAd.Fill(dSet, "tbl_rpt_billMis_6_A");
            return dSet.Tables["tbl_rpt_billMis_6_A"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil Singh
    // Date : 23-04-2012
    // Used For: rpt_billMis_7
    public DataTable rpt_billMis_7(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_7", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);
            dAd.Fill(dSet, "tbl_rpt_billMis_7");
            return dSet.Tables["tbl_rpt_billMis_7"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil Singh
    // Date : 23-08-2012
    // Used For: rpt_billMis_7  
    public DataTable MonthlyCustColl(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_custWise_MonthlyCollection", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@proCode", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@locCode", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@custCode", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@Yr", fdt);
            dAd.Fill(dSet, "tbl_rpt_billMis_7");
            return dSet.Tables["tbl_rpt_billMis_7"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil KumaR Singh
    // Date : 23/04/2012
    // Used For: MIS -  rpt_billMis_8
    public DataTable rpt_billMis_8(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_8", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@edt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);

            dAd.Fill(dSet, "tbl_rpt_billMis_8");
            return dSet.Tables["tbl_rpt_billMis_8"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Vinay Kumar Dubey
    // Date : 22/06/2012
    // Used For: MIS -  rpt_billMis_9
    public DataTable rpt_billMis_9(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_9", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);

            dAd.Fill(dSet, "tbl_rpt_billMis_9");
            return dSet.Tables["tbl_rpt_billMis_9"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }
    // Added By : Sunil Singh
    // Date : 14-07-2012
    // Used For: rpt_bussReg
    public DataTable rpt_bussReg(string Yr, string mth, string loc,string prod)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_businessRegister_WeekWise", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {

            dAd.SelectCommand.Parameters.AddWithValue("@Yr", Yr);
            dAd.SelectCommand.Parameters.AddWithValue("@mth", mth);
            dAd.SelectCommand.Parameters.AddWithValue("@Loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@Prod", prod);
            dAd.Fill(dSet, "tbl_rpt_bussReg");
            return dSet.Tables["tbl_rpt_bussReg"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    public DataTable rpt_billMis_1_B(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string Status, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_1_B", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@Status", Status);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);
            dAd.Fill(dSet, "tbl_rpt_billMis_1_B");
            return dSet.Tables["tbl_rpt_billMis_1_B"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }


    public DataTable rpt_billMis_3_A(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string Status, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_3_A", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@Status", Status);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);
            dAd.Fill(dSet, "tbl_rpt_billMis_1_A");
            return dSet.Tables["tbl_rpt_billMis_1_A"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil Singh
    // Date : 25-09-2012
    // Used For: rpt_billMis_5_A
    public DataTable rpt_billMis_5_A(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_5_A", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);
            dAd.Fill(dSet, "tbl_rpt_billMis_5_A");
            return dSet.Tables["tbl_rpt_billMis_5_A"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    public DataTable rpt_billMis_10_11(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string Status, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_10_11", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@Status", Status);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);
            dAd.Fill(dSet, "tbl_rpt_billMis_10_11");
            return dSet.Tables["tbl_rpt_billMis_10_11"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }


    // Added By : Sunil Singh
    // Date : 25/09/2012
    // Used For: MIS -  rpt_billMis_12
    public DataTable rpt_billMis_12(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_12", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);

            dAd.Fill(dSet, "tbl_rpt_billMis_12");
            return dSet.Tables["tbl_rpt_billMis_12"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil Singh
    // Date : 25/09/2012
    // Used For: MIS -  rpt_billMis_14
    public DataTable rpt_billMis_14(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_14", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);

            dAd.Fill(dSet, "tbl_rpt_billMis_14");
            return dSet.Tables["tbl_rpt_billMis_14"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil Singh
    // Date : 26-09-2012
    // Used For: rpt_billMis_15
    public DataTable rpt_billMis_15(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_15", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);
            dAd.Fill(dSet, "tbl_rpt_billMis_15");
            return dSet.Tables["tbl_rpt_billMis_15"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil Singh
    // Date : 26/09/2012
    // Used For: MIS -  rpt_billMis_16
    public DataTable rpt_billMis_16(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_16", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);

            dAd.Fill(dSet, "tbl_rpt_billMis_16");
            return dSet.Tables["tbl_rpt_billMis_16"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil Singh
    // Date : 27/09/2012
    // Used For: MIS -  rpt_billMis_18
    public DataTable rpt_billMis_18(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_18", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);

            dAd.Fill(dSet, "tbl_rpt_billMis_18");
            return dSet.Tables["tbl_rpt_billMis_18"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil Singh
    // Date : 27/09/2012
    // Used For: MIS -  rpt_billMis_19
    public DataTable rpt_billMis_19(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_19", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);

            dAd.Fill(dSet, "tbl_rpt_billMis_19");
            return dSet.Tables["tbl_rpt_billMis_19"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil Singh
    // Date : 03/10/2012
    // Used For: MIS -  rpt_billMis_19_M
    public DataTable rpt_billMis_19_M(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_rpt_billMis_19_M", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);

            dAd.Fill(dSet, "tbl_rpt_billMis_19_M");
            return dSet.Tables["tbl_rpt_billMis_19_M"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    // Added By : Sunil Singh
    // Date : 04-10-2012
    // Used For: SGXRPT0023
    public DataTable SGXRPT0023(string prodoct, string loc, string grp, string cust, string fdt, string edt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_SGXRPT0023", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@edt", edt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);

            dAd.Fill(dSet, "tbl_rpt_SGXRPT0023");
            return dSet.Tables["tbl_rpt_SGXRPT0023"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    public DataTable SGXRPT0027(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_SGXRPT0027", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);
            dAd.Fill(dSet, "tbl_SGXRPT0027");
            return dSet.Tables["tbl_SGXRPT0027"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    public DataTable SGXRPT0028(string prodoct, string loc, string grp, string cust, string fdt, string tdt, string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_SGXRPT0028", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@prodoct", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@loc", loc);
            dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@fdt", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@tdt", tdt);
            dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);
            dAd.Fill(dSet, "tbl_SGXRPT0028");
            return dSet.Tables["tbl_SGXRPT0028"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }


    //---- Added By : Ashish Kalsarpe -- Date : 03/10/2022----
    //---- Description : Customer-wise Volumes - PO vs. Actuals
    public DataTable SGXRPT0029(string prodoct, string loc, string grp, string cust, string fdt, string tdt)
    {
        SqlConnection conn = new SqlConnection(connStr);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Rpt_CustAndPOWise_Actual_Dispatch", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@product", prodoct);
            dAd.SelectCommand.Parameters.AddWithValue("@LocationCode", loc);
            //dAd.SelectCommand.Parameters.AddWithValue("@grp", grp);
            dAd.SelectCommand.Parameters.AddWithValue("@custcode", cust);
            dAd.SelectCommand.Parameters.AddWithValue("@FromDate", fdt);
            dAd.SelectCommand.Parameters.AddWithValue("@ToDate", tdt);
            //dAd.SelectCommand.Parameters.AddWithValue("@emp", emp);
            dAd.Fill(dSet, "tbl_SGXRPT0029");
            return dSet.Tables["tbl_SGXRPT0029"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }
    // For Fill Product Master
    // By : Rohit Chaurasiya
    // Date : 28-02-2023
    // Use in : All Report having customer drop down 
    public DataTable Fill_PROD_Master()
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectProduct", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@empCode", HttpContext.Current.Session["LogIn_Code"].ToString());
            dAd.Fill(dSet, "tbl_SelectProduct");
            return dSet.Tables["tbl_SelectProduct"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }
    public DataTable FillProo()
    {
        SqlConnection conn = new SqlConnection(connStr);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectProduct", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@empCode", HttpContext.Current.Session["LogIn_Code"].ToString());
            dAd.Fill(dSet, "tbl_SelectProduct");
            return dSet.Tables["tbl_SelectProduct"];
        }
        catch { throw; }
        finally {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }
    public DataTable Fill_location(string emp)
    {
        SqlConnection conn = new SqlConnection(connStr);

        SqlDataAdapter dAd = new SqlDataAdapter("usp_Fill_Location", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@empCode", emp);
            dAd.Fill(dSet, "tbl_Fill_Location");
            return dSet.Tables["tbl_Fill_Location"];
        }
        catch
        {
            throw;
        }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }
   
}
