//將Session判斷從Form_Load分割出來



public void fnCheckLogin(Page pg)
        {
            if (string.IsNullOrEmpty((string)pg.Session["username"]))               
            {
                pg.Response.Redirect("login.aspx");
            }
        }
//how to call
clsCommon.fnCheckLogin(this.Page);



//來自 <http://forums.asp.net/t/1082125.aspx?How+to+check+whether+a+session+exists+or+not+> 
