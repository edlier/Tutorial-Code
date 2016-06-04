        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
            BackColor="White" BorderColor="#DEDFDE" BorderWidth="1px"
            CellPadding="4" ForeColor="Black" GridLines="Vertical" BorderStyle="None">

            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="NO" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <%#Container.DataItemIndex + 1%>
                    </ItemTemplate>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>
				<asp:BoundField DataField="DocNum" HeaderText="文件號碼" />
                <asp:BoundField DataField="ItemCode" HeaderText="ItemCode" />
                <asp:TemplateField HeaderText="Qty">
                    <ItemTemplate>
                        <asp:HiddenField ID="LineNum" runat="server" Value='<%# Eval("LineNum") %>'/>
                        <asp:Label ID="Qty" runat="server" Text='<%# Eval("Qty") %>' DataFormatString="{0:0.##}" Width="50px" ></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
				
				                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:Button ID="btn_start" runat="server" OnClick="btn_start_Click" CssClass="Georgia18px"  CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                    </ItemTemplate>
                </asp:TemplateField>
				            </Columns>
							        </asp:GridView>