
package br.inf.ufg.cadastroProfessorDisciplina.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class ConexaoMySQL {

    public static void main(String[] args) throws InstantiationException, IllegalAccessException {

        String driver = "com.mysql.jdbc.Driver";
        String url = "jdbc:mysql://www.leonardoalves.info:3306/leonar11_projetos";
        String usuario = "leonar11_bdaula";
        String senha = "aulabd";

        try {

            Class.forName(driver).newInstance();
            Connection con = null;

            con = DriverManager.getConnection(url, usuario, senha);

            System.out.println("Conexão realizada com sucesso.");

        } catch (ClassNotFoundException | SQLException ex) {
            ex.printStackTrace();
            
        } 
                    
    }

}
