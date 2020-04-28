//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed; 
    using static Memories;

    /// <summary>
    /// Defines a 64-bit grid
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=8)]
    [IdentityProvider(typeof(BitGridIdentityProvider))]
    public readonly ref struct BitGrid64<T>
        where T : unmanaged
    {                
        internal readonly ulong Data;

        /// <summary>
        /// The number of covered bits
        /// </summary>
        public int BitCount => 64;        

        public ulong Content { [MethodImpl(Inline)] get => Data; }

        public int CellCount { [MethodImpl(Inline)] get => 8/size<T>(); }

        public Span<T> Cells { [MethodImpl(Inline)] get => Data.AsBytes().As<T>(); }

        public ref T Head { [MethodImpl(Inline)] get => ref head(Cells); }

        [MethodImpl(Inline)]
        public static implicit operator ulong(BitGrid64<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static bit operator ==(BitGrid64<T> gx, BitGrid64<T> gy)
            => gx.Data == gy.Data;

        [MethodImpl(Inline)]
        public static bit operator !=(BitGrid64<T> gx, BitGrid64<T> gy)
            => gx.Data != gy.Data;

        [MethodImpl(Inline)]
        public BitGrid64(ulong data)
            => this.Data = data;

        /// <summary>
        /// Reads/writes an index-identified cell
        /// </summary>
        [MethodImpl(Inline)]
        public ref T Cell(int index)
            => ref Unsafe.Add(ref Head, index);

        /// <summary>
        /// Slices a sequence of bits
        /// </summary>
        public BitVector<T> this[byte start, byte count]
        {
            [MethodImpl(Inline)]
            get => BitGrid.slice(this,start,count);
        }

        [MethodImpl(Inline)]
        public bool Equals(BitGrid64<T> rhs)
            => Data.Equals(rhs.Data);

        [MethodImpl(Inline)]
        public BitGrid64<U> As<U>()
            where U : unmanaged
                => new BitGrid64<U>(Data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}