//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IPredicate
    {

    }

    public interface IPredicate<T>: IPredicate
        where T : struct, IPredicate<T>
    {

    }
}