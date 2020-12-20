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

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct PartitionRange<T>
        where T : unmanaged
    {
        public T Min {get;}

        public T Max {get;}

        [MethodImpl(Inline)]
        public PartitionRange(T min, T max)
        {
            Min = min;
            Max = max;
        }

        [MethodImpl(Inline)]
        public static implicit operator PartitionRange<T>((T min, T max) src)
            => new PartitionRange<T>(src.min, src.max);

        public ulong Width
        {
            [MethodImpl(Inline)]
            get => force<ulong>(Max) - force<ulong>(Min);
        }
    }
}