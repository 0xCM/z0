//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmLang
    {
        partial struct Operands
        {
            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ref byte edit<T>(in RegOp<T> src)
                where T : unmanaged
                    => ref bytes<RegOp<T>,T>(src);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ref byte edit<T>(in ImmOp<T> src)
                where T : unmanaged
                    => ref bytes<ImmOp<T>,T>(src);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ref byte edit<T>(in MemOp<T> src)
                where T : unmanaged
                    => ref bytes<MemOp<T>,T>(src);

            [MethodImpl(Inline)]
            static ref byte bytes<H,T>(in H src)
                where H : struct, IOperand<T>
                where T : unmanaged
                    => ref z.@as<H,byte>(src);
        }
    }
}