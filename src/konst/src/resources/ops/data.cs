//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Resources
    {
        /// <summary>
        /// Reveals the data represented by a <see cref='ResDescriptor'/>
        /// </summary>
        /// <param name="src">The source descriptor</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> data(in ResDescriptor src)
            => memory.view(src.Address, src.Size);
    }
}