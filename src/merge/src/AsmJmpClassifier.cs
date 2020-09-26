//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using Z0.Asm;

    public struct AsmJmpClassifier
    {
        public Outcome<JmpKind> Result;

        public static Outcome<JmpKind> classify(Mnemonic src)
        {
            Outcome<JmpKind> kind = default;

            switch(src)
            {
                case Mnemonic.Ja:
                    kind = JmpKind.JA;
                    break;
                case Mnemonic.Jae:
                    kind = JmpKind.JAE;
                    break;
                case Mnemonic.Jb:
                    kind = JmpKind.JB;
                    break;
                case Mnemonic.Jbe:
                    kind = JmpKind.JE;
                    break;
                case Mnemonic.Jcxz:
                    kind = JmpKind.JCXZ;
                    break;
                case Mnemonic.Je:
                    kind = JmpKind.JE;
                    break;
                case Mnemonic.Jg:
                    kind = JmpKind.JG;
                    break;
                case Mnemonic.Jge:
                    kind = JmpKind.JGE;
                    break;
                case Mnemonic.Jl:
                    kind = JmpKind.JL;
                    break;
                case Mnemonic.Jle:
                    kind = JmpKind.JLE;
                    break;
                case Mnemonic.Jmp:
                    kind = JmpKind.JMP;
                    break;
                case Mnemonic.Jne:
                    kind = JmpKind.JNE;
                    break;
                case Mnemonic.Jno:
                    kind = JmpKind.JNO;
                    break;
                case Mnemonic.Jnp:
                    kind = JmpKind.JNP;
                    break;
                case Mnemonic.Jns:
                    kind = JmpKind.JNS;
                    break;
                case Mnemonic.Jo:
                    kind = JmpKind.JO;
                    break;
                case Mnemonic.Jp:
                    kind= JmpKind.JP;
                    break;
                default:
                    kind = z.fail<JmpKind>(text.format("{0} unanticipated", src));
                break;
            }
            return kind;
        }
    }
}