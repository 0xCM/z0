//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection.Metadata;
    using System.Reflection;

    using static Konst;
    using static z;

    /// <summary>
    /// Captures <see cref='MethodImport'/> data in usable form
    /// </summary>
    public struct CliMethodImportRecord
    {
        public MethodImportAttributes Attributes;

        public ModuleReferenceHandle Module;

        public StringRef Name;
    }
}