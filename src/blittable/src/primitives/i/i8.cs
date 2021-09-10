//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;
    partial struct BitFlow
    {
        public struct i8<T> : ISigned<T>
            where T : unmanaged
        {
            public const ulong Width = 8;

            public T Storage;

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}