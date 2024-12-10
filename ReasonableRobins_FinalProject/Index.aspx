<!-- Name: ReasonableRobins
Email: thoma5cg@mail.uc.edu, nairap@mail.uc.edu, king4sl@mail.uc.edu
Assignment Number: Final Project
Due Date: 12/10/24
Course #/Section: IS3050/001
Semester/Year: 1st/4th
Brief Description of the assignment: In this assignment, we are working with a group on 3 separate hard problems from LeetCode.
Citations: ChatGPT, LeetCode
Anything else that's relevant:
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ReasonableRobins_FinalProject.Index" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="cmdSmallestRangeFinder" runat="server" Text="Problem1611: Smallest Range Finder" OnClick="cmdSmallestRangeFinder_Click" />
            <asp:Button ID="cmdPoorPigs" runat="server" Text="Problem458: Poor Pigs" OnClick="cmdPoorPigs_Click" />
            <asp:Button ID="cmdWordCount" runat="server" Text="Problem1255: WordCount" OnClick="cmdWordCount_Click" />
            </div>
    </form>
</body>
</html>