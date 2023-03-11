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

public class BALSGX_SelectCommonMaster
{
    public BALSGX_SelectCommonMaster()
    {

    }
    public DataTable SelectJoint(string custcode, string CustPO_No, string CustPODate)
    {
        DALSGX_SelectCommonMaster pono = new DALSGX_SelectCommonMaster();
        try
        {
            return pono.SelectJoint(custcode, CustPO_No, CustPODate);
        }
        catch
        {
            throw;
        }
        finally
        {
            pono = null;
        }
    }
    //Added By : Vinay Kathera on 06-08-2012
    //Desc: date wise location wise shift wise status checking for all MN Entry Pages
    public DataTable Show_MNAuthorityStatus(string Activities_ID, string DayOpen, string Location_Code, string Shift_Code, string Mine_Code)
    {
        DALSGX_SelectCommonMaster pono = new DALSGX_SelectCommonMaster();
        try
        {
            return pono.Show_MNAuthorityStatus(Activities_ID, DayOpen, Location_Code, Shift_Code, Mine_Code);
        }
        catch
        {
            throw;
        }
        finally
        {
            pono = null;
        }
    }
    //Ended By : Vinay Kathera on 06-08-2012
    //Desc: date wise location wise shift wise status checking for all MN Entry Pages
    public DataTable SelectSaleOrder(string SO_No, string custCode)
    {
        DALSGX_SelectCommonMaster sono = new DALSGX_SelectCommonMaster();
        try
        {
            return sono.SelectSaleOrder(SO_No, custCode);
        }
        catch
        {
            throw;
        }
        finally
        {
            sono = null;
        }
    }
    // Added By     : Sunil KumaR Singh
    // Date         : 17/03/2012
    // For          : State Fill
    public DataTable SelectState_1(string Employee)
    {
        DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
        try
        {
            return Location.SelectState_1(Employee);
        }
        catch
        {
            throw;
        }
        finally
        {
            Location = null;
        }
    }
    // End
    // Added By     : Sunil KumaR Singh
    // Date         : 17/03/2012
    // For          : State Fill




    public DataTable SelectState_Chq(string Employee)
    {
        DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
        try
        {
            return Location.SelectState_Chq(Employee);
        }
        catch
        {
            throw;
        }
        finally
        {
            Location = null;
        }
    }





    public DataTable Fill_ProductGradeWiseType(string Type)
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.Fill_ProductGradeWiseType(Type);
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
    public DataTable SelectLocation(string Product, string Location1, string Employee)
    {
        DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
        try
        {
            return Location.SelectLocation(Product, Location1, Employee);
        }
        catch
        {
            throw;
        }
        finally
        {
            Location = null;
        }
    }


    // 27/12/2021
    public DataTable SelectLocationState(string Location)
    {
        DALSGX_SelectCommonMaster LocState = new DALSGX_SelectCommonMaster();
        try
        {
            return LocState.SelectLocationState(Location);
        }
        catch
        {
            throw;
        }
        finally
        {
            LocState = null;
        }
    }

    // End
    // Added By     : Sunil KumaR Singh
    // Date         : 17/03/2012
    // For          : State Fill


    //Manish 22-jan-2013 for Yard Select
    public DataTable SelectYard(string Mine_Code, string MinePlantType, string locationcode, string productcode, string empCode, string Year, string Month)
    {
        DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
        try
        {
            return Location.SelectYard(Mine_Code, MinePlantType, locationcode, productcode, empCode, Year, Month);
        }
        catch
        {
            throw;
        }
        finally
        {
            Location = null;
        }
    }
    // End Manish 
    public DataTable SelectGrade(string Location)
    {
        DALSGX_SelectCommonMaster Grade = new DALSGX_SelectCommonMaster();
        try
        {
            return Grade.SelectGrade(Location);
        }
        catch
        {
            throw;
        }
        finally
        {
            Grade = null;
        }
    }


