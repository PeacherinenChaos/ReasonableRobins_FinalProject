<!-- Name: Annapoorna Nair -->
<!-- email: nairap@mail.uc.edu -->
<!-- Assignment Title: Reasonable Robins Final project
<!-- Due Date: 12/07/24 -->
<!-- Course: IS 3050 -->
<!-- Semester/Year: Fall 2024
<!-- Brief Description: Final project using the watertrap problem-->
<!-- Citations: Leetcode for the actual problem itself-->
<!-- Anything else that's relevant: -->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WordCount.aspx.cs" Inherits="ReasonableRobins_FinalProject.WordCount" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>LeetCode: Maximum Score Words Formed by Letters</h1>
            <p>
                Given a set of words, a collection of single letters, and a scoring system for each letter was made. The goal is to identify the highest 
    <br />
                scoring subset of words that can be constructed using the available letters. A word can only be used once, and each letter can
    <br />
                be used as many times as it appears in the letter collection. In this example the words "dog, cat, dad, good" will be used.
            </p>
            <asp:Button ID="btnProblem" runat="server" Text="Problem1255" OnClick="Problem1255_Click" />
            <asp:Label ID="lblResult" runat="server" Text="Solution"></asp:Label>
        </div>
    </form>
</body>
</html>