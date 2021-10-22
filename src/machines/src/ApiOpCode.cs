//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ApiOpCode
    {
        readonly ulong Data;

        [MethodImpl(Inline)]
        public ApiOpCode(ulong data)
        {
            Data = data;
        }

        public byte Cluster
        {
            [MethodImpl(Inline)]
            get => (byte)Data;
        }

        public byte Router
        {
            [MethodImpl(Inline)]
            get => (byte)(Data >> 8);
        }

        public byte Operation
        {
            [MethodImpl(Inline)]
            get => (byte)(Data >> 16);
        }

        public static implicit operator ApiOpCode(ulong src)
            => new ApiOpCode(src);
    }
}