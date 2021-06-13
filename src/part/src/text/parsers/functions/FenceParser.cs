//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Rules;
    using static core;

    partial struct ParseComposer
    {
        public readonly struct FenceParser : IParseFunction<string>
        {
            readonly Fence<char> Fence;

            [MethodImpl(Inline)]
            public FenceParser(Fence<char> fence)
            {
                Fence = fence;
            }

            public Outcome Parse(string src, out string dst)
            {
                var result = Outcome.Success;
                dst = EmptyString;
                if(nonempty(src))
                    result = text.unfence(src,Fence, out dst);
                else
                    result = (false, EmptyInput);
                return result;
            }
        }
    }
}