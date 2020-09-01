//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Immutable;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    internal static class MsDx
    {
        public static IntPtr AsIntPtr(this ulong address)
        {
            if (IntPtr.Size == 8)
                return new IntPtr((long)address);

            return new IntPtr((int)address);
        }


        internal static ImmutableArray<T> AsImmutableArray<T>(this T[] array)
        {
            Debug.Assert(Unsafe.SizeOf<T[]>() == Unsafe.SizeOf<ImmutableArray<T>>());
            return Unsafe.As<T[], ImmutableArray<T>>(ref array);
        }

        internal static ImmutableArray<T> MoveOrCopyToImmutable<T>(this ImmutableArray<T>.Builder builder)
        {
            return builder.Capacity == builder.Count ? builder.MoveToImmutable() : builder.ToImmutable();
        }
    }
}