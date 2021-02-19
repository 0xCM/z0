//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IScope
    {

    }

    public interface IScope<T> : IScope
        where T : IScope<T>
    {

    }

}