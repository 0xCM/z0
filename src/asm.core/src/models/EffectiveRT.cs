//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct EffectiveAddress<R,T>
        where R : unmanaged, IRegOp<R>
        where T : unmanaged, IHexNumber<T>
    {
        public R Base {get;}

        public R Index {get;}

        public AsmScale Scale {get;}

        public T Dx {get;}
    }

    public readonly struct EffectiveAddress<T>
        where T : unmanaged, IHexNumber<T>
    {
        public RegIndex Base {get;}

        public RegIndex Index {get;}

        public AsmScale Scale {get;}

        public T Dx {get;}

        public RegWidth RegWidth {get;}

        public RegWidth DxWidth {get;}
    }

    public readonly struct EffectiveAddress
    {
        public RegIndex Base {get;}

        public RegIndex Index {get;}

        public AsmScale Scale {get;}

        public Hex32 Dx {get;}

        public RegWidth RegWidth {get;}

        public RegWidth DxWidth {get;}
    }
}