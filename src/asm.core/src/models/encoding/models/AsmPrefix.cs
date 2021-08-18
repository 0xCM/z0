//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmPrefixCodes;

    /// <summary>
    /// Represents a prefix encoding
    /// [Kind[24,27] | Encoding]
    /// </summary>
    public struct AsmPrefix
    {
        uint Data;

        [MethodImpl(Inline)]
        internal AsmPrefix(uint data)
        {
            Data = data;
        }

        [MethodImpl(Inline)]
        public readonly PrefixKind Kind()
            => (PrefixKind)Bits.segment(Data, 24, 27);

        [MethodImpl(Inline)]
        public void Kind(PrefixKind kind)
            => Bits.replace(Data, 24, 27, (uint)kind);

        [MethodImpl(Inline)]
        public uint Content()
            => Bits.segment(Data,0,23);

        [MethodImpl(Inline)]
        public void Content(uint src)
            => Bits.replace(Data,0,23,src);

        public uint Encoded
        {
            [MethodImpl(Inline)]
            get => Content();
        }
    }
}