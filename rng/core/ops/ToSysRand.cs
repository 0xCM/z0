//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class CoreRngOps
    {
        /// <summary>
        /// Converts a polyrand to the pitiful System.Random
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static System.Random ToSysRand(this IPolyrand random)
            => SysRand.From(random);
    }
}