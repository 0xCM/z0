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
    public readonly struct X86HostIndex
    {
        /// <summary>
        /// The defining host
        /// </summary>
        public readonly ApiHostUri Host;

        /// <summary>
        /// The host-owned code
        /// </summary>
        readonly TableSpan<X86ApiCode> Data;

        [MethodImpl(Inline)]
        public X86HostIndex(ApiHostUri id, X86ApiCode[] code)
        {
            Host = id;
            Data = code.OrderBy(x => x.Base);
        }

        [MethodImpl(Inline)]
        public ref readonly X86ApiCode Cell(ulong index)
            => ref Data[index];

        public ref readonly X86ApiCode this[long index]
        {
             [MethodImpl(Inline)]
             get => ref Data[index];
        }

        public ref readonly X86ApiCode this[ulong index]
        {
             [MethodImpl(Inline)]
             get => ref Data[index];
        }

        /// <summary>
        /// The number of collected functions
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }
    }
}