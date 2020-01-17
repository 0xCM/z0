//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using static AsIn;

    partial class gmath
    {

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static T left<T>(T a, T b)
            where T : unmanaged
                => a;

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static T right<T>(T a, T b)
            where T : unmanaged
                => b;

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static T lnot<T>(T a, T b)
            where T : unmanaged
                => not(a);

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static T rnot<T>(T a, T b)
            where T : unmanaged
                => not(b);


        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static T identity<T>(T a)
            where T : unmanaged
                => a;
    }

}