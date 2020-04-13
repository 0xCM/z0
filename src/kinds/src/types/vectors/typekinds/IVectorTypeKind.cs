//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;

    public interface IVectorTypeKind : ITypeKind, IVectorWidth
    {
        
    }    

    public interface IVectorTypeKind<W> : IVectorTypeKind, IVectorWidth<W>
        where W : struct, IVectorWidth<W>
    {
        
    }

    public interface IVectorTypeKind<F,W,T> : IVectorTypeKind<W>, ITypeKind<T>
        where F : struct, IVectorTypeKind<F,W,T>
        where W : struct, IVectorWidth<W>
        where T : unmanaged
    {
        NumericKind CellKind => NumericKinds.kind<T>();

        NumericWidth CellWidth => (NumericWidth)Widths.measure<T>();
    }
}