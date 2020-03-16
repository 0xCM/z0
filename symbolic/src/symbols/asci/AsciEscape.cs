//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using static Root;

    public class AsciEscapeSet : SymbolSet<AsciEscapeSet, AsciAlphabet>
    {
        static AsciEscapeSet()
            => _Symbols = new Symbol<AsciAlphabet>[]{Tab, NewLine, LineFeed};
        
        public const char Tab = '\t';

        public const char NewLine = '\n';

        public const char LineFeed = '\r';

        /// <summary>
        /// The end-of-line escape sequence
        /// </summary>
        public const string Eol = "\r\n";
    }
}