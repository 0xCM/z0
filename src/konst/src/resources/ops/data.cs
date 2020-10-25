//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Resources
    {
        /// <summary>
        /// Reveals the data represented by a <see cref='ResourceDescriptor'/>
        /// </summary>
        /// <param name="src">The source descriptor</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> data(in ResourceDescriptor src)
            => MemView.view(src.Address, src.Size);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> utf8(in ResourceDescriptor src)
            => Encoded.utf8(data(src));
    }
}