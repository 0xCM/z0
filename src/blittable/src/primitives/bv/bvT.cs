//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        public struct bv<T>
            where T : unmanaged
        {
            public uint Width;

            public T Storage;

            [MethodImpl(Inline)]
            public bv(uint width, T bits)
            {
                Width = width;
                Storage = bits;
            }
        }
    }
}