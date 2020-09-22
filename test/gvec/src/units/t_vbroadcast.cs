//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;


    static class VChecks
    {
       [MethodImpl(Inline)]
       public static VBroadcastCheck128<S,T> vbroadcast<S,T>(N128 w, S s = default, T t = default)
            where S : unmanaged
            where T : unmanaged
                => VBroadcastCheck128<S,T>.Op;

       [MethodImpl(Inline)]
       public static VBroadcastCheck256<S,T> vbroadcast<S,T>(N256 w, S s = default, T t = default)
            where S : unmanaged
            where T : unmanaged
                => VBroadcastCheck256<S,T>.Op;
    }

    public readonly struct VBroadcastCheck128<S,T> : ICheckSF128<S,T>
        where S : unmanaged
        where T : unmanaged
    {
        public static VBroadcastCheck128<S,T> Op => default;

        public const string Name = "vbroadcast_check";

        public Vec128Kind<T> VKind => default;

        public OpIdentity Id => ApiIdentity.sfunc(Name,VKind);

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

    public readonly struct VBroadcastCheck256<S,T> : ICheckSF256<S,T>
        where S : unmanaged
        where T : unmanaged
    {
        public static VBroadcastCheck256<S,T> Op => default;

        public Vec256Kind<T> VKind => default;

        public const string Name = "vbroadcast_check";

        public OpIdentity Id => ApiIdentity.sfunc(Name,VKind);

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

    public class t_vbroadcast : t_inx<t_vbroadcast>
    {
        public void vbroadcast_check()
        {
            vbroadcast_check(n128);
            vbroadcast_check(n256);
        }

        void vbroadcast_check(N128 w)
        {
            vbroadcast_check(w,z8);
            vbroadcast_check(w,z8i);
            vbroadcast_check(w,z16);
            vbroadcast_check(w,z16i);
            vbroadcast_check(w,z32);
            vbroadcast_check(w,z32i);
            vbroadcast_check(w,z64i);
            vbroadcast_check(w,z64);
            vbroadcast_check(w,z32f);
            vbroadcast_check(w,z64f);
        }

        void vbroadcast_check(N256 w)
        {
            vbroadcast_check(w,z8);
            vbroadcast_check(w,z8i);
            vbroadcast_check(w,z16);
            vbroadcast_check(w,z16i);
            vbroadcast_check(w,z32);
            vbroadcast_check(w,z32i);
            vbroadcast_check(w,z64i);
            vbroadcast_check(w,z64);
            vbroadcast_check(w,z32f);
            vbroadcast_check(w,z64f);
        }

        protected void vbroadcast_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckSVF.CheckFactory(w, VSvc.vbroadcast(w,t,t), VChecks.vbroadcast(w,t,t),t,t);

        protected void vbroadcast_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckSVF.CheckFactory(w, VSvc.vbroadcast(w,t,t), VChecks.vbroadcast(w,t,t),t,t);
    }
}