    // Added By     : Sunil KumaR Singh
    // Date         : 15/02/2012
    // For          : Location Fill
    public DataTable Fill_Location(string Employee)
    {
        DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
        try
        {
            return Location.Fill_Location(Employee);
        }
        catch
        {
            throw;
        }
        finally
        {
            Location = null;
        }
    }

    // Added By     : Sunil KumaR Singh
    // Date         : 15/02/2012
    // For          : Location Fill
    public DataTable Fill_Customer(string Loc,string emp)
    {
        DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
        try
        {
            return Location.Fill_Customer(Loc, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            Location = null;
        }
    }

    // Added By     : Sunil Kumar Singh
    // Date         : 03/02/2012
    // For          : Branch Fill
    public DataTable Fill_FillBranchCustomer(string Loc, string emp)
    {
        DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
        try
        {
            return Location.Fill_FillBranchCustomer(Loc, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            Location = null;
        }
    }

    public DataTable Fill_Customer_AG(string Loc, string emp)
    {
        DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
        try
        {
            return Location.Fill_Customer_AG(Loc, emp);
        }
        catch
        {
            throw;
        }
        finally
        {
            Location = null;
        }
    }


    public DataTable SelectMine(string ProductMine, string Location)
    {
        DALSGX_SelectCommonMaster Loc = new DALSGX_SelectCommonMaster();
        try
        {
            return Loc.SelectMine(ProductMine, Location);
        }
        catch
        {
            throw;
        }
        finally
        {
            Loc = null;
        }
    }


    public DataTable SelectStockDumpYard(string ProductMine, string Location)
    { 
        DALSGX_SelectCommonMaster Loc = new DALSGX_SelectCommonMaster();
        try
        {
            return Loc.SelectStockDumpYard(ProductMine, Location);
        }
        catch
        {
            throw;
        }
        finally
        {
            Loc = null;
        }
    }


    public DataTable Select_Loc_PitDistance_Mst(string PitLoc_Code, int Pit_Code, int ProductMine_Code)
    { 
        DALSGX_SelectCommonMaster Loc = new DALSGX_SelectCommonMaster();
        try
        {
            return Loc.Select_Loc_PitDistance_Mst(PitLoc_Code, Pit_Code, ProductMine_Code);
        }
        catch
        {
            throw;
        }
        finally
        {
            Loc = null;
        }
    }




    public DataTable Select_Bench_DistanceMst(string Pit_Code)
    { 
        DALSGX_SelectCommonMaster Loc = new DALSGX_SelectCommonMaster();
        try
        {
            return Loc.Select_Bench_DistanceMst(Pit_Code);
        }
        catch
        {
            throw;
        }
        finally
        {
            Loc = null;
        }
    }




    public DataTable SelectQuery(string Location_Code, string Mine_Code, int level)
    {
        DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
        try
        {
            return Location.SelectQuery(Location_Code, Mine_Code, level);
        }
        catch
        {
            throw;
        }
        finally
        {
            Location = null;
        }
    }
    public DataTable SelectActivity(string Production_Code, string Location_Code)
    {
        DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
        try
        {
            return Location.SelectActivity(Production_Code, Location_Code);
        }
        catch
        {
            throw;
        }
        finally
        {
            Location = null;
        }
    }
    public DataTable SelectProduct()
    {
        DALSGX_SelectCommonMaster Product = new DALSGX_SelectCommonMaster();
        try
        {
            return Product.SelectProduct();
        }
        catch
        {
            throw;
        }
        finally
        {
            Product = null;
        }
    }
    public DataTable SelectGRNBY(string Location_Code)
    {
        DALSGX_SelectCommonMaster Product = new DALSGX_SelectCommonMaster();
        try
        {
            return Product.SelectGRNBY(Location_Code);
        }
        catch
        {
            throw;
        }
        finally
        {
            Product = null;
        }
    }
    public DataTable SelectCustomerNameByLocation(string Location)
    {
        DALSGX_SelectCommonMaster Product = new DALSGX_SelectCommonMaster();
        try
        {
            return Product.SelectCustomerNameByLocation(Location);
        }
        catch
        {
            throw;
        }
        finally
        {
            Product = null;
        }
    }
    public DataTable SelectMonthYears()
    {

        DALSGX_SelectCommonMaster Product = new DALSGX_SelectCommonMaster();
        try
        {
            return Product.SelectMonthYears();
        }
        catch
        {
            throw;
        }
        finally
        {
            Product = null;
        }
    }
    public DataTable SelectCustomer(string prefixText, string prefixText1)
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.SelectCustomer(prefixText, prefixText1);
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
    public DataTable SelectJS(string prefixText, string prefixText1)
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.SelectJS(prefixText, prefixText1);
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
   
    public DataTable SelectCity()
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.SelectCity();
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
    public DataTable SelectState(string city_code)
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.SelectState(city_code);
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
    public DataTable SelectCountry()
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.SelectCountry();
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
    public DataTable Fill_ProductType(string Product)
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.Fill_ProductType(Product);
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
    public DataTable Fill_ProductGrade(string Product)
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.Fill_ProductGrade(Product);
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
    public DataTable Fill_ProductSize(string Product)
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.Fill_ProductSize(Product);
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
    public DataTable Fill_ProductSpecification(string Value)
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.Fill_ProductSpecification(Value);
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
    public DataTable SelectLaboratory()
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.SelectLaboratory();
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
    public DataTable Fill_GroupMaster()
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.Fill_GroupMaster();
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
    public DataTable Fill_Industry()
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.Fill_Industry();
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
    public DataTable SelectDC(string DC_No, string fromdate, string todate, string custcode,string SO)
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.SelectDC(DC_No, fromdate, todate, custcode, SO);
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
    public DataTable selectCustomerLedgerAuto(string ledgerCode, string CustomerName)
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.selectCustomerLedgerAuto(ledgerCode, CustomerName);
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
    public DataTable get_ProductTypeCode(string productCode, int ProductMine_Code)
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.get_ProductTypeCode(productCode, ProductMine_Code);
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }

    public DataTable SelectFormType(string Product, string taxUtilityCode, string PoDate)
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.SelectFormType(Product, taxUtilityCode, PoDate);
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }



