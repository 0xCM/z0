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
    
    using static Konst;

    /// <summary>
    /// Groups a sequence of located instructions
    /// </summary>         
    public readonly struct MemberInstructions
    {
        public OpUri OpUri {get;}
    
        public LocatedInstruction[] Content {get;}

        public MemoryAddress BaseAddress {get;}
        
        public MemoryAddress HostAddress {get;}

        public MemoryOffset OffsetAddress 
            => MemoryOffsets.offset(BaseAddress, HostAddress);

        public OpIdentity OpId => OpUri.OpId;

        public int TotalCount 
        { 
            [MethodImpl(Inline)] 
            get => Content.Length; 
        }

        public bool IsEmpty 
        { 
            [MethodImpl(Inline)] 
            get => TotalCount == 0; 
        }

        public bool IsNonEmpty 
        { 
            [MethodImpl(Inline)] 
            get => TotalCount != 0; 
        }

        public int Length         
        { 
            [MethodImpl(Inline)] 
            get => Content.Length;
        }
        
        public ref LocatedInstruction this[int i] 
        { 
            [MethodImpl(Inline)] 
            get => ref Content[i];
        }

        public MemberInstructions Zero 
            => Empty;

        [MethodImpl(Inline)]        
        public MemberInstructions(MemoryAddress hostaddr, LocatedInstruction[] located)
        {
            OpUri = located.Length != 0 ? located[0].OpUri : OpUri.Empty;
            Content = located;
            HostAddress = hostaddr;
            BaseAddress = located.Length != 0 ? located[0].BaseAddress : MemoryAddress.Empty;
        }

        public static MemberInstructions Empty 
            => new MemberInstructions(MemoryAddress.Empty, Array.Empty<LocatedInstruction>());
        
        [MethodImpl(Inline)]
        public static MemberInstructions Create(MemoryAddress hostaddr, MemberCode uriCode, Instruction[] src)
            => new MemberInstructions(hostaddr, LocatedInstruction.Many(uriCode, src.ToArray()));
    }
}