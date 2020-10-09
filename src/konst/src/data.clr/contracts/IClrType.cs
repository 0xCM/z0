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

    using static Konst;

    /// <summary>
    /// Characterizes a model of a CLR type
    /// </summary>
    public interface IClrType : IReflexArtifact<Type>
    {
        ClrTypeKind Kind {get;}

        ClrArtifactKey Id {get;}

        /// <summary>
        /// Models of the types nested within the subject, if any
        /// </summary>
        IEnumerable<IClrType> NestedTypes
            => z.stream<IClrType>();
    }

    /// <summary>
    /// Characterizes an F-bound polyorphic type model reification
    /// </summary>
    /// <typeparam name="M">The reifying type</typeparam>
    public interface IClrType<T> : IClrType
    {
        IClrType Generalized {get;}

        new IEnumerable<T> NestedTypes
            => z.stream<T>();

        IEnumerable<IClrType> IClrType.NestedTypes
            => NestedTypes.Cast<IClrType>();
    }

    /// <summary>
    /// Characterizes a subject-parametric type model
    /// </summary>
    /// <typeparam name="M">The reified model type</typeparam>
    /// <typeparam name="T">The subject of the model</typeparam>
    public interface IClrType<M,T> : IClrType<M>
        where M : struct, IClrType<M>
    {
        /// <summary>
        /// The equivalent non-parametric model
        /// </summary>
        M Untyped {get;}

        IClrType IClrType<M>.Generalized
            => Untyped.Generalized;

        Type IReflexArtifact<Type>.Definition
            => typeof(T);
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic and subject-parametric type model
    /// </summary>
    /// <typeparam name="X">The reifying type</typeparam>
    /// <typeparam name="M">The reifying type of the equivalent non-parametric model</typeparam>
    /// <typeparam name="T">The subject of the model</typeparam>
    public interface IClrType<X,M,T> : IClrType<M,T>
        where M : struct, IClrType<M>
        where X : struct, IClrType<X,M,T>
    {

    }
}