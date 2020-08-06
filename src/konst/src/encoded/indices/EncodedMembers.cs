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
    public readonly struct EncodedMembers
    {
        /// <summary>
        /// The defining host
        /// </summary>
        public readonly ApiHostUri Host;

        /// <summary>
        /// The host-owned code
        /// </summary>
        public readonly MemberCode[] Data;

        // [MethodImpl(Inline)]
        // public static implicit operator EncodedMembers((ApiHostUri part, MemberCode[] code) src)
        //     => new EncodedMembers(src.part, src.code);
        
        [MethodImpl(Inline)]
        public EncodedMembers(ApiHostUri id, MemberCode[] code)
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
    }
}