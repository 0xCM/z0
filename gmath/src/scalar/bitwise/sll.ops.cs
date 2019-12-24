//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    public readonly struct KsllOp<T> : IPShiftOp<T>
        where T : unmanaged        
    {
        public static KsllOp<T> Op => default;

        public string Moniker => moniker<T>("sll");

        [MethodImpl(Inline)]
        public readonly T Invoke(T x, byte offset)
            => gmath.sll(x,offset);
    }

    partial class KOps
    {
        [MethodImpl(Inline)]
        public static KsllOp<T> sll<T>()
            where T : unmanaged        
                => KsllOp<T>.Op;
    }
}