//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Memories;

    public readonly struct InstructionCodeData
    {
        readonly string Data;
        
        [MethodImpl(Inline)]
        public InstructionCodeData(string src)
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