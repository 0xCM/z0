//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct BitSection
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