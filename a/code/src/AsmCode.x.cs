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

    public static class AsmCodeExtensions
    {
        [MethodImpl(Inline)]
        public static AsmCode WithIdentity(this AsmCode src, OpIdentity id)
            => AsmCode.Define(id, src.Data);


        [MethodImpl(Inline)]
        public static int ParameterCount(this AsmCode src)
            => src.Id.TextComponents.Count() - 1;
                    
        public static IEnumerable<AsmCode> HasParameterCount(this IEnumerable<AsmCode> src, int count)
            => from code in src
                where code.ParameterCount() == count
                select code;
    }
}