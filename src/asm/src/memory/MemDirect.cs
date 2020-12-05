//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Z0.Asm;

    public readonly struct MemDirect
    {
        public readonly IceRegister Base;

        public readonly MemoryScale Scale;

        public readonly MemDx Dx;

        [MethodImpl(Inline)]
        public MemDirect(IceRegister register, MemoryScale scale, MemDx dx)
        {
            Base = register;
            Dx = dx;
            Scale = scale;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Base == 0 && Scale.IsEmpty && Dx.IsEmpty;
        }

        public static MemDirect Empty
            => new MemDirect(IceRegister.None, MemoryScale.Empty, MemDx.Empty);
    }
}