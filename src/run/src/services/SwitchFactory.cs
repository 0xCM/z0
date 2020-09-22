//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    public readonly struct SwitchFactory<D,T>
        where D : unmanaged
    {
        public readonly D Discriminator;

        public readonly uint BranchCount;

        [MethodImpl(Inline)]
        public SwitchFactory(D branch, uint count)
        {
            Discriminator = branch;
            BranchCount = count;
        }

        public void Emit(StringTable dst)
        {

        }
    }
}