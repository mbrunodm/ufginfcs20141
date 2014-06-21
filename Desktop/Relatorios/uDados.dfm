object dm: Tdm
  OldCreateOrder = False
  Height = 338
  Width = 422
  object dbConexao: TZConnection
    ControlsCodePage = cCP_UTF16
    Connected = True
    HostName = 'www.leonardoalves.info:3306'
    Port = 3306
    Database = 'leonar11_projetos'
    User = 'leonar11_bdaula'
    Password = 'aulabd'
    Protocol = 'mysql-5'
    Left = 64
    Top = 40
  end
  object dbQueryDisciplinas: TZQuery
    Connection = dbConexao
    Active = True
    SQL.Strings = (
      
        'select p.Id_Disciplinas_Docente_Turmas, p.Id_Disciplina, p.Id_Do' +
        'cente, t.Nome_Disciplina  from cadastro_Disciplinas t, disciplin' +
        'as_docente_Turmas p where t.Id_Disciplina = p.Id_Disciplina')
    Params = <>
    Left = 248
    Top = 40
    object dbQueryDisciplinasId_Disciplinas_Docente_Turmas: TIntegerField
      FieldName = 'Id_Disciplinas_Docente_Turmas'
      Required = True
    end
    object dbQueryDisciplinasId_Disciplina: TIntegerField
      FieldName = 'Id_Disciplina'
      Required = True
    end
    object dbQueryDisciplinasId_Docente: TIntegerField
      FieldName = 'Id_Docente'
      Required = True
    end
    object dbQueryDisciplinasNome_Disciplina: TWideStringField
      FieldName = 'Nome_Disciplina'
      Size = 45
    end
  end
  object rvProjetoDisciplinas: TRvProject
    Left = 64
    Top = 168
  end
  object rvdsDisciplinas: TRvDataSetConnection
    RuntimeVisibility = rtDeveloper
    DataSet = dbQueryDisciplinas
    Left = 256
    Top = 176
  end
  object dbQueryProfessores: TZQuery
    Connection = dbConexao
    Active = True
    SQL.Strings = (
      'select Id_Docente, Nome from cadastro_Docentes ')
    Params = <>
    Left = 352
    Top = 40
    object dbQueryProfessoresId_Docente: TIntegerField
      FieldName = 'Id_Docente'
      Required = True
    end
    object dbQueryProfessoresNome: TWideStringField
      FieldName = 'Nome'
      Size = 45
    end
  end
  object rvdsProfessores: TRvDataSetConnection
    RuntimeVisibility = rtDeveloper
    DataSet = dbQueryProfessores
    Left = 344
    Top = 176
  end
  object dbQueryCursos: TZQuery
    Connection = dbConexao
    Active = True
    SQL.Strings = (
      'select * from cadastro_Cursos')
    Params = <>
    Left = 248
    Top = 96
    object dbQueryCursosId_Curso: TIntegerField
      FieldName = 'Id_Curso'
      Required = True
    end
    object dbQueryCursosNome_Curso: TWideStringField
      FieldName = 'Nome_Curso'
      Size = 45
    end
  end
  object dbQueryProfCursos: TZQuery
    Connection = dbConexao
    Active = True
    SQL.Strings = (
      
        'SELECT distinct p.id_docente, c.id_curso , p.nome from cadastro_' +
        'Docentes p, disciplinas_docente_Turmas t, cadastro_Disciplinas d' +
        ', cadastro_Cursos c'
      
        'where c.id_curso=d.id_curso and d.Id_Disciplina=t.Id_Disciplina ' +
        'and p.id_docente=t.id_docente order by p.nome')
    Params = <>
    Left = 352
    Top = 96
    object dbQueryProfCursosid_docente: TIntegerField
      FieldName = 'id_docente'
      Required = True
    end
    object dbQueryProfCursosnome: TWideStringField
      FieldName = 'nome'
      Size = 45
    end
    object dbQueryProfCursosid_curso: TIntegerField
      FieldName = 'id_curso'
      Required = True
    end
  end
  object rvdsCursos: TRvDataSetConnection
    RuntimeVisibility = rtDeveloper
    DataSet = dbQueryCursos
    Left = 256
    Top = 248
  end
  object rvdsProfCursos: TRvDataSetConnection
    RuntimeVisibility = rtDeveloper
    DataSet = dbQueryProfCursos
    Left = 352
    Top = 248
  end
  object rvProjetoCursos: TRvProject
    Left = 64
    Top = 248
  end
end
