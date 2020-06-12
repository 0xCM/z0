//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    readonly struct MnemonicParser : IParser<string,Mnemonic>
    {
        readonly Dictionary<string,Mnemonic> Index;

        [MethodImpl(Inline)]
        public static MnemonicParser Create()
            => new MnemonicParser((int)Mnemonic.LAST);

        [MethodImpl(Inline)]
        MnemonicParser(int capacity)
        {
            Index = new Dictionary<string, Mnemonic>(capacity);
            var literals = Enums.valarray<Mnemonic>();
            foreach(var l in literals)
                Index[l.ToString().ToLower()] = l;
        }

        public ParseResult<string, Mnemonic> Parse(string src)
        {
            if(Index.TryGetValue(src.Trim().ToLower(), out var mne))
                return ParseResult.Success<string,Mnemonic>(src,mne);
            else
                return ParseResult.Fail<string,Mnemonic>(src);
        }            
    }                 

}