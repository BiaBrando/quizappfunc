namespace exNavigationPage;

public static class Pontuacao
{
    public static int Total { get; private set; }

    public static void Adicionar(int pontos)
    {
        Total += pontos;
    }

    public static void Zerar()
    {
        Total = 0;
    }
}
