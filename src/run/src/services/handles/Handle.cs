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
    /// Defines a uniform structural representation for <see cref='IHandle{H}'/> reifications
    /// </summary>
    public readonly ref struct Handle<T>
        where T : struct, IHandle<T>
    {
        [MethodImpl(Inline)]
        public static implicit operator Handle<T>(T src)
            =>new Handle<T>(src);

        public readonly T H;

        [MethodImpl(Inline)]
        public Handle(T subject)
            => H = subject;

        public void Dispose()
        {
            if(IsOwner)
                Windows.Kernel32.CloseHandle(Address);
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