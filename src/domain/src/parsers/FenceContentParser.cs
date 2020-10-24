//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static SyntaxModels;

    public struct FenceContentParser<T>
        where T : unmanaged
    {
        readonly Fence<T> Fence;

        // public void Parse(ReadOnlySpan<T> src, BufferSeq<T> dst)
        // {

        // }
    }
}