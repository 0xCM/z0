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
        public readonly struct Primitive
        {
            internal readonly uint Index;

            [MethodImpl(Inline)]
            internal Primitive(uint index)
            {
                Index = index;
            }
        }
    }
}