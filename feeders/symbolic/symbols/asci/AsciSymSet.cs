//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    public sealed class AsciSymSet : SymbolSet<AsciSymSet, AsciAlphabet>
    {
        static AsciSymSet()
        {
            _Symbols = new Symbol<AsciAlphabet>[]
            {
                Amp, At, Bang, BSlash, Caret, Colon, Comma,Dollar, Dot, Eq,
                FSlash, Gt, Hash, LBrace, LBracket, LParen, Lt, Dash, Pipe, Plus,
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

        /// <summary>
        /// Defines the backslash symbol
        /// </summary>
        public const char BSlash = '\\';

        /// <summary>
        /// Defines the '^' symbol
        /// </summary>
        public const char Caret = '^';

        /// <summary>
        /// Defines the ':' symbol
        /// </summary>
        public const char Colon = ':';

        /// <summary>
        /// Defines the ',' symbol
        /// </summary>
        public const char Comma = ',';

        /// <summary>
        /// Defines the '-' character
        /// </summary>
        public const char Dash = '-';

        /// <summary>
        /// Defines the '$' symbol
        /// </summary>
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
        /// Defines the '?' character
        /// </summary>
        public const char Question = '?';

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
        /// Defines the '~' character
        /// </summary>
        public const char Underscore = '_'; 

    }
}