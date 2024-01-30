' Database Programming Assignment.
' This program creates source in a database, creates a form, and utilizes queries. 
' Benjamin Andrews.


' “I will not use code that was never covered in class or in our textbook. If you do you must be able to explain your code when asked by the professor.
' Using code outside of the resources provided, it can be flagged and reported as an academic integrity violation if there is any suspicion of copying/cheating.” 




Public Class frmMain
    Private Sub GamesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GamesBindingNavigatorSaveItem.Click
        ' Try catch statement
        Try
            Me.Validate()
            Me.GamesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.GaloreDataSet)
            MessageBox.Show("Changes saved,", "Game Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Game Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub FillByPsPlatformToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByPsPlatformToolStripButton.Click
        Try
            Me.GamesTableAdapter.FillByPsPlatform(Me.GaloreDataSet.Games)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByPriceToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByPriceToolStripButton.Click
        Try
            Me.GamesTableAdapter.FillByPrice(Me.GaloreDataSet.Games)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByQuantityToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByQuantityToolStripButton.Click
        Try
            Me.GamesTableAdapter.FillByQuantity(Me.GaloreDataSet.Games)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByRatingToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByRatingToolStripButton.Click
        Try
            Me.GamesTableAdapter.FillByRating(Me.GaloreDataSet.Games)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByXbPlatformToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByXbPlatformToolStripButton.Click
        Try
            Me.GamesTableAdapter.FillByXbPlatform(Me.GaloreDataSet.Games)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
