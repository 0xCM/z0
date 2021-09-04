//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct Rules
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public readonly struct SwitchCase<C,T>
        {
            public readonly uint Index;

            public readonly C Case;

            public readonly T Target;

            [MethodImpl(Inline)]
            public SwitchCase(uint index, C @case, T target)
            {
                Index = index;
                Case = @case;
                Target = target;
            }
        }
    }
}