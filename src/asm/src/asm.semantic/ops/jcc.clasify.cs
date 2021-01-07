//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmSemantic
    {
        [MethodImpl(Inline), Op]
        public static JccKind jccKind(IceMnemonic src)
            => classify(src, out JccKind _);

        [Op]
        public static ref JccKind classify(IceMnemonic src, out JccKind kind)
        {
            kind = JccKind.None;
            switch(src)
            {
                case IceMnemonic.Ja:
                    kind = JccKind.JA;
                    break;
                case IceMnemonic.Jae:
                    kind = JccKind.JAE;
                    break;
                case IceMnemonic.Jb:
                    kind = JccKind.JB;
                    break;
                case IceMnemonic.Jbe:
                    kind = JccKind.JE;
                    break;
                case IceMnemonic.Jcxz:
                    kind = JccKind.JCXZ;
                    break;
                case IceMnemonic.Je:
                    kind = JccKind.JE;
                    break;
                case IceMnemonic.Jg:
                    kind = JccKind.JG;
                    break;
                case IceMnemonic.Jge:
                    kind = JccKind.JGE;
                    break;
                case IceMnemonic.Jl:
                    kind = JccKind.JL;
                    break;
                case IceMnemonic.Jle:
                    kind = JccKind.JLE;
                    break;
                case IceMnemonic.Jmp:
                    kind = JccKind.JMP;
                    break;
                case IceMnemonic.Jne:
                    kind = JccKind.JNE;
                    break;
                case IceMnemonic.Jno:
                    kind = JccKind.JNO;
                    break;
                case IceMnemonic.Jnp:
                    kind = JccKind.JNP;
                    break;
                case IceMnemonic.Jns:
                    kind = JccKind.JNS;
                    break;
                case IceMnemonic.Jo:
                    kind = JccKind.JO;
                    break;
                case IceMnemonic.Jp:
                    kind= JccKind.JP;
                    break;
                default:
                break;
            }
            return ref kind;
        }
    }
}