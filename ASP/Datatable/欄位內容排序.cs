欄位內容排序


asp.net 的DataTable欄位內容排序(使用C#語法) 

DataTable dt = new DataTable();

 DataRow dr;
 dt.Columns.Add(new DataColumn("bankname", typeof(string))); //新增一欄位, 欄位名稱為"bankname"

 //加入第一筆銀行資料
 dr = dt.NewRow(); dr["bankname"] = "007-第一商業銀行"; 
dt.Rows.Add(dr); 

//加入第二筆銀行資料 
dr = dt.NewRow(); dr["bankname"] = "021-花旗銀行"; 
dt.Rows.Add(dr);

 //加入第三筆銀行資料 
dr = dt.NewRow(); 
dr["bankname"] = "013-國泰世華商業銀行"; 
dt.Rows.Add(dr); 

//加入第四筆銀行資料 dr = dt.NewRow();
 dr["bankname"] = "011-上海商業儲蓄銀行"; 
dt.Rows.Add(dr); 


dt.DefaultView.Sort = "bankname asc"; //依銀行代碼+名稱 正向排序, 反向排序為 "bankname desc" 

或 

dt.DefaultView.Sort = "bankcode, bankname";

 for (int j = 0; j < dt.Rows.Count; j++) 
{ 
System.Web.HttpContext.Current.Response.Write(dt.DefaultView[j]["bankname"].ToString() + "\n"); 

} 

如此畫面上show的銀行資料為:
007-第一商業銀行 
011-上海商業儲蓄銀行 
013-國泰世華商業銀行 
021-花旗銀行

來自 <https://dotblogs.com.tw/ste5022424/2013/05/01/102539> 

