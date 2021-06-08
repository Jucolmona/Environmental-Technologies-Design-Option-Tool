Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Module PrintScreen
	'**********************************
	'SUMMARY
	'This article shows how to capture any form or window including the screen into a Visual Basic Picture object.
	'Once the on-screen image is captured in the Picture object, it can easily be printed using the PaintPicture
	'method of the Visual Basic Printer object.
	'
	'
	'
	'MORE Information
	'The included example provides several useful routines for capturing images. All of the routines have
	'been written to work under both 16- and 32-bit Windows platforms and they contain full palette support.
	'The routines in the example can:
	'
	'Capture the entire contents of a form.
	'Capture the client area of a form.
	'Capture the entire screen.
	'Capture the active window on the screen.
	'Capture any portion of any window given a handle to it.
	'Create a Picture object from a bitmap and a palette.
	'Print a Picture object as large as possible on the page.
	'
	'Visual Basic 4.0 introduced a new Picture object. The Picture object is actually a standard OLE type and it
	'is documented in the Control Developer's Kit (CDK.)
	'
	'The CDK includes the function OleCreatePictureIndirect that you can use to construct new Picture objects
	'from Visual Basic 4.0. The routine CreateBitmapPicture in the example calls OleCreatePictureIndirect to build a
	'Picture object from a handle to a bitmap and a handle to a palette. If the Picture includes a valid palette,
	'Visual Basic will know to use it when rendering the Picture to the screen or printer. The CreateBitmapPicture
	'routine is used by the CaptureWindow routine to construct Picture objects containing a bitmap of a part or all
	'of a window.
	'
	'The CaptureWindow routine in the example captures any portion of a window given a window handle.
	'The routine includes several parameters for describing the exact portion of the window to capture. Capture Window
	'works by copying the on-screen image of a window into a new bitmap. It also checks to see if the screen has a
	'palette and if so it makes a copy of it. CaptureWindow then calls CreateBitmapPicture to construct a bitmap
	'from the newly created bitmap and palette.
	'
	'The CaptureForm, CaptureClient, CaptureScreen, and CaptureActiveWindow routines included in the example
	'all use CaptureWindow to capture specific windows. CaptureForm and CaptureClient both call Capture window and
	'pass it the hWnd property of a Form object. CaptureScreen simply gets the handle to the desk top window and
	'calls CaptureWindow. Similarly, CaptureActiveWindow just gets the window handle of the active window and calls
	'CaptureWindow.
	'
	'Once the desired image is captured in a Picture object, it is easy to print in Visual Basic 4.0 using the
	'PaintPicture method of the Printer object. The example provides the routine PrintPictureToFitPage that uses
	'the PaintPictureMethod to print the captured images as large as possible in the printable area of the page.
	'
	'Example
	'Start a new project. Form1 is created by default.
	'
	'Place six CommandButtons on the form along the left side.
	'
	'Place one picture box on the form to the right of the buttons.
	'
	'Put the following code in Form1:
	
	'Add a new standard module to the project (module1 by default).
	'Put the following code in the new module:
	
	
	'--------------------------------------------------------------------
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	' Visual Basic 4.0 16/32 Capture Routines
	'
	' This module contains several routines for capturing windows into a
	' picture.  All the routines work on both 16 and 32 bit Windows
	' platforms.
	' The routines also have palette support.
	'
	' CreateBitmapPicture - Creates a picture object from a bitmap and
	' palette.
	' CaptureWindow - Captures any window given a window handle.
	' CaptureActiveWindow - Captures the active window on the desktop.
	' CaptureForm - Captures the entire form.
	' CaptureClient - Captures the client area of a form.
	' CaptureScreen - Captures the entire screen.
	' PrintPictureToFitPage - prints any picture as big as possible on
	' the page.
	'
	' NOTES
	'    - No error trapping is included in these routines.
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	
	Structure PALETTEENTRY
		Dim peRed As Byte
		Dim peGreen As Byte
		Dim peBlue As Byte
		Dim peFlags As Byte
	End Structure
	
	Structure LOGPALETTE
		Dim palVersion As Short
		Dim palNumEntries As Short
		<VBFixedArray(255)> Dim palPalEntry() As PALETTEENTRY ' Enough for 256 colors.
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B4BFF9E0-8631-45CF-910E-62AB3970F27B"'
		Public Sub Initialize()
			ReDim palPalEntry(255)
		End Sub
	End Structure
	
	Structure GUID
		Dim Data1 As Integer
		Dim Data2 As Short
		Dim Data3 As Short
		<VBFixedArray(7)> Dim Data4() As Byte
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B4BFF9E0-8631-45CF-910E-62AB3970F27B"'
		Public Sub Initialize()
			ReDim Data4(7)
		End Sub
	End Structure
	
