//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;

    /// <summary>
    /// Pairs a uri host with owned code
    /// </summary>
    public readonly struct HostCode
    {
        public static HostCode Empty => new HostCode(ApiHostUri.Empty, Control.array<UriCode>());

        /// <summary>
        /// The owning part
        /// </summary>
        public ApiHostUri Id {get;}

        /// <summary>
        /// The part-owned code
        /// </summary>
        public UriCode[] Code {get;}       

        [MethodImpl(Inline)]
        public static HostCode Define(ApiHostUri host, UriCode[] code)
            => new HostCode(host, code);

        [MethodImpl(Inline)]
        public static implicit operator HostCode((ApiHostUri part, UriCode[] code) src)
            => new HostCode(src.part, src.code);
        
        [MethodImpl(Inline)]
        public HostCode(ApiHostUri id, UriCode[] code)
        {
            this.Id = id;
            this.Code = code;
        }
    }
}