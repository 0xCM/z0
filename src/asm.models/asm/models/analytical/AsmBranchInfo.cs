//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    /// <summary>
    /// Describes a branching instruction operand
    /// </summary>
    public readonly struct AsmBranchInfo
    {        
        public readonly Instruction Instruction {get;}
        
        public readonly MemoryAddress Base;

        public readonly MemoryAddress Source;

        public readonly AsmBranchTarget Target;

        public readonly MemoryAddress TargetOffset;
        
        public bool IsEmpty 
        { 
            [MethodImpl(Inline)] 
            get => Base == 0 && Source == 0; 
        }

        public bool IsNonEmpty 
        { 
            [MethodImpl(Inline)] 
            get => !IsEmpty; 
        }

        public bool IsNear 
            => Target.IsNear;
        

        [MethodImpl(Inline)]
        public AsmBranchInfo(in Instruction fx, MemoryAddress @base, MemoryAddress src, in AsmBranchTarget target, uint offset)
        {            
            Instruction = fx;
            Base = @base;
            Source = src;
            Target = target;
            TargetOffset = offset;
        }

        public static AsmBranchInfo Empty 
            => new AsmBranchInfo(new Instruction(), 0, 0, AsmBranchTarget.Empty, 0);
    }
}