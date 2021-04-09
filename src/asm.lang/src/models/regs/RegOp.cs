//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmOps
    {
        public readonly struct RegOp : IRegOp
        {
            readonly ushort Data;

            [MethodImpl(Inline)]
            public RegOp(RegWidth width, RegClass @class, RegIndex index)
            {
                Data = math.or(math.srl((ushort)width,3), math.sll((ushort)@class,5) , math.sll((ushort)index, 10));
            }

            public AsmOpKind OpKind
                => AsmOpKind.R;

            public RegWidth Width
            {
                [MethodImpl(Inline)]
                get => (RegWidth)math.sll(Data,3);
            }

            public RegClass Class
            {
                get => default;
            }

            public RegIndex Index
            {
                get => default;
            }

            public string Format()
            {
                return "";
            }
        }
    }
}