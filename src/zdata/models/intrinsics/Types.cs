//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Text;

    using static z;

    public struct IntrinsicsDocument
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
        public struct Instruction
        {
            public string name;

            public string form;            
            
            public string xed;            
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
                x.types = list<InstructionType>();
                x.parameters = list<Parameter>();
                x.instructions = list<Instruction>();
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

            public List<Instruction> instructions;        

            public string Format()
            {
                var dst = text.build();
                dst.AppendLine(operation.Content);
                return dst.ToString();
            }
        }   

        public struct intrinsics
        {            
            public intrinsic[] entries;
        }
   }
}