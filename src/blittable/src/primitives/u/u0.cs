//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;

    partial struct BitFlow
    {
        public struct u0<T> : IUnsigned<T>
            where T : unmanaged
        {
            public const ulong Width = 0;

            BitWidth IBlittable.ContentWidth
                => Width;
        }
    }
}