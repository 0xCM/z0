//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TypeParameters : ClrArtifacts<TypeParameters, TypeParameter>
    {
        readonly TypeParameter[] reps;

        public static implicit operator TypeParameters(TypeParameter[] src)
            => new TypeParameters(src);
                
        public TypeParameters(TypeParameter[] reps)
            => this.reps = reps;

        public TypeParameters(IEnumerable<TypeParameter> reps)
            => this.reps = reps.ToArray();

        protected override IReadOnlyList<TypeParameter> Items
            => reps;

        public string Format(bool fence)
        {            
            var content = reps.Select(x => x.Format(false)).Concat(", ");
            return fence ? text.angled(content) : content;
        }

        public int Count
            => reps.Length;

        public override string Format()
            => Format(true);
    }
}