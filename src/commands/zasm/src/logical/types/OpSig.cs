//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Logical
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    public readonly struct OpSig
    {
        public string Text {get;}

        [MethodImpl(Inline)]
        public static OpSig Define(string src)
            => new OpSig(src);

        [MethodImpl(Inline)]
        public OpSig(string src)
        {
            Text = src;
        }

        public string Format()
            => Text;

        public override string ToString()
            => Format();        
    }

}