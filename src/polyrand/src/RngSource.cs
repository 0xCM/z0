//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct RngSource
    {
        public Label Name {get;}

        [MethodImpl(Inline)]
        public RngSource(Label name)
        {
            Name = name;
        }
    }
}