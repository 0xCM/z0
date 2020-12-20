//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct MethodParameters : IIndex<MethodParameter>
    {
        readonly MethodParameter[] Data;

        public MethodParameter[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public MethodParameters(params MethodParameter[] src)
            => Data = src;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data?.Length ?? 0;
        }

        public string Format(bool fence)
        {
            if(Length !=0)
            {
                var content = string.Join(", ", Data.Select(x => x.Format()));
                return fence ? (Chars.LParen + content + Chars.RParen) : content;
            }
            else
                return EmptyString;
        }

        public string Format()
            => Format(true);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator MethodParameters(MethodParameter[] src)
            => new MethodParameters(src);
    }
}