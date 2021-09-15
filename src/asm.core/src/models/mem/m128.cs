//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmOperands
    {
        public readonly struct m128 : IMemOp128<m128>
        {
            public AsmAddress Address {get;}

            public NativeSize Size
            {
                [MethodImpl(Inline)]
                get => asm.asmsize(128);
            }

            [MethodImpl(Inline)]
            public m128(AsmAddress address)
            {
                Address = address;
            }

            [MethodImpl(Inline)]
            public m128(RegOp @base, RegOp index, MemoryScale scale, Disp disp)
            {
                Address = new AsmAddress(@base, index, scale, disp);
            }

            [MethodImpl(Inline)]
            public static implicit operator m128(AsmAddress src)
                => new m128(src);
        }
    }
}