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
        public Outcome<JccKind> Result;

        public static Outcome<JccKind> classify(Mnemonic src)
        {
            Outcome<JccKind> kind = default;

            switch(src)
            {
                case Mnemonic.Ja:
                    kind = JccKind.JA;
                    break;
                case Mnemonic.Jae:
                    kind = JccKind.JAE;
                    break;
                case Mnemonic.Jb:
                    kind = JccKind.JB;
                    break;
                case Mnemonic.Jbe:
                    kind = JccKind.JE;
                    break;
                case Mnemonic.Jcxz:
                    kind = JccKind.JCXZ;
                    break;
                case Mnemonic.Je:
                    kind = JccKind.JE;
                    break;
                case Mnemonic.Jg:
                    kind = JccKind.JG;
                    break;
                case Mnemonic.Jge:
                    kind = JccKind.JGE;
                    break;
                case Mnemonic.Jl:
                    kind = JccKind.JL;
                    break;
                case Mnemonic.Jle:
                    kind = JccKind.JLE;
                    break;
                case Mnemonic.Jmp:
                    kind = JccKind.JMP;
                    break;
                case Mnemonic.Jne:
                    kind = JccKind.JNE;
                    break;
                case Mnemonic.Jno:
                    kind = JccKind.JNO;
                    break;
                case Mnemonic.Jnp:
                    kind = JccKind.JNP;
                    break;
                case Mnemonic.Jns:
                    kind = JccKind.JNS;
                    break;
                case Mnemonic.Jo:
                    kind = JccKind.JO;
                    break;
                case Mnemonic.Jp:
                    kind= JccKind.JP;
                    break;
                default:
                    kind = z.fail<JccKind>(text.format("{0} unanticipated", src));
                break;
            }
            return kind;
        }
    }
}