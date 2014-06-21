unit uDados;

interface

uses
  SysUtils, Classes, DB, ZAbstractRODataset, ZAbstractDataset, ZDataset,
  ZAbstractConnection, ZConnection, RpCon, RpConDS, RpDefine, RpRave, RpBase,
  RpSystem;

type
  Tdm = class(TDataModule)
    dbConexao: TZConnection;
    dbQueryDisciplinas: TZQuery;
    rvProjetoDisciplinas: TRvProject;
    rvdsDisciplinas: TRvDataSetConnection;
    dbQueryProfessores: TZQuery;
    rvdsProfessores: TRvDataSetConnection;
    dbQueryProfessoresId_Docente: TIntegerField;
    dbQueryProfessoresNome: TWideStringField;
    dbQueryDisciplinasId_Disciplinas_Docente_Turmas: TIntegerField;
    dbQueryDisciplinasId_Disciplina: TIntegerField;
    dbQueryDisciplinasId_Docente: TIntegerField;
    dbQueryDisciplinasNome_Disciplina: TWideStringField;
    dbQueryCursos: TZQuery;
    dbQueryCursosId_Curso: TIntegerField;
    dbQueryCursosNome_Curso: TWideStringField;
    dbQueryProfCursos: TZQuery;
    rvdsCursos: TRvDataSetConnection;
    rvdsProfCursos: TRvDataSetConnection;
    dbQueryProfCursosid_docente: TIntegerField;
    dbQueryProfCursosnome: TWideStringField;
    dbQueryProfCursosid_curso: TIntegerField;
    rvProjetoCursos: TRvProject;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  dm: Tdm;

implementation

{$R *.dfm}

end.
