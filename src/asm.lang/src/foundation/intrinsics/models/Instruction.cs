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
            {
                var inst = string.Format("Instruction: {0} {1}\r\n", name, form);
                var iform = string.Format("# Iform: {0}", xed);
                return inst + iform;
            }

            public override string ToString()
                => Format();

            public static Instruction Empty
                => new Instruction(EmptyString, EmptyString, EmptyString);
        }
    }
}