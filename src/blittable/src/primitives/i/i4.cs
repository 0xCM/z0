//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct BitFlow
    {
        public struct i4<T> : ISigned<T>
            where T : unmanaged
        {
            public const ulong Width = 4;

            public T Storage;

            BitWidth IBlittable.ContentWidth
                => Width;
        }
    }
}