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

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static T @false<T>()
            where T:unmanaged
                => zero<T>();

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static T @false<T>(T a)
            where T:unmanaged
                => @false<T>();

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static T @false<T>(T a, T b, T c)
            where T:unmanaged
                => @false<T>();

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static T @true<T>()
            where T:unmanaged
                => ones<T>();

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static T @true<T>(T a)
            where T:unmanaged
                => @true<T>();

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static T @true<T>(T a, T b)
            where T:unmanaged
                => @true<T>();

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static T @false<T>(T a, T b)
            where T:unmanaged
                => @false<T>();

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static T @true<T>(T a, T b, T c)
            where T:unmanaged
                => @true<T>();


    }

}