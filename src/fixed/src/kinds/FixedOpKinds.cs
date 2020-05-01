//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Seed;
    using static Memories;

    public partial class FixedOpKinds
    {
        public static IEnumerable<FixedOpKind> Known 
            => type<FixedOpKinds>().StaticProperties(true,false)
                    .Reifies<IFixedOpKind>()
                    .Select(p => p.Data.MemberValue<IFixedOpKind>(null))
                    .Select(k => new FixedOpKind(k.OperandWidth, k.OperandType, k.OperatorType));
    }
}