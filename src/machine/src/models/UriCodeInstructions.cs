//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Seed;

    /// <summary>
    /// Defines an *unbased* sequence of instructions
    /// </summary>         
    public readonly struct UriCodeInstructions : IIndex<UriCodeInstruction> 
    {
        public static UriCodeInstructions Empty => Create(Control.array<UriCodeInstruction>());
        
        readonly UriCodeInstruction[] Inxs;

        [MethodImpl(Inline)]
        public static UriCodeInstructions Create(UriCodeInstruction[] src)
            => new UriCodeInstructions(src);
        
        public ref UriCodeInstruction this[int index]  { [MethodImpl(Inline)] get => ref Inxs[index]; }
        
        public int Length { [MethodImpl(Inline)] get => Inxs.Length; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Length == 0; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Length != 0; }

        public static implicit operator UriCodeInstruction[](UriCodeInstructions src)
            => src.Inxs;

        [MethodImpl(Inline)]        
        public static implicit operator UriCodeInstructions (UriCodeInstruction[] src)
            => new UriCodeInstructions(src);

        [MethodImpl(Inline)]        
        public static implicit operator UriCodeInstructions (List<UriCodeInstruction> src)
            => new UriCodeInstructions(src.ToArray());

        [MethodImpl(Inline)]        
        public UriCodeInstructions(UriCodeInstruction[] src)
        {
            Inxs = src;
        }
    }
}