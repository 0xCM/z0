//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    /// <summary>
    /// Describes a branching instruction operand
    /// </summary>
    public readonly struct AsmBranchInfo : INullaryKnown, INullary<AsmBranchInfo>, IRender
    {
        public static AsmBranchInfo Empty => new AsmBranchInfo(MemoryAddress.Empty, MemoryAddress.Empty, AsmBranchTarget.Empty);
        
        public MemoryAddress Base {get;}

        public MemoryAddress IP {get;}

        public AsmBranchTarget Target {get;}

        public MemoryAddress Source => IP - Base;

        public bool IsEmpty { [MethodImpl(Inline)] get => Base == 0 && IP == 0; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => !IsEmpty; }

        public bool IsNear => Target.IsNear;

        public AsmBranchInfo Zero => Empty;

        [MethodImpl(Inline)]
        public static AsmBranchInfo Define(MemoryAddress @base, MemoryAddress ip, AsmBranchTarget target)
            => new AsmBranchInfo(@base, ip, target);

        [MethodImpl(Inline)]
        AsmBranchInfo(MemoryAddress @base, MemoryAddress ip, AsmBranchTarget target)
        {            
            Base = @base;
            IP = ip;
            Target = target;
        }

        static string Arrow<S,T>(S src, T dst)
            where T : ITextual
            where S : ITextual
            => text.concat(src.Format(), " -> ", dst.Format());

        public string Render()
        {
            var dst = Target.Address > Base ? Target.Address - Base : Base - Target.Address;
            var expr = (dst < ushort.MaxValue) ? Arrow(Source,dst) : Arrow(IP,Target);
            return expr;        
        }

    }
}