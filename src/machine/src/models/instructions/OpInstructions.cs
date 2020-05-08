//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    using static Seed;

    /// <summary>
    /// Collects a sequence of uri instructions that constitute the definition of a uri-identified operation
    /// </summary>         
    public readonly struct OpInstructions : IInstructions<OpInstructions, OpInstruction>, INullaryKnown
    {
        public static OpInstructions Empty => new OpInstructions(OpUri.Empty, Control.array<OpInstruction>());
        
        /// <summary>
        /// The operation uri
        /// </summary>
        public OpUri OpUri {get;}

        /// <summary>
        /// The instructions that define the operation
        /// </summary>
        public OpInstruction[] Instructions {get;}

        public MemoryAddress BaseAddress 
        {
            [MethodImpl(Inline)]
            get => this.Map(x => x.Instructions[0].BaseAddress);
        }

        [MethodImpl(Inline)]
        public static OpInstructions Create(OpUri id, OpInstruction[] src)
            => new OpInstructions(id,src);

        public int Count { [MethodImpl(Inline)] get => Instructions.Length; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Count == 0; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Count != 0; }

        public ref OpInstruction this[int i] { [MethodImpl(Inline)] get => ref Instructions[i];}

        [MethodImpl(Inline)]        
        public OpInstructions(OpUri uri, OpInstruction[] inxs)
        {
            OpUri = uri;
            Instructions = inxs;
        }
    }
}