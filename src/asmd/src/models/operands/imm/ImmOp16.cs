//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct ImmOp16 : IImmOp16<ImmOp16>
    {
        public ushort Data {get;}

        [MethodImpl(Inline)]
        public static implicit operator ImmOp16(ushort src)
            => new ImmOp16(src);

        [MethodImpl(Inline)]
        public ImmOp16(ushort value)
        {
            Data = value;
        }

        public DataWidth Width 
            => DataWidth.W16;
    }
}