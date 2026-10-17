-- Script de Inserção de Dados de Teste - GovAware Risk & Awareness

USE govaware_db;

-- 1. Inserir Organização
INSERT INTO ORGANIZACAO (nome, cnpj, setor) 
VALUES ('GovAware Tech', '12.345.678/0001-90', 'Tecnologia da Informação');

-- 2. Inserir Usuário
INSERT INTO USUARIO (nome, email, cargo, id_organizacao) 
VALUES ('Carlos Silva', 'carlos.silva@govaware.com', 'Analista de Segurança', 1);

-- 3. Inserir Ativo
INSERT INTO ATIVO (nome, tipo, criticidade, id_organizacao) 
VALUES ('Servidor Web Principal', 'Servidor', 'Alta', 1);

-- 4. Inserir Vulnerabilidade
INSERT INTO VULNERABILIDADE (descricao, severidade, id_ativo) 
VALUES ('Versão desatualizada do serviço Apache HTTP', 'Alta', 1);

-- 5. Inserir Risco
INSERT INTO RISCO (descricao, probabilidade, impacto, nivel_risco, id_vulnerabilidade) 
VALUES ('Risco de execução remota de código malicioso', 'Alta', 'Muito Alto', 'Crítico', 1);

-- 6. Inserir Plano de Tratamento
INSERT INTO PLANO_TRATAMENTO (acao_proposta, status, data_inicio, data_conclusao, id_risco) 
VALUES ('Atualizar o servidor Apache para a versão mais recente', 'Em Andamento', '2026-03-01', '2026-03-15', 1);

-- 7. Inserir Incidente
INSERT INTO INCIDENTE (descricao, data_ocorrencia, status, id_risco) 
VALUES ('Tentativa não autorizada de acesso ao servidor', '2026-03-02 14:30:00', 'Em Análise', 1);

-- 8. Inserir Avaliação de Conscientização
INSERT INTO AVALIACAO_CONSCIENTIZACAO (nota, data_avaliacao, id_usuario) 
VALUES (8.50, '2026-03-01', 1);

-- 9. Inserir Ação de Conscientização
INSERT INTO ACAO_CONSCIENTIZACAO (titulo, descricao, status, id_avaliacao, id_usuario) 
VALUES ('Treinamento de Phishing', 'Participação no módulo prático de prevenção contra e-mails falsos', 'Concluído', 1, 1);
