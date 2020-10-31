//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum PeFileKind : byte
    {
        None,

        Dll = 1,

        Exe = 2,

        Lib = 4,

        Pdb = 8
    }
}