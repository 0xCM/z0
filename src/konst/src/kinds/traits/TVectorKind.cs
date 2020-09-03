//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface TVectorKind<F,W,T> : IVectorType<F,W>, IVectorKind
        where F : struct, TVectorKind<F,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        NumericKind IVectorKind.CellKind 
            => NumericKinds.kind<T>();

        NumericWidth IVectorKind.CellWidth 
            => (NumericWidth)Widths.bits<T>();

        /// <summary>
        /// The reified vector type as determined by kind facets
        /// </summary>
        Type IVectorKind.Close()
            => TypeDefinition.MakeGenericType(CellKind.SystemType());
    }
}