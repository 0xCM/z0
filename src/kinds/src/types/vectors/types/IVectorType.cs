//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;

    public interface IVectorType : IVectorWidth
    {
        /// <summary>
        /// The vector's generic type definition
        /// </summary>
        Type TypeDefinition {get;}
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic reification that identifies an intrinsic vector generic type definition
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IVectorType<F> : IVectorType, IFixedWidth<F>, ITypedLiteral<F,VectorWidth,uint>
        where F : struct, IVectorWidth<F>
    {
        
    }
}