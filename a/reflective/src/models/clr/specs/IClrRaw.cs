//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Reflective;

    /// <summary>
    /// Characterizes a model of an unmanaged type
    /// </summary>
    public interface IClrRaw : IClrType
    {
        ClrTypeKind IClrType.Kind => ClrTypeKind.Struct;
        
    }

    /// <summary>
    /// Characterizes an F-bound polyorphic unmanaged type model reification
    /// </summary>
    /// <typeparam name="M">The reifying type</typeparam>
    public interface IClrRaw<M> : IClrRaw, IClrType<M>
        where M : struct, IClrRaw<M>
    {

    }

    /// <summary>
    /// Characterizes a subject-parametric model of an unmanaged type
    /// </summary>
    /// <typeparam name="M">The reified model type</typeparam>
    /// <typeparam name="T">The subject of the model</typeparam>
    public interface IClrRaw<M,T> : IClrRaw<M>, IClrType<M,T>
        where M : struct, IClrRaw<M>
        where T : unmanaged
    {

        ClrType IClrType<M>.Generalized 
            => Untyped.Generalized;
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic and subject-parametric model of an unmanaged type
    /// </summary>
    /// <typeparam name="X">The reifying type</typeparam>
    /// <typeparam name="M">The reifying type of the equivalent non-parametric model</typeparam>
    /// <typeparam name="T">The subject of the model</typeparam>
    public interface IClrRaw<X,M,T> : IClrRaw<M,T>
        where M : struct, IClrRaw<M>
        where X : struct, IClrRaw<X,M,T>
        where T : unmanaged
    {

    }
}