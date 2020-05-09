//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public enum BranchTargetKind : byte
    {
        None = 0,

        Near = 1,

        Far = 2
    }

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static string Format(this BranchTargetSize src)
            => src == 0 ? string.Empty : ((byte)src).ToString();
        

        [MethodImpl(Inline)]
        public static string Format(this BranchTargetKind src, BranchTargetSize sz)
            => src == 0 ? string.Empty : text.concat(src.ToString().ToLower(), sz.Format());
    }
}