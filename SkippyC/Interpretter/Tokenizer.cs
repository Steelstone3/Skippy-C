using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SkippyC.Interpretter;

    public enum Token
    {
        Equals,
    }

    public class Tokenizer : ITokenizer
    {
        public List<Token> InterpretToken(string input)
        {
            List<Token> tokens = new List<Token>();

            // switch (input)
            // {

            //     default:
            //         tokens.Add(Token.Equals);
            // }

            tokens.Add(Token.Equals);

            return tokens;
        }
    }

    public interface ITokenizer
    {
        List<Token> InterpretToken(string input);
    }
