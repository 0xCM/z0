//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using llvm;

    using static Root;
    using static AsmOperands;

    public interface IAsmSpec
    {
        AsmId Id {get;}
    }

    public interface IAsmSpec<T> : IAsmSpec
        where T: unmanaged
    {

    }

    public interface IAsmSpec<T,A> : IAsmSpec<T>
        where T : unmanaged, IAsmOperand<T>
    {

    }


    [ApiHost]
    public readonly partial struct AsmOps
    {
        [MethodImpl(Inline), Op]
        public static Xor32RR xor(r32 op0, r32 op1)
            => new Xor32RR(op0,op1);

        public struct Xor32RR : IAsmSpec<Xor32RR>
        {
            public r32 Op0;

            public r32 Op1;

            [MethodImpl(Inline)]
            public Xor32RR(r32 a0, r32 a1)
            {
                Op0 = a0;
                Op1 = a1;
            }

            public AsmId Id => AsmId.XOR32rr;
        }
    }
}