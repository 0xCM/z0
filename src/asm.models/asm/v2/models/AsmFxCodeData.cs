//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmFxCodeData
    {
        readonly string Data;
        
        [MethodImpl(Inline)]
        public AsmFxCodeData(string src)
            => Data = src;
        
        public string Format()
            => Data;        

        public override string ToString()
            => Format();
    }
}