//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using K = ApiOperatorClass;

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
}