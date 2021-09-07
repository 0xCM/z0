//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;
    partial struct Blit
    {
        public struct i5<T> : ISigned<T>
            where T : unmanaged
        {
            public const ulong Width = 5;

            public T Storage;

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}