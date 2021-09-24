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
        [StructLayout(LayoutKind.Sequential)]
        public readonly struct BitSection
        {
            public readonly uint MinIndex;

            public readonly uint MaxIndex;

            [MethodImpl(Inline)]
            public BitSection(uint min, uint max)
            {
                MinIndex = min;
                MaxIndex = max;
            }
        }
    }
}