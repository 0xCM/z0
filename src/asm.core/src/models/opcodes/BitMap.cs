//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public struct BitMap<I,T>
        where I : unmanaged
        where T : unmanaged
    {
        public I Index;

        public T Bits;

        public string Format()
            => string.Format("{0} -> {1}", Index, Bits);

        public override string ToString()
            => Format();
    }
}