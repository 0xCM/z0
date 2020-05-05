//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IIdentifiedCode<F,C> : IEncoded<F,C>, IIdentified<OpIdentity>
        where F : struct, IEncoded<F,C>

    {

    }

}