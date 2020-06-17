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
    public readonly struct AsmBranchInfo : INullaryKnown, INullary<AsmBranchInfo>, IRender
    {
        public static AsmBranchInfo Empty 
            => new AsmBranchInfo(new Instruction(),MemoryAddress.Empty, 0, AsmBranchTarget.Empty, 0);
        
        public Instruction Instruction {get;}
        
        public MemoryAddress Base {get;}

        public MemoryAddress Source {get;}

        public AsmBranchTarget Target {get;}

        public MemoryAddress TargetOffset {get;}
        
        public bool IsEmpty { [MethodImpl(Inline)] get => Base == 0 && Source == 0; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => !IsEmpty; }

        public bool IsNear => Target.IsNear;

        public AsmBranchInfo Zero => Empty;

        [MethodImpl(Inline)]
        static uint Offset(MemoryAddress src, int inxsSize, MemoryAddress dst)
            => (uint)(dst - (src + inxsSize));

        [MethodImpl(Inline)]
        public static AsmBranchInfo Define(MemoryAddress @base, Instruction inxs, AsmBranchTarget target)
            => new AsmBranchInfo(inxs, @base, inxs.IP, target, Offset(inxs.IP, inxs.ByteLength, target.TargetAddress));

        [MethodImpl(Inline)]
        AsmBranchInfo(Instruction inxs, MemoryAddress @base, MemoryAddress src, AsmBranchTarget target, uint offset)
        {            
            Instruction = inxs;
            Base = @base;
            Source = src;
            Target = target;
            TargetOffset = offset;
        }

        public string Render()
            => text.concat(Source.Format(), " + ",  TargetOffset.FormatMinimal(), " -> ",  (Source + TargetOffset).Format());
    }
}