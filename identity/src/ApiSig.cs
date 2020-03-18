//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static Root;

    public readonly struct ApiSig
    {
        public static ApiSig Empty => default;

        public ApiSig(ApiMethodSig[] parts)
        {
            this.Nodes = parts;
        }

        public Arrow<ApiMethodSig> Nodes {get;}
    }

    public interface ISigNode<S> : IEquatable<S>
        where S : ISigNode<S>
    {

    }

    public interface ITypeSig<S> : ISigNode<S>
        where S :  ITypeSig<S>
    {

    }

    public interface IMethodSig<S> : ISigNode<S>
        where S :  IMethodSig<S>
    {

    }

    public interface IParameterSig<S> : ISigNode<S>
        where S :  IParameterSig<S>
    {

    }

    public readonly struct ApiMethodSig : IMethodSig<ApiMethodSig>
    {
        public OperationClass Class {get;}

        [MethodImpl(Inline)]
        public bool Equals(ApiMethodSig other)
            => default;
    }

    public readonly struct ParameterSig : IParameterSig<ParameterSig>
    {
        public bool Equals(ParameterSig other)
            => default;
    }

    public readonly struct SegmentedTypeSig : ITypeSig<SegmentedTypeSig>
    {
        public SegmentedClass Class {get;}

        public NumericTypSig NumericSig {get;}

        [MethodImpl(Inline)]
        public bool Equals(SegmentedTypeSig other)
            => Class == other.Class;
    }

    public readonly struct NumericTypSig : ITypeSig<NumericTypSig>
    {
        public NumericClass Class {get;}

        public TypeRoleAspect Role {get;}

        internal NumericTypSig(NumericClass c, TypeRoleAspect role) 
        {
            this.Class = c;
            this.Role = role;
        }

        [MethodImpl(Inline)]
        public bool Equals(NumericTypSig other)
            => Class == other.Class
            && Role == other.Role
            ;
    }
}
