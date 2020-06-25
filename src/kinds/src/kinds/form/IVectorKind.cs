//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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
        /// The vector numeric cell width
        /// </summary>
        NumericWidth CellWidth {get;}        

        /// <summary>
        /// The reified vector type as determined by kind facets
        /// </summary>
        Type Close();
    }    

    /// <summary>
    /// Characterizes an F-bound polymorphic reification that identifies an intrinsic vector generic type definition
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IVectorType<F,W> :  IVectorWidth<F>, ITypedLiteral<F,VectorWidth,uint>
        where F : struct, IVectorType<F,W>
        where W : unmanaged, ITypeWidth
    {
        
    }


}