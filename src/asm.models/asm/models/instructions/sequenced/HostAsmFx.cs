//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    using static Konst;

    /// <summary>
    /// Collects sequences of instructions from host-defined members
    /// </summary>         
    public readonly struct HostAsmFx
    {
        /// <summary>
        /// The decoded instructions
        /// </summary>
        public MemberAsmFx[] Data {get;}

        /// <summary>
        /// The defining host
        /// </summary>
        public ApiHostUri Host {get;}

        /// <summary>
        /// The base address of the first member, where members are ordered by their individual base addresses
        /// </summary>
        public MemoryAddress BaseAddress {get;}
    
        [MethodImpl(Inline)]        
        public HostAsmFx(ApiHostUri host, MemberAsmFx[] src)
        {
            Host = host;
            Data = src.OrderBy(x => x.BaseAddress).ToArray();
            BaseAddress = Data.Length != 0 ? Data[0].BaseAddress : MemoryAddress.Empty;
        }

        /// <summary>
        /// The number of host-defined operations
        /// </summary>
        public int MemberCount 
            => Data.Length;

        /// <summary>
        /// The member instruction content length
        /// </summary>
        public int Length 
        { 
            [MethodImpl(Inline)] 
            get => Data.Length; 
        }
        
        /// <summary>
        /// Indexes into the member instruction content
        /// </summary>
        public ref MemberAsmFx this[int index] 
        { 
            [MethodImpl(Inline)]
             get => ref Data[index];
        }

        /// <summary>
        /// The total instruction count
        /// </summary>
        public int TotalCount 
            => Data.Sum(i => i.TotalCount);        
    }
}