//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOperands;
    using static Hex8Seq;

    partial class AsmSpecs
    {
        /// <summary>
        /// (AND AL, imm8)[24 ib]
        /// </summary>
        /// <param name="r"></param>
        /// <param name="imm8"></param>
        [MethodImpl(Inline), Op]
        public static byte and(al r, Imm8 imm8, ref byte hex)
            => AsmEncoder.encode(x24, imm8, ref hex);

        /// <summary>
        /// (AND r/m8, imm8)[80 /4 ib]
        /// </summary>
        /// <param name="r"></param>
        /// <param name="imm8"></param>
        [MethodImpl(Inline), Op]
        public static byte and(r8b r, Imm8 imm8, ref byte hex)
            => AsmEncoder.encode(x24, imm8, ref hex);
    }
}