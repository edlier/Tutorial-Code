//刪除前跳出「確認刪除」的對話框(JavaScript)

<asp:TemplateField ShowHeader="False"> 
<ItemTemplate> 

<asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="刪除" onclientclick="return confirm('確定要刪除嗎？')"> 
</asp:LinkButton> 

</ItemTemplate>
 </asp:TemplateField>


//來自 <https://dotblogs.com.tw/mis0800/2014/03/08/144297> 