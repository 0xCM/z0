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
        public readonly struct m64 : IMemOp64<m64>
        {
            public AsmAddress Address {get;}

            public NativeSize Size
            {
                [MethodImpl(Inline)]
                get => asm.asmsize(64);
            }

            [MethodImpl(Inline)]
            public m64(AsmAddress address)
            {
                Address = address;
            }

            [MethodImpl(Inline)]
            public static implicit operator m64(AsmAddress src)
                => new m64(src);
        }
    }
}