//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using Z0.Asm;


    public readonly struct IceMemDirect
    {
        public readonly IceRegister Base;

        public readonly MemoryScale Scale;

        public readonly AsmDx Dx;

        [MethodImpl(Inline)]
        public IceMemDirect(IceRegister register, MemoryScale scale, AsmDx dx)
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

        public static IceMemDirect Empty
            => new IceMemDirect(IceRegister.None, MemoryScale.Empty, AsmDx.Empty);
    }
}