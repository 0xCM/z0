//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOperands;

    public abstract class AsmMachine<M>
        where M : AsmMachine<M>, new()
    {


    }


    public readonly partial struct AsmMachines
    {



        public sealed class CmpMachine : AsmMachine<CmpMachine>
        {


            /// <summary>
            /// 3C ib
            /// </summary>
            public void cmp(al a, imm8 imm)
            {

            }

            /// <summary>
            /// 3D iw
            /// </summary>
            public void cmp(ax a, imm16 imm)
            {

            }

            /// <summary>
            /// 3D iw
            /// </summary>
            public void cmp(eax a, imm32 imm)
            {

            }

            /// <summary>
            /// REX.W + 3D id
            /// </summary>
            public void cmp(rax a, imm32 imm)
            {

            }

            /// <summary>
            /// 80 /7 ib
            /// </summary>
            public void cmp(r8b a, imm8 imm)
            {

            }

            /// <summary>
            /// 80 /7 ib || REX + 80 /7 ib
            /// </summary>
            public void cmp(m8 a, imm8 imm)
            {

            }

            /// <summary>
            /// 81 /7 iw
            /// </summary>
            public void cmp(r16 a, imm16 imm)
            {

            }

            /// <summary>
            /// 81 /7 iw
            /// </summary>
            public void cmp(m16 a, imm16 imm)
            {

            }

            /// <summary>
            /// 81 /7 id
            /// </summary>
            public void cmp(r32 a, imm32 imm)
            {

            }

            /// <summary>
            /// 81 /7 id
            /// </summary>
            public void cmp(m32 a, imm32 imm)
            {

            }

            /// <summary>
            /// REX.W + 81 /7 id
            /// </summary>
            public void cmp(r64 a, imm32 imm)
            {

            }

            /// <summary>
            /// REX.W + 81 /7 id
            /// </summary>
            public void cmp(m64 a, imm32 imm)
            {

            }

            /// <summary>
            /// 83 /7 ib
            /// </summary>
            public void cmp(r16 a, imm8 imm)
            {

            }

            /// <summary>
            /// 83 /7 ib
            /// </summary>
            public void cmp(m16 a, imm8 imm)
            {

            }


            /// <summary>
            /// 83 /7 ib
            /// </summary>
            public void cmp(r32 a, imm8 imm)
            {

            }

            /// <summary>
            /// 83 /7 ib
            /// </summary>
            public void cmp(m32 a, imm8 imm)
            {

            }

            /// <summary>
            /// REX.W + 83 /7 ib
            /// </summary>
            public void cmp(r64 a, imm8 imm)
            {

            }

            /// <summary>
            /// REX.W + 83 /7 ib
            /// </summary>
            public void cmp(m64 a, imm8 imm)
            {

            }

            /// <summary>
            /// 38 /r || REX + 38 /r
            /// </summary>
            public void cmp(r8 a, r8 b)
            {

            }

            /// <summary>
            /// 38 /r || REX + 38 /r
            /// </summary>
            public void cmp(m8 a, r8 b)
            {

            }


            /// <summary>
            /// 39 /r
            /// </summary>
            public void cmp(r16 a, r16 b)
            {

            }

            /// <summary>
            /// 39 /r
            /// </summary>
            public void cmp(m16 a, r16 b)
            {

            }

            /// <summary>
            /// 39 /r
            /// </summary>
            public void cmp(r32 a, r32 b)
            {

            }

            /// <summary>
            /// 39 /r
            /// </summary>
            public void cmp(m32 a, r32 b)
            {

            }


            /// <summary>
            /// REX.W + 39 /r
            /// </summary>
            public void cmp(r64 a, r64 b)
            {

            }

            /// <summary>
            /// REX.W + 39 /r
            /// </summary>
            public void cmp(m64 a, r64 b)
            {

            }

            /// <summary>
            /// 3A /r || REX + 3A /r
            /// </summary>
            public void cmp(r8 a, m8 b)
            {

            }

            /// <summary>
            /// 3B /r
            /// </summary>
            public void cmp(r16 a, m16 b)
            {

            }

            /// <summary>
            /// 3B /r
            /// </summary>
            public void cmp(r32 a, m32 b)
            {

            }

            /// <summary>
            /// REX.W + 3B /r
            /// </summary>
            public void cmp(r64 a, m64 b)
            {

            }

        }
    }
}