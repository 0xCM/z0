//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct Reflector : IReflector
    {
        public static IReflector Service => default(Reflector);
    }
}