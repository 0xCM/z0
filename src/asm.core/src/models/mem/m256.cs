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
        public readonly struct m256 : IMemOp256<m256>
        {
            public AsmAddress Address {get;}

            public NativeSize Size
            {
                [MethodImpl(Inline)]
                get => asm.asmsize(256);
            }

            [MethodImpl(Inline)]
            public m256(AsmAddress address)
            {
                Address = address;
            }

            [MethodImpl(Inline)]
            public static implicit operator m256(AsmAddress src)
                => new m256(src);
        }
    }
}