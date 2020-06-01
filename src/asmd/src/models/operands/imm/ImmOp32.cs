//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct ImmOp32 : IImmOp32<ImmOp32>
    {
        public uint Data {get;}

        [MethodImpl(Inline)]
        public static implicit operator ImmOp32(uint src)
            => new ImmOp32(src);

        [MethodImpl(Inline)]
        public ImmOp32(uint value)
        {
            Data = value;
        }

        public DataWidth Width 
            => DataWidth.W32;
    }
}