//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmX;

    partial struct AsmOps
    {
        public readonly struct ptr<T> : IMemOp<T>
            where T : unmanaged
        {
            public T Target {get;}

            [MethodImpl(Inline)]
            public ptr(T dst)
            {
                Target = dst;
            }

            [MethodImpl(Inline)]
            public static implicit operator ptr<T>(T dst)
                => new ptr<T>(dst);
        }
    }
}