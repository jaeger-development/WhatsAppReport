#define MyAppName "WhatsAppReport"
#define MyAppVersion "1.1.1"
#define MyAppPublisher "Christian Jäger"
#define MyAppExeName "WhatsAppReport.exe"
#define MyAppCopyrigth "© 2023 Christian Jäger under GPL License"
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
LicenseFile=Resources/lizenz.rtf
InfoBeforeFile=Resources/nutzungsbedingungen.rtf
InfoAfterFile=Resources/nachinstallationshinweise.rtf
SetupIconFile=Resources/multisize.ico
PrivilegesRequired=lowest
OutputDir=SetUpFile
OutputBaseFilename=war-setup
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "german"; MessagesFile: "compiler:Languages\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Dirs]
Name: "{app}\Logfiles"; Permissions: users-modify
Name: "{app}\Templates"; Permissions: users-modify

[Files]
Source: "Resources/WhatsAppReport.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "Resources/nutzungsbedingungen.rtf"; DestDir: "{app}"; Flags: ignoreversion
Source: "Resources/lizenz.rtf"; DestDir: "{app}"; Flags: ignoreversion
Source: "Resources/hilfe.chm"; DestDir: "{app}"; Flags: ignoreversion
Source: "Resources/kurzinfo-main.rtf"; DestDir: "{app}"; Flags: ignoreversion
Source: "Resources/Templates/Anlage.docx"; DestDir: "{app}\Templates"; Flags: ignoreversion

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Code]
var
  Behoerde: string;
  Dienststelle: string;
  Sachbearbeiter: string;

function GetBehoerde(Param: string): string;
begin
  Result := Behoerde;
end;

function GetDienststelle(Param: string): string;
begin
  Result := Dienststelle;
end;

function GetSachbearbeiter(Param: string): string;
begin
  Result := Sachbearbeiter;
end;

function GetUserData(): Boolean;
var
  Form: TSetupForm;
  EditBehoerde: TEdit;
  EditDienststelle: TEdit;
  EditSachbearbeiter: TEdit;
  LabelHeader: TLabel;
  LabelIntro: TLabel;
  LabelBehoerde: TLabel;
  LabelDienststelle: TLabel;
  LabelSachbearbeiter: TLabel;
  OKButton: TButton;
  ScriptPath: string;
  Image: TBitmapImage;

begin
  Form := CreateCustomForm;
  Form.Caption := 'Setup - WhatsAppReport';
  Form.Width := 500;
  Form.Height := 375;
  Form.Position := poScreenCenter;
  Form.Color := clWhite;

  Image := TBitmapImage.Create(Form);
  Image.Parent := Form;
  Image.Width := 120;
  Image.Height := 120;
  Image.Left := 430;
  Image.Top := 40;
  
  ScriptPath := ExtractFilePath(ExpandConstant('{src}'));
  Image.Bitmap.LoadFromFile(ScriptPath + 'logo.bmp');
   
  LabelHeader := TLabel.Create(Form);
  LabelHeader.Parent := Form;
  LabelHeader.Font.Style := [fsBold];
  LabelHeader.Left := 10;
  LabelHeader.Top := 10;
  LabelHeader.Caption := 'WhatsAppReport wird installiert';
 
  LabelIntro := TLabel.Create(Form);
  LabelIntro.Parent := Form;
  LabelIntro.Left := LabelHeader.Left;
  LabelIntro.Top := LabelHeader.Top + 30;
  LabelIntro.Caption := 'Bitte trage zuerst deine Daten ein, wie sie in Berichten angezeigt werden sollen.' + #13#10 + #13#10 + 'Eine Änderung ist später noch in den Programmeinstellungen möglich.';

  LabelBehoerde := TLabel.Create(Form);
  LabelBehoerde.Parent := Form;
  LabelBehoerde.Left := LabelHeader.Left;
  LabelBehoerde.Top := LabelIntro.Top + LabelIntro.Height + 25;
  LabelBehoerde.Caption := 'Behörde:';

  EditBehoerde := TEdit.Create(Form);
  EditBehoerde.Parent := Form;
  EditBehoerde.Left := LabelBehoerde.Left + LabelBehoerde.Width + 40; //Setzt den Wert für alle Edit-Felder
  EditBehoerde.Top := LabelBehoerde.Top - 3;
  EditBehoerde.Width := 300;

  LabelDienststelle := TLabel.Create(Form);
  LabelDienststelle.Parent := Form;
  LabelDienststelle.Left := LabelBehoerde.Left;
  LabelDienststelle.Top := LabelBehoerde.Top + LabelBehoerde.Height + 15;
  LabelDienststelle.Caption := 'Dienststelle:';

  EditDienststelle := TEdit.Create(Form);
  EditDienststelle.Parent := Form;
  EditDienststelle.Left := EditBehoerde.Left; // Wiederholung des vorherigen Edit-Feldes
  EditDienststelle.Top := LabelDienststelle.Top - 3;
  EditDienststelle.Width := EditBehoerde.Width;

  LabelSachbearbeiter := TLabel.Create(Form);
  LabelSachbearbeiter.Parent := Form;
  LabelSachbearbeiter.Left := LabelBehoerde.Left;
  LabelSachbearbeiter.Top := LabelDienststelle.Top + LabelDienststelle.Height + 15;
  LabelSachbearbeiter.Caption := 'Sachbearbeiter:';

  EditSachbearbeiter := TEdit.Create(Form);
  EditSachbearbeiter.Parent := Form;
  EditSachbearbeiter.Left := EditBehoerde.Left; // Wiederholung des vorherigen Edit-Feldes
  EditSachbearbeiter.Top := LabelSachbearbeiter.Top - 3;
  EditSachbearbeiter.Width := EditBehoerde.Width;

  OKButton := TButton.Create(Form);
  OKButton.Parent := Form;
  OKButton.Caption := 'Weiter';
  OKButton.ModalResult := mrOK;
  OKButton.Left := 498;
  OKButton.Top := 368;

  Result := Form.ShowModal = mrOK;

  if Result then
  begin
    // Speichern Sie die Benutzereingaben in Variablen
    Behoerde := EditBehoerde.Text;
    Dienststelle := EditDienststelle.Text;
    Sachbearbeiter := EditSachbearbeiter.Text;
  end;

  Form.Free;
end;

procedure InitializeWizard;
begin
  // Hier können Sie andere Setup-Aufgaben durchführen
end;

procedure CurPageChanged(CurPageID: Integer);
begin
  if CurPageID = wpWelcome then
  begin
    if not GetUserData() then
    begin
      // Benutzer hat das Formular abgebrochen, Sie können entsprechende Maßnahmen ergreifen
    end;
  end;
end;

[Registry]
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ReportSchriftgroesseTitel"; ValueData: "18"; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ReportSchriftgroesseUeberschrift"; ValueData: "14"; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ReportSchriftgroesseText"; ValueData: "12"; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ChatprotokollMaxBildbreite"; ValueData: "300"; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ChatprotokollMaxBildhoehe"; ValueData: "300"; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ChatprotokollMaxEmoticonbreite"; ValueData: "100"; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ChatprotokollMaxEmoticonhoehe"; ValueData: "100"; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "ShowDebugMenu"; ValueData: "false"; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "AuswertungBehoerde"; ValueData: {code:GetBehoerde}; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "AuswertungDienststelle"; ValueData: {code:GetDienststelle}; Flags: uninsdeletevalue
Root: HKCU; Subkey: "SOFTWARE\WhatsAppReport"; ValueType: string; ValueName: "AuswertungSachbearbeiter"; ValueData: {code:GetSachbearbeiter}; Flags: uninsdeletevalue

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
