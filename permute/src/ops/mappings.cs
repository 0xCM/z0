//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
 
    partial class Permute
    {
        /// <summary>
        /// Enumerates all permutation map format strings on 4 symbols
        /// </summary>
        public static IEnumerable<(Perm4L perm, string format)> mappings(N4 n)
            => from perm in Enums.literals<Perm4L>()
                    where !perm.IsSymbol()
                    let maps = (perm, format:perm.FormatMap())
                    orderby maps.perm descending
                    select maps;
    }
}