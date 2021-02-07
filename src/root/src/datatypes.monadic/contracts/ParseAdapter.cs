//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ParseAdapter<S,T>
    {
        readonly IParser<S,T> Parser;

        [MethodImpl(Inline)]
        public ParseAdapter(IParser<S,T> parser)
            => Parser = parser;

        public T Succeed(S src, T @default)
        {
            if(Parse(src, out var dst))
                return dst;
            else
                return @default;
        }

        public bool Parse(in S src, out T dst)
        {
            var result = Parser.Parse(src);
            if(result)
            {
                dst = result.Value;
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        public bool Parse(in S src, out T dst, out string message)
        {
            var result = Parser.Parse(src);
            if(result)
            {
                dst = result.Value;
                message = "Everthing is ok";
                return true;
            }
            else
            {
                dst = default;
                message = result.Reason.MapValueOrDefault(r => r.ToString(), "Fail");
                return false;
            }
        }
    }
}