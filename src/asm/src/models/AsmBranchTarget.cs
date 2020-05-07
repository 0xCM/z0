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
        public MemoryAddress Address {get;}
        
        /// <summary>
        /// Specifies a branch target selector, if far
        /// </summary>
        public ushort Selector {get;}

        public bool IsEmpty => Address == 0;

        public AsmBranchTarget Zero => Empty;   

        public bool IsNear => Kind == BranchTargetKind.Near;    

        public bool IsFar => Kind == BranchTargetKind.Far;    
        
        [MethodImpl(Inline)]
        public AsmBranchTarget(BranchTargetKind kind, BranchTargetSize size, ulong address, ushort selector = 0)
        {
            Kind = kind;
            Size = size;
            Address = address;
            Selector = selector;
        }

        public string Format()
        {
            var kindLabel = Kind == BranchTargetKind.Near ? "near" : Selector.FormatHex();
            var selector = IsFar ? text.concat(Chars.Space, Chars.LBracket, Selector.FormatAsmHex(), Chars.LBracket) : string.Empty;
            return text.concat(Address.Format(), selector);
        }
    }
}