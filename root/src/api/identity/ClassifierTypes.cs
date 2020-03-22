//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IOpKind : IKind
    {
        OpKindId KindId {get;}
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

    public interface IOpKind<E> : IOpKind, ILiteralKind<E>
        where E : unmanaged, Enum
    {
        E ILiftedEnum<E>.Class 
            => Enums.convert<E>(KindId.ToUInt64());

    }

    public interface IOpKind<E,T> : IOpKind<E>, ILiteralKind<E,T>
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