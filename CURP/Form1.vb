Public Class Form1
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        lblfinal.Text = Mid(txtAP.Text, 1, 1)

        If (Mid(txtAP.Text, 2, 1) = "A" Or Mid(txtAP.Text, 2, 1) = "E" Or Mid(txtAP.Text, 2, 1) = "I" Or Mid(txtAP.Text, 2, 1) = "O" Or Mid(txtAP.Text, 2, 1) = "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtAP.Text, 2, 1)
        ElseIf (Mid(txtAP.Text, 3, 1) = "A" Or Mid(txtAP.Text, 3, 1) = "E" Or Mid(txtAP.Text, 3, 1) = "I" Or Mid(txtAP.Text, 3, 1) = "O" Or Mid(txtAP.Text, 3, 1) = "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtAP.Text, 3, 1)
        ElseIf (Mid(txtAP.Text, 4, 1) = "A" Or Mid(txtAP.Text, 4, 1) = "E" Or Mid(txtAP.Text, 4, 1) = "I" Or Mid(txtAP.Text, 4, 1) = "O" Or Mid(txtAP.Text, 4, 1) = "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtAP.Text, 4, 1)
        ElseIf (Mid(txtAP.Text, 5, 1) = "A" Or Mid(txtAP.Text, 5, 1) = "E" Or Mid(txtAP.Text, 5, 1) = "I" Or Mid(txtAP.Text, 5, 1) = "O" Or Mid(txtAP.Text, 5, 1) = "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtAP.Text, 5, 1)
        End If

        lblfinal.Text = lblfinal.Text + Mid(txtAM.Text, 1, 1)

        If (Mid(txtnombre.Text, 1, 4) = "JOSE") Then
            lblfinal.Text = lblfinal.Text + Mid(txtnombre.Text, 6, 1)
        ElseIf (Mid(txtnombre.Text, 1, 5) = "MARIA") Then
            lblfinal.Text = lblfinal.Text + Mid(txtnombre.Text, 7, 1)
        Else
            lblfinal.Text = lblfinal.Text + Mid(txtnombre.Text, 1, 1)
        End If

        lblfinal.Text = lblfinal.Text + Mid(txtanio.Text, 3, 2)
        lblfinal.Text = lblfinal.Text + cbxmes.Text + cbxdia.Text

        If (cbxsexo.Text = "Hombre") Then
            lblfinal.Text = lblfinal.Text + "H"
        Else
            lblfinal.Text = lblfinal.Text + "M"
        End If

        If (cbxestado.Text = "Aguascalientes") Then
            lblfinal.Text = lblfinal.Text + "AS"
        ElseIf (cbxestado.Text = "Baja California") Then
            lblfinal.Text = lblfinal.Text + "BC"
        ElseIf (cbxestado.Text = "Baja California Sur") Then
            lblfinal.Text = lblfinal.Text + "BS"
        ElseIf (cbxestado.Text = "Campeche") Then
            lblfinal.Text = lblfinal.Text + "CC"
        ElseIf (cbxestado.Text = "Chiapas") Then
            lblfinal.Text = lblfinal.Text + "CS"
        ElseIf (cbxestado.Text = "Cihuahua") Then
            lblfinal.Text = lblfinal.Text + "CH"
        ElseIf (cbxestado.Text = "Ciudad de Mexico") Then
            lblfinal.Text = lblfinal.Text + "DF"
        ElseIf (cbxestado.Text = "Coahuila") Then
            lblfinal.Text = lblfinal.Text + "CL"
        ElseIf (cbxestado.Text = "Colima") Then
            lblfinal.Text = lblfinal.Text + "CM"
        ElseIf (cbxestado.Text = "Durango") Then
            lblfinal.Text = lblfinal.Text + "DG"
        ElseIf (cbxestado.Text = "Guanajuato") Then
            lblfinal.Text = lblfinal.Text + "GT"
        ElseIf (cbxestado.Text = "Guerrero") Then
            lblfinal.Text = lblfinal.Text + "GR"
        ElseIf (cbxestado.Text = "Hidalgo") Then
            lblfinal.Text = lblfinal.Text + "HG"
        ElseIf (cbxestado.Text = "Jalisco") Then
            lblfinal.Text = lblfinal.Text + "JC"
        ElseIf (cbxestado.Text = "Estado de Mexico") Then
            lblfinal.Text = lblfinal.Text + "MC"
        ElseIf (cbxestado.Text = "Michoacan") Then
            lblfinal.Text = lblfinal.Text + "MN"
        ElseIf (cbxestado.Text = "Morelos") Then
            lblfinal.Text = lblfinal.Text + "MS"
        ElseIf (cbxestado.Text = "Nayarit") Then
            lblfinal.Text = lblfinal.Text + "NT"
        ElseIf (cbxestado.Text = "Nuevo Leon") Then
            lblfinal.Text = lblfinal.Text + "NL"
        ElseIf (cbxestado.Text = "Oaxaca") Then
            lblfinal.Text = lblfinal.Text + "OC"
        ElseIf (cbxestado.Text = "Puebla") Then
            lblfinal.Text = lblfinal.Text + "PL"
        ElseIf (cbxestado.Text = "Queretaro") Then
            lblfinal.Text = lblfinal.Text + "QO"
        ElseIf (cbxestado.Text = "Quintana Roo") Then
            lblfinal.Text = lblfinal.Text + "QR"
        ElseIf (cbxestado.Text = "San Luis Potosi") Then
            lblfinal.Text = lblfinal.Text + "SP"
        ElseIf (cbxestado.Text = "Sinaloa") Then
            lblfinal.Text = lblfinal.Text + "SL"
        ElseIf (cbxestado.Text = "Sonora") Then
            lblfinal.Text = lblfinal.Text + "SR"
        ElseIf (cbxestado.Text = "Tabasco") Then
            lblfinal.Text = lblfinal.Text + "TC"
        ElseIf (cbxestado.Text = "Tamaulipas") Then
            lblfinal.Text = lblfinal.Text + "TS"
        ElseIf (cbxestado.Text = "Tlaxcala") Then
            lblfinal.Text = lblfinal.Text + "TL"
        ElseIf (cbxestado.Text = "Veracruz") Then
            lblfinal.Text = lblfinal.Text + "VZ"
        ElseIf (cbxestado.Text = "Yucatan") Then
            lblfinal.Text = lblfinal.Text + "YN"
        ElseIf (cbxestado.Text = "Zacatecas") Then
            lblfinal.Text = lblfinal.Text + "ZS"
        ElseIf (cbxestado.Text = "Nacido en el Extranjero") Then
            lblfinal.Text = lblfinal.Text + "NC"
        End If

        If (Mid(txtAP.Text, 2, 1) <> "A" And Mid(txtAP.Text, 2, 1) <> "E" And Mid(txtAP.Text, 2, 1) <> "I" And Mid(txtAP.Text, 2, 1) <> "O" And Mid(txtAP.Text, 2, 1) <> "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtAP.Text, 2, 1)
        ElseIf (Mid(txtAP.Text, 3, 1) <> "A" And Mid(txtAP.Text, 3, 1) <> "E" And Mid(txtAP.Text, 3, 1) <> "I" And Mid(txtAP.Text, 3, 1) <> "O" And Mid(txtAP.Text, 3, 1) <> "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtAP.Text, 3, 1)
        ElseIf (Mid(txtAP.Text, 4, 1) <> "A" And Mid(txtAP.Text, 4, 1) <> "E" And Mid(txtAP.Text, 4, 1) <> "I" And Mid(txtAP.Text, 4, 1) <> "O" And Mid(txtAP.Text, 4, 1) <> "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtAP.Text, 4, 1)
        ElseIf (Mid(txtAP.Text, 5, 1) <> "A" And Mid(txtAP.Text, 5, 1) <> "E" And Mid(txtAP.Text, 5, 1) <> "I" And Mid(txtAP.Text, 5, 1) <> "O" And Mid(txtAP.Text, 5, 1) <> "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtAP.Text, 5, 1)
        End If

        If (Mid(txtAM.Text, 2, 1) <> "A" And Mid(txtAM.Text, 2, 1) <> "E" And Mid(txtAM.Text, 2, 1) <> "I" And Mid(txtAM.Text, 2, 1) <> "O" And Mid(txtAM.Text, 2, 1) <> "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtAM.Text, 2, 1)
        ElseIf (Mid(txtAM.Text, 3, 1) <> "A" And Mid(txtAM.Text, 3, 1) <> "E" And Mid(txtAM.Text, 3, 1) <> "I" And Mid(txtAM.Text, 3, 1) <> "O" And Mid(txtAM.Text, 3, 1) <> "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtAM.Text, 3, 1)
        ElseIf (Mid(txtAM.Text, 4, 1) <> "A" And Mid(txtAM.Text, 4, 1) <> "E" And Mid(txtAM.Text, 4, 1) <> "I" And Mid(txtAM.Text, 4, 1) <> "O" And Mid(txtAM.Text, 4, 1) <> "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtAM.Text, 4, 1)
        ElseIf (Mid(txtAM.Text, 5, 1) <> "A" And Mid(txtAM.Text, 5, 1) <> "E" And Mid(txtAM.Text, 5, 1) <> "I" And Mid(txtAM.Text, 5, 1) <> "O" And Mid(txtAM.Text, 5, 1) <> "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtAM.Text, 5, 1)
        End If

        If (Mid(txtnombre.Text, 2, 1) <> "A" And Mid(txtnombre.Text, 2, 1) <> "E" And Mid(txtnombre.Text, 2, 1) <> "I" And Mid(txtnombre.Text, 2, 1) <> "O" And Mid(txtnombre.Text, 2, 1) <> "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtnombre.Text, 2, 1)
        ElseIf (Mid(txtnombre.Text, 3, 1) <> "A" And Mid(txtnombre.Text, 3, 1) <> "E" And Mid(txtnombre.Text, 3, 1) <> "I" And Mid(txtnombre.Text, 3, 1) <> "O" And Mid(txtnombre.Text, 3, 1) <> "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtnombre.Text, 3, 1)
        ElseIf (Mid(txtnombre.Text, 4, 1) <> "A" And Mid(txtnombre.Text, 4, 1) <> "E" And Mid(txtnombre.Text, 4, 1) <> "I" And Mid(txtnombre.Text, 4, 1) <> "O" And Mid(txtnombre.Text, 4, 1) <> "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtnombre.Text, 4, 1)
        ElseIf (Mid(txtnombre.Text, 5, 1) <> "A" And Mid(txtnombre.Text, 5, 1) <> "E" And Mid(txtnombre.Text, 5, 1) <> "I" And Mid(txtnombre.Text, 5, 1) <> "O" And Mid(txtnombre.Text, 5, 1) <> "U") Then
            lblfinal.Text = lblfinal.Text + Mid(txtnombre.Text, 5, 1)
        End If


    End Sub
End Class