    public DataTable SelectBankname(string bankName)
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.SelectBankname(bankName);
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }
    public DataTable SelectVendorCodeForLaboratory()
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.SelectVendorCodeForLaboratory();
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }

    public DataTable get_ItemNameMaster(int itemTypeCode)
    {
        DALSGX_SelectCommonMaster Product = new DALSGX_SelectCommonMaster();
        try
        {
            return Product.get_ItemNameMaster(itemTypeCode);
        }
        catch
        {
            throw;
        }
        finally
        {
            Product = null;
        }
    }

    //--------------------- Added Date : 21-02-2012 ---------------------------//
    //--------------------- Added By: Devendra Kumar --------------------------//

    public DataTable FillBillAgeing(int level)
    {
        DALSGX_SelectCommonMaster Product = new DALSGX_SelectCommonMaster();
        try
        {
            return Product.FillBillAgeing(level);
        }
        catch
        {
            throw;
        }
        finally
        {
            Product = null;
        }
    }
    
    public DataTable Fill_POStatusRemark(string level)
    {
        DALSGX_SelectCommonMaster Product = new DALSGX_SelectCommonMaster();
        try
        {
            return Product.Fill_POStatusRemark(level);
        }
        catch
        {
            throw;
        }
        finally
        {
            Product = null;
        }
    }
   
    public DataTable Fill_SelectCustomerPO(string Date, string Location, string CustCode)
    {
        DALSGX_SelectCommonMaster Product = new DALSGX_SelectCommonMaster();
        try
        {
            return Product.Fill_SelectCustomerPO(Date, Location, CustCode);
        }
        catch
        {
            throw;
        }
        finally
        {
            Product = null;
        }
    }

    public DataSet POReport_OnLoad(string CustGroup_Code, string Lstatus, string Location_Code)
    {
        DALSGX_SelectCommonMaster Product = new DALSGX_SelectCommonMaster();
        try
        {
            return Product.POReport_OnLoad(CustGroup_Code, Lstatus, Location_Code);
        }
        catch
        {
            throw;
        }
        finally
        {
            Product = null;
        }
    }

    //--------------------- Added Date : 23-02-2012 ---------------------------//
    //--------------------- Added By: Devendra Kumar --------------------------//

    public DataTable SelectDispatchRefNo(string cust)
    {
        DALSGX_SelectCommonMaster dsno = new DALSGX_SelectCommonMaster();
        try
        {
            return dsno.SelectDispatchRefNo(cust);
        }
        catch
        {
            throw;
        }
        finally
        {
            dsno = null;
        }
    }

    public DataTable SelectSONoDispatched(string SoNo, string custCode)
    {
        DALSGX_SelectCommonMaster dsno = new DALSGX_SelectCommonMaster();
        try
        {
            return dsno.SelectSONoDispatched(SoNo, custCode);
        }
        catch
        {
            throw;
        }
        finally
        {
            dsno = null;
        }
    }

    //------------------- Created By[Vinay-Dubey] Created Date[05-01-2012]-------------//

    public DataTable Select_ActivityMaster()
    {
        DALSGX_SelectCommonMaster Product = new DALSGX_SelectCommonMaster();
        try
        {
            return Product.Select_ProductMaster();
        }
        catch
        {
            throw;
        }
        finally
        {
            Product = null;
        }
    }
    // Added BY Sunil Kumar Singh
    // Date; 22/03/2012
    public DataTable SelectCustomerGroup()
    {
        DALSGX_SelectCommonMaster Product = new DALSGX_SelectCommonMaster();
        try
        {
            return Product.SelectCustomerGroup();
        }
        catch
        {
            throw;
        }
        finally
        {
            Product = null;
        }
    }

    // Added By     : Ashok Kumar
    // Date         : 22/03/2012
    // For          : Location Fill for Pulverization
    public DataTable Fill_LocationForPulverization(string Employee)
    {
        DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
        try
        {
            return Location.Fill_LocationForPulverization(Employee);
        }
        catch
        {
            throw;
        }
        finally
        {
            Location = null;
        }
    }

    // Added By     : Sunil KumaR Singh
    // Date         : 12/04/2012
    // For          : Location Branch

    public DataTable SelectLocBranch(string loc)
    {
        DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
        try
        {
            return Location.SelectLocBranch(loc);
        }
        catch
        {
            throw;
        }
        finally
        {
            Location = null;
        }
    }
    // Added By     : Ashok Kumar
    // Date         : 1/08/2012
    // For          : Activities Reason


    public DataTable SelectActivitiesReason()
    {
        DALSGX_SelectCommonMaster ActivitiesReason = new DALSGX_SelectCommonMaster();
        try
        {
            return ActivitiesReason.SelectActivitiesReason();
        }
        catch
        {
            throw;
        }
        finally
        {
            ActivitiesReason = null;
        }
    }
 public DataTable Fill_StatusOfVisit()
    {
        DALSGX_SelectCommonMaster comm = new DALSGX_SelectCommonMaster();
        try
        {
            return comm.Fill_StatusOfVisit();
        }
        catch
        {
            throw;
        }
        finally
        {
            comm = null;
        } 

    }

    public DataTable Fill_StageOfVisit()
    {
        DALSGX_SelectCommonMaster comm = new DALSGX_SelectCommonMaster();
        try
        {
            return comm.Fill_StageOfVisit();
        }
        catch
        {
            throw;
        }
        finally
        {
            comm = null;
        } 
    }
    public DataTable Fill_StageOfVisit(string CustCode, string Location_Code)
    {
        DALSGX_SelectCommonMaster comm = new DALSGX_SelectCommonMaster();
        try
        {
            return comm.Fill_StageOfVisit(CustCode, Location_Code);
        }
        catch
        {
            throw;
        }
        finally
        {
            comm = null;
        }
    }

    public DataTable Fill_PurposeOfVisit()
    {
        DALSGX_SelectCommonMaster comm = new DALSGX_SelectCommonMaster();
        try
        {
            return comm.Fill_PurposeOfVisit();
        }
        catch
        {
            throw;
        }
        finally
        {
            comm = null;
        } 

    }
    public DataTable Select_Stage(int stage)
    {
        DALSGX_SelectCommonMaster customer = new DALSGX_SelectCommonMaster();
        try
        {
            return customer.Select_Stage(stage);
        }
        catch
        {
            throw;
        }
        finally
        {
            customer = null;
        }
    }

    //-----------------------------------Added By Vinay Kathera on 27/08/2012------------------------------//
    //-----------------------------------Desc: select Address or ID proof----------------------------------//

    public DataTable SelectAddress_ID_proof()
    {
        DALSGX_SelectCommonMaster proof = new DALSGX_SelectCommonMaster();
        try
        {
            return proof.SelectAddress_ID_proof();
        }
        catch
        {
            throw;
        }
        finally
        {
            proof = null;
        }
    }


    //-----------------------------------Added By Ashok on 02/04/2013------------------------------//
 
 public DataTable Select_LocationWiseEmployee(string LocationCode)
    {
        DALSGX_SelectCommonMaster proof = new DALSGX_SelectCommonMaster();
        try
        {
            return proof.Select_LocationWiseEmployee(LocationCode);
        }
        catch
        {
            throw;
        }
        finally
        {
            proof = null;
        } 
    }

 public DataTable SelectState_Branch(string Employee, string compcode)
 {
     DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
     try
     {
         return Location.SelectState_Branch(Employee, compcode);
     }
     catch
     {
         throw;
     }
     finally
     {
         Location = null;
     }
 }
    //----------Added By Vinay Kathera on 20th aug 2013--------------------//
    //---------Fill Office Boys List----------------//
 public DataTable Fill_OfficeBoyList(string employee_code, string branch_code)
 {
     DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
     try
     {
         return Location.Fill_OfficeBoyList(employee_code, branch_code);
     }
     catch
     {
         throw;
     }
     finally
     {
         Location = null;
     }
 }

  //----------Added By Vinay Kathera on 04/09/2013--------------------//
    //---------List Of Assumption UOM----------------//

 public DataTable ListOf_AssumtionUOM(int uomid)
 {
     DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
     try
     {
         return Location.ListOf_AssumtionUOM(uomid);
     }
     catch
     {
         throw;
     }
     finally
     {
         Location = null;
     }
 }

 public DataTable Select_DC_Location(string DCNo)
 {
     DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
     try
     {
         return Location.Select_DC_Location(DCNo);
     }
     catch
     {
         throw;
     }
     finally
     {
         Location = null;
     }
 }


 public DataTable Fill_Customer_ForGroup(string Loc, string emp)
 {
     DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
     try
     {
         return Location.Fill_Customer_ForGroup(Loc, emp);
     }
     catch
     {
         throw;
     }
     finally
     {
         Location = null;
     }
 }

 //----------Added By Ashok Gupta on 01/01/2014--------------------//
 //---------List Of Assumption UOM----------------//

 public DataTable ListOf_BagType()
 {
     DALSGX_SelectCommonMaster comm = new DALSGX_SelectCommonMaster();
     try
     {
         return comm.ListOf_BagType();
     }
     catch
     {
         throw;
     }
     finally
     {
         comm = null;
     }
 }
    // Added By Ashok 16-04-2014

 public DataTable FQ_ProductSpecification(string productcode, string SpecType)
 {
     DALSGX_SelectCommonMaster comm = new DALSGX_SelectCommonMaster();
     try
     {
         return comm.FQ_ProductSpecification(productcode, SpecType);
     }
     catch
     {
         throw;
     }
     finally
     {
         comm = null;
     }
 }

    // Added By : Sunil Kumar Singh Dated:24/05/2014

 public DataTable loc()
 {
     DALSGX_SelectCommonMaster comm = new DALSGX_SelectCommonMaster();
     try
     {
         return comm.loc();
     }
     catch
     {
         throw;
     }
     finally
     {
         comm = null;
     }
 }
 //Added By Ashok Gupta =04/06/2014
 public DataTable FQ_AgentList(string lcode)
 {
     DALSGX_SelectCommonMaster comm = new DALSGX_SelectCommonMaster();
     try
     {
         return comm.FQ_AgentList(lcode);
     }
     catch
     {
         throw;
     }
     finally
     {
         comm = null;
     }
 }

 //--------------- Added By :Devendra Kumar---------------
 //--------------- Added Date:18/01/2016 ------------------
 public DataTable Select_Cards(string Branch_Code)
 {
     DALSGX_SelectCommonMaster ShiftDAL = new DALSGX_SelectCommonMaster();
     try
     {
         return ShiftDAL.Select_Cards(Branch_Code);
     }
     catch
     {
         throw;
     }
     finally
     {
         ShiftDAL = null;
     }
 }


 public DataTable SelectCustomerInfo_Calyx(string CustType)
 {
     DALSGX_SelectCommonMaster rpt = new DALSGX_SelectCommonMaster();
     try
     {
         return rpt.SelectCustomerInfo_Calyx(CustType);
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

 public DataTable Select_Vendor_Calyx()
 {
     DALSGX_SelectCommonMaster rpt = new DALSGX_SelectCommonMaster();
     try
     {
         return rpt.Select_Vendor_Calyx();
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


    //----- Added By   : Ashish Kalsarpe
    //----- Added Date : 22/06/2017

 public DataTable Select_City_Mst(string STATE_ID)
 {
     DALSGX_SelectCommonMaster rpt = new DALSGX_SelectCommonMaster();
     try
     {
         return rpt.Select_City_Mst(STATE_ID);
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

 //---------Added By Rohit Chaurasiya on 02/21/2023-------//
 //---------Fill Fill_Vertical Name----------------//
 public DataTable Select_Vertical_Mst()
 {
     DALSGX_SelectCommonMaster common = new DALSGX_SelectCommonMaster();
     try
     {
         return common.Select_Vertical_Mst();
     }
     catch
     {
         throw;
     }
     finally
     {
         common = null;
     }
 }
 //---------Fill Fill_Project Name----------------//
 public DataTable Select_Project_Mst()
 {
     DALSGX_SelectCommonMaster common = new DALSGX_SelectCommonMaster();
     try
     {
         return common.Select_Project_Mst();
     }
     catch
     {
         throw;
     }
     finally
     {
         common = null;
     }
 }
 //---------Fill Fill_CostCode Name----------------//
 public DataTable Select_CostCode_Mst()
 {
     DALSGX_SelectCommonMaster common = new DALSGX_SelectCommonMaster();
     try
     {
         return common.Select_CostCode_Mst();
     }
     catch
     {
         throw;
     }
     finally
     {
         common = null;
     }
 }
 // Added By     : ROHIT CHAURASIYA 
 // Date         : 28/02/2023
 // For          : State Fill
 public DataTable AREA_FILL(string Employee)
 {
     DALSGX_SelectCommonMaster Location = new DALSGX_SelectCommonMaster();
     try
     {
         return Location.AREA_FILL(Employee);
     }
     catch
     {
         throw;
     }
     finally
     {
         Location = null;
     }
 }

 public DataTable A_FILL(string Employee)
 {
     DALSGX_SelectCommonMaster LocAf = new DALSGX_SelectCommonMaster();
     try
     {
         return LocAf.A_FILL(Employee);
     }
     catch
     {

         throw;
     }
     finally
     {
         LocAf = null;
     }
 }

 public DataTable Select_Mine(string ProductMine, string Location)
 {
     DALSGX_SelectCommonMaster Loc = new DALSGX_SelectCommonMaster();
     try
     {
         return Loc.Select_Mine(ProductMine, Location);
     }
     catch
     {
         throw;
     }
     finally
     {
         Loc = null;
     }
 }


}
