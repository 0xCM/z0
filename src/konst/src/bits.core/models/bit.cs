//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct bit
    {
        readonly bool State;
    }

    public struct bit<T>
        where T : unmanaged
    {
        T State;
    }
}