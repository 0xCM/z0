//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Blit
    {
        public struct i6<T> : ISigned<T>
            where T : unmanaged
        {
            public const ulong Width = 6;

            public T Storage;

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}