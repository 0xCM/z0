//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmRegs;
    using static AsmMem;
    using static AsmImm;

    using M = AsmMnemonicCode;


    partial struct asm
    {
        /// <summary>
        /// PUSH r16 | FF /6
        /// </summary>
        /// <param name="r"></param>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r16> push(r16 r)
            => statement(M.PUSH, r);

        /// <summary>
        /// PUSH r32 | FF /6
        /// </summary>
        /// <param name="r"></param>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r32> push(r32 r)
            => statement(M.PUSH, r);

        /// <summary>
        /// PUSH r64 | FF /6
        /// </summary>
        /// <param name="r"></param>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r64> push(r64 r)
            => statement(M.PUSH, r);

        [MethodImpl(Inline), Op]
        public static AsmStatement<m16> push(m16 m)
            => statement(M.PUSH, m);

        [MethodImpl(Inline), Op]
        public static AsmStatement<m32> push(m32 m)
            => statement(M.PUSH, m);

        [MethodImpl(Inline), Op]
        public static AsmStatement<m64> push(m64 m)
            => statement(M.PUSH, m);

    }

/*
 | Sequence | AttMnemonic      | OpCode                            | Instruction                             | Mode64 | LegacyMode | EncodingKind | Properties   | ImplicitRead                                                      | ImplicitWrite                               | ImplicitUndef                                                                                         | Protected | Cpuid         | Description                                                                                                                                                                                                                                                  |
 | 1583     | pushw            | FF /6                             | PUSH r/m16                              | V      | V          | M            | R            | RSP                                                               | RSP                                         |                                                                                                       |           |               | Push r/m16.                                                                                                                                                                                                                                                  |
 | 1584     |                  | FF /6                             | PUSH r/m32                              | NE     | V          |              |              | RSP                                                               | RSP                                         |                                                                                                       |           |               | Push r/m32.                                                                                                                                                                                                                                                  |
 | 1585     | pushq            | FF /6                             | PUSH r/m64                              | V      | NE         | M            | R            | RSP                                                               | RSP                                         |                                                                                                       |           |               | Push r/m64.                                                                                                                                                                                                                                                  |
 | 1586     | pushw            | 50 +rw                            | PUSH r16                                | V      | V          | O            | R            | RSP                                                               | RSP                                         |                                                                                                       |           |               | Push r16.                                                                                                                                                                                                                                                    |
 | 1587     |                  | 50 +rd                            | PUSH r32                                | NE     | V          |              |              | RSP                                                               | RSP                                         |                                                                                                       |           |               | Push r32.                                                                                                                                                                                                                                                    |
 | 1588     | pushq            | 50 +rd                            | PUSH r64                                | V      | NE         | O            | R            | RSP                                                               | RSP                                         |                                                                                                       |           |               | Push r64.                                                                                                                                                                                                                                                    |

*/
}
