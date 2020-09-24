//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiContextState
    {
        internal readonly ApiModules Modules;

        [MethodImpl(Inline)]
        internal ApiContextState(in ApiModules modules)
        {
            Modules = modules;
        }
    }
}