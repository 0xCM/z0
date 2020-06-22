//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface TIdentityProducer
    {
        [MethodImpl(Inline)]
        NatNumericIdentity NaturalNumeric(ulong n, NumericKind t)   
            => IdentityProducer.Service.NaturalNumeric(n,t);
    }
}