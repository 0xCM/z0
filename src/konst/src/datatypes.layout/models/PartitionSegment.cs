//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;
    using static NumericCast;

    /// <summary>
    /// Defines a <see cref='Partition{T}'/> segment
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PartitionSegment<T>
        where T : unmanaged
    {
        public T Min {get;}

        public T Max {get;}

        [MethodImpl(Inline)]
        public PartitionSegment(T min, T max)
        {
            Min = min;
            Max = max;
        }

        public ulong Width
        {
            [MethodImpl(Inline)]
            get => force<ulong>(Max) - force<ulong>(Min);
        }

        [MethodImpl(Inline)]
        public static implicit operator PartitionSegment<T>((T min, T max) src)
            => new PartitionSegment<T>(src.min, src.max);
    }
}