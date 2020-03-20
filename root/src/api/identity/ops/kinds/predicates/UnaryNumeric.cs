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

    public enum NumericPredicate : ulong
    {

        None = 0,

        Negative = Id.Negative,

        Divides  = Id.Divides,
    }


    public sealed class NegativeAttribute : A { public NegativeAttribute() : base(Negative) {} }

    public sealed class DividesAttribute : A { public DividesAttribute() : base(Divides) {} }

}