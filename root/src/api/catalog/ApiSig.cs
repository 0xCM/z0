//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ApiSig
    {
        public static ApiSig Empty => default;

        public ApiSig(ApiMethodSig[] parts)
        {
            this.Nodes = parts;
        }

        public ApiMethodSig[] Nodes {get;}
    }

    public interface ISigNode<S> : IEquatable<S>
        where S : ISigNode<S>
    {

    }

    public interface ISigNode<S,C> :  ISigNode<S>
        where S: ISigNode<S,C>
        where C: unmanaged, Enum
    {
        C Class {get;}
    }

    public interface ITypeSig<S> : ISigNode<S>
        where S: ITypeSig<S>
    {

    }

    public interface ITypeSig<S,C> : ITypeSig<S>, ISigNode<S,C>
        where S: ITypeSig<S,C>
        where C: unmanaged, Enum
    {

    }


    public interface IMethodSig<S> : ISigNode<S>
        where S: IMethodSig<S>
    {

    }

    public interface IMethodSig<S,C> : IMethodSig<S>, ISigNode<S,C>
        where S: IMethodSig<S,C>
        where C: unmanaged, Enum
    {

    }

    public interface IParameterSig<S> : ISigNode<S>
        where S: IParameterSig<S>
    {

    }

    public interface IParameterSig<S,C> : IParameterSig<S>, ISigNode<S,C>
        where S: IParameterSig<S,C>
        where C: unmanaged, Enum
    {

    }

    public readonly struct ApiMethodSig : IMethodSig<ApiMethodSig, OperationClass>
    {
        public OperationClass Class {get;}

        [MethodImpl(Inline)]
        public bool Equals(ApiMethodSig other)
            => default;
    }

    public readonly struct ParameterSig : IParameterSig<ParameterSig, ParameterClass>
    {
        public ParameterClass Class {get;}
        
        public bool Equals(ParameterSig other)
            => default;
    }

    public readonly struct SegmentedTypeSig : ITypeSig<SegmentedTypeSig, SegmentedClass>
    {
        public SegmentedClass Class {get;}

        public NumericTypeSig NumericSig {get;}

        internal SegmentedTypeSig(SegmentedClass segmented, NumericTypeSig numeric)
        {
            this.Class = segmented;
            this.NumericSig = numeric;
        }

        [MethodImpl(Inline)]
        public bool Equals(SegmentedTypeSig other)
            => Class == other.Class;
    }

    public readonly struct NumericTypeSig : ITypeSig<NumericTypeSig, NumericClass>
    {
        public NumericClass Class {get;}

        public TypeRoleAspect Role {get;}

        [MethodImpl(Inline)]
        internal NumericTypeSig(NumericClass c, TypeRoleAspect role) 
        {
            this.Class = c;
            this.Role = role;
        }

        [MethodImpl(Inline)]
        public bool Equals(NumericTypeSig other)
            => Class == other.Class
            && Role == other.Role;
    }
}