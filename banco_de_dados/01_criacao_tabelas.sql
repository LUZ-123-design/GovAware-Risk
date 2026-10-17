-- Script de Criação da Base de Dados e Tabelas - GovAware Risk & Awareness

DROP DATABASE IF EXISTS govaware_db;
CREATE DATABASE govaware_db;
USE govaware_db;

-- Tabela ORGANIZACAO
CREATE TABLE ORGANIZACAO (
    id_organizacao INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cnpj VARCHAR(18) UNIQUE,
    setor VARCHAR(50)
);

-- Tabela USUARIO
CREATE TABLE USUARIO (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    cargo VARCHAR(50),
    id_organizacao INT NOT NULL,
    FOREIGN KEY (id_organizacao) REFERENCES ORGANIZACAO(id_organizacao) ON DELETE CASCADE
);

-- Tabela ATIVO
CREATE TABLE ATIVO (
    id_ativo INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    tipo VARCHAR(50),
    criticidade VARCHAR(20),
    id_organizacao INT NOT NULL,
    FOREIGN KEY (id_organizacao) REFERENCES ORGANIZACAO(id_organizacao) ON DELETE CASCADE
);

-- Tabela VULNERABILIDADE
CREATE TABLE VULNERABILIDADE (
    id_vulnerabilidade INT AUTO_INCREMENT PRIMARY KEY,
    descricao TEXT NOT NULL,
    severidade VARCHAR(20),
    id_ativo INT NOT NULL,
    FOREIGN KEY (id_ativo) REFERENCES ATIVO(id_ativo) ON DELETE CASCADE
);

-- Tabela RISCO
CREATE TABLE RISCO (
    id_risco INT AUTO_INCREMENT PRIMARY KEY,
    descricao TEXT NOT NULL,
    probabilidade VARCHAR(20),
    impacto VARCHAR(20),
    nivel_risco VARCHAR(20),
    id_vulnerabilidade INT NOT NULL,
    FOREIGN KEY (id_vulnerabilidade) REFERENCES VULNERABILIDADE(id_vulnerabilidade) ON DELETE CASCADE
);

-- Tabela PLANO_TRATAMENTO
CREATE TABLE PLANO_TRATAMENTO (
    id_plano INT AUTO_INCREMENT PRIMARY KEY,
    acao_proposta TEXT NOT NULL,
    status VARCHAR(30) DEFAULT 'Pendente',
    data_inicio DATE,
    data_conclusao DATE,
    id_risco INT NOT NULL,
    FOREIGN KEY (id_risco) REFERENCES RISCO(id_risco) ON DELETE CASCADE
);

-- Tabela INCIDENTE
CREATE TABLE INCIDENTE (
    id_incidente INT AUTO_INCREMENT PRIMARY KEY,
    descricao TEXT NOT NULL,
    data_ocorrencia DATETIME NOT NULL,
    status VARCHAR(30) DEFAULT 'Aberto',
    id_risco INT,
    FOREIGN KEY (id_risco) REFERENCES RISCO(id_risco) ON DELETE SET NULL
);

-- Tabela AVALIACAO_CONSCIENTIZACAO
CREATE TABLE AVALIACAO_CONSCIENTIZACAO (
    id_avaliacao INT AUTO_INCREMENT PRIMARY KEY,
    nota DECIMAL(4,2),
    data_avaliacao DATE NOT NULL,
    id_usuario INT NOT NULL,
    FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario) ON DELETE CASCADE
);

-- Tabela ACAO_CONSCIENTIZACAO
CREATE TABLE ACAO_CONSCIENTIZACAO (
    id_acao INT AUTO_INCREMENT PRIMARY KEY,
    titulo VARCHAR(100) NOT NULL,
    descricao TEXT,
    status VARCHAR(30) DEFAULT 'Pendente',
    id_avaliacao INT,
    id_usuario INT NOT NULL,
    FOREIGN KEY (id_avaliacao) REFERENCES AVALIACAO_CONSCIENTIZACAO(id_avaliacao) ON DELETE SET NULL,
    FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario) ON DELETE CASCADE
);
