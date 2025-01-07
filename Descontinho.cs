using System;

class Program
{
    static void Main()
    {
        // Solicitar ao cliente a quantidade de itens comprados
        Console.Write("Quantos itens você comprou? ");
        int itensComprados = int.Parse(Console.ReadLine());

        // Solicitar ao cliente se ele é membro da loja
        Console.Write("Você é membro da loja? (sim/nao): ");
        string membroResposta = Console.ReadLine().ToLower();

        // Definir o preço de cada item
        double precoPorItem = 30.00;
        
        // Calcular o valor total da compra antes dos descontos
        double valorTotalCompra = itensComprados * precoPorItem;

        // Variáveis para descontos
        double descontoTotal = 0;

        // Condição 1: Se a pessoa comprou mais de 20 itens, ela recebe um desconto adicional
        if (itensComprados > 20)
        {
            descontoTotal += 3 * (itensComprados / 100);  // A cada 100 itens, adiciona 3% de desconto
        }

        // Condição 2: Se a pessoa for membro da loja, ela recebe desconto com base no tipo de membro
        if (membroResposta == "sim")
        {
            // Perguntar qual tipo de membro
            Console.Write("Qual o seu tipo de assinatura? (gold/silver/bronze): ");
            string tipoMembro = Console.ReadLine().ToLower();

            // Desconto baseado no tipo de membro
            if (tipoMembro == "gold")
            {
                descontoTotal += 20;  // 20% de desconto para membros Gold
            }
            else if (tipoMembro == "silver")
            {
                descontoTotal += 10;  // 10% de desconto para membros Silver
            }
            else if (tipoMembro == "bronze")
            {
                descontoTotal += 5;   // 5% de desconto para membros Bronze
            }

            // Se comprou 20 ou mais itens, adiciona automaticamente 2% de desconto
            if (itensComprados >= 20)
            {
                descontoTotal += 2;  // 2% de desconto adicional por compra de 20 itens ou mais
            }
        }
        else
        {
            // Se não é membro, nenhum desconto relacionado ao tipo de assinatura é dado
            Console.WriteLine("Você não é membro, portanto, não recebe descontos de membro.");
        }

        // Garantir que o desconto não ultrapasse 100%
        if (descontoTotal > 100)
        {
            descontoTotal = 100;  // Limitar o desconto a 100%
        }

        // Exibir o desconto total calculado
        Console.WriteLine($"Seu desconto total é: {descontoTotal}%");

        // Calcular o valor com desconto
        double valorComDesconto = valorTotalCompra * (1 - descontoTotal / 100);

        // Exibir o valor total da compra e o valor final com desconto
        Console.WriteLine($"O valor total da sua compra (sem desconto) é: R${valorTotalCompra:F2}");
        Console.WriteLine($"O valor final da sua compra após o desconto é: R${valorComDesconto:F2}");
    }
}
