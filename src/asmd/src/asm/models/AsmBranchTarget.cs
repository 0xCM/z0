//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AsmBranchTarget : INullaryKnown, INullary<AsmBranchTarget>, ITextual
    {
        public static AsmBranchTarget Empty => new AsmBranchTarget(BranchTargetKind.None, BranchTargetSize.None, 0, 0);

        [MethodImpl(Inline)]
        public static AsmBranchTarget Define(BranchTargetKind kind, BranchTargetSize size, MemoryAddress address, ushort selector = 0)
            => new AsmBranchTarget(kind,size,address,selector);

        /// <summary>
        /// The target classifier, near or far
        /// </summary>
        public BranchTargetKind Kind {get;}

        /// <summary>
        /// The target size
        /// </summary>
        public BranchTargetSize Size {get;}

        /// <summary>
        /// The target address
        /// </summary>
        public MemoryAddress TargetAddress {get;}
        
        /// <summary>
        /// Specifies a branch target selector, if far
        /// </summary>
        public ushort Selector {get;}

        public bool IsEmpty 
            => TargetAddress == 0;

        public AsmBranchTarget Zero => Empty;   

        public bool IsNear 
            => Kind == BranchTargetKind.Near;    

        public bool IsFar 
            => Kind == BranchTargetKind.Far;    
        
        public string Label => Kind.Format(Size);

        [MethodImpl(Inline)]
        public AsmBranchTarget(BranchTargetKind kind, BranchTargetSize size, MemoryAddress address, ushort selector = 0)
        {
            Kind = kind;
            Size = size;
            TargetAddress = address;
            Selector = selector;
        }

        public string Format()
        {
            var address = TargetAddress.FormatMinimal();
            return Label + (IsNear 
                ? text.bracket(address)
                : text.bracket(text.concat(address, Chars.Colon, Selector.FormatAsmHex())));                    
        }

    }
}