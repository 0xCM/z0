//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MethodParameters : IFormattable<MethodParameters>
    {
        public MethodParameter[] Index {get;}

        [MethodImpl(Inline)]
        public static implicit operator MethodParameters(MethodParameter[] src)
            => new MethodParameters(src);

        [MethodImpl(Inline)]
        public MethodParameters(IEnumerable<MethodParameter> refs)
            => this.Index = refs.ToArray();

        [MethodImpl(Inline)]
        public MethodParameters(params MethodParameter[] src)
            => this.Index = src;

        public string Format(bool fence)
        {
            var content = string.Join(", ", Index.Select(x => x.Format()));
            return fence ?  (Chars.LParen + content + Chars.RParen) : content;
        }

        public string Format()
            => Format(true);
        
        public override string ToString()
            => Format();         
    }
}