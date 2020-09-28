//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    [Flags]
    public enum DllCharacteristics : ushort
    {
        ProcessInit = 0x0001,

        ProcessTerm = 0x0002,

        ThreadInit = 0x0004,

        ThreadTerm = 0x0008,

        /// <summary>
        /// The DLL can be relocated at load time.
        /// </summary>
        DynamicBase = 0x0040,

        /// <summary>
        /// Code integrity checks are forced. If you set this flag and a section contains only uninitialized data, set the PointerToRawData member of <see cref="IMAGE_SECTION_HEADER"/> for that section to zero; otherwise, the image will fail to load because the digital signature cannot be verified.
        /// </summary>
        ForceIntegrity = 0x0080,

        /// <summary>
        /// The image is compatible with data execution prevention (DEP).
        /// </summary>
        NxCompatible = 0x0100,

        /// <summary>
        /// The image is isolation aware, but should not be isolated.
        /// </summary>
        NoIsolation = 0x0200,

        /// <summary>
        /// The image does not use structured exception handling (SEH). No handlers can be called in this image.
        /// </summary>
        NoSEH = 0x0400,

        /// <summary>
        /// Do not bind the image.
        /// </summary>
        NoBind = 0x0800,

        /// <summary>
        /// The image must run inside an AppContainer
        /// </summary>
        AppContainer = 0x1000,

        /// <summary>
        /// A WDM driver.
        /// </summary>
        WDM_Driver = 0x2000,

        /// <summary>
        /// The image is terminal server aware.
        /// </summary>
        TerminalServerAware = 0x8000,
    }
}