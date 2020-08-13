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
        public Instruction Instruction {get;}
        
        public MemoryAddress Base {get;}

        public MemoryAddress Source {get;}

        public AsmBranchTarget Target {get;}

        public MemoryAddress TargetOffset {get;}
        
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
        
        public AsmBranchInfo Zero 
            => Empty;

        [MethodImpl(Inline)]
        static uint Offset(MemoryAddress src, int inxsSize, MemoryAddress dst)
            => (uint)(dst - (src + inxsSize));


        [MethodImpl(Inline)]
        public AsmBranchInfo(in Instruction inxs, MemoryAddress @base, MemoryAddress src, in AsmBranchTarget target, uint offset)
        {            
            Instruction = inxs;
            Base = @base;
            Source = src;
            Target = target;
            TargetOffset = offset;
        }

        public string Render()
            => text.concat(Source.Format(), " + ",  TargetOffset.FormatMinimal(), " -> ",  (Source + TargetOffset).Format());

        public static AsmBranchInfo Empty 
            => new AsmBranchInfo(new Instruction(),MemoryAddress.Empty, 0, AsmBranchTarget.Empty, 0);
    }
}