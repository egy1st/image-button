[Setup]
AppName=DynamicComponents Image Button v4.0
AppVerName=DC Image Button v4.0
AppPublisher=EgyFirst Software , Inc.
AppPublisherURL=http://www.egy1st.com
AppSupportURL=support@egy1st.com
DefaultDirName={pf}\Dynamic Components\Image Button\
DefaultGroupName=Dynamic Components\Image Button\
LicenseFile=License.txt
OutputBaseFilename=image_button
VersionInfoCompany=EgyFirst Software , Inc.
VersionInfoDescription=Dynamic Components Image Button
VersionInfoVersion=4.0.0.0
InfoAfterFile=How to order.txt
RestartIfNeededByRun = True
WizardImageFile = Big02.bmp
WizardSmallImageFile=logo.bmp
BackColorDirection =toptobottom
BackColor = clBlue
BackColor2= clgreen
BackSolid=false
WindowStartMaximized=yes
WindowVisible=yes
WindowShowCaption=no
AppCopyright=EgyFirst Software 2005-2016 Copyright


[Tasks]
Name: "desktopicon"; Description: "Create a &desktop icon"; GroupDescription: "Additional icons:"; Flags: unchecked


[Files]
Source: "DC_ImageButton40.dll"; DestDir: "{app}"
Source: "DC Image Button v4.0.chm"; DestDir: "{app}"
Source: "License.txt"; DestDir: "{app}"
Source: "License Agreement.doc"; DestDir: "{app}"
Source: "egyfirst homepage.url"; DestDir: "{app}"
Source: "Order Now.url"; DestDir: "{app}"
Source: "DC_ImageButton.exe"  ; DestDir: "{app}"
Source: "nWind.accdb"; DestDir: "{app}"
Source: "icons\*.*"; DestDir: "{app}\icons\"


; Visual Studio 2010 ////////////////////////////////////////////////////////
Source: "Tutorials\Visual Studio 2010\*.*"; DestDir: "{app}\Tutorials\Visual Studio 2010\"
Source: "Tutorials\Visual Studio 2010\My Project\*.*"; DestDir: "{app}\Tutorials\Visual Studio 2010\My Project"
Source: "DC_ImageButton40.dll"; DestDir: "{app}\Tutorials\Visual Studio 2010\bin\Debug"
Source: "nWind.accdb"; DestDir: "{app}\Tutorials\Visual Studio 2010\bin\Debug"
Source: "icons\*.*"; DestDir: "{app}\Tutorials\Visual Studio 2010\bin\Debug\icons\"
;////////////////////////////////////////////////////////


[LangOptions]
LanguageName=English
LanguageID=$0409
DialogFontName=
DialogFontSize=8
WelcomeFontName=Verdana
WelcomeFontSize=12
TitleFontName=Arial
TitleFontSize=29
CopyrightFontName=Arial
CopyrightFontSize=10

[Icons]
Name: "{group}\Order Now"; Filename: "{app}\Order Now.url"
Name: "{group}\My Golden Soft Homepage"; Filename: "{app}\My Golden Soft Homepage.url"
Name: "{group}\Help"; Filename: "{app}\DC Image Button v4.0.chm"
Name: "{group}\Tutorials"; Filename: "{app}\Tutorials\"
Name: "{group}\Register DC_ImageButton"; Filename: "{app}\DC_ImageButton35_Registrar.exe"
Name: "{group}\Uninstall DC Image Button"; Filename: "{app}\unins000.exe"
Name: "{userdesktop}\DC Image Button v4.0"; Filename: "{app}"; Tasks: desktopicon

[Run]
; NOTE: The following entry contains an English phrase ("Launch"). You are free to translate it into another language if required.
Filename: "{app}\DC_ImageButton.exe"; Description: "Activate Trial"; Flags: shellexec postinstall skipifsilent
Filename: "{app}\DC Image Button v4.0.chm"; Description: "Launch Help"; Flags: shellexec postinstall skipifsilent
Filename: "{app}\Tutorials\"; Description: "Tutorials"; Flags: shellexec postinstall skipifsilent
Filename: "{app}\My Golden Soft Homepage.url"; Description: "Visit Homepage"; Flags: shellexec postinstall skipifsilent
