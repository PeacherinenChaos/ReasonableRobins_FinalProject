<!-- Name: Connor Thomas
Email: thoma5cg@mail.uc.edu
Assignment Number: Final Project
Due Date: 12/10/24
Course #/Section: IS3050/001
Semester/Year: 1st/4th
Brief Description of the assignment: In this assignment, we are working with a group on 3 separate hard problems from LeetCode. In the problem I chose, I am finding out which bucket is filled with poisonous liquid using pig lives.
Citations: ChatGPT, LeetCode
Anything else that's relevant:
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PoorPigs.aspx.cs" Inherits="ReasonableRobins_FinalProject.PoorPigs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>LeetCode: Poor Pigs</h2>
            <p>
                There is a bucket of poisonous liquid mixed in with other buckets of liquid. To figure out which is poisonous, you feed a random amount of pigs the liquid to see how they will react. Time is at the essence, as there is only a few minutes to determine which bucket is poisonous. 
                <br/> You can feed the pigs according to these steps:
<br/> Choose some live pigs to feed.
<br/> For each pig, choose which buckets to feed it. The pigs will consume all the chosen buckets simultaneously and will take no time. Each pig can feed from any number of buckets, and each bucket can be fed from any number of pigs.
<br/> Wait for minutes. You may not feed any other pigs during this time.
<br/> After minutes have passed, any pig that has been fed the poisonous bucket will die, and all others will survive.
<br/> Repeat this process until you run out of time.
<br/> Given the number of buckets, minutes to die, and minutes to test, it will return the minimum number of pigs needed to figure out which bucket is poisonous within the allotted time.
            </p>
            <p>Enter the number of buckets, minutes to die, and minutes to test:</p>
            <div>
                <label for="buckets">Number of Buckets:</label>
                <asp:TextBox ID="buckets" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="minutesToDie">Minutes to Die:</label>
                <asp:TextBox ID="minutesToDie" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="minutesToTest">Minutes to Test:</label>
                <asp:TextBox ID="minutesToTest" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
            </div>
            <div>
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
