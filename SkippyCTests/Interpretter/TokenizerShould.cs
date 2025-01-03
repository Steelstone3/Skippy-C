using System.Collections.Generic;
using SkippyC.Interpretter;
using Xunit;

namespace SkippyCTests.Interpretter;

public class TokenizerShould
{
    private readonly ITokenizer tokenizer = new Tokenizer();

    [Theory]
    [InlineData(">=", Token.GreaterThanOrEqualTo)]
    [InlineData("<=", Token.LessThanOrEqualTo)]
    [InlineData("=", Token.Equals)]
    [InlineData("", Token.Code)]
    public void InterpretToken(string input, Token token)
    {
        // Given
        List<Token> expectedTokens = new() { token };

        // When
        List<Token> tokens = tokenizer.InterpretToken(input);

        // Then
        Assert.NotEmpty(tokens);
        Assert.Equivalent(expectedTokens, tokens);
    }

}
