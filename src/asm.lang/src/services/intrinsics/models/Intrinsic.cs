//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    partial struct IntelIntrinsicsModel
    {
        public const string IntrinsicElement = "intrinsic";

        /// <summary>
        /// [intrinsic tech="Other" name="_addcarryx_u32">]
        /// </summary>
        public struct Intrinsic
        {
            public static Intrinsic create()
            {
                var dst = default(Intrinsic);
                dst.tech = EmptyString;
                dst.name = EmptyString;
                dst.content = EmptyString;
                dst.types = root.list<InstructionType>();
                dst.CPUID = EmptyString;
                dst.category = EmptyString;
                dst.@return = Return.Empty;
                dst.parameters = root.list<Parameter>();
                dst.description = EmptyString;
                dst.operation = new Operation(root.list<TextLine>());
                dst.instructions = root.list<Instruction>();
                dst.header = EmptyString;
                return dst;
            }

            public string tech;

            public string name;

            public string content;

            public List<InstructionType> types;

            public CpuId CPUID;

            public Category category;

            public Return @return;

            public List<Parameter> parameters;

            public Description description;

            public Operation operation;

            public List<Instruction> instructions;

            public Header header;
        }
    }
}