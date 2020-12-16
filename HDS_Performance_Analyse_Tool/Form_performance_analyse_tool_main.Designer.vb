<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Performance_Analyse_Tool_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Performance_Analyse_Tool_Main))
        Me.Button_exit = New System.Windows.Forms.Button()
        Me.ContextMenuStrip_chart = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.save_as_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.print_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToggleLabelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YAxisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeYAxisToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.y_axis_automatic_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChartTypeToolStripMenuItem_toggle_chart_type = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl_chart1 = New System.Windows.Forms.TabControl()
        Me.Button_select_performance_data_folder = New System.Windows.Forms.Button()
        Me.TreeView_available_performancedata = New System.Windows.Forms.TreeView()
        Me.CheckBox_scalability = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_green = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox_scalability = New System.Windows.Forms.GroupBox()
        Me.Label_amber = New System.Windows.Forms.Label()
        Me.NumericUpDown_amber = New System.Windows.Forms.NumericUpDown()
        Me.Label_green = New System.Windows.Forms.Label()
        Me.ProgressBar_chart = New System.Windows.Forms.ProgressBar()
        Me.Label_progress_chart = New System.Windows.Forms.Label()
        Me.GroupBox_extra_options = New System.Windows.Forms.GroupBox()
        Me.CheckBox_stacked_view = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker_start_performancedate = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_end_performancedate = New System.Windows.Forms.DateTimePicker()
        Me.Label_start_performancedate = New System.Windows.Forms.Label()
        Me.Label_end_performancedata = New System.Windows.Forms.Label()
        Me.MenuStrip_settings = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_save_configuration = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllCheckboxesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_hide_error_numbers = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_GraphSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_no_background_color = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopXValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox_topx_value = New System.Windows.Forms.ToolStripComboBox()
        Me.ContextMenuStrip_chart.SuspendLayout()
        CType(Me.NumericUpDown_green, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_scalability.SuspendLayout()
        CType(Me.NumericUpDown_amber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_extra_options.SuspendLayout()
        Me.MenuStrip_settings.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_exit
        '
        resources.ApplyResources(Me.Button_exit, "Button_exit")
        Me.Button_exit.Name = "Button_exit"
        Me.Button_exit.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip_chart
        '
        Me.ContextMenuStrip_chart.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.save_as_ToolStripMenuItem, Me.print_ToolStripMenuItem, Me.ClipboardToolStripMenuItem, Me.ToggleLabelToolStripMenuItem, Me.YAxisToolStripMenuItem, Me.ChartTypeToolStripMenuItem_toggle_chart_type})
        Me.ContextMenuStrip_chart.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip_chart, "ContextMenuStrip_chart")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'save_as_ToolStripMenuItem
        '
        Me.save_as_ToolStripMenuItem.Name = "save_as_ToolStripMenuItem"
        resources.ApplyResources(Me.save_as_ToolStripMenuItem, "save_as_ToolStripMenuItem")
        '
        'print_ToolStripMenuItem
        '
        Me.print_ToolStripMenuItem.Name = "print_ToolStripMenuItem"
        resources.ApplyResources(Me.print_ToolStripMenuItem, "print_ToolStripMenuItem")
        '
        'ClipboardToolStripMenuItem
        '
        Me.ClipboardToolStripMenuItem.Name = "ClipboardToolStripMenuItem"
        resources.ApplyResources(Me.ClipboardToolStripMenuItem, "ClipboardToolStripMenuItem")
        '
        'ToggleLabelToolStripMenuItem
        '
        Me.ToggleLabelToolStripMenuItem.Name = "ToggleLabelToolStripMenuItem"
        resources.ApplyResources(Me.ToggleLabelToolStripMenuItem, "ToggleLabelToolStripMenuItem")
        '
        'YAxisToolStripMenuItem
        '
        Me.YAxisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeYAxisToolStripTextBox, Me.y_axis_automatic_ToolStripMenuItem})
        Me.YAxisToolStripMenuItem.Name = "YAxisToolStripMenuItem"
        resources.ApplyResources(Me.YAxisToolStripMenuItem, "YAxisToolStripMenuItem")
        '
        'ChangeYAxisToolStripTextBox
        '
        Me.ChangeYAxisToolStripTextBox.Name = "ChangeYAxisToolStripTextBox"
        resources.ApplyResources(Me.ChangeYAxisToolStripTextBox, "ChangeYAxisToolStripTextBox")
        '
        'y_axis_automatic_ToolStripMenuItem
        '
        Me.y_axis_automatic_ToolStripMenuItem.Name = "y_axis_automatic_ToolStripMenuItem"
        resources.ApplyResources(Me.y_axis_automatic_ToolStripMenuItem, "y_axis_automatic_ToolStripMenuItem")
        '
        'ChartTypeToolStripMenuItem_toggle_chart_type
        '
        Me.ChartTypeToolStripMenuItem_toggle_chart_type.Name = "ChartTypeToolStripMenuItem_toggle_chart_type"
        resources.ApplyResources(Me.ChartTypeToolStripMenuItem_toggle_chart_type, "ChartTypeToolStripMenuItem_toggle_chart_type")
        '
        'TabControl_chart1
        '
        resources.ApplyResources(Me.TabControl_chart1, "TabControl_chart1")
        Me.TabControl_chart1.Name = "TabControl_chart1"
        Me.TabControl_chart1.SelectedIndex = 0
        '
        'Button_select_performance_data_folder
        '
        resources.ApplyResources(Me.Button_select_performance_data_folder, "Button_select_performance_data_folder")
        Me.Button_select_performance_data_folder.Name = "Button_select_performance_data_folder"
        Me.Button_select_performance_data_folder.UseVisualStyleBackColor = True
        '
        'TreeView_available_performancedata
        '
        resources.ApplyResources(Me.TreeView_available_performancedata, "TreeView_available_performancedata")
        Me.TreeView_available_performancedata.Name = "TreeView_available_performancedata"
        '
        'CheckBox_scalability
        '
        Me.CheckBox_scalability.AllowDrop = True
        resources.ApplyResources(Me.CheckBox_scalability, "CheckBox_scalability")
        Me.CheckBox_scalability.Name = "CheckBox_scalability"
        Me.CheckBox_scalability.UseVisualStyleBackColor = True
        '
        'NumericUpDown_green
        '
        resources.ApplyResources(Me.NumericUpDown_green, "NumericUpDown_green")
        Me.NumericUpDown_green.Name = "NumericUpDown_green"
        '
        'GroupBox_scalability
        '
        resources.ApplyResources(Me.GroupBox_scalability, "GroupBox_scalability")
        Me.GroupBox_scalability.Controls.Add(Me.Label_amber)
        Me.GroupBox_scalability.Controls.Add(Me.NumericUpDown_amber)
        Me.GroupBox_scalability.Controls.Add(Me.CheckBox_scalability)
        Me.GroupBox_scalability.Controls.Add(Me.Label_green)
        Me.GroupBox_scalability.Controls.Add(Me.NumericUpDown_green)
        Me.GroupBox_scalability.Name = "GroupBox_scalability"
        Me.GroupBox_scalability.TabStop = False
        '
        'Label_amber
        '
        resources.ApplyResources(Me.Label_amber, "Label_amber")
        Me.Label_amber.Name = "Label_amber"
        '
        'NumericUpDown_amber
        '
        resources.ApplyResources(Me.NumericUpDown_amber, "NumericUpDown_amber")
        Me.NumericUpDown_amber.Name = "NumericUpDown_amber"
        '
        'Label_green
        '
        resources.ApplyResources(Me.Label_green, "Label_green")
        Me.Label_green.Name = "Label_green"
        '
        'ProgressBar_chart
        '
        resources.ApplyResources(Me.ProgressBar_chart, "ProgressBar_chart")
        Me.ProgressBar_chart.Name = "ProgressBar_chart"
        '
        'Label_progress_chart
        '
        resources.ApplyResources(Me.Label_progress_chart, "Label_progress_chart")
        Me.Label_progress_chart.Name = "Label_progress_chart"
        '
        'GroupBox_extra_options
        '
        resources.ApplyResources(Me.GroupBox_extra_options, "GroupBox_extra_options")
        Me.GroupBox_extra_options.Controls.Add(Me.CheckBox_stacked_view)
        Me.GroupBox_extra_options.Name = "GroupBox_extra_options"
        Me.GroupBox_extra_options.TabStop = False
        '
        'CheckBox_stacked_view
        '
        Me.CheckBox_stacked_view.AllowDrop = True
        resources.ApplyResources(Me.CheckBox_stacked_view, "CheckBox_stacked_view")
        Me.CheckBox_stacked_view.Name = "CheckBox_stacked_view"
        Me.CheckBox_stacked_view.UseVisualStyleBackColor = True
        '
        'DateTimePicker_start_performancedate
        '
        resources.ApplyResources(Me.DateTimePicker_start_performancedate, "DateTimePicker_start_performancedate")
        Me.DateTimePicker_start_performancedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_start_performancedate.Name = "DateTimePicker_start_performancedate"
        '
        'DateTimePicker_end_performancedate
        '
        resources.ApplyResources(Me.DateTimePicker_end_performancedate, "DateTimePicker_end_performancedate")
        Me.DateTimePicker_end_performancedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_end_performancedate.Name = "DateTimePicker_end_performancedate"
        '
        'Label_start_performancedate
        '
        resources.ApplyResources(Me.Label_start_performancedate, "Label_start_performancedate")
        Me.Label_start_performancedate.Name = "Label_start_performancedate"
        '
        'Label_end_performancedata
        '
        resources.ApplyResources(Me.Label_end_performancedata, "Label_end_performancedata")
        Me.Label_end_performancedata.Name = "Label_end_performancedata"
        '
        'MenuStrip_settings
        '
        Me.MenuStrip_settings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ToolStripMenuItem_GraphSettings})
        resources.ApplyResources(Me.MenuStrip_settings, "MenuStrip_settings")
        Me.MenuStrip_settings.Name = "MenuStrip_settings"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_save_configuration, Me.ClearAllCheckboxesToolStripMenuItem, Me.ToolStripMenuItem_hide_error_numbers})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        resources.ApplyResources(Me.SettingsToolStripMenuItem, "SettingsToolStripMenuItem")
        '
        'ToolStripMenuItem_save_configuration
        '
        Me.ToolStripMenuItem_save_configuration.Checked = True
        Me.ToolStripMenuItem_save_configuration.CheckOnClick = True
        Me.ToolStripMenuItem_save_configuration.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem_save_configuration.Name = "ToolStripMenuItem_save_configuration"
        resources.ApplyResources(Me.ToolStripMenuItem_save_configuration, "ToolStripMenuItem_save_configuration")
        '
        'ClearAllCheckboxesToolStripMenuItem
        '
        Me.ClearAllCheckboxesToolStripMenuItem.Name = "ClearAllCheckboxesToolStripMenuItem"
        resources.ApplyResources(Me.ClearAllCheckboxesToolStripMenuItem, "ClearAllCheckboxesToolStripMenuItem")
        '
        'ToolStripMenuItem_hide_error_numbers
        '
        Me.ToolStripMenuItem_hide_error_numbers.CheckOnClick = True
        Me.ToolStripMenuItem_hide_error_numbers.Name = "ToolStripMenuItem_hide_error_numbers"
        resources.ApplyResources(Me.ToolStripMenuItem_hide_error_numbers, "ToolStripMenuItem_hide_error_numbers")
        '
        'ToolStripMenuItem_GraphSettings
        '
        Me.ToolStripMenuItem_GraphSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_no_background_color, Me.TopXValueToolStripMenuItem})
        Me.ToolStripMenuItem_GraphSettings.Name = "ToolStripMenuItem_GraphSettings"
        resources.ApplyResources(Me.ToolStripMenuItem_GraphSettings, "ToolStripMenuItem_GraphSettings")
        '
        'ToolStripMenuItem_no_background_color
        '
        Me.ToolStripMenuItem_no_background_color.CheckOnClick = True
        Me.ToolStripMenuItem_no_background_color.Name = "ToolStripMenuItem_no_background_color"
        resources.ApplyResources(Me.ToolStripMenuItem_no_background_color, "ToolStripMenuItem_no_background_color")
        '
        'TopXValueToolStripMenuItem
        '
        Me.TopXValueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox_topx_value})
        Me.TopXValueToolStripMenuItem.Name = "TopXValueToolStripMenuItem"
        resources.ApplyResources(Me.TopXValueToolStripMenuItem, "TopXValueToolStripMenuItem")
        '
        'ToolStripComboBox_topx_value
        '
        Me.ToolStripComboBox_topx_value.Name = "ToolStripComboBox_topx_value"
        resources.ApplyResources(Me.ToolStripComboBox_topx_value, "ToolStripComboBox_topx_value")
        '
        'Form_Performance_Analyse_Tool_Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MenuStrip_settings)
        Me.Controls.Add(Me.Label_end_performancedata)
        Me.Controls.Add(Me.Label_start_performancedate)
        Me.Controls.Add(Me.DateTimePicker_end_performancedate)
        Me.Controls.Add(Me.DateTimePicker_start_performancedate)
        Me.Controls.Add(Me.GroupBox_extra_options)
        Me.Controls.Add(Me.ProgressBar_chart)
        Me.Controls.Add(Me.GroupBox_scalability)
        Me.Controls.Add(Me.TreeView_available_performancedata)
        Me.Controls.Add(Me.Label_progress_chart)
        Me.Controls.Add(Me.TabControl_chart1)
        Me.Controls.Add(Me.Button_exit)
        Me.Controls.Add(Me.Button_select_performance_data_folder)
        Me.MainMenuStrip = Me.MenuStrip_settings
        Me.Name = "Form_Performance_Analyse_Tool_Main"
        Me.ContextMenuStrip_chart.ResumeLayout(False)
        CType(Me.NumericUpDown_green, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_scalability.ResumeLayout(False)
        Me.GroupBox_scalability.PerformLayout()
        CType(Me.NumericUpDown_amber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_extra_options.ResumeLayout(False)
        Me.GroupBox_extra_options.PerformLayout()
        Me.MenuStrip_settings.ResumeLayout(False)
        Me.MenuStrip_settings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_exit As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip_chart As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents save_as_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents print_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl_chart1 As System.Windows.Forms.TabControl
    Friend WithEvents Button_select_performance_data_folder As System.Windows.Forms.Button
    Friend WithEvents TreeView_available_performancedata As System.Windows.Forms.TreeView
    Friend WithEvents CheckBox_scalability As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown_green As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox_scalability As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDown_amber As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_amber As System.Windows.Forms.Label
    Friend WithEvents Label_green As System.Windows.Forms.Label
    Friend WithEvents ProgressBar_chart As System.Windows.Forms.ProgressBar
    Friend WithEvents Label_progress_chart As System.Windows.Forms.Label
    Friend WithEvents ClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox_extra_options As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox_stacked_view As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker_start_performancedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker_end_performancedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_start_performancedate As System.Windows.Forms.Label
    Friend WithEvents Label_end_performancedata As System.Windows.Forms.Label
    Friend WithEvents MenuStrip_settings As System.Windows.Forms.MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_save_configuration As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_GraphSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_no_background_color As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllCheckboxesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToggleLabelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YAxisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeYAxisToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ChartTypeToolStripMenuItem_toggle_chart_type As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopXValueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox_topx_value As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents y_axis_automatic_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_hide_error_numbers As ToolStripMenuItem
End Class
