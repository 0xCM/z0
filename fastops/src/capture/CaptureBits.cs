//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
 
    using static zfunc;    

    public readonly struct CaptureBits
    {
        public readonly byte[] Raw;

        public readonly byte[] Trimmed;

        [MethodImpl(Inline)]
        public static CaptureBits Define(byte[] raw, byte[] trimmed)
            => new CaptureBits(raw,trimmed);

        [MethodImpl(Inline)]
        CaptureBits(byte[] raw, byte[] trimmed)
        {
            this.Raw = raw;
            this.Trimmed = trimmed;
        }

        public int RawLength
            => Raw.Length;

        public int TrimmedLength
            => Trimmed.Length;
    }
}