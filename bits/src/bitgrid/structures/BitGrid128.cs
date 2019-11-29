//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    /// <summary>
    /// Defines a 128-bit grid sans dimensional content
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    public readonly ref struct BitGrid128<T>
        where T : unmanaged
    {                
        internal readonly Vector128<T> data;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 16;

        /// <summary>
        /// The number of bits covered by the grid
        /// </summary>
        public const int BitCount = ByteCount * 8;
        
        /// <summary>
        /// The number of cells covered by the grid
        /// </summary>
        public static int GridCells => ByteCount/size<T>();

        /// <summary>
        /// The number of bits covered by a grid cell
        /// </summary>
        public static int CellSize => bitsize<T>();
        
        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(in BitGrid128<T> g)
            => g.data;

        [MethodImpl(Inline)]
        public static implicit operator BitGrid128<T>(Vector128<T> data)
            => new BitGrid128<T>(data);

        [MethodImpl(Inline)]
        public static implicit operator BitGrid128<T>(Vector128<byte> src)
            => new BitGrid128<T>(src.As<byte,T>());

        [MethodImpl(Inline)]
        public static bit operator ==(in BitGrid128<T> gx, in BitGrid128<T> gy)
            => BitGrid.same(gx,gy);

        [MethodImpl(Inline)]
        public static bit operator !=(in BitGrid128<T> gx, in BitGrid128<T> gy)
            => !BitGrid.same(gx,gy);

        [MethodImpl(Inline)]
        internal BitGrid128(Vector128<T> data)
            => this.data = data;
        
        [MethodImpl(Inline)]
        internal BitGrid128(in Block128<T> src)
            => this.data = src.TakeVector();

        public Vector128<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public int CellCount
        {
            [MethodImpl(Inline)]
            get => GridCells;
        }

        /// <summary>
        /// The number of covered bits
        /// </summary>
        public int PointCount
        {
            [MethodImpl(Inline)]
            get => BitCount;
        }

        public Span<T> Cells
        {
            [MethodImpl(Inline)]
            get => data.ToSpan<T>();
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref head(Cells);
        }

        /// <summary>
        /// Reads an index-identified cell
        /// </summary>
        public T this[int cell]
        {
            [MethodImpl(Inline)]
            get => data.GetElement(cell);
        }

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();

    }
}