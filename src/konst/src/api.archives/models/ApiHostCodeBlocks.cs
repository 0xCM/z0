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
    public readonly struct ApiHostCodeBlocks
    {
        /// <summary>
        /// The defining host
        /// </summary>
        public ApiHostUri Host {get;}

        /// <summary>
        /// The host-owned code
        /// </summary>
        public TableSpan<ApiCodeBlock> Code {get;}

        [MethodImpl(Inline)]
        public ApiHostCodeBlocks(ApiHostUri host, ApiCodeBlock[] code)
        {
            Host = host;
            Code = code.OrderBy(x => x.Base);
        }

        [MethodImpl(Inline)]
        public ref readonly ApiCodeBlock Cell(ulong index)
            => ref Code[index];

        public ref readonly ApiCodeBlock this[long index]
        {
             [MethodImpl(Inline)]
             get => ref Code[index];
        }

        public ref readonly ApiCodeBlock this[ulong index]
        {
             [MethodImpl(Inline)]
             get => ref Code[index];
        }

        /// <summary>
        /// The number of collected functions
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Code.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Code.Count;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Code.IsNonEmpty;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Code.IsNonEmpty;
        }

        public ApiCodeBlock[] Storage
        {
            [MethodImpl(Inline)]
            get => Code.Storage;
        }
    }
}