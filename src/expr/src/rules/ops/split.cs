//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines rules pertaining to sequences
    /// </summary>
    partial struct rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Split<T> split<T>(T delimiter)
            => new Split<T>(delimiter);    
    }
}