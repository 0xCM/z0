//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static z;

    public readonly struct WfProcessor : ITextual
    {        
        public readonly string Name;

        [MethodImpl(Inline)]
        public static implicit operator WfProcessor(string name)
            => new WfProcessor(name);

        [MethodImpl(Inline)]
        public WfProcessor(string name)
            => Name = name;

        [MethodImpl(Inline)]
        public string Format()
            => Name;
    }
}