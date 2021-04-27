// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    public struct FixedFileInfo
    {
        public uint Signature;            /* e.g. 0xfeef04bd */

        public uint StrucVersion;         /* e.g. 0x00000042 = "0.42" */

        public ushort Minor;

        public ushort Major;

        public ushort Patch;

        public ushort Revision;

        public uint ProductVersionMS;     /* e.g. 0x00030010 = "3.10" */

        public uint ProductVersionLS;     /* e.g. 0x00000031 = "0.31" */

        public uint FileFlagsMask;        /* = 0x3F for version "0.42" */

        public uint FileFlags;            /* e.g. VFF_DEBUG | VFF_PRERELEASE */

        public uint FileOS;               /* e.g. VOS_DOS_WINDOWS16 */

        public uint FileType;             /* e.g. VFT_DRIVER */

        public uint FileSubtype;          /* e.g. VFT2_DRV_KEYBOARD */

        // Timestamps would be useful, but they're generally missing (0).
        public uint FileDateMS;           /* e.g. 0 */

        public uint FileDateLS;           /* e.g. 0 */

        public VersionInfo AsVersionInfo()
            => new VersionInfo(Major, Minor, Revision, Patch);
    }
}