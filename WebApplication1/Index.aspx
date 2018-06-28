<!DOCTYPE html>
<script runat="server">

    Protected Sub Button1_Click(sender As Object, e As EventArgs)

        WebApplication1.Notifier.GroupNotify("foo", "test")
        WebApplication1.Notifier.GroupNotify("foo", "test2")


    End Sub
</script>

<html>
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <p>
            Howdy!&nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
</body>
</html>