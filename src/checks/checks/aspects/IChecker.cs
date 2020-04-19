//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IChecker<V> : IValidator
        where V : struct, IValidator
    {
        static V Checker => default(V);
    }
}