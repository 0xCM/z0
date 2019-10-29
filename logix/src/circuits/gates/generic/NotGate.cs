//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public readonly struct NotGate<T> : IUnaryGate<T>, IUnaryGate<Vector128<T>>, IUnaryGate<Vector256<T>>        
        where T : unmanaged
    {
        internal static readonly NotGate<T> Gate = default;
        
        [MethodImpl(Inline)]
        public bit Send(bit input)
            => !input;    

        [MethodImpl(Inline)]
        public T Send(T x)
            => gmath.not(x);

        [MethodImpl(Inline)]
        public Vector128<T> Send(Vector128<T> x)
            => ginx.vnot(x);

        [MethodImpl(Inline)]
        public Vector256<T> Send(Vector256<T> x)
            => ginx.vnot(x);
 

    }
}