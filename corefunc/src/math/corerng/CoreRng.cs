//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
    using static As;

    public static partial class CoreRng
    {
        /// <summary>
        /// Converts a polyrand to the pitiful System.Random
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static System.Random ToSystemRand(this IPolyrand random)
            => SysRand.From(random);
    }
}