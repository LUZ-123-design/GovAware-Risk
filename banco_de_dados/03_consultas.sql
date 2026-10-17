-- Script de Consultas SQL (Queries) - GovAware Risk & Awareness

USE govaware_db;

-- Consulta 1: Listar Usuários e suas respetivas Organizações
SELECT 
    u.id_usuario,
    u.nome AS Usuario,
    u.cargo,
    o.nome AS Organizacao
FROM USUARIO u
INNER JOIN ORGANIZACAO o ON u.id_organizacao = o.id_organizacao;

-- Consulta 2: Visão Geral da Gestão de Riscos e Planos de Tratamento
SELECT 
    r.id_risco,
    v.descricao AS Vulnerabilidade,
    r.descricao AS Risco,
    r.nivel_risco AS Nivel,
    p.acao_proposta AS Plano_Tratamento,
    p.status AS Status_Plano
FROM RISCO r
INNER JOIN VULNERABILIDADE v ON r.id_vulnerabilidade = v.id_vulnerabilidade
LEFT JOIN PLANO_TRATAMENTO p ON r.id_risco = p.id_risco;

-- Consulta 3: Listar Incidentes Registados
SELECT 
    i.id_incidente,
    i.descricao AS Incidente,
    i.data_ocorrencia,
    i.status
FROM INCIDENTE i;
