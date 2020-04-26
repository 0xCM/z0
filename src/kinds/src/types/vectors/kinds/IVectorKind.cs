//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
 
    public interface IVectorKind : IVectorType, IVectorWidth
    {
        /// <summary>
        /// The vector numeric cell kind
        /// </summary>
        NumericKind CellKind {get;}

        /// <summary>
        /// The vector numeric cell width
        /// </summary>
        NumericWidth CellWidth {get;}        

        /// <summary>
        /// The reified vector type as determined by kind facets
        /// </summary>
        Type Reified => TypeDefinition.MakeGenericType(CellKind.SystemType());            
    }    

    public interface IVectorKind<F,W,T> : IVectorType<W>, IVectorKind
        where F : struct, IVectorKind<F,W,T>
        where W : struct, IVectorWidth<W>
        where T : unmanaged
    {
        NumericKind IVectorKind.CellKind => NumericKinds.kind<T>();

        NumericWidth IVectorKind.CellWidth => (NumericWidth)Widths.measure<T>();
    }
}