//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static CheckSpecs;

    static class VChecks
    {
        public static bit vand<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            var svc = MathSvcFactory.bitlogic<T>();
            var v1 = VF.vbitlogic<T>(n128).and(x,y);
            var buffer = Fixed.alloc<Fixed128>();
            ref var dst = ref Fixed.head<Fixed128,T>(ref buffer);
            var count = gvec.vcount<T>(n128);            
            for(var i=0; i< count; i++)
                seek(ref dst, i) = svc.and(vcell(x,i), vcell(y,i));
            var v2 = gvec.vload(n128, in dst);
            return ginx.vsame(v1,v2);
        }


       [MethodImpl(Inline)]
       public static VBroadcastCheck128<S, T> vbroadcast<S,T>(N128 w, S s = default, T t = default)
            where S : unmanaged
            where T : unmanaged
                => VBroadcastCheck128<S, T>.Op;

       [MethodImpl(Inline)]
       public static VBroadcastCheck256<S, T> vbroadcast<S,T>(N256 w, S s = default, T t = default)
            where S : unmanaged
            where T : unmanaged
                => VBroadcastCheck256<S, T>.Op;
    }

    partial class CheckSpecs
    {
        public readonly struct VBroadcastCheck128<S, T> : IVChecker128<S, T>
            where S : unmanaged
            where T : unmanaged
        {
            public static VBroadcastCheck128<S, T> Op => default;
            
            public const string Name = "vbroadcast_check";

            static N128 w => default;

            static S s => default;
            
            static T t => default;

            public OpIdentity Id => NaturalIdentity.contracted(Name,w,t);

            public bit Invoke(S a, Vector128<T> x)
            {
                var count = vcount(w,t);
                var result = bit.On;
                var y = x.As<T,S>();
                for(var i=0; i< count; i++)
                    result &= gmath.eq(a, y.Cell(i));
                return result;
            }
        }

        public readonly struct VBroadcastCheck256<S, T> : IVChecker256<S, T>
            where S : unmanaged
            where T : unmanaged
        {
            public static VBroadcastCheck256<S, T> Op => default;

            static N256 w => default;

            static S s => default;
            
            static T t => default;

            public const string Name = "vbroadcast_check";

            public OpIdentity Id => NaturalIdentity.contracted<N256,T>(Name);

            public bit Invoke(S a, Vector256<T> x)
            {
                var count = vcount(w,t);
                var result = bit.On;
                var y = x.As<T,S>();
                for(var i=0; i< count; i++)
                    result &= gmath.eq(a, y.Cell(i));
                return result;
            }
        }
    }
}