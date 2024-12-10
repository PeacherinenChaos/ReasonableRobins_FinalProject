<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SmallestRangeFinder.aspx.cs" Inherits="ReasonableRobins_FinalProject.SmallestRangeFinder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>LeetCode: Minimun One Bit Operations to Make an Interger Zero</h1>
            <p>
                We are determining the minimum number of operations needed in order to take a given interger
                <br />
                and transform it into zero using a limited set of operation. For this example we inputed 6.
            </p>
            <asp:Button ID="Problem" runat="server" Text="Problem1611" OnClick="Problem1611_Click" Style="width: 177px" />
            <asp:Label ID="lblResult" runat="server" Text="Solution"></asp:Label>
        </div>
    </form>
</body>
</html>
