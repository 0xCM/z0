//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static OpKind;

    partial struct SemanticRender 
    {
        public static string Render(AsmOperandInfo src)
        {            
            switch(src.Kind)
            {
                case OpKind.Register:
                    return Render(src.Register);
                case MemorySegSI:
                case MemorySegESI:
                case MemorySegRSI:
                case MemorySegDI:
                case MemorySegEDI:
                case MemorySegRDI:
                case MemoryESDI:
                case MemoryESEDI:
                case MemoryESRDI:
                case Memory64:
                case OpKind.Memory:
                    return Render(src.Memory);
                case NearBranch16:
                case NearBranch32:
                case NearBranch64:
                case FarBranch16:
                case FarBranch32:
                    return Render(src.Branch);
                case Immediate8:
                case Immediate8_2nd:
                case Immediate16:
                case Immediate32:
                case Immediate64:
                case Immediate8to16:
                case Immediate8to32:
                case Immediate8to64:
                case Immediate32to64:
                    return Render(src.ImmInfo);
                default:
                    return Unknown;
            }            
        }
    }
}