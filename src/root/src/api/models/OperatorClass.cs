//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using K = OperatorArity;


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

    public readonly struct OperatorClass<T> : IOperationClass<OperatorArity,T>
    {
        public OperatorArity Kind {get;}

        [MethodImpl(Inline)]
        public OperatorClass(OperatorArity k)
            => Kind = k;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(OperatorClass<T> src)
            => new OperatorClass(src.Kind);
    }
}