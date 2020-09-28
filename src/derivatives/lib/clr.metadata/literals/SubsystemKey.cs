//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using static Part;

    public enum SubsystemKey : ushort
    {
        Unknown = 0, // Unknown subsystem.

        Native = 1, // Image doesn't require a subsystem.

        WindowsGUI = 2, // Image runs in the Windows GUI subsystem.

        WindowsCUI = 3, // Image runs in the Windows character subsystem.

        OS2CUI = 5, // image runs in the OS/2 character subsystem.

        POSIXCUI = 7, // image runs in the Posix character subsystem.

        NativeWindows = 8, // image is a native Win9x driver.

        WindowsCEGUI = 9, // Image runs in the Windows CE subsystem.

        EFIApplication = 10,

        EFIBootServiceDriver = 11,

        EFIRuntimeDriver = 12,

        EFIROM = 13,

        XBOX = 14,
    }
}