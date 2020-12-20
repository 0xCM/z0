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
        readonly Index<MethodParameter> Data;

        public MethodParameter[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public MethodParameters(params MethodParameter[] src)
            => Data = src;

        public string Format(bool fence)
        {
            if(Data.IsNonEmpty)
            {
                var content = string.Join(", ", Data.Storage. Select(x => x.Format()));
                return fence ?  (Chars.LParen + content + Chars.RParen) : content;
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