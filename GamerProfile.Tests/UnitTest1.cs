using GamerProfile.App;

namespace GamerProfile.Tests;

public class PerfilJogadorServiceTests
{
    [Fact]
    public void GerarTagUsuario_NicknameECodigo_RetornaFormatoCorreto()
    {
        // Arrange
        var service = new PerfilJogadorService();

        // Act
        var resultado = service.GerarTagUsuario("Nickname", "0000");

        // Assert
        Assert.Equal("Nickname#0000", resultado);
    }

    [Fact]
    public void CalcularXPTotal_SomaFasesEAplicaBonus_RetornaTotalCorreto()
    {
        // Arrange
        var service = new PerfilJogadorService();
        int valorEsperado = 600;

        // Act
        var resultado = service.CalcularXPTotal(200, 300);

        // Assert
        Assert.Equal(valorEsperado, resultado);
    }

    [Fact]
    public void EEligivelParaRanked_VerificaRegraDoNivel15_RetornaTrueOuFalse()
    {
        // Arrange
        var service = new PerfilJogadorService();

        // Act & Assert
        Assert.True(service.EEligivelParaRanked(15));
        Assert.True(service.EEligivelParaRanked(20));
        Assert.False(service.EEligivelParaRanked(14));
        Assert.False(service.EEligivelParaRanked(1));
    }
}