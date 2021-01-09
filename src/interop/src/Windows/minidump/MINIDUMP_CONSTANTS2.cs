//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Windows
{
    using System.Runtime.InteropServices;

    public readonly struct MINIDUMP_CONSTANTS
    {
        public const uint Signature = (uint)'P' << 24 | (uint)'M' << 16 | (uint)'D' << 8 | (uint)'M';

        public const ushort Version = 42899;
    }

}