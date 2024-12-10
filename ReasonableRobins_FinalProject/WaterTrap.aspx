<!-- Name: Annapoorna Nair -->
<!-- email: nairap@mail.uc.edu -->
<!-- Assignment Title: Reasonable Robins Final project
<!-- Due Date: 12/07/24 -->
<!-- Course: IS 3050 -->
<!-- Semester/Year: Fall 2024
<!-- Brief Description: Final project using the watertrap problem-->
<!-- Citations: Leetcode for the actual problem itself-->
<!-- Anything else that's relevant: -->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WaterTrap.aspx.cs" Inherits="ReasonableRobins_FinalProject.WaterTrap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>LeetCode: Trapping Rain Water</h1>
            <p>Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining. 
                For this use [0,1,0,2,1,0,1,3,2,1,2,1] as our elevations.
            </p>
            <asp:Button ID="cmdAnswerClick" runat="server" Text="Have you counted the water drops?" OnClick="cmdAnswerClick_Click" />
            <asp:Label ID="LblCalculateWater" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
