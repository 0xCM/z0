//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

   public struct EffectiveAddress<T>
        where T : unmanaged
    {
        public RegIndexCode Base;

        public RegIndexCode Index;

        public MemoryScale Scale;

        public Disp<T> Disp;

        public RegWidth RegWidth;

        public DataWidth DispWidth
        {
            [MethodImpl(Inline)]
            get => Disp.Width;
        }
    }
}