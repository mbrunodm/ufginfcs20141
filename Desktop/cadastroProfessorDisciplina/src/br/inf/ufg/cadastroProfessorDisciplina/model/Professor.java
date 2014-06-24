
package br.inf.ufg.cadastroProfessorDisciplina.model;


public class Professor {
    
    private String nome;
    private String email;
    private String telefone;
    private String observacao;

    public Professor(String nome, String email, String telefone, String observacao) {
        this.nome = nome;
        this.email = email;
        this.telefone = telefone;
        this.observacao = observacao;
    }
    

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getTelefone() {
        return telefone;
    }

    public void setTelefone(String telefone) {
        this.telefone = telefone;
    }

    public String getObservacao() {
        return observacao;
    }

    public void setObservacao(String observacao) {
        this.observacao = observacao;
    }
    
    
    
}
