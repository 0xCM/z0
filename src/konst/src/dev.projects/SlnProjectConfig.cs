//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record]
    public struct SlnProjectConfig : IRecord<SlnProjectConfig>
    {
        //
        // Summary:
        //     The configuration part of this configuration - e.g. "Debug", "Release"
        public Name SimpleName;

        //
        // Summary:
        //     The platform part of this configuration - e.g. "Any CPU", "Win32"
        public Name Platform;

        //
        // Summary:
        //     The full name of this configuration - e.g. "Debug|Any CPU"
        public Name FullName;

        //
        // Summary:
        //     True if this project configuration should be built as part of its parent solution
        //     configuration
        public bool Build;
    }
}