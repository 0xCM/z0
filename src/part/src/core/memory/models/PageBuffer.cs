//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Captures the content of a page in memory
    /// </summary>
    public readonly struct PageBuffer
    {
        readonly ByteBlock4096 Data;

        public const ushort Size = ByteBlock4096.Size;

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Data.Bytes;
        }

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Bytes;
        }
    }
}