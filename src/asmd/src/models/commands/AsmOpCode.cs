//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    public readonly struct AsmOpCode
    {
        readonly string Data;
        
        [MethodImpl(Inline)]
        public AsmOpCode(string src)
        {
            this.Data = src;
        }
        
        public ReadOnlySpan<char> Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }    

        public string Format()
            => Data;        

        public override string ToString()
            => Format();
    }
}