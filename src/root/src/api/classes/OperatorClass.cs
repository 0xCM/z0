//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using K = ApiOperatorKind;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;


    [Free]
    public interface IOperatorClass<E> : IOperationClass, IOperationClass<E>
        where E : unmanaged, Enum
    {


    }

    public readonly struct OperatorClass : IOperatorClassHost<OperatorClass,K>
    {
        public K Kind {get;}

        [MethodImpl(Inline)]
        public OperatorClass(K k)
            => Kind = k;

        public OperatorClass Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }
    }

    public readonly struct OperatorClass<T> : IOperationClass<ApiOperatorKind,T>
    {
        public ApiOperatorKind Kind {get;}

        [MethodImpl(Inline)]
        public OperatorClass(ApiOperatorKind k)
            => Kind = k;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(OperatorClass<T> src)
            => new OperatorClass(src.Kind);
    }
}