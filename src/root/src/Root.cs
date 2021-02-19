//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    [ApiHost]
    public readonly partial struct Root
    {
        [MethodImpl(Inline)]
        public static ref T @as<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref Unsafe.AsRef(src));

        /// <summary>
        /// The number of bits to shift a field specifier left/right to reveal/specify the width of an identified field
        /// </summary>
        public const int WidthOffset = 16;

        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline), Op]
        public static uint hash(PartId src)
            => (uint)src;

        public static T[] array<T>(params T[] src)
            => src;

        /// <summary>
        /// Applies a function to a value
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="f">The function to apply</param>
        /// <typeparam name="X">The source value type</typeparam>
        /// <typeparam name="Y">The output value type</typeparam>
         [MethodImpl(Inline)]
         public static Y apply<X,Y>(X x, Func<X,Y> f)
            => f(x);



        [MethodImpl(Inline), Op]
        public static string format(ExternId id)
            => id.ToString().ToLower();

        const string TestSuffix = ".test";

        const string SvcSuffix = ".svc";

        const string BaseSuffix = "";

        public const string EmptyString = "";
    }

    [ApiHost]
    public static partial class XTend
    {
        const NumericKind Closure = Root.UnsignedInts;

    }

    [ApiHost]
    public static partial class XText
    {
        const NumericKind Closure = Root.UnsignedInts;

    }

    [ApiHost]
    public static partial class ClrQuery
    {
        const NumericKind Closure = Root.UnsignedInts;

    }
}