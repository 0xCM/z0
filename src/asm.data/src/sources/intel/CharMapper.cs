//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public ref struct CharMapper
    {
        readonly CharMap Spec;

        public CharMapper(CharMap spec)
        {
            Spec = spec;
        }

        public uint Map(ReadOnlySpan<char> src, Span<char> dst)
        {
            return 0;
        }

    }
}