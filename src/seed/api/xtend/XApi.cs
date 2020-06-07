//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using W = TypeWidth;

    partial class Extend 
    {
        [MethodImpl(Inline), Op]
        public static string formatvalue(TypeWidth w)
            => w switch {
                W.W1 => "1",
                W.W8 => "8",
                W.W16 => "16",
                W.W32 => "32",
                W.W64 => "64",
                W.W128 => "128",
                W.W256 => "256",
                W.W512 => "512",
                W.W1024 => "1024",
                _ => "0",
            };
    }
}