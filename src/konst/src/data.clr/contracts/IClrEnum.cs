//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a model of a clr enum type
    /// </summary>
    public interface IClrEnum : IClrType
    {
        ClrTypeKind IClrType.Kind
            => ClrTypeKind.Enum;
    }

    /// <summary>
    /// Characterizes an F-bound polyorphic enum model reification
    /// </summary>
    /// <typeparam name="M">The reifying type</typeparam>
    public interface IClrEnum<F> : IClrEnum, IClrType<F>
        where F : struct, IClrEnum<F>
    {

    }

    /// <summary>
    /// Characterizes a subject-parametric type model
    /// </summary>
    /// <typeparam name="M">The reified model type</typeparam>
    /// <typeparam name="T">The subject of the model</typeparam>
    public interface IClrEnum<M,T> : IClrEnum<M>, IClrType<M,T>
        where M : struct, IClrEnum<M>
        where T : unmanaged, Enum
    {
        IClrType IClrType<M>.Generalized
            => Untyped.Generalized;
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic and subject-parametric enum model
    /// </summary>
    /// <typeparam name="X">The reifying type</typeparam>
    /// <typeparam name="M">The reifying type of the equivalent non-parametric model</typeparam>
    /// <typeparam name="T">The subject of the model</typeparam>
    public interface IClrEnum<X,M,T> : IClrEnum<M,T>
        where M : struct, IClrEnum<M>
        where X : struct, IClrEnum<X,M,T>
        where T : unmanaged, Enum
    {

    }
}