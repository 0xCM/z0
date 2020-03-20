//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Root;

    public readonly struct HalfAdder
    {
        static readonly AndGate andg = Gates.and();
        
        static readonly XOrGate xorg = Gates.xor();

        [MethodImpl(Inline)]
        public (bit s, bit c) Send(bit a, bit b)        
            => (xorg.Send(a, b), andg.Send(a, b));
    }

    public readonly struct HalfAdder<T> 
        where T : unmanaged
    {
        public static readonly HalfAdder<T> Circuit = default;
        
        static readonly XOrGate<T> xorg = Gates.xor<T>();

        static readonly AndGate<T> andg = Gates.and<T>();

        [MethodImpl(Inline)]
        public (T s, T c) Send(T a, T b)
            => (xorg.Send(a,b), andg.Send(a,b));

        [MethodImpl(Inline)]
        public (Vector128<T> s, Vector128<T> c) Send(Vector128<T> a, Vector128<T> b)
            => (xorg.Send(a,b), andg.Send(a,b));

        [MethodImpl(Inline)]
        public (Vector256<T> s, Vector256<T> c) Send(Vector256<T> a, Vector256<T> b)
            => (xorg.Send(a,b), andg.Send(a,b));        
    }
}