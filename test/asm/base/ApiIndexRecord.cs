//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;

    public struct ApiIndexRecord
    {
        public PartId PartId;

        public StringRef PartName;

    }

    public readonly struct ApiIndexReport
    {
        public static ref ApiIndexRecord record(ClrMethod src, ref ApiIndexRecord dst)
        {


            return ref dst;
        }
    }
}
