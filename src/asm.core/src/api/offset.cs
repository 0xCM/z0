//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using static AsmOpTypes;

    using C = AsmMnemonicCode;
    using K = JmpKind;

    partial struct asm
    {
        /// <summary>
        /// Defines an IP offset relative to a specified base address, instruction size and target address
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="size">The size, in bytes, of the call/branch/jmp instruction</param>
        /// <param name="dst">The call/branch/jmp target</param>
        [MethodImpl(Inline), Op]
        public static MemoryAddress offset(MemoryAddress src, byte fxSize, MemoryAddress dst)
            => (MemoryAddress)(dst - (src + fxSize));

        [MethodImpl(Inline), Op]
        public static AsmOffsetOp offset(RegOp @base, RegOp index, Disp disp = default, MemoryScale? scale = null)
            => new AsmOffsetOp(@base,index, disp, scale ?? ScaleFactor.S1);

        [MethodImpl(Inline), Op]
        public static AsmOffsetOp<r8,Disp8> offset(r8 @base, r8 index, byte disp = default, MemoryScale? scale = null)
            => new AsmOffsetOp<r8,Disp8>(@base,index, scale ?? ScaleFactor.S1, disp);

        [MethodImpl(Inline), Op]
        public static AsmOffsetOp<r16,Disp16> offset(r16 @base, r16 index, ushort disp = default, MemoryScale? scale = null)
            => new AsmOffsetOp<r16,Disp16>(@base,index, scale ?? ScaleFactor.S1, disp);

        [MethodImpl(Inline), Op]
        public static AsmOffsetOp<r32,Disp32> offset(r32 @base, r32 index, uint disp = default, MemoryScale? scale = null)
            => new AsmOffsetOp<r32,Disp32>(@base,index, scale ?? ScaleFactor.S1, disp);

        [MethodImpl(Inline), Op]
        public static AsmOffsetOp<r64,Disp32> offset(r64 @base, r64 index, uint disp = default, MemoryScale? scale = null)
            => new AsmOffsetOp<r64,Disp32>(@base,index, scale ?? ScaleFactor.S1, disp);

        [Op]
        static ref JmpKind classify(AsmMnemonicCode src, out JmpKind kind)
        {
            kind = K.None;
            switch(src)
            {
                case C.JMP:
                    kind = K.JMP;
                    break;

                // case C.JB:
                //     kind = K.JA;
                //     break;

                // case C.JAE:
                //     kind = K.JAE;
                //     break;

                case C.JB:
                    kind = K.JB;
                    break;
                case C.JBE:
                    kind = K.JBE;
                    break;

                case C.JCXZ:
                    kind = K.JCXZ;
                    break;

                // case C.JE:
                //     kind = K.JE;
                //     break;
                // case C.JNE:
                //     kind = K.JNE;
                //     break;

                // case C.JG:
                //     kind = K.JG;
                //     break;
                // case C.JGE:
                //     kind = K.JGE;
                //     break;

                case C.JL:
                    kind = K.JL;
                    break;
                case C.JLE:
                    kind = K.JLE;
                    break;

                case C.JO:
                    kind = K.JO;
                    break;
                case C.JNO:
                    kind = K.JNO;
                    break;

                case C.JP:
                    kind= K.JP;
                    break;
                case C.JNP:
                    kind = K.JNP;
                    break;

                case C.JS:
                    kind= K.JS;
                    break;
                case C.JNS:
                    kind = K.JNS;

                    break;
                default:
                break;
            }
            return ref kind;
        }
    }
}