//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using api = ByteSpans;

    partial class XTend
    {
        public static ByteSpanSpec SpecifyByteSpan(this BinaryCode src, Identifier name, bool @static = true)
            => api.specify(name, src, @static);
    }
}