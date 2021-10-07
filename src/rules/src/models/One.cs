//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        /// <summary>
        /// Just one, neither more nor less
        /// </summary>
        public readonly struct One
        {
            public dynamic Element {get;}

            [MethodImpl(Inline)]
            public One(dynamic src)
                => Element = src;
        }
    }
}