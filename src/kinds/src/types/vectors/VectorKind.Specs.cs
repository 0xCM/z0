//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static Z0.Seed;

    public interface IVectorKind : ITypeKind, IVectorWidth
    {
        
    }    

    public interface IVectorKind<W> : IVectorKind, IVectorWidth<W>
        where W : struct, IVectorWidth<W>
    {
        
    }

    public interface IVectorKind<F,W,T> : IVectorKind<W>, ITypeKind<T>
        where F : struct, IVectorKind<F,W,T>
        where W : struct, IVectorWidth<W>
        where T : unmanaged
    {
        NumericKind CellKind => NumericKinds.kind<T>();

        NumericWidth CellWidth => (NumericWidth)Widths.measure<T>();
    }

    public readonly struct VectorTypeKind : IVectorKind
    {
        public VectorWidth VectorWidth {get;}

        public TypeWidth TypeWidth => (TypeWidth)VectorWidth;

        public DataWidth DataWidth => (DataWidth)VectorWidth;

        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(VectorWidth width)
            => new VectorTypeKind(width);

        [MethodImpl(Inline)]
        public VectorTypeKind(VectorWidth width)
        {
            this.VectorWidth = width;
        }
    }        
}