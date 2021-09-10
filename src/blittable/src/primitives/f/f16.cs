//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct BitFlow
    {
        public struct f16<T> : IFloat<T>
            where T : unmanaged
        {
            public const ulong Width = 16;

            public T Storage;

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}