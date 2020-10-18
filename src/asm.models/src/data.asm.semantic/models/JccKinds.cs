//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using K = JccKind;
    using I = IKinded<Asm.JccKind>;

    public readonly struct JccKinds
    {
        /// <summary> Jump if Above; CF=0 and ZF=0 </summary>
        public readonly struct JA : I { K I.Literal => K.JA; }

        public readonly struct JAE : I { K I.Literal => K.JAE; }

        /// <summary> Jump if Below; CF=1 </summary>
        public readonly struct JB  : I { K I.Literal => K.JB; }

        /// <summary> Jump if Below or Equal; CF=1 or ZF=1 </summary>
        public readonly struct JBE  : I { K I.Literal => K.JBE; }

        /// <summary> Jump if Carry; CF=1 </summary>
        public readonly struct JC  : I { K I.Literal => K.JA; }

        /// <summary> Jump if CX Zero; CX=0 </summary>
        public readonly struct JCXZ  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Equal; ZF=1 </summary>
        public readonly struct JE  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Greater (signed); ZF=0 and SF=OF </summary>
        public readonly struct JG  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Greater or Equal (signed); SF=OF </summary>
        public readonly struct JGE  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Less (signed); SF != OF </summary>
        public readonly struct JL  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Less or Equal (signed) ;ZF=1 or SF != OF </summary>
        public readonly struct JLE  : I { K I.Literal => K.JA; }

        /// <summary> Unconditional Jump; unconditional </summary>
        public readonly struct JMP  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Not Above; CF=1 or ZF=1 </summary>
        public readonly struct JNA  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Not Above or Equal; CF=1 </summary/>
        public readonly struct JNAE  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Not Below; CF=0 </summary/>
        public readonly struct JNB  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Not Below or Equal; CF=0 and ZF=0 </summary>
        public readonly struct JNBE  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Not Carry; CF=0 </summary/>
        public readonly struct JNC  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Not Equal; ZF=0 </summary/>
        public readonly struct JNE  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Not Greater (signed); ZF=1 or SF != OF </summary>
        public readonly struct JNG  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Not Greater or Equal (signed); SF != OF </summary>
        public readonly struct JNGE  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Not Less (signed); SF=OF </summary>
        public readonly struct JNL  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Not Less or Equal (signed); ZF=0 and SF=OF </summary>
        public readonly struct JNLE  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Not Overflow (signed); OF=0 </summary>
        public readonly struct JNO  : I { K I.Literal => K.JA; }

        /// <summary> Jump if No Parity; PF=0 </summary/>
        public readonly struct JNP  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Not Signed (signed); SF=0 </summary>
        public readonly struct JNS  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Not Zero; ZF=0 </summary>
        public readonly struct JNZ  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Overflow (signed); OF=1 </summary>
        public readonly struct JO  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Parity; PF=1 </summary>
        public readonly struct JP  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Parity Even; PF=1 </summary>
        public readonly struct JPE  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Parity Odd; PF=0 </summary>
        public readonly struct JPO  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Signed (signed); SF=1 </summary>
        public readonly struct JS  : I { K I.Literal => K.JA; }

        /// <summary> Jump if Zero; ZF=1 </summary>
        public readonly struct JZ  : I { K I.Literal => K.JA; }

    }
}