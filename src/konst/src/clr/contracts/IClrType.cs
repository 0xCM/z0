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

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a model of a CLR type during runtime
    /// </summary>
    [Free]
    public interface IClrRuntimeType : IClrRuntimeObject
    {
        ClrTypeKind TypeKind {get;}

        ClrArtifactKind IClrRuntimeObject.ClrKind
            => (ClrArtifactKind)TypeKind;

        /// <summary>
        /// Models of the types nested within the subject, if any
        /// </summary>
        IEnumerable<IClrRuntimeType> NestedTypes
            => z.stream<IClrRuntimeType>();
    }

    /// <summary>
    /// Characterizes an F-bound polyorphic type model reification
    /// </summary>
    /// <typeparam name="M">The reifying type</typeparam>
    [Free]
    public interface IClrRuntimeType<T> : IClrRuntimeType
        where T : struct, IClrRuntimeType<T>
    {
        new IEnumerable<T> NestedTypes
            => z.stream<T>();

        IEnumerable<IClrRuntimeType> IClrRuntimeType.NestedTypes
            => NestedTypes.Cast<IClrRuntimeType>();
    }

    /// <summary>
    /// Characterizes a subject-parametric type model
    /// </summary>
    /// <typeparam name="M">The reified model type</typeparam>
    /// <typeparam name="T">The subject of the model</typeparam>
    [Free]
    public interface IClrRuntimeType<M,T> : IClrRuntimeType<M>
        where M : struct, IClrRuntimeType<M>
    {
        /// <summary>
        /// The equivalent non-parametric model
        /// </summary>
        M Untyped {get;}
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic and subject-parametric type model
    /// </summary>
    /// <typeparam name="X">The reifying type</typeparam>
    /// <typeparam name="M">The reifying type of the equivalent non-parametric model</typeparam>
    /// <typeparam name="T">The subject of the model</typeparam>
    [Free]
    public interface IClrRuntimeType<X,M,T> : IClrRuntimeType<M,T>
        where M : struct, IClrRuntimeType<M>
        where X : struct, IClrRuntimeType<X,M,T>
    {

    }
}