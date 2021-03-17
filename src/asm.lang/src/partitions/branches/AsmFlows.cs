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

    [ApiHost]
    public class AsmFlows : WfService<AsmFlows>
    {
        [MethodImpl(Inline), Op]
        public JmpKind EvalJmpKind(AsmMnemonicCode src)
            => EvalJmpKind(src, out JmpKind _);

        [Op]
        public ref JccCode EvalJccCode(JccKind src, out JccCode code)
        {
            code = 0;
            return ref code;
        }

        public bool IsJcc(AsmHexCode src)
        {
            return default;
        }

        [Op]
        ref JmpKind EvalJmpKind(AsmMnemonicCode src, out JmpKind kind)
        {
            kind = JmpKind.None;
            switch(src)
            {
                case JMP:
                    kind = JmpKind.JMP;
                    break;
                case JA:
                    kind = JmpKind.JA;
                    break;
                case JAE:
                    kind = JmpKind.JAE;
                    break;

                case JB:
                    kind = JmpKind.JB;
                    break;
                case JBE:
                    kind = JmpKind.JBE;
                    break;

                case JC:
                    kind = JmpKind.JC;
                    break;
                case JCXZ:
                    kind = JmpKind.JCXZ;
                    break;

                case JE:
                    kind = JmpKind.JE;
                    break;
                case JG:
                    kind = JmpKind.JG;
                    break;
                case JGE:
                    kind = JmpKind.JGE;
                    break;

                case JL:
                    kind = JmpKind.JL;
                    break;
                case JLE:
                    kind = JmpKind.JLE;
                    break;

                case JNC:
                    kind = JmpKind.JNC;
                    break;

                case JNB:
                    kind = JmpKind.JNB;
                    break;

                case JNBE:
                    kind = JmpKind.JNBE;
                    break;

                case JNG:
                    kind = JmpKind.JNG;
                    break;
                case JNGE:
                    kind = JmpKind.JNGE;
                    break;

                case JNA:
                    kind = JmpKind.JNA;
                    break;
                case JNAE:
                    kind = JmpKind.JNAE;
                    break;

                case JNL:
                    kind = JmpKind.JNL;
                    break;
                case JNLE:
                    kind = JmpKind.JNLE;
                    break;

                case JNE:
                    kind = JmpKind.JNE;
                    break;

                case JNZ:
                    kind= JmpKind.JNZ;
                    break;

                case JNO:
                    kind = JmpKind.JNO;
                    break;
                case JNP:
                    kind = JmpKind.JNP;
                    break;
                case JNS:
                    kind = JmpKind.JNS;
                    break;
                case JO:
                    kind = JmpKind.JO;
                    break;
                case JP:
                    kind= JmpKind.JP;
                    break;


                case JPE:
                    kind= JmpKind.JPE;
                    break;
                case JPO:
                    kind= JmpKind.JPO;
                    break;
                case JS:
                    kind= JmpKind.JS;
                    break;
                case JZ:
                    kind= JmpKind.JZ;
                    break;
                default:
                break;
            }
            return ref kind;
        }
    }
}