#If Win32 Then
	
	Public Const RASTERCAPS As Integer = 38
	Public Const RC_PALETTE As Integer = &H100
	Public Const SIZEPALETTE As Integer = 104
	
	Structure RECT
		'UPGRADE_NOTE: Left was upgraded to Left_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Left_Renamed As Integer
		Dim Top As Integer
		'UPGRADE_NOTE: Right was upgraded to Right_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Right_Renamed As Integer
		Dim Bottom As Integer
	End Structure
	
	Declare Function CreateCompatibleDC Lib "GDI32" (ByVal hDC As Integer) As Integer
	Declare Function CreateCompatibleBitmap Lib "GDI32" (ByVal hDC As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer) As Integer
	Declare Function GetDeviceCaps Lib "GDI32" (ByVal hDC As Integer, ByVal iCapabilitiy As Integer) As Integer
	'UPGRADE_WARNING: Structure PALETTEENTRY may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Declare Function GetSystemPaletteEntries Lib "GDI32" (ByVal hDC As Integer, ByVal wStartIndex As Integer, ByVal wNumEntries As Integer, ByRef lpPaletteEntries As PALETTEENTRY) As Integer
	'UPGRADE_WARNING: Structure LOGPALETTE may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Declare Function CreatePalette Lib "GDI32" (ByRef lpLogPalette As LOGPALETTE) As Integer
	Declare Function SelectObject Lib "GDI32" (ByVal hDC As Integer, ByVal hObject As Integer) As Integer
	Declare Function BitBlt Lib "GDI32" (ByVal hDCDest As Integer, ByVal XDest As Integer, ByVal YDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hDCSrc As Integer, ByVal XSrc As Integer, ByVal YSrc As Integer, ByVal dwRop As Integer) As Integer
	Declare Function DeleteDC Lib "GDI32" (ByVal hDC As Integer) As Integer
	Declare Function GetForegroundWindow Lib "USER32" () As Integer
	Declare Function SelectPalette Lib "GDI32" (ByVal hDC As Integer, ByVal hPalette As Integer, ByVal bForceBackground As Integer) As Integer
	Declare Function RealizePalette Lib "GDI32" (ByVal hDC As Integer) As Integer
	Declare Function GetWindowDC Lib "USER32" (ByVal hWnd As Integer) As Integer
	Declare Function GetDC Lib "USER32" (ByVal hWnd As Integer) As Integer
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Declare Function GetWindowRect Lib "USER32" (ByVal hWnd As Integer, ByRef lpRect As RECT) As Integer
	Declare Function ReleaseDC Lib "USER32" (ByVal hWnd As Integer, ByVal hDC As Integer) As Integer
	Declare Function GetDesktopWindow Lib "USER32" () As Integer
	
	Structure PicBmp
		Dim Size As Integer
		Dim Type As Integer
		Dim hBmp As Integer
		Dim hPal As Integer
		Dim Reserved As Integer
	End Structure
	
	'UPGRADE_WARNING: Structure IPicture may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	'UPGRADE_WARNING: Structure GUID may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	'UPGRADE_WARNING: Structure PicBmp may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Declare Function OleCreatePictureIndirect Lib "olepro32.dll" (ByRef PicDesc As PicBmp, ByRef RefIID As GUID, ByVal fPictureOwnsHandle As Integer, ByRef IPic As System.Drawing.Image) As Integer
	
