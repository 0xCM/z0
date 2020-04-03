//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    public static class Seed
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const string Kernel32 = "kernel32.dll";

        public const NumericKind UnsignedInts = NumericKind.UnsignedInts;

        public const NumericKind SignedInts = NumericKind.SignedInts;

        public const NumericKind Integers = NumericKind.Integers;

        public const NumericKind Floats = NumericKind.Floats;

        public const NumericKind AllNumeric = NumericKind.All;

        [MethodImpl(Inline)]
        internal static IEnumerable<T> seq<T>(params T[] src)
            => src;

        [MethodImpl(Inline)]
        internal static int bitsize<T>()            
            => Unsafe.SizeOf<T>()*8;

        [MethodImpl(Inline)]
        internal static int size<T>()
            => Unsafe.SizeOf<T>();

        [MethodImpl(Inline)]
        internal static Type type<T>()
            => typeof(T);    
    }

    public static partial class XTend
    {

    }
}