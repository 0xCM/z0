//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmMnemonicCode;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static JccKind jcckind(AsmMnemonicCode src)
            => jcckind(src, out JccKind _);

        [Op]
        public static ref JccKind jcckind(AsmMnemonicCode src, out JccKind kind)
        {
            kind = JccKind.None;
            switch(src)
            {
                case JA:
                    kind = JccKind.JA;
                    break;
                case JAE:
                    kind = JccKind.JAE;
                    break;
                case JB:
                    kind = JccKind.JB;
                    break;
                case JBE:
                    kind = JccKind.JE;
                    break;
                case JCXZ:
                    kind = JccKind.JCXZ;
                    break;
                case JE:
                    kind = JccKind.JE;
                    break;
                case JG:
                    kind = JccKind.JG;
                    break;
                case JGE:
                    kind = JccKind.JGE;
                    break;
                case JL:
                    kind = JccKind.JL;
                    break;
                case JLE:
                    kind = JccKind.JLE;
                    break;
                case JMP:
                    kind = JccKind.JMP;
                    break;
                case JNE:
                    kind = JccKind.JNE;
                    break;
                case JNO:
                    kind = JccKind.JNO;
                    break;
                case JNP:
                    kind = JccKind.JNP;
                    break;
                case JNS:
                    kind = JccKind.JNS;
                    break;
                case JO:
                    kind = JccKind.JO;
                    break;
                case JP:
                    kind= JccKind.JP;
                    break;
                default:
                break;
            }
            return ref kind;
        }
    }
}