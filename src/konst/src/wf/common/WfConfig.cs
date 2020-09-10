//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct WfConfig
    {
        /// <summary>
        /// The controlling part
        /// </summary>
        public PartId Control;

        /// <summary>
        /// The controlling arguments, in raw form as supplied by the entry point or caller
        /// </summary>
        public string[] Args;

        /// <summary>
        /// The shell settings
        /// </summary>
        public WfSettings Settings;

        /// <summary>
        /// The parts considered by the workflow
        /// </summary>
        public PartId[] Parts;

        /// <summary>
        /// The module directory
        /// </summary>
        public FS.FolderPath ModuleRoot;

        /// <summary>
        /// The root capture directory
        /// </summary>
        public FS.FolderPath CaptureRoot;

        /// <summary>
        /// The root table directory
        /// </summary>
        public FS.FolderPath TableRoot;

        /// <summary>
        /// The shell-specific status log path
        /// </summary>
        public FS.FilePath StatusPath;

        /// <summary>
        /// The shell-specific error log path
        /// </summary>
        public FS.FilePath ErrorPath;
    }
}