//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SeqSplit<T> splitter<T>(T delimiter)
            => new SeqSplit<T>(delimiter);
    }
}