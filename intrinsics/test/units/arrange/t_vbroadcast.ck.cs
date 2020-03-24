//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Nats;
    using static vgeneric;
    using static CheckSpecs;

    static class VChecks
    {
        public static bit vand<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            var svc = MathSvcFactory.bitlogic<T>();
            var v1 = VSvc.vbitlogic<T>(n128).and(x,y);
            var buffer = Fixed.alloc<Fixed128>();
            ref var dst = ref Fixed.head<Fixed128,T>(ref buffer);
            var count = vgeneric.vcount<T>(n128);            
            for(var i=0; i< count; i++)
                seek(ref dst, i) = svc.and(vcell(x,i), vcell(y,i));
            var v2 = vgeneric.vload(n128, in dst);
            return gvec.vsame(v1,v2);
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
        public readonly struct VBroadcastCheck128<S, T> : ISFChecker128Api<S, T>
            where S : unmanaged
            where T : unmanaged
        {
            public static VBroadcastCheck128<S, T> Op => default;
            
            public const string Name = "vbroadcast_check";

            public Vec128Kind<T> VKind => default;
            
            public OpIdentity Id => OpIdentity.sfunc(Name,VKind);

            public bit Invoke(S a, Vector128<T> x)
            {
                var count = vcount<T>(w128);
                var result = bit.On;
                var y = x.As<T,S>();
                for(var i=0; i< count; i++)
                    result &= gmath.eq(a, y.Cell(i));
                return result;
            }
        }

        public readonly struct VBroadcastCheck256<S, T> : ISFChecker256Api<S, T>
            where S : unmanaged
            where T : unmanaged
        {
            public static VBroadcastCheck256<S, T> Op => default;

            public Vec256Kind<T> VKind => default;
            
            public const string Name = "vbroadcast_check";

            public OpIdentity Id => OpIdentity.sfunc(Name,VKind);

            public bit Invoke(S a, Vector256<T> x)
            {
                var count = vcount<T>(w256);
                var result = bit.On;
                var y = x.As<T,S>();
                for(var i=0; i< count; i++)
                    result &= gmath.eq(a, y.Cell(i));
                return result;
            }
        }
    }
}