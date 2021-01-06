//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Collects code derived from members declared by a specific operation host
    /// </summary>
    public readonly struct ApiHostCode
    {
        /// <summary>
        /// The defining host
        /// </summary>
        public ApiHostUri Host {get;}

        /// <summary>
        /// The host-owned code
        /// </summary>
        readonly ApiCodeBlock[] Data;

        [MethodImpl(Inline)]
        public ApiHostCode(ApiHostUri host, ApiCodeBlock[] code)
        {
            Host = host;
            Data = code.OrderBy(x => x.BaseAddress);
        }

        public ref readonly ApiCodeBlock this[long index]
        {
             [MethodImpl(Inline)]
             get => ref skip(Data,index);
        }

        public ref readonly ApiCodeBlock this[ulong index]
        {
             [MethodImpl(Inline)]
             get => ref skip(Data,index);
        }

        /// <summary>
        /// The number of collected functions
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Data?.Length ?? 0;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Length;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Length != 0;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Length == 0;
        }

        public Index<ApiCodeBlock> Blocks
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public static ApiHostCode Empty
        {
            [MethodImpl(Inline)]
            get => new ApiHostCode(ApiHostUri.Empty, sys.empty<ApiCodeBlock>());
        }
    }
}