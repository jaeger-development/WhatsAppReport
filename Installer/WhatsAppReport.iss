#define MyAppName "WhatsAppReport"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "Christian Jäger"
#define MyAppExeName "WhatsAppReport.exe"
#define MyAppCopyrigth "© 2023 Christian Jäger"
#define MyAppAssocName MyAppName + " File"
#define MyAppAssocExt ".myp"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt
#define MyAppURL "https://github.com/jaeger-development/WhatsAppReport/"


[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{115FDD44-C8C8-4BCA-B1A7-3767ED6661A1}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
VersionInfoVersion={#MyAppVersion}
AppCopyright={#MyAppCopyrigth}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
LicenseFile=C:\Users\mail\Documents\Visual Studio 2022\WhatsAppReport\Code\Resources\lizenz.rtf
InfoBeforeFile=C:\Users\mail\Documents\Visual Studio 2022\WhatsAppReport\Code\Resources\nutzungsbedingungen.rtf
InfoAfterFile=C:\Users\mail\Documents\Visual Studio 2022\WhatsAppReport\Installer\nachinstallationshinweise.rtf
SetupIconFile=C:\Users\mail\Documents\Visual Studio 2022\WhatsAppReport\Installer\multisize.ico
; Remove the following line to run in administrative install mode (install for all users.)
PrivilegesRequired=lowest
OutputDir=C:\Users\mail\Documents\Visual Studio 2022\WhatsAppReport\Installer
OutputBaseFilename=whatsappreport-setup
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "german"; MessagesFile: "compiler:Languages\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Dirs]
Name: "{app}\Log"; Permissions: users-modify

[Files]
Source: "C:\Users\mail\Documents\Visual Studio 2022\WhatsAppReport\Code\bin\Release\WhatsAppReport.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\mail\Documents\Visual Studio 2022\WhatsAppReport\Code\Resources\nutzungsbedingungen.rtf"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\mail\Documents\Visual Studio 2022\WhatsAppReport\Code\Resources\lizenz.rtf"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\mail\Documents\Visual Studio 2022\WhatsAppReport\Hilfe\hilfe.chm"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Registry]
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ReportSchriftgroesseTitel"; ValueData: "18"; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ReportSchriftgroesseUeberschrift"; ValueData: "14"; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ReportSchriftgroesseText"; ValueData: "12"; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ChatprotokollMaxBildbreite"; ValueData: "300"; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ChatprotokollMaxBildhoehe"; ValueData: "300"; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ChatprotokollMaxEmoticonbreite"; ValueData: "100"; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ChatprotokollMaxEmoticonhoehe"; ValueData: "100"; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ShowDebugMenu"; ValueData: "false"; Flags: uninsdeletevalue

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent