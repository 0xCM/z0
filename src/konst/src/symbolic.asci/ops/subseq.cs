//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Asci
    {
        [Op]
        public static AsciSequence subseq<T>(T src, int i0, int i1)
            where T : unmanaged, IAsciSeq
                => new AsciSequence(memory.segment(src.View, i0, i1).ToArray());
    }
}