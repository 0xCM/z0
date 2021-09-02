//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace types.generic
{
    using System.Runtime.CompilerServices;
    using static Z0.Root;

    public struct block<T>
        where T : unmanaged
    {
        T Storage;

        [MethodImpl(Inline), Op]
        public block(T storage)
        {
            Storage = storage;
        }
    }
}