//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct ViewTrigger<T>
    {
        T Current;

        public void Raise(in T src)
        {
            Current = src;
        }
    }
}