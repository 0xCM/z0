//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using N = SystemNode;

    public interface IPath<X> : ILink<X>, IReadOnlyList<Link<X>>
    {

    }

}