//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public partial struct IntelIntrinsicsModel
    {
        /// <summary>
        /// [instruction name="ADCX" form="r32, r32" xed="ADCX_GPR32d_GPR32d"
        /// </summary>
        public struct Instruction
        {
            public const string ElementName = "instruction";

            public string name;

            public string form;

            public string xed;

            [MethodImpl(Inline)]
            public Instruction(string name, string form, string xed)
            {
                this.name = name;
                this.form = form;
                this.xed = xed;
            }

            public static Instruction Empty
                => new Instruction(EmptyString, EmptyString, EmptyString);
        }
    }
}