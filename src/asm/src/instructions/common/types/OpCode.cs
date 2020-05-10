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

    partial class InstructionModels
    {
        public readonly struct OpCode
        {
            [MethodImpl(Inline)]
            public static OpCode Define(string src)
                => new OpCode(src);

            public string Text {get;}

            [MethodImpl(Inline)]
            public OpCode(string src)
            {
                Text = src;
            }

            public string Format()
                => Text;

            public override string ToString()
                => Format();        
        }
    }
}