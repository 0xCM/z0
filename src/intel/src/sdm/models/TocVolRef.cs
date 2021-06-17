//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct IntelSdm
    {
        /// <summary>
        /// Represents a volume reference in a TocEntry
        /// </summary>
        public struct TocVolRef
        {
            readonly CharBlock16 Data;

            [MethodImpl(Inline)]
            public TocVolRef(CharBlock16 src)
            {
                Data = src;
            }

            public ReadOnlySpan<char> String
            {
                [MethodImpl(Inline)]
                get => Data.String;
            }
        }
    }
}