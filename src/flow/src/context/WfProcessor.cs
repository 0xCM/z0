//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
        
    using static Konst;
    using static z;

    public readonly struct WfProcessor : ITextual
    {        
        public readonly asci32 Name;

        [MethodImpl(Inline)]
        public static implicit operator WfProcessor(string name)
            => new WfProcessor(name);

        [MethodImpl(Inline)]
        internal WfProcessor(string name)
            => Name = name;

        [MethodImpl(Inline)]
        internal WfProcessor(in asci32 name)
            => Name = name;

        [MethodImpl(Inline)]
        public string Format()
            => Name;
    }
}