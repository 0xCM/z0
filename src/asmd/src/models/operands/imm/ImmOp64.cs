//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public partial class ImmOps
    {
        public readonly struct imm64 : IImmOp64<imm64>
        {
            public Fixed64 Value {get;}

            [MethodImpl(Inline)]
            public static implicit operator imm64(ulong src)
                => new imm64(src);

            [MethodImpl(Inline)]
            public imm64(Fixed64 value)
            {
                Value = value;
            }
            
            public DataWidth Width 
                => DataWidth.W64;

            public string Format()
                => Value.FormatHex();

            public override string ToString()
                => Format();
        }

    }
}