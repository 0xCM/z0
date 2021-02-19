//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    public struct IntelIntrinsicsDoc
    {
        public const string InstructionElement = "instruction";

        public const string InstructionTypeElement = "type";

        public const string CpuIdElement = "CPUID";

        public const string ParameterElement = "parameter";

        public const string ReturnElement = "return";

        public const string IntrinsicElement = "intrinsic";

        public const string DescriptionElement = "description";

        public const string OperationElement = "operation";

        public const string CategoryElement = "category";

        public struct InstructionType
        {
            public string Content;
        }

        public struct CpuId
        {
            public string Content;
        }

        public struct Category
        {
            public string Content;
        }

        /// <summary>
        /// [parameter type="unsigned char" varname="c_in" etype="UI8"]
        /// </summary>
        public struct Parameter
        {
            public string varname;

            public string type;

            public string etype;

            public string memwidth;
        }

        /// <summary>
        /// [return type="unsigned char" varname="c_in" etype="UI8"]
        /// </summary>
        public struct Return
        {
            public string varname;

            public string type;

            public string etype;

            public string memwidth;
        }

        /// <summary>
        /// [instruction name="ADCX" form="r32, r32" xed="ADCX_GPR32d_GPR32d"
        /// </summary>
        public struct instruction
        {
            public instruction(string name, string form, string xed)
            {
                this.name = name;
                this.form = form;
                this.xed = xed;
                this.attributes = new List<string>();
            }

            public string name;

            public string form;

            public string xed;

            public List<string> attributes;

            public static instruction Empty
                => new instruction(EmptyString, EmptyString, EmptyString);
        }

        public struct Operation
        {
            public string Content;
        }

        public struct Description
        {
            public string Content;
        }

        /// <summary>
        /// [intrinsic tech="Other" name="_addcarryx_u32">]
        /// </summary>
        public struct intrinsic
        {
            public static intrinsic init(string content)
            {
                var x = default(intrinsic);
                x.content = content;
                x.types = root.list<InstructionType>();
                x.parameters = root.list<Parameter>();
                x.instructions = root.list<instruction>();
                return x;
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

            public List<instruction> instructions;

            public string identifier
            {
                get
                {
                    var instruction = instructions.ToArray().TryGetFirst().ValueOrDefault(IntelIntrinsicsDoc.instruction.Empty);
                    return text.ifempty(instruction.name, name);
                }
            }
        }

        public struct intrinsics
        {
            public intrinsic[] entries;
        }
   }
}