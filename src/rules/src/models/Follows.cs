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
        /// <summary>
        /// Requires that one element occurrs after another
        /// </summary>
        public readonly struct Next<S,T>
        {
            public readonly S Input;

            public readonly T Output;

            [MethodImpl(Inline)]
            public Next(S i, T o)
            {
                Input = i;
                Output = o;
            }
        }
    }
}