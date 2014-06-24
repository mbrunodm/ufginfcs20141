
package br.inf.ufg.cadastroProfessorDisciplina.model;



public class Disciplina {
    
    private String nomeDisciplina;
    private Curso curso;
    private int cargaHoraria;
    private Turma turma;
    private String periodo;

    public Disciplina(String nomeDisciplina, Curso curso, int cargaHoraria, Turma turma, String periodo) {
        this.nomeDisciplina = nomeDisciplina;
        this.curso = curso;
        this.cargaHoraria = cargaHoraria;
        this.turma = turma;
        this.periodo = periodo;
    }

    public String getNomeDisciplina() {
        return nomeDisciplina;
    }

    public void setNomeDisciplina(String nomeDisciplina) {
        this.nomeDisciplina = nomeDisciplina;
    }

    public Curso getCurso() {
        return curso;
    }

    public void setCurso(Curso curso) {
        this.curso = curso;
    }

    public int getCargaHoraria() {
        return cargaHoraria;
    }

    public void setCargaHoraria(int cargaHoraria) {
        this.cargaHoraria = cargaHoraria;
    }

    public Turma getTurma() {
        return turma;
    }

    public void setTurma(Turma turma) {
        this.turma = turma;
    }

    public String getPeriodo() {
        return periodo;
    }

    public void setPeriodo(String periodo) {
        this.periodo = periodo;
    }
    
    
    
}
