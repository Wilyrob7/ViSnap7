﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.VS7_RadioButton1 = New Proyecto_ViSnap7.VS7_RadioButton()
        Me.VS7_RadioButton2 = New Proyecto_ViSnap7.VS7_RadioButton()
        Me.VS7_Led1 = New Proyecto_ViSnap7.VS7_Led()
        Me.VS7_Led2 = New Proyecto_ViSnap7.VS7_Led()
        Me.SuspendLayout()
        '
        'VS7_RadioButton1
        '
        Me.VS7_RadioButton1.AutoSize = True
        Me.VS7_RadioButton1.Location = New System.Drawing.Point(218, 155)
        Me.VS7_RadioButton1.Name = "VS7_RadioButton1"
        Me.VS7_RadioButton1.PLC_Bit = 0
        Me.VS7_RadioButton1.PLC_Byte = 89
        Me.VS7_RadioButton1.PLC_DataArea = Proyecto_ViSnap7.General.DataArea.MARK
        Me.VS7_RadioButton1.PLC_DataType = Proyecto_ViSnap7.General.DataType.BOOL
        Me.VS7_RadioButton1.PLC_DB = 0
        Me.VS7_RadioButton1.PLC_Length = 0
        Me.VS7_RadioButton1.PLC_Number = 0
        Me.VS7_RadioButton1.Size = New System.Drawing.Size(149, 21)
        Me.VS7_RadioButton1.TabIndex = 0
        Me.VS7_RadioButton1.Text = "VS7_RadioButton1"
        '
        'VS7_RadioButton2
        '
        Me.VS7_RadioButton2.AutoSize = True
        Me.VS7_RadioButton2.Location = New System.Drawing.Point(218, 182)
        Me.VS7_RadioButton2.Name = "VS7_RadioButton2"
        Me.VS7_RadioButton2.PLC_Bit = 1
        Me.VS7_RadioButton2.PLC_Byte = 89
        Me.VS7_RadioButton2.PLC_DataArea = Proyecto_ViSnap7.General.DataArea.MARK
        Me.VS7_RadioButton2.PLC_DataType = Proyecto_ViSnap7.General.DataType.BOOL
        Me.VS7_RadioButton2.PLC_DB = 0
        Me.VS7_RadioButton2.PLC_Length = 0
        Me.VS7_RadioButton2.PLC_Number = 0
        Me.VS7_RadioButton2.Size = New System.Drawing.Size(149, 21)
        Me.VS7_RadioButton2.TabIndex = 1
        Me.VS7_RadioButton2.Text = "VS7_RadioButton2"
        '
        'VS7_Led1
        '
        Me.VS7_Led1.BackColor = System.Drawing.SystemColors.Window
        Me.VS7_Led1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VS7_Led1.Location = New System.Drawing.Point(98, 144)
        Me.VS7_Led1.Name = "VS7_Led1"
        Me.VS7_Led1.PLC_Bit = 0
        Me.VS7_Led1.PLC_Byte = 89
        Me.VS7_Led1.PLC_ColorFalse = System.Drawing.SystemColors.Window
        Me.VS7_Led1.PLC_ColorTrue = System.Drawing.Color.Lime
        Me.VS7_Led1.PLC_DataArea = Proyecto_ViSnap7.General.DataArea.MARK
        Me.VS7_Led1.PLC_DataType = Proyecto_ViSnap7.General.DataType.BOOL
        Me.VS7_Led1.PLC_DB = 0
        Me.VS7_Led1.PLC_Length = 0
        Me.VS7_Led1.PLC_Number = 0
        Me.VS7_Led1.PLC_ShapeType = Proyecto_ViSnap7.VS7_Led.ShapeType.Normal
        Me.VS7_Led1.Size = New System.Drawing.Size(25, 25)
        Me.VS7_Led1.TabIndex = 2
        '
        'VS7_Led2
        '
        Me.VS7_Led2.BackColor = System.Drawing.SystemColors.Window
        Me.VS7_Led2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VS7_Led2.Location = New System.Drawing.Point(98, 178)
        Me.VS7_Led2.Name = "VS7_Led2"
        Me.VS7_Led2.PLC_Bit = 1
        Me.VS7_Led2.PLC_Byte = 89
        Me.VS7_Led2.PLC_ColorFalse = System.Drawing.SystemColors.Window
        Me.VS7_Led2.PLC_ColorTrue = System.Drawing.Color.Lime
        Me.VS7_Led2.PLC_DataArea = Proyecto_ViSnap7.General.DataArea.MARK
        Me.VS7_Led2.PLC_DataType = Proyecto_ViSnap7.General.DataType.BOOL
        Me.VS7_Led2.PLC_DB = 0
        Me.VS7_Led2.PLC_Length = 0
        Me.VS7_Led2.PLC_Number = 0
        Me.VS7_Led2.PLC_ShapeType = Proyecto_ViSnap7.VS7_Led.ShapeType.Normal
        Me.VS7_Led2.Size = New System.Drawing.Size(25, 25)
        Me.VS7_Led2.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.VS7_Led2)
        Me.Controls.Add(Me.VS7_Led1)
        Me.Controls.Add(Me.VS7_RadioButton2)
        Me.Controls.Add(Me.VS7_RadioButton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VS7_ValueLabel1 As VS7_ValueLabel
    Friend WithEvents VS7_RadioButton1 As VS7_RadioButton
    Friend WithEvents VS7_RadioButton2 As VS7_RadioButton
    Friend WithEvents VS7_Led1 As VS7_Led
    Friend WithEvents VS7_Led2 As VS7_Led
End Class