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
    public readonly struct MemberCodeIndex
    {
        /// <summary>
        /// The defining host
        /// </summary>
        public readonly ApiHostUri Host;

        /// <summary>
        /// The host-owned code
        /// </summary>
        public readonly MemberCode[] Data;

        [MethodImpl(Inline)]
        public static implicit operator MemberCodeIndex((ApiHostUri part, MemberCode[] code) src)
            => new MemberCodeIndex(src.part, src.code);
        
        [MethodImpl(Inline)]
        internal MemberCodeIndex(ApiHostUri id, MemberCode[] code)
        {
            Host = id;
            Data = code.OrderBy(x => x.Address);
        }

        [MethodImpl(Inline)]
        public ref readonly MemberCode Cell(uint index)
            => ref Data[index];

        public ref readonly MemberCode this[int index]  
        {
             [MethodImpl(Inline)] 
             get => ref Cell((uint)index);
        }

        /// <summary>
        /// The number of collected functions
        /// </summary>
        public int Length 
        { 
            [MethodImpl(Inline)] 
            get => Data.Length;
        }

        [MethodImpl(Inline)]
        MemberCodeIndex(ApiHostUri id)
        {
            Host = id;
            Data = Array.Empty<MemberCode>();
        }

        public static MemberCodeIndex Empty
        { 
            [MethodImpl(Inline)]
            get => new MemberCodeIndex(ApiHostUri.Empty);
        }
    }
}