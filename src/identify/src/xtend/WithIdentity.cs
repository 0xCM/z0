//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {

        [MethodImpl(Inline)]
        public static int ParameterCount(this OperationBits src)
            => src.Id.TextComponents.Count() - 1;
                    
        public static IEnumerable<OperationBits> WithParameterCount(this IEnumerable<OperationBits> src, int count)
            => from code in src
                where code.ParameterCount() == count
                select code;
    }
}