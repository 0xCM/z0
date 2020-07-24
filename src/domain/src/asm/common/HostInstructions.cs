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
    /// Collects a sequence of operation instuction sequences from host-defined members
    /// </summary>         
    public readonly struct HostInstructions : IContentedIndex<MemberInstructions>
    {
        /// <summary>
        /// The decoded instructions
        /// </summary>
        public MemberInstructions[] Content {get;}

        /// <summary>
        /// The defining host
        /// </summary>
        public ApiHostUri Host {get;}

        /// <summary>
        /// The base address of the first member, where members are ordered by their individual base addresses
        /// </summary>
        public MemoryAddress BaseAddress {get;}

        /// <summary>
        /// The number of host-defined operations
        /// </summary>
        public int MemberCount => Content.Length;

        /// <summary>
        /// The member instruction content length
        /// </summary>
        public int Length { [MethodImpl(Inline)] get => Content.Length; }
        
        /// <summary>
        /// Indexes into the member instruction content
        /// </summary>
        public ref MemberInstructions this[int index] { [MethodImpl(Inline)] get => ref Content[index];}

        /// <summary>
        /// The total instruction count
        /// </summary>
        public int TotalCount => Content.Sum(i => i.TotalCount);

        [MethodImpl(Inline)]
        public static HostInstructions Create(ApiHostUri host, MemberInstructions[] src)
            => new HostInstructions(host, src);
    
        [MethodImpl(Inline)]        
        public HostInstructions(ApiHostUri host, MemberInstructions[] inxs)
        {
            Host = host;
            Content = inxs.OrderBy(x => x.BaseAddress).ToArray();
            BaseAddress = Content.Length != 0 ? Content[0].BaseAddress : MemoryAddress.Empty;
        }

        public static HostInstructions Empty 
            => new HostInstructions(ApiHostUri.Empty, sys.empty<MemberInstructions>());
    }
}