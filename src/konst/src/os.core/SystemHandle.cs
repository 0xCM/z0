//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a uniform structural representation for <see cref='ISystemHandle{H}'/> reifications
    /// </summary>
    public readonly ref struct SystemHandle<T>
        where T : struct, ISystemHandle<T>
    {
        [MethodImpl(Inline)]
        public static implicit operator SystemHandle<T>(T src)
            => new SystemHandle<T>(src);

        public readonly T H;

        [MethodImpl(Inline)]
        public SystemHandle(T subject)
            => H = subject;

        public void Dispose()
        {
            if(IsOwner)
                SystemHandles.CloseHandle(Address);
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => H.Address;
        }

        public bool IsOwner
        {
            [MethodImpl(Inline)]
            get => H.IsOwner;
        }
    }
}