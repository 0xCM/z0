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

    partial struct TextParsers
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static FenceParser CreateFenceParser(Fence<char> fence)
            => new FenceParser(fence);

        [Op, Closures(Closure)]
        public static Outcome parse(string input, FenceParser parser, out string dst)
            => parser.Parse(input, out dst);

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
                if(text.nonempty(src))
                    result = text.unfence(src,Fence, out dst);
                else
                    result = (false, EmptyInput);
                return result;
            }
        }
    }
}