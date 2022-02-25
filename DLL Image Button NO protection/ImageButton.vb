Imports System.Windows.Forms
Imports System.Drawing

Namespace DynamicComponents
    Public Class ImageButton

        Private Col_ControlName As New Collection()
        Private Col_ControlIndex As New Collection()
        Private MyForm As New System.Windows.Forms.Form()
        Private ImagePath As String
        Private ImageButtons(51) As String
        Private ImageMotion As Boolean = False
        Private ImagePos As Long
        Private HasImage As Boolean = False
        Public Shared Internal_Registration_Key As String = "0000-000-000-000-0000"
        Dim currentDomain As AppDomain = AppDomain.CurrentDomain
        Private Sub MYExnHandler(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
            Dim EX As Exception
            'EX = e.ExceptionObject
            'Dim str_error As String = "http://www.egy1st.com/notify.php?error=" + EX.StackTrace
            'Dim result_error As String = GetPageHTML(str_error)
        End Sub
        Private Sub MYThreadHandler(ByVal sender As Object, ByVal e As Threading.ThreadExceptionEventArgs)
            'Dim str_error As String = "http://www.egy1st.com/notify.php?error=" + e.Exception.StackTrace
            'Dim result_error As String = GetPageHTML(str_error)
        End Sub
        Private Function GetPageHTML(ByVal URL As String) As String
            Dim objWC As New System.Net.WebClient()
            Return New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
        End Function
        Public Sub InitForm(ByRef dm_Form As System.Windows.Forms.Form)

            
            ' Define a handler for unhandled exceptions.
            AddHandler currentDomain.UnhandledException, AddressOf MYExnHandler

            ' Define a handler for unhandled exceptions for threads behind forms.
            AddHandler Application.ThreadException, AddressOf MYThreadHandler

            Dim TxtCtrl As New Control()
            Dim X As Byte
            Dim Num As Byte = 0
            Dim Num2 As Byte = 0

            MyForm = dm_Form

            X = 0
            For Each TxtCtrl In dm_Form.Controls
                If TypeName(TxtCtrl) = "TextBox" Then
                    Col_ControlName.Add(TxtCtrl)
                    Col_ControlIndex.Add(X)
                End If
                X += 1
            Next TxtCtrl

        End Sub

        Public Sub PrepareImageButtons(ByVal ImageFullPath As String, ByVal Motion As Boolean)

            HasImage = True

            ImageMotion = Motion
            ImagePath = ImageFullPath
        End Sub

        Public Sub AddImageButton(ByRef ButtonName As Windows.Forms.Button, ByVal img_MouseLeave As String, ByVal img_MouseEnter As String, ByVal img_MouseDown As String)
            Dim MyButton As New System.Windows.Forms.Control()
            Dim Num As Byte = 0
            On Error Resume Next

            ImageButtons(ImagePos * 3 + 0) = img_MouseLeave
            ImageButtons(ImagePos * 3 + 1) = img_MouseEnter
            ImageButtons(ImagePos * 3 + 2) = img_MouseDown

            For Each MyButton In MyForm.Controls
                If UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 0 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(0))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button1_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button1_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button1_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button1_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button1_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button1_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 1 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(3))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button2_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button2_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button2_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button2_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button2_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button2_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 2 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(6))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button3_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button3_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button3_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button3_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button3_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button3_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 3 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(9))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button4_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button4_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button4_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button4_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button4_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button4_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 4 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(12))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button5_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button5_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button5_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button5_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button5_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button5_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 5 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(15))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button6_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button6_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button6_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button6_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button6_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button6_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 6 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(18))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button7_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button7_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button7_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button7_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button7_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button7_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 7 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(21))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button8_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button8_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button8_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button8_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button8_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button8_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 8 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(24))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button9_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button9_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button9_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button9_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button9_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button9_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 9 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(27))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button10_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button10_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button10_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button10_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button10_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button10_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 10 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(30))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button11_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button11_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button11_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button11_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button11_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button11_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 11 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(33))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button12_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button12_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button12_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button12_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button12_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button12_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 12 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(36))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button13_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button13_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button13_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button13_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button13_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button13_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 13 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(39))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button14_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button14_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button14_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button14_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button14_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button14_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 14 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(39))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button15_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button15_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button15_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button15_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button15_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button15_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 15 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(39))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button16_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button16_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button16_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button16_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button16_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button16_Enter
                ElseIf UCase(MyButton.Name) = UCase(ButtonName.Name) And ImagePos = 16 Then
                    Dim MyImageButton As Button
                    MyImageButton = CType(MyButton, Button)
                    MyImageButton.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(39))
                    AddHandler MyForm.Controls(Num).MouseEnter, AddressOf Button17_MouseEnter
                    AddHandler MyForm.Controls(Num).MouseLeave, AddressOf Button17_MouseLeave
                    AddHandler MyForm.Controls(Num).MouseDown, AddressOf Button17_MouseDown
                    AddHandler MyForm.Controls(Num).KeyDown, AddressOf Button17_KeyDown
                    AddHandler MyForm.Controls(Num).Leave, AddressOf Button17_Leave
                    AddHandler MyForm.Controls(Num).Enter, AddressOf Button17_Enter

                End If

                Num += 1
            Next MyButton

            ImagePos += 1

        End Sub


        ' Button 01
        Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(0))
            End If
        End Sub
        Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(1))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(2))
            End If
        End Sub
        Private Sub Button1_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(0))
            End If
        End Sub
        Private Sub Button1_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(1))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(2))
            End If
        End Sub

        ' Button 02
        Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(3))
            End If
        End Sub
        Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(4))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(5))
            End If
        End Sub
        Private Sub Button2_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(3))
            End If
        End Sub
        Private Sub Button2_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(4))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(5))
            End If
        End Sub
        ' Button 03
        Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(6))
            End If
        End Sub
        Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(7))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(8))
            End If
        End Sub
        Private Sub Button3_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(6))
            End If
        End Sub
        Private Sub Button3_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(7))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(8))
            End If
        End Sub

        ' Button 04
        Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(9))
            End If
        End Sub
        Private Sub Button4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(10))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(11))
            End If
        End Sub
        Private Sub Button4_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(9))
            End If
        End Sub
        Private Sub Button4_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(10))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(11))
            End If
        End Sub
        ' Button 05
        Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(12))
            End If
        End Sub
        Private Sub Button5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(13))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(14))
            End If
        End Sub
        Private Sub Button5_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(12))
            End If
        End Sub
        Private Sub Button5_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(13))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(14))
            End If
        End Sub

        ' Button 06
        Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(15))
            End If
        End Sub
        Private Sub Button6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(16))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(17))
            End If
        End Sub
        Private Sub Button6_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(15))
            End If
        End Sub
        Private Sub Button6_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(16))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(17))
            End If
        End Sub

        ' Button 07
        Private Sub Button7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(18))
            End If
        End Sub
        Private Sub Button7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(19))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(20))
            End If
        End Sub
        Private Sub Button7_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(18))
            End If
        End Sub
        Private Sub Button7_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(19))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(20))
            End If
        End Sub

        'Button 08
        Private Sub Button8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(21))
            End If
        End Sub
        Private Sub Button8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(22))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(23))
            End If
        End Sub
        Private Sub Button8_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(21))
            End If
        End Sub
        Private Sub Button8_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(22))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(23))
            End If
        End Sub

        'Button 09
        Private Sub Button9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(24))
            End If
        End Sub
        Private Sub Button9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(25))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(26))
            End If
        End Sub
        Private Sub Button9_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(24))
            End If
        End Sub
        Private Sub Button9_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(25))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button9_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(26))
            End If

        End Sub

        'Button 10
        Private Sub Button10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(27))
            End If
        End Sub
        Private Sub Button10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(28))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button10_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(29))
            End If
        End Sub
        Private Sub Button10_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(27))
            End If
        End Sub
        Private Sub Button10_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(28))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button10_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(29))
            End If

        End Sub


        'Button 11
        Private Sub Button11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(30))
            End If
        End Sub
        Private Sub Button11_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(31))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button11_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(32))
            End If
        End Sub
        Private Sub Button11_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(30))
            End If
        End Sub
        Private Sub Button11_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(31))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button11_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(32))
            End If

        End Sub




        'Button 12
        Private Sub Button12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(33))
            End If
        End Sub
        Private Sub Button12_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(34))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button12_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(35))
            End If
        End Sub
        Private Sub Button12_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(33))
            End If
        End Sub
        Private Sub Button12_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(34))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button12_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(35))
            End If

        End Sub


        'Button 13
        Private Sub Button13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(36))
            End If
        End Sub
        Private Sub Button13_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(37))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button13_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(38))
            End If
        End Sub
        Private Sub Button13_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(36))
            End If
        End Sub
        Private Sub Button13_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(37))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button13_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(38))
            End If

        End Sub


        'Button 14
        Private Sub Button14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(39))
            End If
        End Sub
        Private Sub Button14_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(40))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button14_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(41))
            End If
        End Sub
        Private Sub Button14_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(39))
            End If
        End Sub
        Private Sub Button14_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(40))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button14_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(41))
            End If

        End Sub



        'Button 15
        Private Sub Button15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(42))
            End If
        End Sub
        Private Sub Button15_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(43))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button15_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(44))
            End If
        End Sub
        Private Sub Button15_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(42))
            End If
        End Sub
        Private Sub Button15_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(43))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button15_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(44))
            End If

        End Sub



        'Button 16
        Private Sub Button16_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(45))
            End If
        End Sub
        Private Sub Button16_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(46))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button16_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(47))
            End If
        End Sub
        Private Sub Button16_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(45))
            End If
        End Sub
        Private Sub Button16_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(46))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button16_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(47))
            End If

        End Sub



        'Button 17
        Private Sub Button17_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(48))
            End If
        End Sub
        Private Sub Button17_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(49))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button17_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(50))
            End If
        End Sub
        Private Sub Button17_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(48))
            End If
        End Sub
        Private Sub Button17_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
            If HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(49))
            End If
            If ImageMotion = True Then
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
                sender.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                sender.Refresh()
                System.Threading.Thread.Sleep(150)
            End If
        End Sub
        Private Sub Button17_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Space And HasImage Then
                sender.Image = System.Drawing.Image.FromFile(ImagePath + ImageButtons(50))
            End If

        End Sub


        Public Sub setRegistrationKey(ByVal myKey As String)
            Internal_Registration_Key = myKey
        End Sub

    End Class
End Namespace