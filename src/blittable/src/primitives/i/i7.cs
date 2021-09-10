//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct BitFlow
    {
        public struct i7<T> : ISigned<T>
            where T : unmanaged
        {
            public const ulong Width = 7;

            public T Storage;

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}