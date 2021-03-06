Imports System.Data.OleDb

Public Class Form1
    Dim IB As New DynamicComponents.ImageButton()
    Dim connetionString As String
    Dim connection As OleDbConnection
    Dim oledbAdapter As OleDbDataAdapter
    Dim sql As String
    Dim ds As New DataSet
    Dim i As Integer

    Private Sub TestForm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'establish DSN
        connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\nWind.accdb"
        Sql = "select * from Customers"
        connection = New OleDbConnection(connetionString)

        Try

            connection.Open()
            oledbAdapter = New OleDbDataAdapter(Sql, connection)
            oledbAdapter.Fill(ds)
            oledbAdapter.Dispose()
            connection.Close()
        Catch ex As Exception
            MsgBox("Can not open connection ! ")
            Exit Sub
        End Try

        PopulateData()
        IB.setRegistrationKey("4049-642-054-131-4610")
        IB.InitForm(Me)
        IB.PrepareImageButtons(Application.StartupPath + "\icons\", False)
        IB.AddImageButton(Me.FirstButton, "first.png", "first_over.png", "first_down.png")
        IB.AddImageButton(Me.PreviousButton, "previous.png", "previous_over.png", "previous_down.png")
        IB.AddImageButton(Me.NextButton, "next.png", "next_over.png", "next_down.png")
        IB.AddImageButton(Me.LastButton, "last.png", "last_over.png", "last_down.png")
        IB.AddImageButton(Me.ExitButton, "exit.png", "exit_over.png", "exit_down.png")
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub PopulateData()
        Dim Row As DataRow

        Row = ds.Tables(0).Rows(i)
        Me.CustomerID.Text = Row.Item(0).ToString
        Me.CustomerName.Text = Row.Item(1).ToString
        Me.Address.Text = Row.Item(2).ToString
        Me.Phone.Text = Row.Item(3).ToString
    End Sub

    Private Sub FirstButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstButton.Click
        i = 0
        PopulateData()
    End Sub

    Private Sub PreviousButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousButton.Click
        If i > 0 Then
            i = i - 1
        End If
        PopulateData()
    End Sub

    Private Sub NextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click
        If i < (ds.Tables(0).Rows.Count - 1) Then
            i = i + 1
        End If
        PopulateData()
    End Sub


    
    Private Sub LastButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LastButton.Click
        i = ds.Tables(0).Rows.Count - 1
        PopulateData()
    End Sub
End Class

