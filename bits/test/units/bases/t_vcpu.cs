//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static BitVector;

    public abstract class t_vcpu<X> : t_bits<X>
        where X : t_vcpu<X>, new()
    {


    }
}