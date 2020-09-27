//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class ToolPaths
    {
        public FS.FilePath IlDasm {get;}
            = FS.path(@"J:\lang\net\runtime\artifacts\toolset\ilasm\ildasm.exe");
    }
}