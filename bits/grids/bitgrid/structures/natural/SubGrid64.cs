//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static root;
    using static Nats;

    /// <summary>
    /// A grid of natural dimensions M and N such that M*N <= W := 64
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=ByteCount)]
    [IdentityProvider(typeof(BitGridIdentity))]    
    public readonly ref struct SubGrid64<M,N,T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
        where M : unmanaged, ITypeNat
    {                
        readonly ulong data;

        /// <summary>
        /// The number of bytes covered by the grid
        /// </summary>
        public const int ByteCount = 8;

        /// <summary>
        /// The maximum grid width
        /// </summary>
        public static N64 W => default;

        /// <summary>
        /// The grid dimension
        /// </summary>
        public static GridDim<M,N,T> Dim => default;        

        [MethodImpl(Inline)]
        public static implicit operator SubGrid64<M,N,T>(in Block64<T> src)
            => new SubGrid64<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator SubGrid64<M,N,T>(ulong src)
            => new SubGrid64<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ulong(SubGrid64<M,N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitGrid64<T>(SubGrid64<M,N,T> src)
            => new BitGrid64<T>(src.data, natval<M>(), natval<N>());

        [MethodImpl(Inline)]
        public static implicit operator SubGrid64<M,N,T>(BitGrid64<T> src)
            => new SubGrid64<M,N,T>(src);

        [MethodImpl(Inline)]
        public static bool operator ==(SubGrid64<M,N,T> g1, SubGrid64<M,N,T> g2)
            => g1.Equals(g2);

        [MethodImpl(Inline)]
        public static bool operator !=(SubGrid64<M,N,T> g1, SubGrid64<M,N,T> g2)
            => !g1.Equals(g2);

        [MethodImpl(Inline)]
        internal SubGrid64(ulong src)
            => this.data = src;
        
        [MethodImpl(Inline)]
        internal SubGrid64(Block64<T> src)
            => this.data = src.As<ulong>().Head;

        public ulong Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public Span<T> Cells
        {
            [MethodImpl(Inline)]
            get => Data.AsBytes().As<T>();
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref head(Cells);
        }


        /// <summary>
        /// The number of grid rows
        /// </summary>
        public int RowCount => natval<M>();         

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public int ColCount => natval<N>();  


        /// <summary>
        /// The number of covered bits
        /// </summary>
        public int BitCount
        {
            [MethodImpl(Inline)]
            get => NatMath.mul<M,N>();
        }

        /// <summary>
        /// Reads/writes an index-identified cell
        /// </summary>
        [MethodImpl(Inline)]
        public ref T Cell(int index)
            => ref Unsafe.Add(ref Head, index);

        /// <summary>
        /// Extracts row content as a bitvector
        /// </summary>
        public BitVector<N,T> this[int index]
        {
            [MethodImpl(Inline)]
            get => BitGrid.row(this,index);
        }

        [MethodImpl(Inline)]
        public SubGrid64<M,N,U> As<U>()
            where U : unmanaged
                => new SubGrid64<M, N, U>(data);
        
        [MethodImpl(Inline)]
        public bool Equals(SubGrid64<M,N,T> rhs)
            => data.Equals(rhs.data);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}