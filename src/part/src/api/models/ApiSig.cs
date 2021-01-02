//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiSig
    {
        readonly Index<dynamic> Components;

        [MethodImpl(Inline)]
        public ApiSig(dynamic[] src)
            => Components = src;
    }
}