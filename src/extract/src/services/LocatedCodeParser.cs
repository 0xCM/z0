//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    public readonly struct LocatedCodeParser : ILocatedCodeParser
    {
        readonly byte[] Buffer;

        [MethodImpl(Inline)]
        public LocatedCodeParser(byte[] buffer)
        {
            Buffer = buffer;
        }

        public Option<LocatedCode> Parse(LocatedCode src)
            => Extracts.parse(src, Buffer);
    }
}