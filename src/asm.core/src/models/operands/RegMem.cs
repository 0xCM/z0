//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public partial struct AsmOps
    {
        public readonly struct RegMem<T>
            where T : unmanaged, IRegOp
        {
            public T Base {get;}

            public T Index {get;}

            public MemoryScale Scale {get;}

            public Hex32 Dx {get;}

            public RegMem(T @base, T index, MemoryScale scale, Hex32 dx)
            {
                Base = @base;
                Index = index;
                Scale = scale;
                Dx = dx;
            }
        }
    }
}