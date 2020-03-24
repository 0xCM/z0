//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using W = TypeWidth;

    public readonly struct W1 : ITypeWidth<W1>  { public TypeWidth TypeWidth => W.W1; }

    public readonly struct W8 : ITypeWidth<W8> { public TypeWidth TypeWidth => W.W8; }

    public readonly struct W16 : ITypeWidth<W16> { public TypeWidth TypeWidth => W.W16; }

    public readonly struct W32 : ITypeWidth<W32> { public TypeWidth TypeWidth => W.W32; }

    public readonly struct W64 : ITypeWidth<W64> { public TypeWidth TypeWidth => W.W64; }

    public readonly struct W128 : ITypeWidth<W128> { public TypeWidth TypeWidth => W.W128; }

    public readonly struct W256 : ITypeWidth<W256> { public TypeWidth TypeWidth => W.W256; }

    public readonly struct W512 : ITypeWidth<W512> { public TypeWidth TypeWidth => W.W512; }
}