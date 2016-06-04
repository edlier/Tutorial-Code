protected void btn_start_Click(object sender, EventArgs e)
        {
            int rowIndex = int.Parse(((Button)sender).CommandArgument);
            GridViewRow r = GridView1.Rows[rowIndex];

            //直接將Button1_Click事件中的sender參數轉換成按鈕
            Button Bu2 = (Button)sender;            

            //將Button轉換成GridViewRow就是您所點選的某一列
            GridViewRow GV_Row = (GridViewRow)Bu2.NamingContainer;


            //將資料導到下一個頁面

            Response.Redirect("cnnSAP_List_inProcess.aspx?DocNum=" + GV_Row.Cells[1].Text +
                "&ItemCode=" + GV_Row.Cells[2].Text +
                "&LineNum=" + ((HiddenField)GV_Row.Cells[3].FindControl("LineNum")).Value +
                "&status=" + ((Label)r.FindControl("status")).Text);
        }