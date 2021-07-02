//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection;

    using static core;

    partial class PeReader
    {
        [Op]
        public AssemblyName AssemblyName()
            => MD.GetAssemblyDefinition().GetAssemblyName();
    }
}