using System;

/*
 * ============================================================================
 * PROJETO: GovAware Risk & Awareness v1.0
 * EMPRESA/PROJETO: GovAware
 * DESCRIÇÃO: Sistema Integrado de Gestão de Riscos de TI e Conscientização Digital
 *
 * EQUIPE DE DESENVOLVIMENTO:
 *  - Clara Barbosa Paiva            (RA: 2224202958)
 *  - Gisele Fernandes das Chagas    (RA: 2223206193)
 *  - Guilherme Paz de Oliveira      (RA: 2225105322)
 *  - Laura Barbosa Moura            (RA: 2225101520)
 *  - Luis Eduardo Rodrigues Ribeiro (RA: 2326103539)
 *  - Luzala Dimatondo               (RA: 302420183)
 *
 * DISCIPLINA: Lógica e Programação Visual
 * ============================================================================
 */

namespace GovAware
{
    class Program
    {
        // --- REQUISITO OBRIGATÓRIO: CONSTANTE ---
        const int TOTAL_PERGUNTAS_QUIZ = 2;

        // --- VARIÁVEIS PRINCIPAIS DO PROJETO ---
        static string ativo = "";
        static string vulnerabilidade = "";
        static int probabilidade = 0;
        static int impacto = 0;
        static int pontuacao = 0;
        static string classificacao = "";
        static string planoTratamento = "";
        static string responsavel = "";
        static string prazo = "";
        static string statusTratamento = "Não iniciado";

        static void Main(string[] args)
        {
            int opcao;

            // --- ESTRUTURA DE REPETIÇÃO DO MENU ---
            do
            {
                Console.Clear();

                Console.WriteLine("==========================================");
                Console.WriteLine("       GOVAWARE RISK & AWARENESS");
                Console.WriteLine("==========================================");
                Console.WriteLine(" Gestão de Riscos e Conscientização");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("1 - Cadastrar ativo");
                Console.WriteLine("2 - Registrar vulnerabilidade");
                Console.WriteLine("3 - Avaliar risco");
                Console.WriteLine("4 - Criar plano de tratamento");
                Console.WriteLine("5 - Acompanhar tratamento");
                Console.WriteLine("6 - Consultar situação do risco");
                Console.WriteLine("7 - Avaliação de conscientização");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("------------------------------------------");
                Console.Write("Escolha uma opção (digite o número): ");

                int.TryParse(Console.ReadLine(), out opcao);

                // --- ESTRUTURA DE DECISÃO (SWITCH) ---
                switch (opcao)
                {
                    case 1:
                        CadastrarAtivo();
                        break;

                    case 2:
                        RegistrarVulnerabilidade();
                        break;

                    case 3:
                        AvaliarRisco();
                        break;

                    case 4:
                        CriarPlanoTratamento();
                        break;

                    case 5:
                        AcompanharTratamento();
                        break;

                    case 6:
                        ConsultarRisco();
                        break;

                    case 7:
                        AvaliarConscientizacao();
                        break;

                    case 0:
                        Console.WriteLine("\nEncerrando o sistema... Obrigado por usar o GovAware!");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida! Lembre-se de digitar apenas o NÚMERO da opção.");
                        Pausar();
                        break;
                }

            } while (opcao != 0);
        }

        // ==========================================
        // 1. CADASTRO DE ATIVO
        // ==========================================
        static void CadastrarAtivo()
        {
            Console.Clear();

            Console.WriteLine("=== CADASTRO DE ATIVO ===\n");

            Console.Write("Nome do ativo (ex: Servidor Web, Notebook): ");
            ativo = Console.ReadLine();

            Console.WriteLine("\nAtivo cadastrado com sucesso!");
            Console.WriteLine("Ativo: " + ativo);

            Pausar();
        }

        // ==========================================
        // 2. REGISTRO DE VULNERABILIDADE
        // ==========================================
        static void RegistrarVulnerabilidade()
        {
            Console.Clear();

            Console.WriteLine("=== REGISTRO DE VULNERABILIDADE ===\n");

            if (string.IsNullOrWhiteSpace(ativo))
            {
                Console.WriteLine("Atenção: Cadastre um ativo (Opção 1) antes de registrar uma vulnerabilidade.");
                Pausar();
                return;
            }

            Console.WriteLine("Ativo relacionado: " + ativo);

            Console.Write("Descrição da vulnerabilidade: ");
            vulnerabilidade = Console.ReadLine();

            Console.WriteLine("\nVulnerabilidade registrada com sucesso!");
            Console.WriteLine("Ativo: " + ativo);
            Console.WriteLine("Vulnerabilidade: " + vulnerabilidade);

            Pausar();
        }

