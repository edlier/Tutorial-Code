
 for (int i = 0; i < serviceOption.Rows.Count; i++)
        {
         CheckList_service.Items.Add(new ListItem((serviceOption.Rows[i]["description"]).ToString(),  (serviceOption.Rows[i]["num"]).ToString()));                

         }