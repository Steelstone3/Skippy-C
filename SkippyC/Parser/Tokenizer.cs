using System.Collections.Generic;

namespace SkippyC.Parser;

public class Tokenizer : ITokenizer
{
    public List<Token> InterpretToken(string input)
    {
        List<Token> tokens = new List<Token>();

        switch (input)
        {
            case "structure":
                tokens.Add(Token.Structure);
                break;
            case ">=":
                tokens.Add(Token.GreaterThanOrEqualTo);
                break;
            case "<=":
                tokens.Add(Token.LessThanOrEqualTo);
                break;
            case "=":
                tokens.Add(Token.Equals);
                break;
            default:
                tokens.Add(Token.Code);
                break;
        }

        tokens.Add(Token.Equals);

        return tokens;
    }
}

public interface ITokenizer
{
    List<Token> InterpretToken(string input);
}
