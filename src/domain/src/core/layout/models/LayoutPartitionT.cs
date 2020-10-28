//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    using api = DataLayouts;

    /// <summary>
    /// Defines a <typeparamref name='T'/> kinded segment partition
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct LayoutPartition<T>
        where T : unmanaged
    {
        public LayoutIdentity<T> Id {get;}

        readonly ClosedInterval<ulong> Range;

        /// <summary>
        /// The enclosure-relative partition index
        /// </summary>
        public uint Index => Id.Index;

        [MethodImpl(Inline)]
        public LayoutPartition(LayoutIdentity<T> id, ulong start, ulong end)
        {
            Id = id;
            Range = new ClosedInterval<ulong>(start,end);
        }

        /// <summary>
        /// The inclusive lower index
        /// </summary>
        public ulong Left
        {
            [MethodImpl(Inline)]
            get => Range.Min;
        }

        /// <summary>
        /// The inclusive upper index
        /// </summary>
        public ulong Right
        {
            [MethodImpl(Inline)]
            get => Range.Max;
        }

        /// <summary>
        /// The partition width determined by <see cref='Right'/> - <see cref='Left'/>
        /// </summary>
        public ulong Width
        {
            [MethodImpl(Inline)]
            get => Range.Width;
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator LayoutPartition(LayoutPartition<T> src)
            => api.untyped(src);
    }
}