/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package br.inf.ufg.cadastroProfessorDisciplina.model;


/**
 *
 * @author Athos
 */
public class Turma {
    
    private char turma;
    private Curso curso;
    private String semestre;

    public Turma() {
    }

    public Turma(char turma, Curso curso, String semestre) {
        this.turma = turma;
        this.curso = curso;
        this.semestre = semestre;
    }

    public char getTurma() {
        return turma;
    }

    public void setTurma(char turma) {
        this.turma = turma;
    }

    public Curso getCurso() {
        return curso;
    }

    public void setCurso(Curso curso) {
        this.curso = curso;
    }

    public String getSemestre() {
        return semestre;
    }

    public void setSemestre(String semestre) {
        this.semestre = semestre;
    }
    
    
    
}
