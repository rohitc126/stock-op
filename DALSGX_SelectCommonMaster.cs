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

public class DALSGX_SelectCommonMaster
{
    string connSGX = ConfigurationManager.ConnectionStrings["DBConnSGX"].ToString();
    string connHRM = ConfigurationManager.ConnectionStrings["DBConnHRM"].ToString();
    string connStr_calyx = ConfigurationManager.ConnectionStrings["DBConnCAL"].ToString();

    public DALSGX_SelectCommonMaster()
    {

    }
    public DataTable SelectJoint(string custcode,string CustPO_No, string CustPODate)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectCustomerPO_Auto", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Custcode", custcode);
            dAd.SelectCommand.Parameters.AddWithValue("@CustPO_No", CustPO_No);
            dAd.SelectCommand.Parameters.AddWithValue("@CustPODate", CustPODate);
            dAd.Fill(dSet, "tbl_usp_SelectQuery");
            return dSet.Tables["tbl_usp_SelectQuery"];
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
    //Added By : Vinay Kathera on 06-08-2012
    //Desc: date wise location wise shift wise status checking for all MN Entry Pages
    public DataTable Show_MNAuthorityStatus(string Activities_ID, string DayOpen, string Location_Code, string Shift_Code, string Mine_Code)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_CheckRecordEntry_DayWiseOpenorClose", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Activities_ID", Activities_ID);
            dAd.SelectCommand.Parameters.AddWithValue("@DayOpen", DayOpen);
            dAd.SelectCommand.Parameters.AddWithValue("@Location_Code", Location_Code);
            dAd.SelectCommand.Parameters.AddWithValue("@Shift_Code", Shift_Code);
            dAd.SelectCommand.Parameters.AddWithValue("@Mine_Code", Mine_Code);
            dAd.Fill(dSet, "tbl_usp_SelectQuery");
            return dSet.Tables["tbl_usp_SelectQuery"];
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
    //Ended By : Vinay Kathera on 06-08-2012
    //Desc: date wise location wise shift wise status checking for all MN Entry Pages
    //public DataTable SelectJointDetails(string JSRef_Code)
    //{
    //    SqlConnection conn = new SqlConnection(connSGX);
    //    SqlDataAdapter dAd = new SqlDataAdapter("[usp_SearchJointSamplingDetails]", conn);
    //    dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
    //    DataSet dSet = new DataSet();
    //    try
    //    {
    //        dAd.SelectCommand.Parameters.AddWithValue("@JSRef_Code", JSRef_Code);
    //        dAd.Fill(dSet, "tbl_usp_SelectQuery");
    //        return dSet.Tables["tbl_usp_SelectQuery"];
    //    }
    //    catch
    //    {
    //        throw;
    //    }
    //    finally
    //    {
    //        dSet.Dispose();
    //        dAd.Dispose();
    //        conn.Close();
    //        conn.Dispose();
    //    }
    //}

    public DataTable SelectSaleOrder(string SO_No,string custCode)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectSO", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@SO_No", SO_No);
            dAd.SelectCommand.Parameters.AddWithValue("@cust", custCode);
            dAd.Fill(dSet, "tbl_SelectSO");
            return dSet.Tables["tbl_SelectSO"];
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

    public DataTable SelectLocation(string Product, string Location, string Employee)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_selectLocation", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Product", Product);
            dAd.SelectCommand.Parameters.AddWithValue("@Location", Location);
            dAd.SelectCommand.Parameters.AddWithValue("@Employee", Employee);
            dAd.Fill(dSet, "tbl_usp_SelectProduct");
            return dSet.Tables["tbl_usp_SelectProduct"];
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

    // 27/12/2021
    public DataTable SelectLocationState(string Location)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_selectLocationState", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Location", Location);
            dAd.Fill(dSet, "tbl_usp_selectLocationState");
            return dSet.Tables["tbl_usp_selectLocationState"];
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

    public DataTable SelectYard(string Mine_Code, string MinePlantType, string locationcode, string productcode, string empCode, string Year, string Month)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Select_YardMineCSY", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Mine_Code", Mine_Code);
            dAd.SelectCommand.Parameters.AddWithValue("@MinePlantType", MinePlantType);
            dAd.SelectCommand.Parameters.AddWithValue("@locationcode", locationcode);
            dAd.SelectCommand.Parameters.AddWithValue("@productcode", productcode);
            dAd.SelectCommand.Parameters.AddWithValue("@empCode", empCode);
            dAd.SelectCommand.Parameters.AddWithValue("@Year", Year);
            dAd.SelectCommand.Parameters.AddWithValue("@Month", Month);
            dAd.Fill(dSet, "tbl_Select_YardMineCSY");
            return dSet.Tables["tbl_Select_YardMineCSY"];
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
    public DataTable SelectGrade(string Location)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_rptGrade", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Location", Location);
            dAd.Fill(dSet, "tbl_rptGrade");
            return dSet.Tables["tbl_rptGrade"];
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

    // Added By     : Sunil KumaR Singh
    // Date         : 17/03/2012
    // For          : State Fill

    public DataTable Fill_ProductGradeWiseType(string ProductType_Code)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectProductGradeWiseType", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@ProductType_Code", Convert.ToInt32(ProductType_Code));
            dAd.Fill(dSet, "tbl_SelectProductGradeWiseType");
            return dSet.Tables["tbl_SelectProductGradeWiseType"];
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

    public DataTable SelectState_1(string Employee)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_FillState", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@empCode", Employee);
            dAd.Fill(dSet, "tbl_SelectState");
            return dSet.Tables["tbl_SelectState"];
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
    // End
    // Added By     : Sunil KumaR Singh
    // Date         : 17/03/2012
    // For          : State Fill



    // Added By     : Vinay Dubey
    // Date         :01/03/2013
    // For          : State Fill
    public DataTable SelectState_Chq(string Employee)
    { 
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_FillState_Chq", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@empCode", Employee);
            dAd.Fill(dSet, "tbl_SelectState");
            return dSet.Tables["tbl_SelectState"];
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
    // End
    // Added By     : Vinay Dubey
    // Date         :01/03/2013
    // For          : State Fill








    // Added By     : Sunil KumaR Singh
    // Date         : 15/02/2012
    // For          : Location Fill









    public DataTable Fill_Location(string Employee)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Fill_Location", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@empCode", Employee);
            dAd.Fill(dSet, "tbl_FillLoc");
            return dSet.Tables["tbl_FillLoc"];
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

    // Added By     : Sunil KumaR Singh
    // Date         : 15/02/2012
    // For          : Location Fill
    public DataTable Fill_Customer(string Loc,string emp)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_FillCustomer", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@loc", Loc);
            dAd.SelectCommand.Parameters.AddWithValue("@Emp", emp);
            dAd.Fill(dSet, "tbl_FillCust");
            return dSet.Tables["tbl_FillCust"];
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


    // Added By     : Sunil Kumar Singh
    // Date         : 03/07/2013
    // For          : Branch Fill
    public DataTable Fill_FillBranchCustomer(string Loc, string emp)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_FillBranchCustomer", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@brcd", Loc);
            dAd.SelectCommand.Parameters.AddWithValue("@Emp", emp);
            dAd.Fill(dSet, "tbl_FillBranchCustomer");
            return dSet.Tables["tbl_FillBranchCustomer"];
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


    public DataTable Fill_Customer_AG(string Loc, string emp)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_FillCustomer_AG", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@loc", Loc);
            dAd.SelectCommand.Parameters.AddWithValue("@Emp", emp);
            dAd.Fill(dSet, "tbl_FillCust");
            return dSet.Tables["tbl_FillCust"];
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


    public DataTable SelectMine(string ProductMine, string Location)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_selectMine", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@ProductMine_Code", ProductMine);
            dAd.SelectCommand.Parameters.AddWithValue("@Location_Code", Location);
            dAd.Fill(dSet, "tbl_usp_SelectMine");
            return dSet.Tables["tbl_usp_SelectMine"];
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


    public DataTable SelectStockDumpYard(string ProductMine, string Location)
    { 
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Select_MN_StockDumpYard", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@ProductMine_Code", ProductMine);
            dAd.SelectCommand.Parameters.AddWithValue("@Location_Code", Location);
            dAd.Fill(dSet, "tbl_usp_Select_MN_StockDumpYard");
            return dSet.Tables["tbl_usp_Select_MN_StockDumpYard"];
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



    public DataTable Select_Loc_PitDistance_Mst(string PitLoc_Code, int Pit_Code, int ProductMine_Code)
    { 
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Select_MN_Loc_PitDistance_Mst", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@PitLoc_Code", PitLoc_Code);
            dAd.SelectCommand.Parameters.AddWithValue("@Pit_Code", Pit_Code);
            dAd.SelectCommand.Parameters.AddWithValue("@ProductMine_Code", ProductMine_Code);
            dAd.Fill(dSet, "tbl_MN_Loc_PitDistance_Mst");
            return dSet.Tables["tbl_MN_Loc_PitDistance_Mst"];
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




    public DataTable Select_Bench_DistanceMst(string Pit_Code)
    { 
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Select_MN_Pit_Bench_DistanceMst", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Pit_Code", Pit_Code);

            dAd.Fill(dSet, "tbl_Bench_DistanceMst");
            return dSet.Tables["tbl_Bench_DistanceMst"];
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


    public DataTable SelectQuery(string Location_Code, string Mine_Code, int level)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_selectQuery", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Location_Code", Location_Code);
            dAd.SelectCommand.Parameters.AddWithValue("@Mine_Code", Mine_Code);
            dAd.SelectCommand.Parameters.AddWithValue("@Level", level);
            dAd.Fill(dSet, "tbl_usp_SelectQuery");
            return dSet.Tables["tbl_usp_SelectQuery"];
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
    public DataTable SelectActivity(string Production_Code, string Location_Code)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_selectActivity", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@ProductActivity_Code", Production_Code);
            dAd.SelectCommand.Parameters.AddWithValue("@Location_Code", Location_Code);
            dAd.Fill(dSet, "tbl_usp_SelectQuery");
            return dSet.Tables["tbl_usp_SelectQuery"];
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

    public DataTable SelectProduct()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectProduct", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@empCode", HttpContext.Current.Session["LogIn_Code"].ToString());
            dAd.Fill(dSet, "tbl_usp_SelectProduct");
            return dSet.Tables["tbl_usp_SelectProduct"];
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



    public DataTable SelectGRNBY(string Location_Code)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SELECTGRNBY", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Location_Code", Location_Code);
            dAd.Fill(dSet, "tbl_SELECTGRNBY");
            return dSet.Tables["tbl_SELECTGRNBY"];
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

    public DataTable SelectCustomerNameByLocation(string Location)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_selectCustomerName", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@LocationCode", Location);
            dAd.Fill(dSet, "tbl_usp_selectCustomerName");
            return dSet.Tables["tbl_usp_selectCustomerName"];
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

    public DataTable SelectActivity()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_selectQuery", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            // dAd.SelectCommand.Parameters.AddWithValue("@Product", Product);
            dAd.Fill(dSet, "tbl_usp_SelectQuery");
            return dSet.Tables["tbl_usp_SelectQuery"];
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

    public DataTable SelectMonthYears()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectMonthYears", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@emp", HttpContext.Current.Session["LogIn_Code"].ToString());
            dAd.Fill(dSet, "tbl_MonthYears");
            return dSet.Tables["tbl_MonthYears"];
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
    public DataTable SelectCustomer(string Customercode, string CustomerName)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_selectCustomerAuto", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Customercode", Customercode);
            dAd.SelectCommand.Parameters.AddWithValue("@CustomerName", CustomerName);
            dAd.SelectCommand.Parameters.AddWithValue("@Employee_Code", HttpContext.Current.Session["LogIn_Code"].ToString());
            dAd.Fill(dSet, "tbl_Customer");
            return dSet.Tables["tbl_Customer"];
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

    public DataTable SelectJS(string Customercode, string JSRef_Code)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_selectJSAuto", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Customercode", Customercode);
            dAd.SelectCommand.Parameters.AddWithValue("@JSRef_Code", JSRef_Code);
            dAd.Fill(dSet, "tbl_Customer");
            return dSet.Tables["tbl_Customer"];
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
  
    public DataTable SelectCity()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("SP_SelectCity", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.Fill(dSet, "tbl_SP_SelectCity");
            return dSet.Tables["tbl_SP_SelectCity"];
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
    public DataTable SelectState(string city_code)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_selectState", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@city_code", city_code);

            dAd.Fill(dSet, "tbl_SP_SelectState");
            return dSet.Tables["tbl_SP_SelectState"];
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
    public DataTable SelectCountry()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("SP_SelectCountry", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.Fill(dSet, "tbl_SP_SelectCity");
            return dSet.Tables["tbl_SP_SelectCity"];
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
    public DataTable Fill_ProductType(string Product)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectProductType", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();

        try
        {

            dAd.SelectCommand.Parameters.AddWithValue("@productCode", Product);
            dAd.Fill(dSet, "tbl_custProductInfo");
            return dSet.Tables["tbl_custProductInfo"];
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
    public DataTable Fill_ProductGrade(string Product)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectProductGrade", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();

        try
        {

            dAd.SelectCommand.Parameters.AddWithValue("@productCode", Product);
            dAd.Fill(dSet, "tbl_custProductInfo");
            return dSet.Tables["tbl_custProductInfo"];
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
    public DataTable Fill_ProductSize(string Product)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectProductSize", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();

        try
        {

            dAd.SelectCommand.Parameters.AddWithValue("@productCode", Product);
            dAd.Fill(dSet, "tbl_custProductInfo");
            return dSet.Tables["tbl_custProductInfo"];
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
    public DataTable Fill_ProductSpecification(string Value)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectProductSpecification", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();

        try
        {

            dAd.SelectCommand.Parameters.AddWithValue("@value", Value);
            dAd.Fill(dSet, "tbl_custProductSpec");
            return dSet.Tables["tbl_custProductSpec"];
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
    public DataTable SelectLaboratory()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectLaboratory", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            // dAd.SelectCommand.Parameters.AddWithValue("@Product", Product);
            dAd.Fill(dSet, "tbl_usp_SelectQuery");
            return dSet.Tables["tbl_usp_SelectQuery"];
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

    public DataTable Fill_GroupMaster()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Select_CustomerGroup_Mst", conn);
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

    public DataTable Fill_Industry()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectIndustry", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();

        try
        {
            dAd.Fill(dSet, "tbl_usp_SelectIndustry");
            return dSet.Tables["tbl_usp_SelectIndustry"];
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
    public DataTable SelectDC(string DC_No, string fromdate, string todate, string custcode, string SO)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectDCAuto", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@DC_No", DC_No);
            dAd.SelectCommand.Parameters.AddWithValue("@fromdate", fromdate);
            dAd.SelectCommand.Parameters.AddWithValue("@todate", todate);
            dAd.SelectCommand.Parameters.AddWithValue("@custcode", custcode);
            dAd.SelectCommand.Parameters.AddWithValue("@SO", SO);
            dAd.Fill(dSet, "tbl_DC");
            return dSet.Tables["tbl_DC"];
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
    public DataTable selectCustomerLedgerAuto(string ledgerCode, string CustomerName)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("[usp_selectCustomerLegderAuto]", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@ledgerCode", ledgerCode);
            dAd.SelectCommand.Parameters.AddWithValue("@CustomerName", CustomerName);
            dAd.SelectCommand.Parameters.AddWithValue("@Employee_Code", HttpContext.Current.Session["LogIn_Code"].ToString());
            dAd.Fill(dSet, "tbl_usp_selectCustomerLegderAuto");
            return dSet.Tables["tbl_usp_selectCustomerLegderAuto"];
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


    public DataTable get_ProductTypeCode(string productCode, int ProductMine_Code)
    {
      
       // SqlCommand dCmd = new SqlCommand("usp_Get_ProductTypeCode", conn);//  dCmd.Parameters.AddWithValue("@productCode", productCode);    
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("[usp_Get_ProductTypeCode]", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@productCode", productCode);
            dAd.SelectCommand.Parameters.AddWithValue("@ProductMine_Code", ProductMine_Code);
            
            dAd.Fill(dSet, "tbl_");
            return dSet.Tables["tbl_"];
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

    public DataTable SelectFormType(string Product, string taxUtilityCode,string PoDate)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectForm", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@ProductCode", Product);
            dAd.SelectCommand.Parameters.AddWithValue("@taxUtilityCode", taxUtilityCode);
            dAd.SelectCommand.Parameters.AddWithValue("@PoDate", PoDate);
            dAd.Fill(dSet, "tbl_usp_SelectForm");
            return dSet.Tables["tbl_usp_SelectForm"];
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

    public DataTable SelectBankname(string bankName)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_BanknameAutoextender", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@bankName", bankName);
            dAd.Fill(dSet, "tbl_usp_SelectbankName");
            return dSet.Tables["tbl_usp_SelectbankName"];
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
    public DataTable SelectVendorCodeForLaboratory()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectVendorCodeForLaboratory", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.Fill(dSet, "tbl_usp_SelectVendorCodeForLaboratory");
            return dSet.Tables["tbl_usp_SelectVendorCodeForLaboratory"];
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

    public DataTable get_ItemNameMaster(int itemTypeCode)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Select_ItemName_Master", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@itemTypeCode", itemTypeCode);

            dAd.Fill(dSet, "tbl_ItemName_Master");
            return dSet.Tables["tbl_ItemName_Master"];
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

    //--------------------- Added Date : 21-02-2012 ---------------------------//
    //--------------------- Added By: Devendra Kumar --------------------------//

    public DataTable FillBillAgeing(int level)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_FillBill_Ageing", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@level", level);
            dAd.Fill(dSet, "tbl_FillBill_Ageing");
            return dSet.Tables["tbl_FillBill_Ageing"];
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

    public DataTable Fill_POStatusRemark(string level)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectPOTypeOfRemarks_Mst", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@level", level);
            dAd.Fill(dSet, "tbl_SelectPOTypeOfRemarks_Mst");
            return dSet.Tables["tbl_SelectPOTypeOfRemarks_Mst"];
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

    public DataTable Fill_SelectCustomerPO(string Date, string Location, string CustCode)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectCustomerPO", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Date", Date);
            dAd.SelectCommand.Parameters.AddWithValue("@Location", Location);
            dAd.SelectCommand.Parameters.AddWithValue("@CustCode", CustCode);
            dAd.Fill(dSet, "tbl_SelectCustomerPO");
            return dSet.Tables["tbl_SelectCustomerPO"];
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

    public DataSet POReport_OnLoad(string CustGroup_Code, string Lstatus, string Location_Code)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_POReport_OnLoad", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@CustGroup_Code", CustGroup_Code);
            dAd.SelectCommand.Parameters.AddWithValue("@Lstatus", Lstatus);
            dAd.SelectCommand.Parameters.AddWithValue("@Location_Code", Location_Code);
            dAd.SelectCommand.Parameters.AddWithValue("@Employee_Code", HttpContext.Current.Session["LogIn_Code"].ToString());
            dAd.Fill(dSet, "tbl_");
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


    //--------------------- Added Date : 23-02-2012 ---------------------------//
    //--------------------- Added By: Devendra Kumar --------------------------//

    public DataTable SelectDispatchRefNo(string cust)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectDispatchRefNo_Auto", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@cust", cust);
            dAd.Fill(dSet, "tbl_SelectDS");
            return dSet.Tables["tbl_SelectDS"];
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

    public DataTable SelectSONoDispatched(string SoNo, string custCode)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectSONO_IsDispatched", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@So_No", SoNo);
            dAd.SelectCommand.Parameters.AddWithValue("@custCode", custCode);
            dAd.Fill(dSet, "tbl_SelectDS");
            return dSet.Tables["tbl_SelectDS"];
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

    //------------------- Created By[Vinay-Dubey] Created Date[05-01-2012]-------------//
    public DataTable Select_ProductMaster()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Select_ActivityMaster", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.Fill(dSet, "tbl_Select_ActivityMaster");
            return dSet.Tables["tbl_Select_ActivityMaster"];
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

    // Added By Sunil KumaR Singh
    // Date: 22/03/2012
    public DataTable SelectCustomerGroup()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectCustomerGroup_Mst", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.Fill(dSet, "tbl_SelectCustomerGroup");
            return dSet.Tables["tbl_SelectCustomerGroup"];
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

    // Added By     : Ashok Kumar
    // Date         : 22/03/2012
    // For          : Location Fill for Pulverization
    public DataTable Fill_LocationForPulverization(string Employee)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Fill_LocationForPulverization", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@empCode", Employee);
            dAd.Fill(dSet, "tbl_FillLoc");
            return dSet.Tables["tbl_FillLoc"];
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

    // Added By : Sunil Kumar Singh
    // Date : 12/04/2012
    // Desc : Location Branch

    public DataTable SelectLocBranch(string Loc)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_locBranch", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@loc", Loc);
            dAd.Fill(dSet, "tbl_locBranch");
            return dSet.Tables["tbl_locBranch"];
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


      // Added By     : Ashok Kumar
    // Date         : 1/08/2012
    // For          : Activities Reason


    public DataTable SelectActivitiesReason()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Fill_ActivitiesReason", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.Fill(dSet, "tbl_Select");
            return dSet.Tables["tbl_Select"];
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


    public DataTable Fill_StatusOfVisit()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Fill_StatusOfVisit_Mst", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.Fill(dSet, "tbl_StatusOfVisit");
            return dSet.Tables["tbl_StatusOfVisit"];
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

    public DataTable Fill_StageOfVisit()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Fill_StageOfVisit_Mst", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.Fill(dSet, "tbl_StageOfVisit");
            return dSet.Tables["tbl_StageOfVisit"];
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
    public DataTable Fill_StageOfVisit(string CustCode, string Location_Code)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Select_CustomerStage", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {    
            dAd.SelectCommand.Parameters.AddWithValue("@CustCode",CustCode);
            dAd.SelectCommand.Parameters.AddWithValue("@Location_Code",Location_Code);
            dAd.Fill(dSet, "tbl_StageOfVisit");
            return dSet.Tables["tbl_StageOfVisit"];
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

    public DataTable Fill_PurposeOfVisit()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Fill_PurposeOfVisit_Mst", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.Fill(dSet, "tbl_PurposeOfVisit");
            return dSet.Tables["tbl_PurposeOfVisit"];
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

    public DataTable Select_Stage(int stage)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Select_Stage", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@STAGE", stage);
            dAd.Fill(dSet, "tbl_Select_Stage");
            return dSet.Tables["tbl_Select_Stage"];
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

    //-----------------------------------Added By Vinay Kathera on 27/08/2012------------------------------//
    //-----------------------------------Desc: select Address or ID proof----------------------------------//

    public DataTable SelectAddress_ID_proof()
    {
        SqlConnection conn = new SqlConnection(connHRM);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_SelectAddress_ID_proof", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            // dAd.SelectCommand.Parameters.AddWithValue("@proof_Type", proof_Type);
            dAd.Fill(dSet, "tbl_Address_ID_proof");
            return dSet.Tables["tbl_Address_ID_proof"];
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
   //Added By Ashok : 30-03-2013

    public DataTable Select_LocationWiseEmployee(string LocationCode)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Select_LocationWiseEmployee", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@LocationCode", LocationCode);
            dAd.Fill(dSet, "tbl_Employee");
            return dSet.Tables["tbl_Employee"];
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

    public DataTable SelectState_Branch(string Employee,string compcode)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_FillState_1", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@empCode", Employee);
            dAd.SelectCommand.Parameters.AddWithValue("@compcode", compcode);
            dAd.Fill(dSet, "tbl_SelectState");
            return dSet.Tables["tbl_SelectState"];
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

    //----------Added By Vinay Kathera on 20th aug 2013--------------------//
    //---------Fill Office Boys List----------------//
    public DataTable Fill_OfficeBoyList(string employee_code, string branch_code)
    {
        SqlConnection conn = new SqlConnection(connHRM);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Fill_OfficeboysList", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@employee_code", employee_code);
            dAd.SelectCommand.Parameters.AddWithValue("@branch_code", branch_code);

            dAd.Fill(dSet, "tbl_usp_Fill_OfficeboysList");
            return dSet.Tables["tbl_usp_Fill_OfficeboysList"];
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

