//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using K = EFlagKind;

    public struct EFlags : IRegister<EFlags,W32,K>
    {
        public K Content  {get; private set;}

        public RegisterKind RegKind => RegisterKind.EFLAGS;

        public bit CF
        {
            [MethodImpl(Inline)]
            get => bit.test((uint)Content, 0);

            [MethodImpl(Inline)]
            set => Content = (K)bit.set((uint)Content, 0, value);
        }
    }
}