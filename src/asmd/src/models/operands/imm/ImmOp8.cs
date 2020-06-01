//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct ImmOp8 : IImmOp8<ImmOp8>
    {
        public byte Data {get;}

        [MethodImpl(Inline)]
        public static implicit operator ImmOp8(byte src)
            => new ImmOp8(src);

        [MethodImpl(Inline)]
        public ImmOp8(byte value)
        {
            Data = value;
        }

        public DataWidth Width 
            => DataWidth.W8;
    }
}