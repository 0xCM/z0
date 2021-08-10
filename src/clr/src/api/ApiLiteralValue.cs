//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    using api = ApiLiterals;

    public readonly struct ApiLiteralValue
    {
        public string Data {get;}

        [MethodImpl(Inline)]
        public ApiLiteralValue(string src)
        {
            Data = src;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]

        public static implicit operator ApiLiteralValue(string src)
            => new ApiLiteralValue(src);
    }
}