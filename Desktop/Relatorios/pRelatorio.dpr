program pRelatorio;

uses
  Forms,
  uRelatorio in 'uRelatorio.pas' {frmRelatorio},
  uDados in 'uDados.pas' {dm: TDataModule};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TfrmRelatorio, frmRelatorio);
  Application.CreateForm(Tdm, dm);
  Application.Run;
end.
