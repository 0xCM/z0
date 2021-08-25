//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Blit
    {
        /// <summary>
        /// Represents a character of width 8
        /// </summary>
        public struct c8<T> : IChar<T>
            where T : unmanaged
        {
            public const ulong Width = 8;

            public T Storage;

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}