        // ==========================================
        // 3. AVALIAÇÃO DO RISCO
        // ==========================================
        static void AvaliarRisco()
        {
            Console.Clear();

            Console.WriteLine("=== AVALIAÇÃO DE RISCO ===\n");

            if (string.IsNullOrWhiteSpace(vulnerabilidade))
            {
                Console.WriteLine("Atenção: Registre uma vulnerabilidade (Opção 2) antes de avaliar o risco.");
                Pausar();
                return;
            }

            Console.WriteLine("Ativo: " + ativo);
            Console.WriteLine("Vulnerabilidade: " + vulnerabilidade);
            Console.WriteLine();

            Console.Write("Informe a probabilidade (1 a 5): ");
            int.TryParse(Console.ReadLine(), out probabilidade);

            Console.Write("Informe o impacto (1 a 5): ");
            int.TryParse(Console.ReadLine(), out impacto);

            // --- OPERADOR ARITMÉTICO: Cálculo da Pontuação do Risco ---
            pontuacao = probabilidade * impacto;

            // --- ESTRUTURA CONDICIONAL (Ajustada conforme Seção 5.8 da documentação) ---
            if (pontuacao <= 4)
            {
                classificacao = "Baixo";
            }
            else if (pontuacao <= 9)
            {
                classificacao = "Médio";
            }
            else if (pontuacao <= 15)
            {
                classificacao = "Alto";
            }
            else
            {
                classificacao = "Crítico";
            }

            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("RESULTADO DA AVALIAÇÃO");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Probabilidade: " + probabilidade);
            Console.WriteLine("Impacto: " + impacto);
            Console.WriteLine("Pontuação obtida (Probabilidade x Impacto): " + pontuacao);
            Console.WriteLine("Classificação do Risco: " + classificacao);
            Console.WriteLine("------------------------------------------");

            Pausar();
        }

        // ==========================================
        // 4. PLANO DE TRATAMENTO
        // ==========================================
        static void CriarPlanoTratamento()
        {
            Console.Clear();

            Console.WriteLine("=== PLANO DE TRATAMENTO ===\n");

            if (string.IsNullOrWhiteSpace(classificacao))
            {
                Console.WriteLine("Atenção: Avalie o risco (Opção 3) antes de criar um plano de tratamento.");
                Pausar();
                return;
            }

            Console.WriteLine("Risco classificado como: " + classificacao);
            Console.WriteLine();

            Console.Write("Ação de tratamento necessária: ");
            planoTratamento = Console.ReadLine();

            Console.Write("Responsável pela execução: ");
            responsavel = Console.ReadLine();

            Console.Write("Prazo estimado: ");
            prazo = Console.ReadLine();

            statusTratamento = "Em tratamento";

            Console.WriteLine("\nPlano de tratamento criado com sucesso!");
            Console.WriteLine("Ação: " + planoTratamento);
            Console.WriteLine("Responsável: " + responsavel);
            Console.WriteLine("Prazo: " + prazo);
            Console.WriteLine("Status: " + statusTratamento);

            Pausar();
        }

        // ==========================================
        // 5. ACOMPANHAMENTO DO TRATAMENTO
        // ==========================================
        static void AcompanharTratamento()
        {
            Console.Clear();

            Console.WriteLine("=== ACOMPANHAMENTO DO TRATAMENTO ===\n");

            if (string.IsNullOrWhiteSpace(planoTratamento))
            {
                Console.WriteLine("Nenhum plano de tratamento foi criado até o momento.");
                Pausar();
                return;
            }

            Console.WriteLine("Risco: " + classificacao);
            Console.WriteLine("Ação: " + planoTratamento);
            Console.WriteLine("Responsável: " + responsavel);
            Console.WriteLine("Prazo: " + prazo);
            Console.WriteLine("Status atual: " + statusTratamento);

            Console.WriteLine("\n[1] Em tratamento");
            Console.WriteLine("[2] Concluído");
            Console.Write("Selecione o novo status: ");

            int opcao;
            int.TryParse(Console.ReadLine(), out opcao);

            if (opcao == 1)
            {
                statusTratamento = "Em tratamento";
            }
            else if (opcao == 2)
            {
                statusTratamento = "Concluído";
            }
            else
            {
                Console.WriteLine("Opção inválida.");
                Pausar();
                return;
            }

            Console.WriteLine("\nStatus atualizado com sucesso para: " + statusTratamento);

            Pausar();
        }

