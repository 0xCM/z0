//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Blit
    {
        /// <summary>
        /// Represents a character of width 6
        /// </summary>
        public struct c6<T> : IChar<T>
            where T : unmanaged
        {
            public const ulong Width = 6;

            public T Storage;

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}