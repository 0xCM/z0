//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Windows
{
    using System.Runtime.InteropServices;

    public struct MINIDUMP_SIGNATURE
    {
        public uint Value;


        public uint Expected => (uint)'P' << 24 | (uint)'M' << 16 | (uint)'D' << 8 | (uint)'M';
    }

    /*
        #define MINIDUMP_SIGNATURE ('PMDM')
        #define MINIDUMP_VERSION   (42899)

    */
}
