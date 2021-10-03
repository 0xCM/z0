//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct BitFlow
    {
        public struct f0<T> : IFloat<T>
            where T : unmanaged
        {
            public const ulong Width = 0;

            BitWidth IBlittable.ContentWidth
                => Width;
        }
    }
}