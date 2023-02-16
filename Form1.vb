Public Class Form1
    ' #################################################################################################
    ' COMBO BOXES
    ' #################################################################################################
    Private Sub cbxValues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxValues.SelectedIndexChanged
        txtSelectedItem.Text = cbxValues.Items(cbxValues.SelectedIndex)
    End Sub
    ' ADD
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtDep.Text = "" Then
            MsgBox("Please insert a department!", MsgBoxStyle.Exclamation, "Empty input")

        ElseIf cbxValues.Items.Contains(txtDep.Text) Then
            MsgBox("Department already exist!", MsgBoxStyle.Exclamation, "Data Exists")
            Return
        End If

        cbxValues.Items.Add(txtDep.Text)
        txtDep.Clear()
        txtDep.Focus()
    End Sub

    ' ADD AT INDEX AND INSERT
    Private Sub btnAddAt_Click(sender As Object, e As EventArgs) Handles btnAddAt.Click, btnInsert.Click

        If Not IsNumeric(txtIndex.Text) Then
            MsgBox("Please provide an valid index value!", MsgBoxStyle.Exclamation, "Invalid index")
            Return
        ElseIf CInt(txtIndex.Text) + 1 > cbxValues.Items.Count Then
            MsgBox("Index exceeds the size of box!", MsgBoxStyle.Exclamation, "Index out of range")
            Return
        End If
        Dim index As Integer = CInt(txtIndex.Text)
        cbxValues.Items.Insert(index, txtDep.Text)
        txtDep.Clear()
        txtDep.Focus()
    End Sub

    ' REMOVE
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If Not cbxValues.Items.Contains(txtDep.Text) Then
            MsgBox("Department does not exist!", MsgBoxStyle.Exclamation, "Data Not Found ")
            Return
        End If
        cbxValues.Items.Remove(txtDep.Text)
        txtDep.Clear()
        txtDep.Focus()
    End Sub

    ' REMOVE AT INDEX
    Private Sub btnRemoveAt_Click(sender As Object, e As EventArgs) Handles btnRemoveAt.Click
        If Not IsNumeric(txtIndex.Text) Then
            MsgBox("Please provide an valid index value!", MsgBoxStyle.Exclamation, "Invalid index")
            Return
        ElseIf CInt(txtIndex.Text) > cbxValues.Items.Count Then
            MsgBox("Index exceeds the size of box!", MsgBoxStyle.Exclamation, "Index out of range")
            Return
        ElseIf Not cbxValues.Items.Contains(txtDep.Text) Then
            MsgBox("Department does not exist!", MsgBoxStyle.Exclamation, "Data Not Found ")
            Return
        End If
        cbxValues.Items.RemoveAt(CInt(txtIndex.Text))
        txtDep.Clear()
        txtDep.Focus()

    End Sub
    ' #################################################################################################

    ' #################################################################################################
    ' LIST BOXES
    ' #################################################################################################
    ' ADD
    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click

        If txtStudent.Text = "" Then
            MsgBox("Please insert a student!", MsgBoxStyle.Exclamation, "Empty input")
        ElseIf lsbValues.Items.Contains(txtStudent.Text) Then
            MsgBox("Student already exist!", MsgBoxStyle.Exclamation, "Data Exists")
            Return
        End If

        lsbValues.Items.Add(txtStudent.Text)
        txtStudent.Clear()
        txtStudent.Focus()
    End Sub

    ' REMOVE
    Private Sub btnRemove1_Click(sender As Object, e As EventArgs) Handles btnRemove1.Click

        If Not lsbValues.Items.Contains(txtStudent.Text) Then
            MsgBox("Student does not exist!", MsgBoxStyle.Exclamation, "Data Not Found ")
            Return
        End If
        lsbValues.Items.Remove(txtStudent.Text)
        txtStudent.Clear()
        txtStudent.Focus()
    End Sub

    ' SEARCH
    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch1.Click
        If lsbValues.Items.Contains(txtStudent.Text) Then
            MsgBox("Student exist!", MsgBoxStyle.Information, "Data Found ")
        Else
            MsgBox("Student Does not exist!", MsgBoxStyle.Information, "Data Not Found ")
        End If
    End Sub

End Class
