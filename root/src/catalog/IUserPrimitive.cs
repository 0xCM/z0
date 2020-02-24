//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    public interface IUserPrimitive
    {
        /// <summary>
        /// A unique number, relative to the world of user-defined primitives, 
        /// that identifies the user primitive
        /// </summary>
        uint PrimitiveId {get;}

        /// <summary>
        /// Specifies whether type arguments are required
        /// </summary>
        bool IsParametric {get;}

        /// <summary>
        /// The number of type arguments required by the primitive
        /// </summary>
        int ParameterCount {get;}

        /// <summary>
        /// The type that defines the primitive, which may be either a concrete type
        /// or a generic type definition
        /// </summary>
        Type DefiningType  {get;}

        /// <summary>
        /// The types to which the user-defined type may be converted to
        /// </summary>
        Type[] ConversionTargets
            => new Type[]{};

        /// <summary>
        /// The types to which the user-defined type may be converted from
        /// </summary>
        Type[] ConversionSources 
            => new Type[]{};
    }

    public interface IUserPrimitive<P> : IUserPrimitive
        where P : IUserPrimitive<P>
    {
        Type IUserPrimitive.DefiningType 
        {
            [MethodImpl(Inline)]
            get => typeof(P); 
        }

        bool IUserPrimitive.IsParametric
        {
            [MethodImpl(Inline)]
            get => false;
        }

        int IUserPrimitive.ParameterCount
        {
            [MethodImpl(Inline)]
            get => 0;
        }
    }

    public interface IUserPrimitive<P,T> : IUserPrimitive<P>
        where P : IUserPrimitive<P,T>
    {
        bool IUserPrimitive.IsParametric
        {
            [MethodImpl(Inline)]
            get => true;
        }

        int IUserPrimitive.ParameterCount
        {
            [MethodImpl(Inline)]
            get => 1;
        }
    }

    public interface IUserPrimitive<P,T0,T1> : IUserPrimitive<P>
        where P : IUserPrimitive<P,T0,T1>
    {
        bool IUserPrimitive.IsParametric
        {
            [MethodImpl(Inline)]
            get => true;
        }

        int IUserPrimitive.ParameterCount
        {
            [MethodImpl(Inline)]
            get => 2;
        }
    }
}