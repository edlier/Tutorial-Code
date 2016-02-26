選到多少個ITEM選項
        private int[] getSelectItemOfOptions(CheckBoxList checkListName, int count, int minus)
        {
            int[] xcount = new int[count];
            foreach (ListItem lst in checkListName.Items)
            {
                if (lst.Selected == true)
                {
                    xcount[Convert.ToInt32(lst.Value) - minus] = Convert.ToInt32(lst.Value);
                }
            }
            return xcount;
        }
