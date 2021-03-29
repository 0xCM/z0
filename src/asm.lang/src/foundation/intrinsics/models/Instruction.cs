//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class IntelIntrinsics
    {
        public struct Instruction : ITextual
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

            public string Format()
                => string.Format("{0,-24} | {1}", string.Format("{0} {1}", name, form), xed);

            public override string ToString()
                => Format();

            public static Instruction Empty
                => new Instruction(EmptyString, EmptyString, EmptyString);
        }
    }
}