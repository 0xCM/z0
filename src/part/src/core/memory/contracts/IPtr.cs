//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public unsafe interface IPtr
    {
        void* Target {get;}

        MemoryAddress Address
            => Target;
    }

    public unsafe interface IPtr<T> : IPtr
        where T : unmanaged
    {
        new T* Target {get;}

        void* IPtr.Target
            => Target;
    }
}