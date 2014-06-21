unit uRelatorio;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, pngimage, StdCtrls, Buttons,uDados;

type
  TfrmRelatorio = class(TForm)
    Panel1: TPanel;
    Image1: TImage;
    rgTipos: TRadioGroup;
    BitBtn1: TBitBtn;
    procedure BitBtn1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frmRelatorio: TfrmRelatorio;

implementation

{$R *.dfm}

procedure TfrmRelatorio.BitBtn1Click(Sender: TObject);
begin
 if(rgTipos.ItemIndex = -1) then
 begin
   ShowMessage('Selecionar um tipo de relat�rio v�lido.');
 end
 else if(rgTipos.ItemIndex = 0) then
 begin
   dm.rvProjetoDisciplinas.ProjectFile:='C:\Users\Work\Desktop\relat�rio trabalho\RelatorioDisciplinaProfessorFinal.rav';
   dm.rvProjetoDisciplinas.Execute;
 end
 else if(rgTipos.ItemIndex = 1) then
 begin
   dm.rvProjetoCursos.ProjectFile:='C:\Users\Work\Desktop\relat�rio trabalho\RelatorioProfessorCurso.rav';
   dm.rvProjetoCursos.Execute;
 end;


end;

end.
