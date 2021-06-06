//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct MemoryStore<T>
        where T : struct
    {
        public UIntPtr StoreLocation {get;}

        [MethodImpl(Inline)]
        public MemoryStore(UIntPtr location)
            => StoreLocation = location;

        public unsafe ref T Deposited
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.AsRef<T>(StoreLocation.ToPointer());
        }
    }
}