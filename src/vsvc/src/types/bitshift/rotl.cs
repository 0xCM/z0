//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class VSvcHosts
    {
        [Closures(Integers), Rotl]
        public readonly struct Rotl128<T> : IShiftOp128D<T>, IShiftOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count) 
                => gvec.vrotl(x,count);
            
            [MethodImpl(Inline)]
            public T Invoke(T a, byte count) 
                => gbits.rotl(a,count);
        }

        [Closures(Integers), Rotl]
        public readonly struct Rotl256<T> : IShiftOp256D<T>, IShiftOp256<T>
            where T : unmanaged
        {           
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count) 
                => gvec.vrotl(x,count);

            [MethodImpl(Inline)]
            public T Invoke(T a, byte count) 
                => gbits.rotl(a,count);
        }               
    }
}