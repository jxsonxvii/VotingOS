﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DatabaseDataSet = New VotingOS.DatabaseDataSet()
        Me.HeadBoyCountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeadBoyCountTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.HeadBoyCountTableAdapter()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.HeadGirlCountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeadGirlCountTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.HeadGirlCountTableAdapter()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeadBoyCountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeadGirlCountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.HeadBoyCountBindingSource
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(148, 202)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.XValueMember = "First Name"
        Series1.YValueMembers = "CountOfLast Name1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(300, 286)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HeadBoyCountBindingSource
        '
        Me.HeadBoyCountBindingSource.DataMember = "HeadBoyCount"
        Me.HeadBoyCountBindingSource.DataSource = Me.DatabaseDataSet
        '
        'HeadBoyCountTableAdapter
        '
        Me.HeadBoyCountTableAdapter.ClearBeforeFill = True
        '
        'Chart2
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.DataSource = Me.HeadGirlCountBindingSource
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(500, 202)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Series2.XValueMember = "First Name"
        Series2.YValueMembers = "CountOfLast Name1"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(300, 286)
        Me.Chart2.TabIndex = 1
        Me.Chart2.Text = "Chart2"
        '
        'HeadGirlCountBindingSource
        '
        Me.HeadGirlCountBindingSource.DataMember = "HeadGirlCount"
        Me.HeadGirlCountBindingSource.DataSource = Me.DatabaseDataSet
        '
        'HeadGirlCountTableAdapter
        '
        Me.HeadGirlCountTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(885, 529)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeadBoyCountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeadGirlCountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents HeadBoyCountBindingSource As BindingSource
    Friend WithEvents HeadBoyCountTableAdapter As DatabaseDataSetTableAdapters.HeadBoyCountTableAdapter
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents HeadGirlCountBindingSource As BindingSource
    Friend WithEvents HeadGirlCountTableAdapter As DatabaseDataSetTableAdapters.HeadGirlCountTableAdapter
End Class
