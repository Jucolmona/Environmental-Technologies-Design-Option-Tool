<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmInputParamsPSDMInRoom
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents _cboUnits_0 As System.Windows.Forms.ComboBox
	Public WithEvents _txtData_0 As System.Windows.Forms.TextBox
	Public WithEvents _cboUnits_1 As System.Windows.Forms.ComboBox
	Public WithEvents _txtData_1 As System.Windows.Forms.TextBox
	Public WithEvents _lblData_0 As System.Windows.Forms.Label
	Public WithEvents _lblData_1 As System.Windows.Forms.Label
	Public WithEvents _lblDesc_4 As System.Windows.Forms.Label
	Public WithEvents lblAirRate As System.Windows.Forms.Label
	Public WithEvents lblAirRateUnits As System.Windows.Forms.Label
    Public WithEvents SSFrame1 As AxThreed.AxSSFrame
    Public WithEvents cboChemical As System.Windows.Forms.ComboBox
    Public WithEvents _cboUnits_4 As System.Windows.Forms.ComboBox
    Public WithEvents _txtData_4 As System.Windows.Forms.TextBox
    Public WithEvents _txtData_5 As System.Windows.Forms.TextBox
    Public WithEvents _cboUnits_5 As System.Windows.Forms.ComboBox
    Public WithEvents _txtData_6 As System.Windows.Forms.TextBox
    Public WithEvents cbo_RXN_PRODUCT As System.Windows.Forms.ComboBox
    Public WithEvents _txtData_3 As System.Windows.Forms.TextBox
    Public WithEvents _cboUnits_3 As System.Windows.Forms.ComboBox
    Public WithEvents _optTimeVarEmit_0 As AxThreed.AxSSOption
    Public WithEvents _optTimeVarEmit_1 As AxThreed.AxSSOption
    Public WithEvents cmdTimeVarEmit As AxThreed.AxSSCommand
    Public WithEvents SSFrame5 As AxThreed.AxSSFrame
    Public WithEvents _cboUnits_2 As System.Windows.Forms.ComboBox
    Public WithEvents _txtData_2 As System.Windows.Forms.TextBox
    Public WithEvents _optTimeVarConc_0 As AxThreed.AxSSOption
    Public WithEvents _optTimeVarConc_1 As AxThreed.AxSSOption
    Public WithEvents cmdTimeVarConc As AxThreed.AxSSCommand
    Public WithEvents SSFrame4 As AxThreed.AxSSFrame
    Public WithEvents _txtData_7 As System.Windows.Forms.TextBox
    Public WithEvents _cboUnits_7 As System.Windows.Forms.ComboBox
    Public WithEvents _optTimeVarK_0 As AxThreed.AxSSOption
    Public WithEvents _optTimeVarK_1 As AxThreed.AxSSOption
    Public WithEvents cmdTimeVarK As AxThreed.AxSSCommand
    Public WithEvents SSFrame6 As AxThreed.AxSSFrame
    Public WithEvents _lblData_4 As System.Windows.Forms.Label
    Public WithEvents _lblDesc_5 As System.Windows.Forms.Label
    Public WithEvents lblSSValue As System.Windows.Forms.Label
    Public WithEvents lblSSValueUnits As System.Windows.Forms.Label
    Public WithEvents _lblData_5 As System.Windows.Forms.Label
    Public WithEvents _lblData_6 As System.Windows.Forms.Label
    Public WithEvents lbl_cbo_RXN_PRODUCT As System.Windows.Forms.Label
    Public WithEvents sspContaminantProps As AxThreed.AxSSPanel
    Public WithEvents lblDesc_cboChemical As System.Windows.Forms.Label
    Public WithEvents SSFrame2 As AxThreed.AxSSFrame
    Public WithEvents CancelButton As AxThreed.AxSSCommand
    Public WithEvents OKButton As AxThreed.AxSSCommand
    Public WithEvents sspanel_Dirty As AxThreed.AxSSPanel
    Public WithEvents sspanel_Status As AxThreed.AxSSPanel
    Public WithEvents SSPanel2 As AxThreed.AxSSPanel
    Public WithEvents _cboUnits_6 As System.Windows.Forms.ComboBox
    Public WithEvents ssframe_ContaminantProps As AxThreed.AxSSFrame
    Public WithEvents _lblData_3 As System.Windows.Forms.Label
    Public WithEvents _lblData_2 As System.Windows.Forms.Label
    Public WithEvents SSFrame3 As AxThreed.AxSSFrame
    Public WithEvents cboUnits As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
    '  Public WithEvents cmdCancelOK As AxThreed.AxSSCommandArray
    Public WithEvents lblData As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents lblDesc As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    '  Public WithEvents optTimeVarConc As AxThreed.AxSSOptionArray
    '  Public WithEvents optTimeVarEmit As AxThreed.AxSSOptionArray
    ' Public WithEvents optTimeVarK As AxThreed.AxSSOptionArray
    Public WithEvents txtData As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputParamsPSDMInRoom))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboUnits = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(Me.components)
        Me.lblData = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblDesc = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.txtData = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me._cboUnits_0 = New System.Windows.Forms.ComboBox()
        Me._txtData_0 = New System.Windows.Forms.TextBox()
        Me._cboUnits_1 = New System.Windows.Forms.ComboBox()
        Me._txtData_1 = New System.Windows.Forms.TextBox()
        Me._lblData_0 = New System.Windows.Forms.Label()
        Me._lblData_1 = New System.Windows.Forms.Label()
        Me._lblDesc_4 = New System.Windows.Forms.Label()
        Me.lblAirRate = New System.Windows.Forms.Label()
        Me.lblAirRateUnits = New System.Windows.Forms.Label()
        Me.cboChemical = New System.Windows.Forms.ComboBox()
        Me.lblDesc_cboChemical = New System.Windows.Forms.Label()
        Me._cboUnits_6 = New System.Windows.Forms.ComboBox()
        Me._lblData_3 = New System.Windows.Forms.Label()
        Me._lblData_2 = New System.Windows.Forms.Label()
        Me._cboUnits_4 = New System.Windows.Forms.ComboBox()
        Me._txtData_4 = New System.Windows.Forms.TextBox()
        Me._txtData_5 = New System.Windows.Forms.TextBox()
        Me._cboUnits_5 = New System.Windows.Forms.ComboBox()
        Me._txtData_6 = New System.Windows.Forms.TextBox()
        Me.cbo_RXN_PRODUCT = New System.Windows.Forms.ComboBox()
        Me._lblData_4 = New System.Windows.Forms.Label()
        Me._lblDesc_5 = New System.Windows.Forms.Label()
        Me.lblSSValue = New System.Windows.Forms.Label()
        Me.lblSSValueUnits = New System.Windows.Forms.Label()
        Me._lblData_5 = New System.Windows.Forms.Label()
        Me._lblData_6 = New System.Windows.Forms.Label()
        Me.lbl_cbo_RXN_PRODUCT = New System.Windows.Forms.Label()
        Me._txtData_3 = New System.Windows.Forms.TextBox()
        Me._cboUnits_3 = New System.Windows.Forms.ComboBox()
        Me._cboUnits_2 = New System.Windows.Forms.ComboBox()
        Me._txtData_2 = New System.Windows.Forms.TextBox()
        Me._txtData_7 = New System.Windows.Forms.TextBox()
        Me._cboUnits_7 = New System.Windows.Forms.ComboBox()
        Me.ssframe_ContaminantProps = New AxThreed.AxSSFrame()
        Me.sspContaminantProps = New AxThreed.AxSSPanel()
        Me.sspanel_Status = New AxThreed.AxSSPanel()
        Me.SSFrame5 = New AxThreed.AxSSFrame()
        Me.SSFrame4 = New AxThreed.AxSSFrame()
        Me.SSFrame6 = New AxThreed.AxSSFrame()
        Me.cmdTimeVarEmit = New AxThreed.AxSSCommand()
        Me.cmdTimeVarConc = New AxThreed.AxSSCommand()
        Me.cmdTimeVarK = New AxThreed.AxSSCommand()
        Me.sspanel_Dirty = New AxThreed.AxSSPanel()
        Me.SSFrame1 = New AxThreed.AxSSFrame()
        Me.SSFrame2 = New AxThreed.AxSSFrame()
        Me._optTimeVarConc_0 = New AxThreed.AxSSOption()
        Me.CancelButton = New AxThreed.AxSSCommand()
        Me.OKButton = New AxThreed.AxSSCommand()
        Me.SSPanel2 = New AxThreed.AxSSPanel()
        Me.SSFrame3 = New AxThreed.AxSSFrame()
        Me._optTimeVarEmit_0 = New AxThreed.AxSSOption()
        Me._optTimeVarEmit_1 = New AxThreed.AxSSOption()
        Me._optTimeVarConc_1 = New AxThreed.AxSSOption()
        Me._optTimeVarK_0 = New AxThreed.AxSSOption()
        Me._optTimeVarK_1 = New AxThreed.AxSSOption()
        CType(Me.cboUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ssframe_ContaminantProps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sspContaminantProps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sspanel_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSFrame5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSFrame4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSFrame6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdTimeVarEmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdTimeVarConc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdTimeVarK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sspanel_Dirty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSFrame1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSFrame2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._optTimeVarConc_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OKButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSFrame3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._optTimeVarEmit_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._optTimeVarEmit_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._optTimeVarConc_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._optTimeVarK_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._optTimeVarK_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboUnits
        '
        '
        'txtData
        '
        '
        '_cboUnits_0
        '
        Me._cboUnits_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._cboUnits_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cboUnits_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cboUnits_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cboUnits_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cboUnits_0.Location = New System.Drawing.Point(350, 16)
        Me._cboUnits_0.Name = "_cboUnits_0"
        Me._cboUnits_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cboUnits_0.Size = New System.Drawing.Size(85, 24)
        Me._cboUnits_0.TabIndex = 5
        Me._cboUnits_0.TabStop = False
        '
        '_txtData_0
        '
        Me._txtData_0.AcceptsReturn = True
        Me._txtData_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtData_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txtData_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtData_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtData_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtData_0.Location = New System.Drawing.Point(266, 18)
        Me._txtData_0.MaxLength = 0
        Me._txtData_0.Name = "_txtData_0"
        Me._txtData_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtData_0.Size = New System.Drawing.Size(81, 23)
        Me._txtData_0.TabIndex = 0
        Me._txtData_0.Text = "txtData(0)"
        Me._txtData_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_cboUnits_1
        '
        Me._cboUnits_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._cboUnits_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cboUnits_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cboUnits_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cboUnits_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cboUnits_1.Location = New System.Drawing.Point(350, 40)
        Me._cboUnits_1.Name = "_cboUnits_1"
        Me._cboUnits_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cboUnits_1.Size = New System.Drawing.Size(85, 24)
        Me._cboUnits_1.TabIndex = 4
        Me._cboUnits_1.TabStop = False
        '
        '_txtData_1
        '
        Me._txtData_1.AcceptsReturn = True
        Me._txtData_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtData_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txtData_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtData_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtData_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtData_1.Location = New System.Drawing.Point(266, 42)
        Me._txtData_1.MaxLength = 0
        Me._txtData_1.Name = "_txtData_1"
        Me._txtData_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtData_1.Size = New System.Drawing.Size(81, 23)
        Me._txtData_1.TabIndex = 1
        Me._txtData_1.Text = "txtData(1)"
        Me._txtData_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_lblData_0
        '
        Me._lblData_0.BackColor = System.Drawing.Color.Transparent
        Me._lblData_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblData_0.Location = New System.Drawing.Point(-2, 20)
        Me._lblData_0.Name = "_lblData_0"
        Me._lblData_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_0.Size = New System.Drawing.Size(259, 17)
        Me._lblData_0.TabIndex = 10
        Me._lblData_0.Text = "Volume of Room"
        Me._lblData_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblData_1
        '
        Me._lblData_1.BackColor = System.Drawing.Color.Transparent
        Me._lblData_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblData_1.Location = New System.Drawing.Point(-2, 44)
        Me._lblData_1.Name = "_lblData_1"
        Me._lblData_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_1.Size = New System.Drawing.Size(259, 17)
        Me._lblData_1.TabIndex = 9
        Me._lblData_1.Text = "Volumetric Flow Rate of Air Through Room"
        Me._lblData_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblDesc_4
        '
        Me._lblDesc_4.BackColor = System.Drawing.Color.Transparent
        Me._lblDesc_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDesc_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDesc_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDesc_4.Location = New System.Drawing.Point(-2, 68)
        Me._lblDesc_4.Name = "_lblDesc_4"
        Me._lblDesc_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDesc_4.Size = New System.Drawing.Size(259, 17)
        Me._lblDesc_4.TabIndex = 8
        Me._lblDesc_4.Text = "Air Change Rate"
        Me._lblDesc_4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAirRate
        '
        Me.lblAirRate.BackColor = System.Drawing.Color.Transparent
        Me.lblAirRate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAirRate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAirRate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblAirRate.Location = New System.Drawing.Point(266, 68)
        Me.lblAirRate.Name = "lblAirRate"
        Me.lblAirRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAirRate.Size = New System.Drawing.Size(81, 17)
        Me.lblAirRate.TabIndex = 7
        Me.lblAirRate.Text = "lblAirRate"
        Me.lblAirRate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAirRateUnits
        '
        Me.lblAirRateUnits.BackColor = System.Drawing.Color.Transparent
        Me.lblAirRateUnits.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAirRateUnits.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAirRateUnits.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblAirRateUnits.Location = New System.Drawing.Point(350, 68)
        Me.lblAirRateUnits.Name = "lblAirRateUnits"
        Me.lblAirRateUnits.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAirRateUnits.Size = New System.Drawing.Size(85, 17)
        Me.lblAirRateUnits.TabIndex = 6
        Me.lblAirRateUnits.Text = "hour^(-1)"
        '
        'cboChemical
        '
        Me.cboChemical.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboChemical.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboChemical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChemical.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChemical.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboChemical.Location = New System.Drawing.Point(220, 14)
        Me.cboChemical.Name = "cboChemical"
        Me.cboChemical.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboChemical.Size = New System.Drawing.Size(223, 24)
        Me.cboChemical.TabIndex = 11
        Me.cboChemical.TabStop = False
        '
        'lblDesc_cboChemical
        '
        Me.lblDesc_cboChemical.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc_cboChemical.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDesc_cboChemical.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc_cboChemical.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDesc_cboChemical.Location = New System.Drawing.Point(48, 18)
        Me.lblDesc_cboChemical.Name = "lblDesc_cboChemical"
        Me.lblDesc_cboChemical.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDesc_cboChemical.Size = New System.Drawing.Size(167, 17)
        Me.lblDesc_cboChemical.TabIndex = 12
        Me.lblDesc_cboChemical.Text = "Select Contaminant Name:"
        Me.lblDesc_cboChemical.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_cboUnits_6
        '
        Me._cboUnits_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._cboUnits_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._cboUnits_6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cboUnits_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cboUnits_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cboUnits_6.Location = New System.Drawing.Point(20, 26)
        Me._cboUnits_6.Name = "_cboUnits_6"
        Me._cboUnits_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cboUnits_6.Size = New System.Drawing.Size(85, 24)
        Me._cboUnits_6.TabIndex = 19
        Me._cboUnits_6.TabStop = False
        '
        '_lblData_3
        '
        Me._lblData_3.BackColor = System.Drawing.Color.Transparent
        Me._lblData_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblData_3.Location = New System.Drawing.Point(2, 68)
        Me._lblData_3.Name = "_lblData_3"
        Me._lblData_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_3.Size = New System.Drawing.Size(251, 17)
        Me._lblData_3.TabIndex = 21
        Me._lblData_3.Text = "Mass Emission Rate Within Room"
        Me._lblData_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblData_2
        '
        Me._lblData_2.BackColor = System.Drawing.Color.Transparent
        Me._lblData_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblData_2.Location = New System.Drawing.Point(10, 54)
        Me._lblData_2.Name = "_lblData_2"
        Me._lblData_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_2.Size = New System.Drawing.Size(251, 17)
        Me._lblData_2.TabIndex = 20
        Me._lblData_2.Text = "Concentration in Influent Stream To Room"
        Me._lblData_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_cboUnits_4
        '
        Me._cboUnits_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._cboUnits_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._cboUnits_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cboUnits_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cboUnits_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cboUnits_4.Location = New System.Drawing.Point(346, 184)
        Me._cboUnits_4.Name = "_cboUnits_4"
        Me._cboUnits_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cboUnits_4.Size = New System.Drawing.Size(85, 24)
        Me._cboUnits_4.TabIndex = 40
        Me._cboUnits_4.TabStop = False
        '
        '_txtData_4
        '
        Me._txtData_4.AcceptsReturn = True
        Me._txtData_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtData_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txtData_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtData_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtData_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtData_4.Location = New System.Drawing.Point(262, 186)
        Me._txtData_4.MaxLength = 0
        Me._txtData_4.Name = "_txtData_4"
        Me._txtData_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtData_4.Size = New System.Drawing.Size(81, 23)
        Me._txtData_4.TabIndex = 39
        Me._txtData_4.Text = "txtData(4)"
        Me._txtData_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtData_5
        '
        Me._txtData_5.AcceptsReturn = True
        Me._txtData_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtData_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txtData_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtData_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtData_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtData_5.Location = New System.Drawing.Point(262, 212)
        Me._txtData_5.MaxLength = 0
        Me._txtData_5.Name = "_txtData_5"
        Me._txtData_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtData_5.Size = New System.Drawing.Size(81, 23)
        Me._txtData_5.TabIndex = 38
        Me._txtData_5.Text = "txtData(5)"
        Me._txtData_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_cboUnits_5
        '
        Me._cboUnits_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._cboUnits_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._cboUnits_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cboUnits_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cboUnits_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cboUnits_5.Location = New System.Drawing.Point(346, 210)
        Me._cboUnits_5.Name = "_cboUnits_5"
        Me._cboUnits_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cboUnits_5.Size = New System.Drawing.Size(85, 24)
        Me._cboUnits_5.TabIndex = 37
        Me._cboUnits_5.TabStop = False
        '
        '_txtData_6
        '
        Me._txtData_6.AcceptsReturn = True
        Me._txtData_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtData_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txtData_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtData_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtData_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtData_6.Location = New System.Drawing.Point(262, 238)
        Me._txtData_6.MaxLength = 0
        Me._txtData_6.Name = "_txtData_6"
        Me._txtData_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtData_6.Size = New System.Drawing.Size(81, 23)
        Me._txtData_6.TabIndex = 36
        Me._txtData_6.Text = "txtData(6)"
        Me._txtData_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbo_RXN_PRODUCT
        '
        Me.cbo_RXN_PRODUCT.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbo_RXN_PRODUCT.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbo_RXN_PRODUCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_RXN_PRODUCT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_RXN_PRODUCT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbo_RXN_PRODUCT.Location = New System.Drawing.Point(208, 264)
        Me.cbo_RXN_PRODUCT.Name = "cbo_RXN_PRODUCT"
        Me.cbo_RXN_PRODUCT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbo_RXN_PRODUCT.Size = New System.Drawing.Size(223, 24)
        Me.cbo_RXN_PRODUCT.TabIndex = 35
        Me.cbo_RXN_PRODUCT.TabStop = False
        '
        '_lblData_4
        '
        Me._lblData_4.BackColor = System.Drawing.Color.Transparent
        Me._lblData_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblData_4.Location = New System.Drawing.Point(6, 188)
        Me._lblData_4.Name = "_lblData_4"
        Me._lblData_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_4.Size = New System.Drawing.Size(251, 17)
        Me._lblData_4.TabIndex = 47
        Me._lblData_4.Text = "Concentration in Room at Time = Zero"
        Me._lblData_4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblDesc_5
        '
        Me._lblDesc_5.BackColor = System.Drawing.Color.Transparent
        Me._lblDesc_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblDesc_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblDesc_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblDesc_5.Location = New System.Drawing.Point(-2, 164)
        Me._lblDesc_5.Name = "_lblDesc_5"
        Me._lblDesc_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblDesc_5.Size = New System.Drawing.Size(259, 17)
        Me._lblDesc_5.TabIndex = 46
        Me._lblDesc_5.Text = "Steady State Conc. at Saturation (Cr,ss)"
        Me._lblDesc_5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSSValue
        '
        Me.lblSSValue.BackColor = System.Drawing.Color.Transparent
        Me.lblSSValue.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSSValue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSValue.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblSSValue.Location = New System.Drawing.Point(262, 164)
        Me.lblSSValue.Name = "lblSSValue"
        Me.lblSSValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSSValue.Size = New System.Drawing.Size(81, 17)
        Me.lblSSValue.TabIndex = 45
        Me.lblSSValue.Text = "lblSSValue"
        Me.lblSSValue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSSValueUnits
        '
        Me.lblSSValueUnits.BackColor = System.Drawing.Color.Transparent
        Me.lblSSValueUnits.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSSValueUnits.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSValueUnits.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblSSValueUnits.Location = New System.Drawing.Point(346, 164)
        Me.lblSSValueUnits.Name = "lblSSValueUnits"
        Me.lblSSValueUnits.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSSValueUnits.Size = New System.Drawing.Size(85, 17)
        Me.lblSSValueUnits.TabIndex = 44
        Me.lblSSValueUnits.Text = "{u}g/L"
        '
        '_lblData_5
        '
        Me._lblData_5.BackColor = System.Drawing.Color.Transparent
        Me._lblData_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblData_5.Location = New System.Drawing.Point(6, 214)
        Me._lblData_5.Name = "_lblData_5"
        Me._lblData_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_5.Size = New System.Drawing.Size(251, 17)
        Me._lblData_5.TabIndex = 43
        Me._lblData_5.Text = "First-Order Destruction Rate"
        Me._lblData_5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblData_6
        '
        Me._lblData_6.BackColor = System.Drawing.Color.Transparent
        Me._lblData_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._lblData_6.Location = New System.Drawing.Point(6, 240)
        Me._lblData_6.Name = "_lblData_6"
        Me._lblData_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_6.Size = New System.Drawing.Size(251, 17)
        Me._lblData_6.TabIndex = 42
        Me._lblData_6.Text = "# Moles Of Product Per Mole Reactant"
        Me._lblData_6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_cbo_RXN_PRODUCT
        '
        Me.lbl_cbo_RXN_PRODUCT.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cbo_RXN_PRODUCT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_cbo_RXN_PRODUCT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cbo_RXN_PRODUCT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_cbo_RXN_PRODUCT.Location = New System.Drawing.Point(36, 268)
        Me.lbl_cbo_RXN_PRODUCT.Name = "lbl_cbo_RXN_PRODUCT"
        Me.lbl_cbo_RXN_PRODUCT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_cbo_RXN_PRODUCT.Size = New System.Drawing.Size(167, 17)
        Me.lbl_cbo_RXN_PRODUCT.TabIndex = 41
        Me.lbl_cbo_RXN_PRODUCT.Text = "Product For This Reactant"
        Me.lbl_cbo_RXN_PRODUCT.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_txtData_3
        '
        Me._txtData_3.AcceptsReturn = True
        Me._txtData_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtData_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txtData_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtData_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtData_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtData_3.Location = New System.Drawing.Point(100, 20)
        Me._txtData_3.MaxLength = 0
        Me._txtData_3.Name = "_txtData_3"
        Me._txtData_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtData_3.Size = New System.Drawing.Size(81, 23)
        Me._txtData_3.TabIndex = 25
        Me._txtData_3.Text = "txtData(3)"
        Me._txtData_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_cboUnits_3
        '
        Me._cboUnits_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._cboUnits_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._cboUnits_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cboUnits_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cboUnits_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cboUnits_3.Location = New System.Drawing.Point(184, 18)
        Me._cboUnits_3.Name = "_cboUnits_3"
        Me._cboUnits_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cboUnits_3.Size = New System.Drawing.Size(85, 24)
        Me._cboUnits_3.TabIndex = 24
        Me._cboUnits_3.TabStop = False
        '
        '_cboUnits_2
        '
        Me._cboUnits_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._cboUnits_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cboUnits_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cboUnits_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cboUnits_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cboUnits_2.Location = New System.Drawing.Point(184, 18)
        Me._cboUnits_2.Name = "_cboUnits_2"
        Me._cboUnits_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cboUnits_2.Size = New System.Drawing.Size(85, 24)
        Me._cboUnits_2.TabIndex = 31
        Me._cboUnits_2.TabStop = False
        '
        '_txtData_2
        '
        Me._txtData_2.AcceptsReturn = True
        Me._txtData_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtData_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txtData_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtData_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtData_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtData_2.Location = New System.Drawing.Point(100, 20)
        Me._txtData_2.MaxLength = 0
        Me._txtData_2.Name = "_txtData_2"
        Me._txtData_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtData_2.Size = New System.Drawing.Size(81, 23)
        Me._txtData_2.TabIndex = 30
        Me._txtData_2.Text = "txtData(2)"
        Me._txtData_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtData_7
        '
        Me._txtData_7.AcceptsReturn = True
        Me._txtData_7.BackColor = System.Drawing.SystemColors.Control
        Me._txtData_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txtData_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtData_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtData_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._txtData_7.Location = New System.Drawing.Point(100, 20)
        Me._txtData_7.MaxLength = 0
        Me._txtData_7.Name = "_txtData_7"
        Me._txtData_7.ReadOnly = True
        Me._txtData_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtData_7.Size = New System.Drawing.Size(81, 23)
        Me._txtData_7.TabIndex = 51
        Me._txtData_7.Text = "txtData(7)"
        Me._txtData_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_cboUnits_7
        '
        Me._cboUnits_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._cboUnits_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._cboUnits_7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cboUnits_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cboUnits_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cboUnits_7.Location = New System.Drawing.Point(184, 18)
        Me._cboUnits_7.Name = "_cboUnits_7"
        Me._cboUnits_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cboUnits_7.Size = New System.Drawing.Size(85, 24)
        Me._cboUnits_7.TabIndex = 50
        Me._cboUnits_7.TabStop = False
        '
        'ssframe_ContaminantProps
        '
        Me.ssframe_ContaminantProps.Location = New System.Drawing.Point(14, 92)
        Me.ssframe_ContaminantProps.Name = "ssframe_ContaminantProps"
        Me.ssframe_ContaminantProps.OcxState = CType(resources.GetObject("ssframe_ContaminantProps.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssframe_ContaminantProps.Size = New System.Drawing.Size(124, 23)
        Me.ssframe_ContaminantProps.TabIndex = 48
        '
        'sspContaminantProps
        '
        Me.sspContaminantProps.Location = New System.Drawing.Point(10, 38)
        Me.sspContaminantProps.Name = "sspContaminantProps"
        Me.sspContaminantProps.OcxState = CType(resources.GetObject("sspContaminantProps.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sspContaminantProps.Size = New System.Drawing.Size(511, 289)
        Me.sspContaminantProps.TabIndex = 22
        '
        'sspanel_Status
        '
        Me.sspanel_Status.Location = New System.Drawing.Point(148, 4)
        Me.sspanel_Status.Name = "sspanel_Status"
        Me.sspanel_Status.OcxState = CType(resources.GetObject("sspanel_Status.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sspanel_Status.Size = New System.Drawing.Size(100, 50)
        Me.sspanel_Status.TabIndex = 17
        '
        'SSFrame5
        '
        Me.SSFrame5.Location = New System.Drawing.Point(16, 62)
        Me.SSFrame5.Name = "SSFrame5"
        Me.SSFrame5.OcxState = CType(resources.GetObject("SSFrame5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSFrame5.Size = New System.Drawing.Size(100, 50)
        Me.SSFrame5.TabIndex = 23
        '
        'SSFrame4
        '
        Me.SSFrame4.Location = New System.Drawing.Point(16, 16)
        Me.SSFrame4.Name = "SSFrame4"
        Me.SSFrame4.OcxState = CType(resources.GetObject("SSFrame4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSFrame4.Size = New System.Drawing.Size(100, 50)
        Me.SSFrame4.TabIndex = 29
        '
        'SSFrame6
        '
        Me.SSFrame6.Location = New System.Drawing.Point(16, 108)
        Me.SSFrame6.Name = "SSFrame6"
        Me.SSFrame6.OcxState = CType(resources.GetObject("SSFrame6.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSFrame6.Size = New System.Drawing.Size(100, 50)
        Me.SSFrame6.TabIndex = 49
        '
        'cmdTimeVarEmit
        '
        Me.cmdTimeVarEmit.Location = New System.Drawing.Point(414, 18)
        Me.cmdTimeVarEmit.Name = "cmdTimeVarEmit"
        Me.cmdTimeVarEmit.OcxState = CType(resources.GetObject("cmdTimeVarEmit.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cmdTimeVarEmit.Size = New System.Drawing.Size(100, 50)
        Me.cmdTimeVarEmit.TabIndex = 28
        Me.cmdTimeVarEmit.TabStop = False
        '
        'cmdTimeVarConc
        '
        Me.cmdTimeVarConc.Location = New System.Drawing.Point(414, 18)
        Me.cmdTimeVarConc.Name = "cmdTimeVarConc"
        Me.cmdTimeVarConc.OcxState = CType(resources.GetObject("cmdTimeVarConc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cmdTimeVarConc.Size = New System.Drawing.Size(100, 50)
        Me.cmdTimeVarConc.TabIndex = 34
        Me.cmdTimeVarConc.TabStop = False
        '
        'cmdTimeVarK
        '
        Me.cmdTimeVarK.Location = New System.Drawing.Point(414, 18)
        Me.cmdTimeVarK.Name = "cmdTimeVarK"
        Me.cmdTimeVarK.OcxState = CType(resources.GetObject("cmdTimeVarK.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cmdTimeVarK.Size = New System.Drawing.Size(100, 50)
        Me.cmdTimeVarK.TabIndex = 54
        Me.cmdTimeVarK.TabStop = False
        '
        'sspanel_Dirty
        '
        Me.sspanel_Dirty.Location = New System.Drawing.Point(12, 452)
        Me.sspanel_Dirty.Name = "sspanel_Dirty"
        Me.sspanel_Dirty.OcxState = CType(resources.GetObject("sspanel_Dirty.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sspanel_Dirty.Size = New System.Drawing.Size(100, 50)
        Me.sspanel_Dirty.TabIndex = 16
        '
        'SSFrame1
        '
        Me.SSFrame1.Location = New System.Drawing.Point(6, 5)
        Me.SSFrame1.Name = "SSFrame1"
        Me.SSFrame1.OcxState = CType(resources.GetObject("SSFrame1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSFrame1.Size = New System.Drawing.Size(531, 89)
        Me.SSFrame1.TabIndex = 2
        '
        'SSFrame2
        '
        Me.SSFrame2.Location = New System.Drawing.Point(6, 100)
        Me.SSFrame2.Name = "SSFrame2"
        Me.SSFrame2.OcxState = CType(resources.GetObject("SSFrame2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSFrame2.Size = New System.Drawing.Size(531, 333)
        Me.SSFrame2.TabIndex = 3
        '
        '_optTimeVarConc_0
        '
        Me._optTimeVarConc_0.Location = New System.Drawing.Point(179, 154)
        Me._optTimeVarConc_0.Name = "_optTimeVarConc_0"
        Me._optTimeVarConc_0.OcxState = CType(resources.GetObject("_optTimeVarConc_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me._optTimeVarConc_0.Size = New System.Drawing.Size(100, 50)
        Me._optTimeVarConc_0.TabIndex = 32
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(305, 438)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.OcxState = CType(resources.GetObject("CancelButton.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CancelButton.Size = New System.Drawing.Size(100, 50)
        Me.CancelButton.TabIndex = 13
        Me.CancelButton.TabStop = False
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(427, 438)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.OcxState = CType(resources.GetObject("OKButton.OcxState"), System.Windows.Forms.AxHost.State)
        Me.OKButton.Size = New System.Drawing.Size(100, 50)
        Me.OKButton.TabIndex = 14
        Me.OKButton.TabStop = False
        '
        'SSPanel2
        '
        Me.SSPanel2.Location = New System.Drawing.Point(7, 565)
        Me.SSPanel2.Name = "SSPanel2"
        Me.SSPanel2.OcxState = CType(resources.GetObject("SSPanel2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSPanel2.Size = New System.Drawing.Size(100, 50)
        Me.SSPanel2.TabIndex = 15
        '
        'SSFrame3
        '
        Me.SSFrame3.Location = New System.Drawing.Point(26, 432)
        Me.SSFrame3.Name = "SSFrame3"
        Me.SSFrame3.OcxState = CType(resources.GetObject("SSFrame3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSFrame3.Size = New System.Drawing.Size(222, 127)
        Me.SSFrame3.TabIndex = 18
        Me.SSFrame3.Visible = False
        '
        '_optTimeVarEmit_0
        '
        Me._optTimeVarEmit_0.Location = New System.Drawing.Point(8, 20)
        Me._optTimeVarEmit_0.Name = "_optTimeVarEmit_0"
        Me._optTimeVarEmit_0.OcxState = CType(resources.GetObject("_optTimeVarEmit_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me._optTimeVarEmit_0.Size = New System.Drawing.Size(100, 50)
        Me._optTimeVarEmit_0.TabIndex = 26
        '
        '_optTimeVarEmit_1
        '
        Me._optTimeVarEmit_1.Location = New System.Drawing.Point(288, 20)
        Me._optTimeVarEmit_1.Name = "_optTimeVarEmit_1"
        Me._optTimeVarEmit_1.OcxState = CType(resources.GetObject("_optTimeVarEmit_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me._optTimeVarEmit_1.Size = New System.Drawing.Size(100, 50)
        Me._optTimeVarEmit_1.TabIndex = 27
        '
        '_optTimeVarConc_1
        '
        Me._optTimeVarConc_1.Location = New System.Drawing.Point(288, 20)
        Me._optTimeVarConc_1.Name = "_optTimeVarConc_1"
        Me._optTimeVarConc_1.OcxState = CType(resources.GetObject("_optTimeVarConc_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me._optTimeVarConc_1.Size = New System.Drawing.Size(100, 50)
        Me._optTimeVarConc_1.TabIndex = 33
        '
        '_optTimeVarK_0
        '
        Me._optTimeVarK_0.Location = New System.Drawing.Point(8, 20)
        Me._optTimeVarK_0.Name = "_optTimeVarK_0"
        Me._optTimeVarK_0.OcxState = CType(resources.GetObject("_optTimeVarK_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me._optTimeVarK_0.Size = New System.Drawing.Size(100, 50)
        Me._optTimeVarK_0.TabIndex = 52
        '
        '_optTimeVarK_1
        '
        Me._optTimeVarK_1.Location = New System.Drawing.Point(288, 20)
        Me._optTimeVarK_1.Name = "_optTimeVarK_1"
        Me._optTimeVarK_1.OcxState = CType(resources.GetObject("_optTimeVarK_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me._optTimeVarK_1.Size = New System.Drawing.Size(100, 50)
        Me._optTimeVarK_1.TabIndex = 53
        '
        'frmInputParamsPSDMInRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(558, 627)
        Me.ControlBox = False
        Me.Controls.Add(Me.sspanel_Dirty)
        Me.Controls.Add(Me.SSFrame1)
        Me.Controls.Add(Me.SSFrame2)
        Me.Controls.Add(Me._optTimeVarConc_0)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.SSPanel2)
        Me.Controls.Add(Me.SSFrame3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(81, 88)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputParamsPSDMInRoom"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Parameters for PSDMR Model"
        CType(Me.cboUnits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ssframe_ContaminantProps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sspContaminantProps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sspanel_Status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSFrame5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSFrame4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSFrame6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdTimeVarEmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdTimeVarConc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdTimeVarK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sspanel_Dirty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSFrame1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSFrame2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._optTimeVarConc_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OKButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSFrame3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._optTimeVarEmit_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._optTimeVarEmit_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._optTimeVarConc_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._optTimeVarK_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._optTimeVarK_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
End Class