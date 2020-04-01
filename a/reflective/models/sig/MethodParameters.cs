//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MethodParameters : IFormattable<MethodParameters>
    {
        public static implicit operator MethodParameters(MethodParameter[] src)
            => new MethodParameters(src);

        public MethodParameter[] Items {get;}

        public MethodParameters(IEnumerable<MethodParameter> refs)
            => this.Items = refs.ToArray();

        public string Format(bool fence)
        {
            var content = string.Join(", ", Items.Select(x => x.Format()));
            return fence ?  ('<' + content + '>') : content;
        }

        public string Format()
            => Format(true);
        
        public override string ToString()
            => Format();         
    }
}