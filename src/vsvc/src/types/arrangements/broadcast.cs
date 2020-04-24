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
    using static Memories;
    
    partial class VSvcHosts
    {
        [Closures(AllNumeric)]
        public readonly struct Broadcast128<T> : ISVFactory128<T,T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(T a) => Vectors.vbroadcast(n128, a);            
        }

        [Closures(AllNumeric)]
        public readonly struct Broadcast128<S,T> : ISVFactory128<S,T>
            where T : unmanaged
            where S : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(S a) => Vectors.vbroadcast(n128, convert<S,T>(a));            
        }

        [Closures(AllNumeric)]
        public readonly struct Broadcast256<T> : ISVFactory256<T,T>
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(T a) => Vectors.vbroadcast(n256, a);            
        }

        public readonly struct Broadcast256<S,T> : ISVFactory256<S,T>
            where T : unmanaged
            where S : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(S a) => Vectors.vbroadcast(n256, convert<S,T>(a));            
        }
    }
}