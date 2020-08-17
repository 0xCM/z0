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
    public readonly struct MemberAsmFx
    {
        public OpUri OpUri {get;}
    
        public BasedAsmFx[] Content {get;}

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
        
        public ref BasedAsmFx this[int i] 
        { 
            [MethodImpl(Inline)] 
            get => ref Content[i];
        }

        public MemberAsmFx Zero 
            => Empty;

        [MethodImpl(Inline)]        
        public MemberAsmFx(MemoryAddress hostaddr, BasedAsmFx[] located)
        {
            OpUri = located.Length != 0 ? located[0].OpUri : OpUri.Empty;
            Content = located;
            HostAddress = hostaddr;
            BaseAddress = located.Length != 0 ? located[0].BaseAddress : MemoryAddress.Empty;
        }

        public static MemberAsmFx Empty 
            => new MemberAsmFx(MemoryAddress.Empty, Array.Empty<BasedAsmFx>());
        
        [MethodImpl(Inline)]
        public static MemberAsmFx Create(MemoryAddress hostaddr, MemberCode uriCode, Instruction[] src)
            => new MemberAsmFx(hostaddr, BasedAsmFx.Many(uriCode, src.ToArray()));
    }
}