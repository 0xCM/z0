//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    partial class Seed
    {
        public static Zed Zed => default(Zed);

        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;

        public const MethodImplOptions Suboptimal = MethodImplOptions.NoOptimization;

        public const string Kernel32 = "kernel32.dll";

        public const NumericKind UnsignedInts = NumericKind.UnsignedInts;

        public const NumericKind SignedInts = NumericKind.SignedInts;

        public const NumericKind Integers = NumericKind.Integers;

        public const NumericKind Floats = NumericKind.Floats;

        public const NumericKind AllNumeric = NumericKind.All;

        public const NumericKind Numeric8 = NumericKind.Width8;

        public const NumericKind Numeric16 = NumericKind.Width16;

        public const NumericKind Numeric32 = NumericKind.Width32;

        public const NumericKind Numeric64 = NumericKind.Width64;

        public const NumericKind Numeric8u = NumericKind.U8;

        public const NumericKind Numeric8i = NumericKind.I8;

        public const NumericKind Numeric16u = NumericKind.U16;

        public const NumericKind Numeric16i = NumericKind.I16;

        public const NumericKind Numeric32u = NumericKind.U32;

        public const NumericKind Numeric32i = NumericKind.I32;

        public const NumericKind Numeric64u = NumericKind.U64;

        public const NumericKind Numeric64i = NumericKind.I64;

        public const NumericKind Numeric32f = NumericKind.F32;

        public const NumericKind Numeric64f = NumericKind.F64;

        public const NumericKind Numeric8x16 = NumericKind.Width8 | NumericKind.Width16;

        public const NumericKind Numeric8x16x32 = NumericKind.Width8 | NumericKind.Width16 | NumericKind.Width32;

        public const NumericKind Numeric16x32 = NumericKind.Width16 | NumericKind.Width32;

        public const NumericKind Numeric16x32x64 = NumericKind.Width16 | NumericKind.Width32 | NumericKind.Width64;

        public const NumericKind Numeric16x32x64u = NumericKind.U16 | NumericKind.U32 | NumericKind.U64;

        public const NumericKind Numeric16x32x64i = NumericKind.I16 | NumericKind.I32 | NumericKind.I64;

        public const NumericKind Numeric32x64 = NumericKind.Width32 | NumericKind.Width64;

        public const NumericKind Numeric8x16u = NumericKind.U8 | NumericKind.U16;

        public const NumericKind Numeric8x16x32u = NumericKind.U8 | NumericKind.U16 | NumericKind.U32;

        public const NumericKind Numeric16x32u = NumericKind.U16 | NumericKind.U32;
        
        public const NumericKind Numeric32x64u = NumericKind.U32 | NumericKind.U64;

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
}