#ElseIf Win16 Then
	'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression Win16 did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="27EE2C3C-05AF-4C04-B2AF-657B4FB6B5FC"'
	
	Global Const RASTERCAPS As Integer = 38
	Global Const RC_PALETTE As Integer = &H100
	Global Const SIZEPALETTE As Integer = 104
	
	Type RECT
	Left As Integer
	Top As Integer
	Right As Integer
	Bottom As Integer
	End Type
	
	Declare Function CreateCompatibleDC Lib "GDI" ( _
	            ByVal hDC As Integer) As Integer
	Declare Function CreateCompatibleBitmap Lib "GDI" ( _
	            ByVal hDC As Integer, ByVal nWidth As Integer, _
	            ByVal nHeight As Integer) As Integer
	Declare Function GetDeviceCaps Lib "GDI" ( _
	            ByVal hDC As Integer, ByVal iCapabilitiy As Integer) As Integer
	Declare Function GetSystemPaletteEntries Lib "GDI" ( _
	            ByVal hDC As Integer, ByVal wStartIndex As Integer, _
	            ByVal wNumEntries As Integer, _
	            lpPaletteEntries As PALETTEENTRY) As Integer
	Declare Function CreatePalette Lib "GDI" ( _
	            lpLogPalette As LOGPALETTE) As Integer
	Declare Function SelectObject Lib "GDI" ( _
	            ByVal hDC As Integer, ByVal hObject As Integer) As Integer
	Declare Function BitBlt Lib "GDI" ( _
	            ByVal hDCDest As Integer, ByVal XDest As Integer, _
	            ByVal YDest As Integer, ByVal nWidth As Integer, _
	            ByVal nHeight As Integer, ByVal hDCSrc As Integer, _
	            ByVal XSrc As Integer, ByVal YSrc As Integer, _
	            ByVal dwRop As Long) As Integer
	Declare Function DeleteDC Lib "GDI" ( _
	            ByVal hDC As Integer) As Integer
	Declare Function GetForegroundWindow Lib "USER" _
	            Alias "GetActiveWindow" () As Integer
	Declare Function SelectPalette Lib "USER" ( _
	            ByVal hDC As Integer, ByVal hPalette As Integer, ByVal _
	            bForceBackground As Integer) As Integer
	Declare Function RealizePalette Lib "USER" ( _
	            ByVal hDC As Integer) As Integer
	Declare Function GetWindowDC Lib "USER" ( _
	            ByVal hWnd As Integer) As Integer
	Declare Function GetDC Lib "USER" ( _
	            ByVal hWnd As Integer) As Integer
	Declare Function GetWindowRect Lib "USER" ( _
	            ByVal hWnd As Integer, lpRect As RECT) As Integer
	Declare Function ReleaseDC Lib "USER" ( _
	            ByVal hWnd As Integer, ByVal hDC As Integer) As Integer
	Declare Function GetDesktopWindow Lib "USER" () As Integer
	
	Type PicBmp
	Size As Integer
	Type As Integer
	hBmp As Integer
	hPal As Integer
	Reserved As Integer
	End Type
	
	Declare Function OleCreatePictureIndirect _
	            Lib "oc25.dll" (PictDesc As PicBmp, RefIID As GUID, _
	            ByVal fPictureOwnsHandle As Integer, IPic As IPicture) _
	            As Integer
	
#End If
	
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	' CreateBitmapPicture
	'    - Creates a bitmap type Picture object from a bitmap and
	'      palette.
	'
	' hBmp
	'    - Handle to a bitmap.
	'
	' hPal
	'    - Handle to a Palette.
	'    - Can be null if the bitmap doesn't use a palette.
	'
	' Returns
	'    - Returns a Picture object containing the bitmap.
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
#If Win32 Then
	Public Function CreateBitmapPicture(ByVal hBmp As Integer, ByRef hPal As Integer) As System.Drawing.Image
		
		Dim r As Integer
#ElseIf Win16 Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression Win16 did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="27EE2C3C-05AF-4C04-B2AF-657B4FB6B5FC"'
		Public Function CreateBitmapPicture(ByVal hBmp As Integer, _
		            ByVal hPal As Integer) As Picture
		
		Dim r As Integer
