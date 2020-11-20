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
    /// Defines a uniform structural representation for so-called 'handles'
    /// </summary>
    public readonly ref struct SystemHandle<T>
        where T : struct, ISystemHandle<T>
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public SystemHandle(T subject)
            => Value = subject;

        public void Dispose()
        {
            if(IsOwner)
                OS.CloseHandle(Address);
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Value.Address;
        }

        public bool IsOwner
        {
            [MethodImpl(Inline)]
            get => Value.IsOwner;
        }

        [MethodImpl(Inline)]
        public static implicit operator SystemHandle<T>(T src)
            => new SystemHandle<T>(src);
    }
}