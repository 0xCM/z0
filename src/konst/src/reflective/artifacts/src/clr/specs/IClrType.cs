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

    public interface IClrMethod : IClrArtifact
    {

    }

    /// <summary>
    /// Characterizes a model of a CLR type
    /// </summary>
    public interface IClrType : IClrArtifact<Type>
    {
        ClrTypeKind Kind {get;}

        string IArtifactModel.Identifier
            => Subject.Name;
        
        /// <summary>
        /// Indicates whether the model is empty and thus models nothing
        /// </summary>
        bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Subject == typeof(void);
        }

        /// <summary>
        /// Models of the types nested within the subject, if any
        /// </summary>
        IEnumerable<IClrType> NestedTypes 
            => z.seq<IClrType>();
    }

    /// <summary>
    /// Characterizes an F-bound polyorphic type model reification
    /// </summary>
    /// <typeparam name="M">The reifying type</typeparam>
    public interface IClrType<M> : IClrType
        where M : struct, IClrType<M>
    {
        ClrType Generalized {get;}
        
        new IEnumerable<M> NestedTypes
            => z.seq<M>();

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
        new ClrType<T> Generalized => ClrType.From<T>();

        /// <summary>
        /// The equivalent non-parametric model
        /// </summary>
        M Untyped {get;}

        ClrType IClrType<M>.Generalized => Untyped.Generalized;

        Type IClrArtifact<Type>.Subject => typeof(T);
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

    /// <summary>
    /// Characterizes a model of a struct type
    /// </summary>
    public interface IClrStruct : IClrType
    {
        
    }

    /// <summary>
    /// Characterizes a model of a class type
    /// </summary>
    public interface IClrClass : IClrType
    {
        
    }

    /// <summary>
    /// Characterizes a model of a delegate type
    /// </summary>
    public interface IClrDelegate : IClrType
    {
        
    }
}