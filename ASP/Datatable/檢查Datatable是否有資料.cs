DataTable dt;
string sqlstr = "";
sqlstr = "SELECT sn";
sqlstr += " FROM machine";
sqlstr += " where sn=" + publicNewClass.mydb.qo(sn);
dt = publicNewClass.mydb.GetDataTable(sqlstr);

if (dt.Rows.Count == 0)
{
    return false;
}
else
{
     return true;

}