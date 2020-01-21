//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public class ComparisonOpAttribute : OpKindAttribute
    {
        static readonly string kindName = typeof(ComparisonKind).DisplayName();

        public ComparisonOpAttribute(ComparisonKind kind)
            : base((uint)kind,kind.Format())
        {
            this.Kind = kind;
        }

        public ComparisonKind Kind {get;}

        public override string KindName => kindName;
    }   
}