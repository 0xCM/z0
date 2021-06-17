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
        /// Denotes a volume part such as 'iii'
        /// </summary>
        public readonly struct VolPartNumber
        {
            readonly CharBlock4 Storage;

            [MethodImpl(Inline)]
            public VolPartNumber(CharBlock4 data)
            {
                Storage = data;
            }

            public ReadOnlySpan<char> Data
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            public ReadOnlySpan<char> String
            {
                [MethodImpl(Inline)]
                get => Storage.String;
            }

            public static VolPartNumber Empty
            {
                [MethodImpl(Inline)]
                get => new VolPartNumber(CharBlock4.Empty);
            }
        }
    }
}