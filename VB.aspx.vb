Imports System.Web.Services
Imports System.IO

Partial Class VB
    Inherits System.Web.UI.Page
    <WebMethod()> _
    Public Shared Function LoadUserControl(message As String) As String
        Using page As New Page()
            Dim userControl As UserControl = DirectCast(page.LoadControl("Message.ascx"), UserControl)
            TryCast(userControl.FindControl("lblMessage"), Label).Text = message
            page.Controls.Add(userControl)
            Using writer As New StringWriter()
                page.Controls.Add(userControl)
                HttpContext.Current.Server.Execute(page, writer, False)
                Return writer.ToString()
            End Using
        End Using
    End Function

End Class
