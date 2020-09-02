//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    using api = Pointers;

    public unsafe struct FPtr
    {
        public Delegate F;

        public Ptr P;

        [MethodImpl(Inline)]
        public FPtr(Delegate f, void* src)
        {
            F = f;
            P = src;
        }

        public readonly MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => P.Address;
        }

        [MethodImpl(Inline)]
        public string Format()
            => P.Format();
    }
}