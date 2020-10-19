//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IVectorKind : IVectorWidth
    {
        /// <summary>
        /// The vector's generic type definition
        /// </summary>
        Type TypeDefinition {get;}

        /// <summary>
        /// The vector numeric cell kind
        /// </summary>
        NumericKind CellKind {get;}

        /// <summary>
        /// The reified vector type as determined by kind facets
        /// </summary>
        Type Close();
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic reification that identifies an intrinsic vector generic type definition
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    [Free]
    public interface IVectorKind<F,W> : TVectorWidth<F>, ITypedLiteral<F,VectorWidth,uint>, IDataWidth
        where F : struct, IVectorKind<F,W>
        where W : unmanaged, ITypeWidth
    {
        DataWidth IDataWidth.DataWidth
            => Widths.data<W>();
    }

    [Free]
    public interface IVectorKind<F,W,T> : IVectorKind<F,W>, IVectorKind
        where F : struct, IVectorKind<F,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        NumericKind IVectorKind.CellKind
            => NumericKinds.kind<T>();

        /// <summary>
        /// The reified vector type as determined by kind facets
        /// </summary>
        Type IVectorKind.Close()
            => TypeDefinition.MakeGenericType(CellKind.SystemType());
    }
}