#End If
		Dim Pic As PicBmp
		' IPicture requires a reference to "Standard OLE Types."
		Dim IPic As System.Drawing.Image
		'UPGRADE_WARNING: Arrays in structure IID_IDispatch may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim IID_IDispatch As GUID
		
		' Fill in with IDispatch Interface ID.
		With IID_IDispatch
			.Data1 = &H20400
			.Data4(0) = &HC0
			.Data4(7) = &H46
		End With
		
		' Fill Pic with necessary parts.
		With Pic
			.Size = Len(Pic) ' Length of structure.
			'UPGRADE_ISSUE: Constant vbPicTypeBitmap was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
			'.Type = vbPicTypeBitmap ' Type of Picture (bitmap).
			.hBmp = hBmp ' Handle to bitmap.
			.hPal = hPal ' Handle to palette (may be null).
		End With
		
		' Create Picture object.
		r = OleCreatePictureIndirect(Pic, IID_IDispatch, 1, IPic)
		
		' Return the new Picture object.
		CreateBitmapPicture = IPic
	End Function
	
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	' CaptureWindow
	'    - Captures any portion of a window.
	'
	' hWndSrc
	'    - Handle to the window to be captured.
	'
	' Client
	'    - If True CaptureWindow captures from the client area of the
	'      window.
	'    - If False CaptureWindow captures from the entire window.
	'
	' LeftSrc, TopSrc, WidthSrc, HeightSrc
	'    - Specify the portion of the window to capture.
	'    - Dimensions need to be specified in pixels.
	'
	' Returns
	'    - Returns a Picture object containing a bitmap of the specified
	'      portion of the window that was captured.
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	''''''
	'
#If Win32 Then
	Public Function CaptureWindow(ByVal hWndSrc As Integer, ByVal Client As Boolean, ByVal LeftSrc As Integer, ByVal TopSrc As Integer, ByVal WidthSrc As Integer, ByVal HeightSrc As Integer) As System.Drawing.Image
		
		Dim hDCMemory As Integer
		Dim hBmp As Integer
		Dim hBmpPrev As Integer
		Dim r As Integer
		Dim hDCSrc As Integer
		Dim hPal As Integer
		Dim hPalPrev As Integer
		Dim RasterCapsScrn As Integer
		Dim HasPaletteScrn As Integer
		Dim PaletteSizeScrn As Integer
#ElseIf Win16 Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression Win16 did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="27EE2C3C-05AF-4C04-B2AF-657B4FB6B5FC"'
		Public Function CaptureWindow(ByVal hWndSrc As Integer, _
		            ByVal Client As Boolean, ByVal LeftSrc As Integer, _
		            ByVal TopSrc As Integer, ByVal WidthSrc As Long, _
		            ByVal HeightSrc As Long) As Picture
		
		Dim hDCMemory As Integer
		Dim hBmp As Integer
		Dim hBmpPrev As Integer
		Dim r As Integer
		Dim hDCSrc As Integer
		Dim hPal As Integer
		Dim hPalPrev As Integer
		Dim RasterCapsScrn As Integer
		Dim HasPaletteScrn As Integer
		Dim PaletteSizeScrn As Integer
#End If
		'UPGRADE_WARNING: Arrays in structure LogPal may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim LogPal As LOGPALETTE
		
		' Depending on the value of Client get the proper device context.
		If Client Then
			hDCSrc = GetDC(hWndSrc) ' Get device context for client area.
		Else
			hDCSrc = GetWindowDC(hWndSrc) ' Get device context for entire
			' window.
		End If
		
		' Create a memory device context for the copy process.
		hDCMemory = CreateCompatibleDC(hDCSrc)
		' Create a bitmap and place it in the memory DC.
		hBmp = CreateCompatibleBitmap(hDCSrc, WidthSrc, HeightSrc)
		hBmpPrev = SelectObject(hDCMemory, hBmp)
		
		' Get screen properties.
		RasterCapsScrn = GetDeviceCaps(hDCSrc, RASTERCAPS) ' Raster
		' capabilities.
		HasPaletteScrn = RasterCapsScrn And RC_PALETTE ' Palette
		' support.
		PaletteSizeScrn = GetDeviceCaps(hDCSrc, SIZEPALETTE) ' Size of
		' palette.
		
		' If the screen has a palette make a copy and realize it.
		If HasPaletteScrn And (PaletteSizeScrn = 256) Then
			' Create a copy of the system palette.
			LogPal.palVersion = &H300
			LogPal.palNumEntries = 256
			r = GetSystemPaletteEntries(hDCSrc, 0, 256, LogPal.palPalEntry(0))
			hPal = CreatePalette(LogPal)
			' Select the new palette into the memory DC and realize it.
			hPalPrev = SelectPalette(hDCMemory, hPal, 0)
			r = RealizePalette(hDCMemory)
		End If

		' Copy the on-screen image into the memory DC.
		'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		r = BitBlt(hDCMemory, 0, 0, WidthSrc, HeightSrc, hDCSrc, LeftSrc, TopSrc, &HCC0020)

		' Remove the new copy of the  on-screen image.
		hBmp = SelectObject(hDCMemory, hBmpPrev)
		
		' If the screen has a palette get back the palette that was
		' selected in previously.
		If HasPaletteScrn And (PaletteSizeScrn = 256) Then
			hPal = SelectPalette(hDCMemory, hPalPrev, 0)
		End If
		
		' Release the device context resources back to the system.
		r = DeleteDC(hDCMemory)
		r = ReleaseDC(hWndSrc, hDCSrc)
		
		' Call CreateBitmapPicture to create a picture object from the
		' bitmap and palette handles. Then return the resulting picture
		' object.
		CaptureWindow = CreateBitmapPicture(hBmp, hPal)
	End Function
	
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	' CaptureScreen
	'    - Captures the entire screen.
	'
	' Returns
	'    - Returns a Picture object containing a bitmap of the screen.
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	Public Function CaptureScreen() As System.Drawing.Image
#If Win32 Then
		Dim hWndScreen As Integer
