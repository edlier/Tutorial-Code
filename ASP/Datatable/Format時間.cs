//新增RollinDate2 Collin↑↓來Format 日期資料
            
DataColumn column;
            column = new DataColumn();
            column.ColumnName = "manufacturerDate2";

            DataColumn column2;
            column2 = new DataColumn();
            column2.ColumnName = "indate2";

            myTable.Columns.Add(column);
            myTable.Columns.Add(column2);
            if (myTable.Rows.Count > 0)
            {
                for (int i = 0; i < myTable.Rows.Count; i++)
                {
                    myTable.Rows[i]["indate2"] = String.Format("{0:yyyy-MM-dd}", myTable.Rows[i]["indate"]);
                    myTable.Rows[i]["manufacturerDate2"] = String.Format("{0:yyyy-MM-dd}", myTable.Rows[i]["manufacturerdate"]);
                }
            }
