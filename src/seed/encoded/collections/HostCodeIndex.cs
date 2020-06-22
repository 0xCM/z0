//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Collects code derived from members declared by a specific operation host
    /// </summary>
    public readonly struct HostCodeIndex
    {
        /// <summary>
        /// The owning part
        /// </summary>
        public ApiHostUri Id {get;}

        /// <summary>
        /// The host-owned code
        /// </summary>
        public MemberCode[] Code {get;}       

        public MemberCode this[int index]  
        {
             [MethodImpl(Inline)] 
             get => Code[index]; 
        }

        /// <summary>
        /// The number of collected functions
        /// </summary>
        public int Length 
        { 
            [MethodImpl(Inline)] 
            get => Code.Length;
        }

        [MethodImpl(Inline)]
        public static implicit operator HostCodeIndex((ApiHostUri part, MemberCode[] code) src)
            => new HostCodeIndex(src.part, src.code);
        
        [MethodImpl(Inline)]
        public HostCodeIndex(ApiHostUri id, MemberCode[] code)
        {
            Id = id;
            Code = code.OrderBy(x => x.Address);
        }

        public static HostCodeIndex Empty 
            => new HostCodeIndex(ApiHostUri.Empty, Array.Empty<MemberCode>());
    }
}