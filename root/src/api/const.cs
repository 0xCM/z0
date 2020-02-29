//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Root
    {
        /// <summary>
        /// Specifies the name of the windows kernel32 dll, primarily intended for use in DllImport attributions
        /// </summary>
        public const string Kernel32 = "kernel32.dll";

        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;

        public const StringComparison IgnoreCase = StringComparison.InvariantCultureIgnoreCase;
    }
}