//----------Added By Vinay Kathera on 04/09/2013--------------------//
    //---------List Of Assumption UOM----------------//

    public DataTable ListOf_AssumtionUOM(int uomid)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_ListOf_AssumtionUOM", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@uomid", uomid);

            dAd.Fill(dSet, "tbl_usp_ListOf_AssumtionUOM");
            return dSet.Tables["tbl_usp_ListOf_AssumtionUOM"];
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

    public DataTable Select_DC_Location(string DCNo)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_DCLocation", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@DCNO", DCNo);

            dAd.Fill(dSet, "tbl_DCLocation");
            return dSet.Tables["tbl_DCLocation"];
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

   
    public DataTable Fill_Customer_ForGroup(string Loc, string emp)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_FillCustomer_WithGroup", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@loc", Loc);
            dAd.SelectCommand.Parameters.AddWithValue("@Emp", emp);
            dAd.Fill(dSet, "tbl_FillCustWithGroup");
            return dSet.Tables["tbl_FillCustWithGroup"];
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

    //----------Added By Ashok Gupta on 01/01/2014--------------------//
    //---------List Of Assumption UOM----------------//

    public DataTable ListOf_BagType()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("USP_EX_EXPORTLEAD_PACKAGING", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.Fill(dSet, "tbl_BagType");
            return dSet.Tables["tbl_BagType"];
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
    public DataTable FQ_ProductSpecification(string productcode, string SpecType)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_FQ_ProductSpecification", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        dAd.SelectCommand.Parameters.AddWithValue("@productcode", productcode);
        dAd.SelectCommand.Parameters.AddWithValue("@SpecType", SpecType);
        DataSet dSet = new DataSet();
        try
        {
            dAd.Fill(dSet, "tbl_ProdSpec");
            return dSet.Tables["tbl_ProdSpec"];
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
    // Added By : Sunil Kumar Singh Dated:24/05/2014

    public DataTable loc()
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_loc", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.Fill(dSet, "tbl_loc");
            return dSet.Tables["tbl_loc"];
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
    // Added By Ashok Gupta =04/06/2014
    public DataTable FQ_AgentList(string lcode)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_FQ_AgentList", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        dAd.SelectCommand.Parameters.AddWithValue("@lcode", lcode);
        DataSet dSet = new DataSet();
        try
        {
            dAd.Fill(dSet, "tbl_AgentList");
            return dSet.Tables["tbl_AgentList"];
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
    //--------------- Added By :Devendra Kumar---------------
    //--------------- Added Date:18/01/2016 ------------------
    public DataTable Select_Cards(string Branch_Code)
    {

        SqlConnection conn = new SqlConnection(connHRM);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Select_Card", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Branch_Code", Branch_Code);

            dAd.Fill(dSet, "tbl_Card_Mst");
            return dSet.Tables["tbl_Card_Mst"];
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

    public DataTable SelectCustomerInfo_Calyx(string CustType)
    {
        SqlConnection conn = new SqlConnection(connStr_calyx);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Fill_CustomerGenInfo", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@Customer_Type", CustType);
            dAd.Fill(dSet, "tbl_CustomerGenInfo_");
            return dSet.Tables["tbl_CustomerGenInfo_"];
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


    public DataTable Select_Vendor_Calyx()
    {
        SqlConnection Conn = new SqlConnection(connStr_calyx);

        // usp_Select_Vendor;
        SqlDataAdapter sda = new SqlDataAdapter("usp_Vendor", Conn);
        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        try
        {
            sda.Fill(dt);
            return dt;
        }
        catch
        {
            throw;
        }
        finally
        {
            dt.Dispose();
            sda.Dispose();
            Conn.Close();
            Conn.Dispose();
        }

    }

    //----- Added By   : Ashish Kalsarpe
    //----- Added Date : 22/06/2017

    public DataTable Select_City_Mst(string STATE_ID)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("[usp_Select_City_Mst]", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@STATE_ID", STATE_ID);
            dAd.Fill(dSet, "tbl_CityMst_SGX");
            return dSet.Tables["tbl_CityMst_SGX"];
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
    //----------Rohit Chaurasiya on 02/21/2023-------
    //---------Fill Fill_Vertical Name----------------//
    public DataTable Select_Vertical_Mst()
    {
        SqlConnection conn = new SqlConnection(connHRM);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Select_Verticals_Mst", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        try
        {
            dAd.Fill(dt);
            return dt;
        }
        catch
        {
            throw;
        }
        finally
        {
            dt.Dispose();
            dt.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }
    //---------Fill Fill_Project Name----------------//
    public DataTable Select_Project_Mst()
    {
        SqlConnection conn = new SqlConnection(connHRM);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Select_Project_Mst", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        try
        {
            dAd.Fill(dt);
            return dt;
        }
        catch
        {
            throw;
        }
        finally
        {
            dt.Dispose();
            dt.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }
    //---------Fill Fill_CostCode Name----------------//
    public DataTable Select_CostCode_Mst()
    {
        SqlConnection conn = new SqlConnection(connHRM);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_Select_CCName_Mst", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        try
        {
            dAd.Fill(dt);
            return dt;
        }
        catch
        {
            throw;
        }
        finally
        {
            dt.Dispose();
            dt.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }
    //----------Rohit Chaurasiya on 02/21/2023-------
    //---------Fill Fill_AREA----------------//

    public DataTable AREA_FILL(string Employee)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_FillState", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@empCode", Employee);
            dAd.Fill(dSet, "tbl_SelectState");
            return dSet.Tables["tbl_SelectState"];
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

    public DataTable A_FILL(string Employee)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_FillState", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@empCode", Employee);
            dAd.Fill(dSet, "tbl_SelectState");
            return dSet.Tables["tbl_SelectState"];
        }
        catch
        { throw; }
        finally
        {
            dSet.Dispose();
            dAd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    public DataTable Select_Mine(string ProductMine, string Location)
    {
        SqlConnection conn = new SqlConnection(connSGX);
        SqlDataAdapter dAd = new SqlDataAdapter("usp_selectMine", conn);
        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet dSet = new DataSet();
        try
        {
            dAd.SelectCommand.Parameters.AddWithValue("@ProductMine_Code", ProductMine);
            dAd.SelectCommand.Parameters.AddWithValue("@Location_Code", Location);
            dAd.Fill(dSet, "tbl_usp_SelectMine");
            return dSet.Tables["tbl_usp_SelectMine"];
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
