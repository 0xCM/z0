//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Metatype stratification
    /// </summary>
    public interface IKind
    {
        
    }

    /// <summary>
    /// Characterizes type classifiers predicated on enumerations
    /// </summary>
    /// <typeparam name="E">The enum type defining potential classifications</typeparam>
    public interface IKind<E> : IKind
        where E : unmanaged, Enum
    {
        E Class {get;}

        string Name => Class.ToString().ToLower();
    }

    public interface ILiteral<E> : IKind<E>
        where E : unmanaged, Enum
    {

    }

    public interface ILiteral<E,T> : ILiteral<E>, INumericKind<T>
        where T : unmanaged
        where E : unmanaged, Enum

    {

    }

    public interface IOpKind : IKind
    {
        OpKindId KindId {get;}
    }

    public interface IClass
    {

    }

    public interface IOpClass : IClass
    {

    }

    public interface IOpClass<E> : IOpClass
        where E : unmanaged, Enum
    {
        E Class {get;}

        string Name => Class.ToString().ToLower();
        
    }

    public interface IOpClass<E,T> : IOpClass<E>
        where T : unmanaged
        where E : unmanaged, Enum
    {

    }

    public interface IOpKind<E> : IOpKind, ILiteral<E>
        where E : unmanaged, Enum
    {
        E IKind<E>.Class 
            => Enums.convert<E>(KindId.ToUInt64());

    }

    public interface IOpKind<E,T> : IOpKind, ILiteral<E,T>
        where T : unmanaged
        where E : unmanaged, Enum
    {   

    }

    public interface ITypeClass : IClass
    {

    }

    public interface ITypeClass<C> : ITypeClass
    {

    }

    public interface ITypeArity
    {
        /// <summary>
        /// The parametric arity of a type
        /// </summary>
        int Arity {get;}
    }

    public interface ITypeWidth 
    {
        FixedWidth Width {get;}
    }

    public interface ITypeKind : IKind
    {        

    }
    
    /// <summary>
    /// Type kinds are partitioned by types thar are not enumerations
    /// </summary>
    /// <typeparam name="K"></typeparam>
    public interface ITypeKind<K> : ITypeKind
    {

    }

    public interface ITypeKind<K1,K2> : ITypeKind
    {

    }
}