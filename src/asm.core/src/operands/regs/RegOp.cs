//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = AsmOp;

    partial struct AsmOps
    {
        /// <summary>
        /// [0000 0000 00000 000]
        /// </summary>
        public readonly struct RegOp : IRegOp
        {
            readonly ushort Data;

            [MethodImpl(Inline)]
            internal RegOp(ushort src)
            {
                Data = src;
            }

            internal ushort Bitfield
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            public AsmOpClass OpClass
                => AsmOpClass.R;

            public RegWidth Width
            {
                [MethodImpl(Inline)]
                get => api.width(this);
            }

            public RegClass RegClass
            {
                [MethodImpl(Inline)]
                get => api.regclass(this);
            }

            public RegIndex Index
            {
                [MethodImpl(Inline)]
                get => api.index(this);
            }

            public string Format()
                => string.Format("{0}/{1}/{2}", Index, RegClass, Width);


            public override string ToString()
                =>  Format();
        }
    }
}