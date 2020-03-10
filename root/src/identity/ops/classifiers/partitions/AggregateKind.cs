//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static OpKindId;

    using Id = OpKindId;
    using A = OpKindAttribute;
    using K = AggregateKind;

    public enum AggregateKind : ulong
    {
        None  = 0,

        Sum = Id.Sum,

        Avg = Id.Avg,
    }

    public sealed class SumAttribute : A { public SumAttribute() : base(Sum) {} }

    public sealed class AvgAttribute : A { public AvgAttribute() : base(Avg) {} }

    partial class OpKinds
    {
        public readonly struct Sum : IOpKind<Sum,K> { public K Kind { [MethodImpl(Inline)] get => K.Sum;} }

        public readonly struct Avg : IOpKind<Avg,K> { public K Kind { [MethodImpl(Inline)] get => K.Avg;} }
    }
}