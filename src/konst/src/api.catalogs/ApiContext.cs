//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public struct ApiContext : IApiContext<ApiContext, ApiContextState>
    {
        ApiContextState[] Data;

        ref ApiContextState State
        {
            [MethodImpl(Inline)]
            get => ref Data[0];
        }

        [MethodImpl(Inline)]
        internal ApiContext(in ApiContextState src)
            => Data = new ApiContextState[1]{src};


        ApiContextState IStateful<ApiContextState>.State
            => State;
    }
}