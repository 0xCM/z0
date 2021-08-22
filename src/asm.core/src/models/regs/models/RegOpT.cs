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

        public RegClassCode RegClassCode
        {
            [MethodImpl(Inline)]
            get => Data.RegClassCode;
        }

        public RegWidthCode WidthCode
        {
            [MethodImpl(Inline)]
            get => Data.WidthCode;
        }

        public string Format()
            => string.Format("{0}/{1}/{2}", Index, RegClassCode, WidthCode);

        public override string ToString()
            =>  Format();
    }
}