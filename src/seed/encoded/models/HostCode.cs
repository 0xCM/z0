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
    public readonly struct HostCode
    {
        /// <summary>
        /// The owning part
        /// </summary>
        public ApiHostUri Id {get;}

        /// <summary>
        /// The host-owned code
        /// </summary>
        public UriCode[] Code {get;}       

        public UriCode this[int index]  
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
        public static implicit operator HostCode((ApiHostUri part, UriCode[] code) src)
            => new HostCode(src.part, src.code);
        
        [MethodImpl(Inline)]
        public HostCode(ApiHostUri id, UriCode[] code)
        {
            Id = id;
            Code = code.OrderBy(x => x.Address);
        }

        public static HostCode Empty 
            => new HostCode(ApiHostUri.Empty, Array.Empty<UriCode>());
    }
}