        // ==========================================
        // 6. CONSULTA DO RISCO
        // ==========================================
        static void ConsultarRisco()
        {
            Console.Clear();

            Console.WriteLine("=== CONSULTA DO RISCO COMPLETO ===\n");

            Console.WriteLine("Ativo: " + (string.IsNullOrEmpty(ativo) ? "Não informado" : ativo));
            Console.WriteLine("Vulnerabilidade: " + (string.IsNullOrEmpty(vulnerabilidade) ? "Não informada" : vulnerabilidade));
            Console.WriteLine("Probabilidade: " + probabilidade);
            Console.WriteLine("Impacto: " + impacto);
            Console.WriteLine("Pontuação: " + pontuacao);
            Console.WriteLine("Classificação: " + (string.IsNullOrEmpty(classificacao) ? "Pendente" : classificacao));
            Console.WriteLine("Plano de tratamento: " + (string.IsNullOrEmpty(planoTratamento) ? "Pendente" : planoTratamento));
            Console.WriteLine("Responsável: " + (string.IsNullOrEmpty(responsavel) ? "Pendente" : responsavel));
            Console.WriteLine("Prazo: " + (string.IsNullOrEmpty(prazo) ? "Pendente" : prazo));
            Console.WriteLine("Status: " + statusTratamento);

            Pausar();
        }

        // ==========================================
        // 7. CONSCIENTIZAÇÃO DIGITAL
        // ==========================================
        static void AvaliarConscientizacao()
        {
            Console.Clear();

            Console.WriteLine("=== AVALIAÇÃO DE CONSCIENTIZAÇÃO DIGITAL ===\n");

            int pontos = 0;

            Console.WriteLine("Pergunta 1:");
            Console.WriteLine("Você recebeu um e-mail solicitando sua senha institucional.");
            Console.WriteLine("1 - Informar a senha solicitada");
            Console.WriteLine("2 - Ignorar e comunicar imediatamente a equipe de segurança");
            Console.Write("Sua Resposta: ");

            int resposta1;
            int.TryParse(Console.ReadLine(), out resposta1);

            if (resposta1 == 2)
            {
                pontos++;
            }

            Console.WriteLine("\nPergunta 2:");
            Console.WriteLine("Você encontrou um link encurtado suspeito em uma mensagem.");
            Console.WriteLine("1 - Clicar para verificar o conteúdo");
            Console.WriteLine("2 - Não clicar e comunicar a ocorrência");
            Console.Write("Sua Resposta: ");

            int resposta2;
            int.TryParse(Console.ReadLine(), out resposta2);

            if (resposta2 == 2)
            {
                pontos++;
            }

            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("RESULTADO DA AVALIAÇÃO");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Pontuação: {pontos} de {TOTAL_PERGUNTAS_QUIZ} pontos.");

            if (pontos == TOTAL_PERGUNTAS_QUIZ)
            {
                Console.WriteLine("Resultado: Conhecimento adequado.");
                Console.WriteLine("Orientação: Parabéns! Mantenha as boas práticas de cibersegurança.");
            }
            else if (pontos == 1)
            {
                Console.WriteLine("Resultado: Necessidade de reforço.");
                Console.WriteLine("Orientação: Atenção em cenários de phishing e engenharia social.");
            }
            else
            {
                Console.WriteLine("Resultado: Necessidade urgente de atenção.");
                Console.WriteLine("Orientação: Recomendado realizar treinamento completo de conscientização.");
            }

            Pausar();
        }

        // ==========================================
        // FUNÇÃO AUXILIAR
        // ==========================================
        static void Pausar()
        {
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}