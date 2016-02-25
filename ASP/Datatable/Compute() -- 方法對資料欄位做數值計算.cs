DataTable.Compute()方法對資料欄位做數值計算


EX :
int x = (int)dt_auList.Compute("Count(num)", "auDepID=4");

//Count "dt_List"  Datable 裡面  NUM 的數量
// audept的數值需要等於4





1.前言:
如果要對DataTable中的特定欄位做資料分析，在不使用其他第三方函式庫的情況下，可以用Compute方法來做基本的數值計算。
2.說明:
用法: DataTable.Compute( string expression, string filter)
支援以下聚合函數:
•Sum (Sum)  
•Avg (Average)  
•Min (Minimum)  
•Max (Maximum)  
•Count (Count)  
•StDev (Statistical standard deviation)  
•Var (Statistical variance)
使用上要注意的是欄位的型態需要是數值型態，如果是字串型態，可以簡單定義一個新欄位為數值型，再複製要計算的欄位資料做資料分析，否則會出現彙總函式和型別的無效用法: String錯誤訊息。
有關DataTable.Compute()的說明可參考:
http://msdn.microsoft.com/en-us/library/system.data.datatable.compute(v=vs.100).aspx
程式碼:
?
1	private void btCalc_Click(object sender, EventArgs e)
2	{
3	    double mean, stdev, max, min, variance, count, sum;
4	    DataTable dt = TxtConvertToDataTable(@"d:\tmp\dt.csv", "tmp", ",");//讀取資料
5	 
6	    dt.Columns.Add("tmpColumn", typeof(double), "Convert(data, 'System.Double')");//加入暫存欄位，將資料中string的型態轉為double型態
7	 
8	    mean = (double)dt.Compute("Avg(tmpColumn)", string.Empty);
9	    stdev = (double)dt.Compute("Stdev(tmpColumn)", string.Empty);
10	    max = (double)dt.Compute("Max(tmpColumn)", string.Empty);
11	    min = (double)dt.Compute("Min(tmpColumn)", string.Empty);
12	    variance = (double)dt.Compute("Var(tmpColumn)", string.Empty);
13	    count = (int)dt.Compute("Count(tmpColumn)", string.Empty);
14	    sum = (double)dt.Compute("Sum(tmpColumn)", string.Empty);
15	 
16	    dt.Columns.Remove("tmpColumn");//移除暫存欄位        
17	     
18	    MessageBox.Show("Mean: "+mean+"\r\n"
19	        + "Stdev: " + stdev + "\r\n"
20	        + "Max: " + max + "\r\n"
21	        + "Min: " + min + "\r\n"
22	        + "Variance: " + variance + "\r\n"
23	        + "Count: " + count + "\r\n"
24	        + "Sum: " + sum + "\r\n"
25	        );
26	}
27	 
28	public DataTable TxtConvertToDataTable(string File, string TableName, string delimiter)
29	{
30	    DataTable dt = new DataTable();
31	    DataSet ds = new DataSet();
32	    StreamReader s = new StreamReader(File, System.Text.Encoding.Default);
33	    string[] columns = s.ReadLine().Split(delimiter.ToCharArray());
34	    ds.Tables.Add(TableName);
35	    foreach (string col in columns)
36	    {
37	        bool added = false;
38	        string next = "";
39	        int i = 0;
40	        while (!added)
41	        {
42	            string columnname = col + next;
43	            columnname = columnname.Replace("#", "");
44	            columnname = columnname.Replace("'", "");
45	            columnname = columnname.Replace("&", "");
46	 
47	            if (!ds.Tables[TableName].Columns.Contains(columnname))
48	            {
49	                ds.Tables[TableName].Columns.Add(columnname.ToUpper());
50	                added = true;
51	            }
52	            else
53	            {
54	                i++;
55	                next = "_" + i.ToString();
56	            }
57	        }
58	    }
59	 
60	    string AllData = s.ReadToEnd();
61	    string[] rows = AllData.Split("\n".ToCharArray());
62	 
63	    foreach (string r in rows)
64	    {
65	        string[] items = r.Split(delimiter.ToCharArray());
66	        ds.Tables[TableName].Rows.Add(items);
67	    }
68	 
69	    s.Close();
70	 
71	    dt = ds.Tables[0];
72	 
73	    return dt;
74	}
圖例:

  

來自 <http://einboch.pixnet.net/blog/post/279208343-c%23%E4%B8%AD%E5%88%A9%E7%94%A8datatable.compute()%E6%96%B9%E6%B3%95%E5%B0%8D%E8%B3%87%E6%96%99%E6%AC%84%E4%BD%8D%E5%81%9A%E6%95%B8%E5%80%BC> 
