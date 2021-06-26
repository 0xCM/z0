//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct RegOp<T> : IRegOp<T>
        where T : unmanaged, IRegOp
    {
        readonly T Data;

        [MethodImpl(Inline)]
        public RegOp(T src)
        {
            Data = src;
        }

        public RegIndexCode Index
        {
            [MethodImpl(Inline)]
            get => Data.Index;
        }

        public RegClass RegClass
        {
            [MethodImpl(Inline)]
            get => Data.RegClass;
        }

        public RegWidth Width
        {
            [MethodImpl(Inline)]
            get => Data.Width;
        }

        public string Format()
            => string.Format("{0}/{1}/{2}", Index, RegClass, Width);

        public override string ToString()
            =>  Format();
    }
}