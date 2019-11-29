//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class GridDim
    {
        public static GridDim<M,N,T> define<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => default;
    }

    public interface IGridDim
    {
        int RowCount {get;}
        
        int ColCount {get;}
        
        int CellWidth {get;}
    }

    public interface IGridDim<T> : IGridDim
        where T : unmanaged
    {

    }

    public interface IGridDim<M,N,T> : IGridDim<T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {

    }

    public readonly struct GridDim<T> : IGridDim<T>
        where T : unmanaged
    {
        public GridDim(int rows, int cols)
        {
            this.RowCount = rows;
            this.ColCount = cols;
        }

        public int RowCount {get;}

        public int ColCount {get;}

        public int CellWidth
        {
            [MethodImpl(Inline)]
            get => bitsize<T>();
        }

    }

    public readonly struct GridDim<M,N,T> : IGridDim<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator GridDim<T>(GridDim<M,N,T> src)
            => new GridDim<T>(src.RowCount, src.ColCount);

        public int RowCount
        {
            [MethodImpl(Inline)]
            get => natval<M>();
        }

        public int ColCount
        {
            [MethodImpl(Inline)]
            get => natval<N>();
        }

        /// <summary>
        /// The bit width of a storage cell
        /// </summary>
        public int CellWidth
        {
            [MethodImpl(Inline)]
            get => bitsize<T>();
        }

        /// <summary>
        /// The number of cells required cover a grid
        /// </summary>
        public int CellCount
        {
            [MethodImpl(Inline)]
            get => BitCalcs.cellcount<M,N,T>();
        }

        /// <summary>
        /// The number of bytes required to cover a grid
        /// </summary>
        public int ByteCount
        {
            [MethodImpl(Inline)]
            get => BitCalcs.bytecount<M,N>();
        }

    }

    public enum GridDim32 : uint
    {
        Dim1x32 = 1 << 16 | 32,

        Dim32x1 = 32 << 16 | 1,

        Dim2x16 = 2 << 16 | 16,

        Dim16x2 = 16 << 16 | 2,

        Dim4x8 = 4 << 16 | 8,

        Dim8x4 = 8 << 16 | 4,

    }

    public enum GridDim64 : uint
    {
        Dim1x64 = 1 << 16 | 64,

        Dim64x1 = 64 << 16 | 1,

        Dim2x32 = 2 << 16 | 32,

        Dim32x2 = 32 << 16 | 2,

        Dim4x16 = 4 << 16 | 16,

        Dim16x4 = 16 << 16 | 4,

        Dim8x8 = 8 << 16 | 8,
    }
 
    public enum GridDim128 : uint
    {
        Dim1x128 = 1 << 16 | 128,

        Dim128x1 = 128 << 16 | 1,

        Dim2x64 =  2 << 16 | 64,

        Dim64x2 = 64 << 16 | 2,

        Dim4x32 =  4 << 16 | 32,

        Dim32x4 = 32 << 16 | 4,

        Dim8x16 =  8 << 16 | 16,

        Dim16x8 = 16 << 16 | 8,
    }

    public enum GridDim256 : uint
    {
        Dim1x256 = 1 << 16 | 256,

        Dim256x1 = 256 << 16 | 1,

        Dim2x128 = 2 << 16 | 128,

        Dim128x2 = 128 << 16 | 2,

        Dim4x64 = 4 << 16 | 64,

        Dim64x4 = 64 << 16 | 4,

        Dim8x32 = 8 << 16 | 32,

        Dim32x8 = 32 << 16 | 8,

        Dim16x16 = 16 << 16 | 16,
 
    }


}