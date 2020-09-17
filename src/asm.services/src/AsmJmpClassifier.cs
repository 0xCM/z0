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

    public struct AsmJmpClassifier : IAsmHandler<AsmJmpClassifier>
    {
        public Outcome<JmpKind> Result;

        public void Handle<T>(in T src)
            where T : struct, IAsmInstruction<T>
        {
            var kind = JmpKind.None;

            switch(src.Mnemonic)
            {
                case Mnemonic.Ja:
                    Result = JmpKind.JA;
                    break;
                case Mnemonic.Jae:
                    Result = JmpKind.JAE;
                    break;
                case Mnemonic.Jb:
                    Result = JmpKind.JB;
                    break;
                case Mnemonic.Jbe:
                    Result = JmpKind.JE;
                    break;
                case Mnemonic.Jcxz:
                    Result = JmpKind.JCXZ;
                    break;
                case Mnemonic.Je:
                    Result = JmpKind.JE;
                    break;
                case Mnemonic.Jg:
                    Result = JmpKind.JG;
                    break;
                case Mnemonic.Jge:
                    Result = JmpKind.JGE;
                    break;
                case Mnemonic.Jl:
                    Result = JmpKind.JL;
                    break;
                case Mnemonic.Jle:
                    Result = JmpKind.JLE;
                    break;
                case Mnemonic.Jmp:
                    Result = JmpKind.JMP;
                    break;
                case Mnemonic.Jne:
                    Result = JmpKind.JNE;
                    break;
                case Mnemonic.Jno:
                    Result = JmpKind.JNO;
                    break;
                case Mnemonic.Jnp:
                    Result = JmpKind.JNP;
                    break;
                case Mnemonic.Jns:
                    Result = JmpKind.JNS;
                    break;
                case Mnemonic.Jo:
                    Result = JmpKind.JO;
                    break;
                case Mnemonic.Jp:
                    Result= JmpKind.JP;
                    break;
                default:
                    Result = z.fail<JmpKind>(text.format("{0} unanticipated", src.Mnemonic));
                break;
            }
        }
    }
}