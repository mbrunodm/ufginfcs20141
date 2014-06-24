/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package br.inf.ufg.cadastroProfessorDisciplina.model;

import java.sql.Date;

/**
 *
 * @author Gustavo
 */
public class Horario {
    
    private Date diaSemana;
    private Date horario;
    private String status;
    private String observacao;

    public Horario() {
    }

    public Horario(Date diaSemana, Date horario, String status, String observacao) {
        this.diaSemana = diaSemana;
        this.horario = horario;
        this.status = status;
        this.observacao = observacao;
    }

    public Date getDiaSemana() {
        return diaSemana;
    }

    public void setDiaSemana(Date diaSemana) {
        this.diaSemana = diaSemana;
    }

    public Date getHorario() {
        return horario;
    }

    public void setHorario(Date horario) {
        this.horario = horario;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    public String getObservacao() {
        return observacao;
    }

    public void setObservacao(String observacao) {
        this.observacao = observacao;
    }
    
    
    
    
}
