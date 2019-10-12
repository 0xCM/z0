//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Linq;

    using static zfunc;

    public sealed class AsciSym : SymbolSet<AsciSym, AsciAlphabet>
    {
        static AsciSym()
        {
            _Symbols = new Symbol<AsciAlphabet>[]
            {
                Amp, At, Bang, BSlash, Caret, Colon, Comma,Dollar, Dot, Eq,
                FSlash, Gt, Hash, LBrace, LBracket, LParen, Lt, Minus, Pipe, Plus,
                Percent, Quote, RParen, RBrace, RBracket, Semicolon, Space,
                SQuote, Star, Tilde,
            };            
        }

        /// <summary>
        /// Defines the '&' symbol
        /// </summary>
        public const char Amp = '&';

        /// <summary>
        /// Defines the '@' symbol
        /// </summary>
        public const char At = '@';

        /// <summary>
        /// Defines the '!' symbol
        /// </summary>
        public const char Bang = '!';

        public const char BSlash = '\\';

        public const char Caret = '^';

        public const char Colon = ':';

        public const char Comma = ',';

        public const char Dollar = '$';

        /// <summary>
        /// Defines the '.' character
        /// </summary>
        public const char Dot = '.';

        /// <summary>
        /// Defines the '=' character
        /// </summary>
        public const char Eq = '=';

        /// <summary>
        /// Defines the '/' character
        /// </summary>
        public const char FSlash = '/';

        /// <summary>
        /// Defines the '>' character
        /// </summary>
        public const char Gt = '>';

        /// <summary>
        /// Defines the '#' character
        /// </summary>
        public const char Hash = '#';

        /// <summary>
        /// Defines the '{' character
        /// </summary>
        public const char LBrace = '{';

        /// <summary>
        /// Defines the '[' character
        /// </summary>
        public const char LBracket = '[';

        /// <summary>
        /// Defines the '(' character
        /// </summary>
        public const char LParen = '(';        

        /// <summary>
        /// Defines the '<' character
        /// </summary>
        public const char Lt = '<';

        /// <summary>
        /// Defines the '-' character
        /// </summary>
        public const char Minus = '-';

        /// <summary>
        /// Defines the '%' character
        /// </summary>
        public const char Percent = '%';

        /// <summary>
        /// Defines the '|' character
        /// </summary>
        public const char Pipe = '|';

        /// <summary>
        /// Defines the '+' character
        /// </summary>
        public const char Plus = '+';

        /// <summary>
        /// Specifies '"', the double-quote character
        /// </summary>
        public const char Quote = '\"';

        /// <summary>
        /// Defines the ')' character
        /// </summary>
        public const char RParen = ')';        
        
        /// <summary>
        /// Defines the '}' character
        /// </summary>
        public const char RBrace = '}';

        /// <summary>
        /// Defines the ']' character
        /// </summary>
        public const char RBracket = ']';

        /// <summary>
        /// Defines the ';' character
        /// </summary>
        public const char Semicolon = ';';

        
        /// <summary>
        /// Defines the ' ' character
        /// </summary>
        public const char Space = ' ';

        /// <summary>
        /// Defines the ''' character
        /// </summary>
        public const char SQuote = '\'';

        /// <summary>
        /// Defines the '*' character
        /// </summary>
        public const char Star = '*';

        /// <summary>
        /// Defines the '~' character
        /// </summary>
        public const char Tilde = '~'; 

        /// <summary>
        /// Defines the '?' character
        /// </summary>
        public const char Question = '?';
    }
}