#ElseIf Win16 Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression Win16 did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="27EE2C3C-05AF-4C04-B2AF-657B4FB6B5FC"'
		Dim hWndScreen As Integer
#End If
		
		' Get a handle to the desktop window.
		hWndScreen = GetDesktopWindow()
		
		' Call CaptureWindow to capture the entire desktop give the handle
		' and return the resulting Picture object.
		
		CaptureScreen = CaptureWindow(hWndScreen, False, 0, 0, VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) \ VB6.TwipsPerPixelX, VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) \ VB6.TwipsPerPixelY)
	End Function
	
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	' CaptureForm
	'    - Captures an entire form including title bar and border.
	'
	' frmSrc
	'    - The Form object to capture.
	'
	' Returns
	'    - Returns a Picture object containing a bitmap of the entire
	'      form.
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	Public Function CaptureForm(ByRef frmSrc As System.Windows.Forms.Form) As System.Drawing.Image
		' Call CaptureWindow to capture the entire form given its window
		' handle and then return the resulting Picture object.
		'UPGRADE_ISSUE: Constant vbPixels was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Constant vbTwips was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Form method frmSrc.ScaleY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form method frmSrc.ScaleX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'		CaptureForm = CaptureWindow(frmSrc.Handle.ToInt32, False, 0, 0, frmSrc.ScaleX(VB6.PixelsToTwipsX(frmSrc.Width), vbTwips, vbPixels), frmSrc.ScaleY(VB6.PixelsToTwipsY(frmSrc.Height), vbTwips, vbPixels))
		CaptureForm = CaptureWindow(frmSrc.Handle.ToInt32, False, 0, 0, frmSrc.Width, frmSrc.Height)

	End Function

	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	' CaptureClient
	'    - Captures the client area of a form.
	'
	' frmSrc
	'    - The Form object to capture.
	'
	' Returns
	'    - Returns a Picture object containing a bitmap of the form's
	'      client area.
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	Public Function CaptureClient(ByRef frmSrc As System.Windows.Forms.Form) As System.Drawing.Image
		' Call CaptureWindow to capture the client area of the form given
		' its window handle and return the resulting Picture object.
		'UPGRADE_ISSUE: Constant vbPixels was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Form property frmSrc.ScaleMode is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8027179A-CB3B-45C0-9863-FAA1AF983B59"'
		'UPGRADE_ISSUE: Form method frmSrc.ScaleY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form method frmSrc.ScaleX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'	CaptureClient = CaptureWindow(frmSrc.Handle.ToInt32, True, 0, 0, frmSrc.ScaleX(VB6.PixelsToTwipsX(frmSrc.ClientRectangle.Width), frmSrc.ScaleMode, vbPixels), frmSrc.ScaleY(VB6.PixelsToTwipsY(frmSrc.ClientRectangle.Height), frmSrc.ScaleMode, vbPixels))
		CaptureClient = CaptureWindow(frmSrc.Handle.ToInt32, True, 0, 0, frmSrc.ClientRectangle.Width, frmSrc.ClientRectangle.Height)
	End Function

	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	' CaptureActiveWindow
	'    - Captures the currently active window on the screen.
	'
	' Returns
	'    - Returns a Picture object containing a bitmap of the active
	'      window.
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	Public Function CaptureActiveWindow() As System.Drawing.Image
#If Win32 Then
		Dim hWndActive As Integer
		Dim r As Integer
