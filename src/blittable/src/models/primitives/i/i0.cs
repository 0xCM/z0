//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct Blit
    {
        public struct i0<T> : ISigned<T>
            where T : unmanaged
        {
            public const ulong Width = 0;

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}