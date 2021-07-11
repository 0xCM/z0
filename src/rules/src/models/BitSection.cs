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
        public readonly struct BitSection : IRuleDataType<BitSection>
        {
            public ushort MinIndex {get;}

            public ushort MaxIndex {get;}

            [MethodImpl(Inline)]
            public BitSection(ushort min, ushort max)
            {
                MinIndex = min;
                MaxIndex = max;
            }
        }
    }
}