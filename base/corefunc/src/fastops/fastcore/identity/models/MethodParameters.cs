//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class MethodParameters : ClrArtifacts<MethodParameters, MethodParameter>
    {
        public static implicit operator MethodParameters(MethodParameter[] src)
            => new MethodParameters(src);

        readonly MethodParameter[] reps;

        public MethodParameters(IEnumerable<MethodParameter> refs)
            => this.reps = refs.ToArray();

        protected override IReadOnlyList<MethodParameter> Items
            => reps;

        public string Format(bool fence)
        {
            var content = reps.Select(mp => mp.Format()).Concat(", ");
            return fence ? parenthetical(content) : content;
        }
    }

}