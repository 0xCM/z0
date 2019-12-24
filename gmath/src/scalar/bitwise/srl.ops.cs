//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    public readonly struct KsrlOp<T> : IPShiftOp<T>
        where T : unmanaged        
    {
        public static KsrlOp<T> Op => default;

        public string Moniker => moniker<T>("srl");

        [MethodImpl(Inline)]
        public readonly T Invoke(T x, byte offset)
            => gmath.srl(x,offset);
    }

    partial class KOps
    {
        [MethodImpl(Inline)]
        public static KsrlOp<T> srl<T>()
            where T : unmanaged        
                => KsrlOp<T>.Op;
    }
}