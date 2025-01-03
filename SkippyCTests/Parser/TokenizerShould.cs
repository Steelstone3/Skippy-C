using System.Collections.Generic;
using SkippyC.Parser;
using Xunit;

namespace SkippyCTests.Parser;

public class TokenizerShould
{
    private readonly ITokenizer tokenizer = new Tokenizer();

    [Theory]
    [InlineData("structure", Token.Structure)]
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

    // [Fact]
    // public void InterpretMultipleTokens()
    // {
    //     // Given
    //     // string input="";


    //     // When
    
    //     // Then
    // }
}