#ElseIf Win16 Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression Win16 did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="27EE2C3C-05AF-4C04-B2AF-657B4FB6B5FC"'
		Dim hWndActive As Integer
		Dim r As Integer
#End If
		Dim RectActive As RECT
		
		' Get a handle to the active/foreground window.
		hWndActive = GetForegroundWindow()
		
		' Get the dimensions of the window.
		r = GetWindowRect(hWndActive, RectActive)
		
		' Call CaptureWindow to capture the active window given its
		' handle and return the Resulting Picture object.
		CaptureActiveWindow = CaptureWindow(hWndActive, False, 0, 0, RectActive.Right_Renamed - RectActive.Left_Renamed, RectActive.Bottom - RectActive.Top)
	End Function
	
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	' PrintPictureToFitPage
	'    - Prints a Picture object as big as possible.
	'
	' Prn
	'    - Destination Printer object.
	'
	' Pic
	'    - Source Picture object.
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'
	Public Sub PrintPictureToFitPage(ByRef Prn As Printer, ByRef Pic As System.Drawing.Image)
		Const vbHiMetric As Short = 8
		Dim PicRatio As Double
		Dim PrnWidth As Double
		Dim PrnHeight As Double
		Dim PrnRatio As Double
		Dim PrnPicWidth As Double
		Dim PrnPicHeight As Double
		
		' Determine if picture should be printed in landscape or portrait
		' and set the orientation.
		'UPGRADE_ISSUE: Picture property Pic.Width was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Picture property Pic.Height was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		If Pic.Height >= Pic.Width Then
			Prn.Orientation = PrinterObjectConstants.vbPRORPortrait ' Taller than wide.
		Else
			Prn.Orientation = PrinterObjectConstants.vbPRORLandscape ' Wider than tall.
		End If
		
		' Calculate device independent Width-to-Height ratio for picture.
		'UPGRADE_ISSUE: Picture property Pic.Height was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Picture property Pic.Width was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		PicRatio = Pic.Width / Pic.Height
		
		' Calculate the dimensions of the printable area in HiMetric.
		PrnWidth = (Prn.ScaleX(Prn.ScaleWidth, Prn.ScaleMode, ScaleModeConstants.vbHimetric)) - 2000
		PrnHeight = Prn.ScaleY(Prn.ScaleHeight, Prn.ScaleMode, ScaleModeConstants.vbHimetric) - 2000
		' Calculate device independent Width to Height ratio for printer.
		PrnRatio = PrnWidth / PrnHeight
		
		' Scale the output to the printable area.
		If PicRatio >= PrnRatio Then
			' Scale picture to fit full width of printable area.
			PrnPicWidth = Prn.ScaleX(PrnWidth, ScaleModeConstants.vbHimetric, Prn.ScaleMode)
			PrnPicHeight = Prn.ScaleY(PrnWidth / PicRatio, ScaleModeConstants.vbHimetric, Prn.ScaleMode)
		Else
			' Scale picture to fit full height of printable area.
			PrnPicHeight = Prn.ScaleY(PrnHeight, ScaleModeConstants.vbHimetric, Prn.ScaleMode)
			PrnPicWidth = Prn.ScaleX(PrnHeight * PicRatio, ScaleModeConstants.vbHimetric, Prn.ScaleMode)
		End If
		
		' Print the picture using the PaintPicture method.
		Prn.PaintPicture(Pic, 0, 0, PrnPicWidth, PrnPicHeight)
	End Sub
	'--------------------------------------------------------------------
	'Save the project.
	'Before running this project verify in Project References that a Reference to OLE Automation exists (StdOle2.tlb).
	'Run the project and test. You should be able to capture the form, the form's client area, the screen, and the active window. You will also be able to print any of these.
	'NOTE: Once you have captured the image you want in a Picture object, you can easily place it on the clipboard using the SetData method of the Clipboard object.
End Module