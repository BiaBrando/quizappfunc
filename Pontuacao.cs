namespace exNavigationPage;

public static class Pontuacao
{
    public static int total { get; private set; }

    public static void Adicionar(int pontos)
    {
        total += pontos;
    }

    public static void Zerar()
    {
        total = 0;
    }
}
