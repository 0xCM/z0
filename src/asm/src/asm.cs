//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;

    [ApiHost]
    public readonly partial struct asm
    {
        public static asm Service => new asm(2);

        const NumericKind Closure = UnsignedInts;

        readonly object[] state;

        ref object this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref state[index];
        }

        public asm(int i)
        {
            state = new object[i];
            state[0] = HexFormatSpecs.options(zpad:false, specifier:false);
            state[1] = new StringBuilder(1024);
        }
    }

    [ApiComplete]
    partial struct Msg
    {

    }
}