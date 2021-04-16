//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDfaState<S>
        where S : IEquatable<S>
    {
        S Value {get;}
    }
}