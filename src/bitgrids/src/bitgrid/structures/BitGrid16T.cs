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
    /// Defines a 16-bit grid of fixed order 4
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=2)]
    [IdentityProvider(typeof(BitGridIdentityProvider))]
    public readonly ref struct BitGrid16<T>
        where T : unmanaged
    {                
        /// <summary>
        /// Grid storage
        /// </summary>
        internal readonly ushort Data;

        /// <summary>
        /// The grid row count := 4
        /// </summary>
        public int RowCount => 4;

        /// <summary>
        /// The grid col count := 4
        /// </summary>
        public int ColCount => 4;

        /// <summary>
        /// The number of covered bits := 16
        /// </summary>
        public int BitCount => 16; 

        /// <summary>
        /// Returns a copy of the grid's backing storage
        /// </summary>
        public ushort Content { [MethodImpl(Inline)] get => Data; }

        /// <summary>
        /// The number of grid cells := {1 | 2}
        /// </summary>
        public int CellCount { [MethodImpl(Inline)] get => 2/size<T>(); }
        
        /// <summary>
        /// Covers grid content with a span that defines cells of width := {1 | 2}
        /// </summary>
        public Span<T> Cells { [MethodImpl(Inline)] get => Data.AsBytes().As<T>();}

        /// <summary>
        /// Yields a mutable reference to the grid's leading storage cell
        /// </summary>
        public ref T Head { [MethodImpl(Inline)] get => ref head(Cells); }

        /// <summary>
        /// Maninulates an index-identified cell, where index := {0 | 1}
        /// </summary>
        public ref T this[int index] { [MethodImpl(Inline)] get => ref Cell(index);}

        [MethodImpl(Inline)]
        public static implicit operator ushort(BitGrid16<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator BitGrid16<T>(ushort src)
            => new BitGrid16<T>(src);

        [MethodImpl(Inline)]
        public static bit operator ==(BitGrid16<T> gx, BitGrid16<T> gy)
            => gx.Data == gy.Data;

        [MethodImpl(Inline)]
        public static bit operator !=(BitGrid16<T> gx, BitGrid16<T> gy)
            => gx.Data != gy.Data;

        [MethodImpl(Inline)]
        internal BitGrid16(ushort data)
            => Data = data; 

        /// <summary>
        /// Reads/writes an index-identified cell
        /// </summary>
        [MethodImpl(Inline)]
        public ref T Cell(int index)
            => ref Unsafe.Add(ref Head, index);

        [MethodImpl(Inline)]
        public BitGrid16<U> As<U>()
            where U : unmanaged
                => new BitGrid16<U>(Data);

        [MethodImpl(Inline)]
        public bool Equals(BitGrid16<T> rhs)
            => Data.Equals(rhs.Data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException(); 
    }
}