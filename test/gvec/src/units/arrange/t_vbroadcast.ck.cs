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

    static class VChecks
    {


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

    public readonly struct VBroadcastCheck128<S, T> : ISFChecker128Api<S, T>
        where S : unmanaged
        where T : unmanaged
    {
        public static VBroadcastCheck128<S, T> Op => default;
        
        public const string Name = "vbroadcast_check";

        public Vec128Kind<T> VKind => default;
        
        public OpIdentity Id => Identities.sfunc(Name,VKind);

        public bit Invoke(S a, Vector128<T> x)
        {
            var count = vcount<T>(Widths.w128);
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

        public OpIdentity Id => Identities.sfunc(Name,VKind);

        public bit Invoke(S a, Vector256<T> x)
        {
            var count = vcount<T>(Widths.w256);
            var result = bit.On;
            var y = x.As<T,S>();
            for(var i=0; i< count; i++)
                result &= gmath.eq(a, y.Cell(i));
            return result;
        }
    } 
}