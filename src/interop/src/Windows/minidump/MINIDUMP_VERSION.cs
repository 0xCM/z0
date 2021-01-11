//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Windows
{
    using System.Runtime.InteropServices;

    public struct MINIDUMP_VERSION
    {
        public ushort Value;

        public ushort Expected => 42899;
    }
}