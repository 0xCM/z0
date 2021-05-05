//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct CodeBlocks
    {
        [MethodImpl(Inline), Op]
        public static MsilSourceBlock msil(CliToken id, CliSig sig, BinaryCode encoded)
            => new MsilSourceBlock(id,sig,encoded);

        [MethodImpl(Inline), Op]
        public static MsilSourceBlock msil(in OpMsil src)
            => msil(src.Token, src.CliSig, src.MsilCode);
    }
}