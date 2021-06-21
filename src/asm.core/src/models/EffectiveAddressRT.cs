//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    public struct EffectiveAddress<R,T>
        where R : unmanaged, IRegOp<R>
        where T : unmanaged
    {
        public R Base;

        public R Index;

        public MemoryScale Scale;

        public Disp<T> Disp;

        public RegWidth RegWidth
        {
            [MethodImpl(Inline)]
            get => default(R).Width;
        }

        public DataWidth DispWidth
        {
            [MethodImpl(Inline)]
            get => Disp.Width;
        }
    }
}