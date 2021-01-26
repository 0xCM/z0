//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    public readonly struct AsmMnemonicParser : IParser<string,IceMnemonic>
    {
        readonly Dictionary<string,IceMnemonic> Index;

        [MethodImpl(Inline)]
        public static AsmMnemonicParser Create()
            => new AsmMnemonicParser((int)IceMnemonic.LAST);

        [MethodImpl(Inline)]
        public AsmMnemonicParser(int capacity)
        {
            Index = new Dictionary<string, IceMnemonic>(capacity);
            var literals = Enums.literals<IceMnemonic>();
            foreach(var l in literals)
                Index[l.ToString().ToLower()] = l;
        }

        public ParseResult<string, IceMnemonic> Parse(string src)
        {
            if(Index.TryGetValue(src.Trim().ToLower(), out var mne))
                return root.parsed<string,IceMnemonic>(src,mne);
            else
                return root.unparsed<string,IceMnemonic>(src);
        }
    }
}