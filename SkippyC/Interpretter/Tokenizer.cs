using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SkippyC.Interpretter;

    public enum Token
    {
        Code,
        GreaterThanOrEqualTo,
        LessThanOrEqualTo,
        Equals,
    }

    public class Tokenizer : ITokenizer
    {
        public List<Token> InterpretToken(string input)
        {
            List<Token> tokens = new List<Token>();

            switch (input)
            {
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
