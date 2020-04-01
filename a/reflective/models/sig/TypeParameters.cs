//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TypeParameters  : IFormattable<TypeParameters>
    {
        public TypeParameter[] Items {get;}

        public static implicit operator TypeParameters(TypeParameter[] src)
            => new TypeParameters(src);
                
        public TypeParameters(TypeParameter[] reps)
            => this.Items = reps;

        public TypeParameters(IEnumerable<TypeParameter> reps)
            => this.Items = reps.ToArray();

        public string Format(bool fence)
        {            
            var content = string.Join(", ", Items.Select(x => x.Format(false)));
            return fence ?  ('<' + content + '>') : content;
        }

        public string Format()
            => Format(true);

        public int Count
            => Items.Length;

        public override string ToString()
            => Format();
    }
}