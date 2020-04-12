//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
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
}