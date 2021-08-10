//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct LiteralProvider
    {
        public Type Definition {get;}

        public LiteralUsage Usage {get;}

        [MethodImpl(Inline)]
        public LiteralProvider(Type src, LiteralUsage usage = default)
        {
            Definition = src;
            Usage = usage;
        }

        public string Name
        {
            [MethodImpl(Inline)]
            get => Definition.Name;
        }
    }
}