string[] SingleUserInfo = new string[20];

//搜尋UserInfo
SingleUserInfo=GlobalAnnounce.user.searchSingleUserInfoDetail(catchId);

foreach (ListItem lst in checkListboxID.Items)
            {
                for (int x = 0; x < 5;x++ )
                    if (SingleUserInfo[x+15] == "1")
                    {
                        checkListboxID.Items[x].Selected = true;
                    }
            }
