//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmCodes;

    using K = AsmCodes.VexPrefixKind;

    public struct VexPrefix
    {
        uint Data;

        [MethodImpl(Inline)]
        internal VexPrefix(K k)
        {
            Data = (byte)k;
        }

        [MethodImpl(Inline)]
        internal VexPrefix(K k, byte b1)
        {
            Data = math.join((byte)k,b1,0,2);
        }

        [MethodImpl(Inline)]
        internal VexPrefix(K k, byte b1, byte b2)
        {
            Data = math.join((byte)k,b1,b2,3);
        }

        public byte Size
        {
            [MethodImpl(Inline)]
            get => (byte)(Data >> 24);
        }

        [MethodImpl(Inline)]
        public K Kind()
            => (K)Data;

        [MethodImpl(Inline)]
        public void Kind(K k)
            => Data = Bytes.inject((byte)k,0, ref Data);
    }
}