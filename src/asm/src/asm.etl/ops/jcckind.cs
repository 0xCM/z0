//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using M = AsmMnemonicCode;

    partial struct AsmEtl
    {
        [Op]
        public static JccKind jcckind(M src)
        {
            var kind = JccKind.None;
            switch(src)
            {
                case M.JA:
                    kind = JccKind.JA;
                    break;
                case M.JAE:
                    kind = JccKind.JAE;
                    break;
                case M.JB:
                    kind = JccKind.JB;
                    break;
                case M.JBE:
                    kind = JccKind.JE;
                    break;
                case M.JCXZ:
                    kind = JccKind.JCXZ;
                    break;
                case M.JE:
                    kind = JccKind.JE;
                    break;
                case M.JG:
                    kind = JccKind.JG;
                    break;
                case M.JGE:
                    kind = JccKind.JGE;
                    break;
                case M.JL:
                    kind = JccKind.JL;
                    break;
                case M.JLE:
                    kind = JccKind.JLE;
                    break;
                case M.JMP:
                    kind = JccKind.JMP;
                    break;
                case M.JNE:
                    kind = JccKind.JNE;
                    break;
                case M.JNO:
                    kind = JccKind.JNO;
                    break;
                case M.JNP:
                    kind = JccKind.JNP;
                    break;
                case M.JNS:
                    kind = JccKind.JNS;
                    break;
                case M.JO:
                    kind = JccKind.JO;
                    break;
                case M.JP:
                    kind= JccKind.JP;
                    break;
                default:
                    break;
            }
            return kind;
        }
    }
}