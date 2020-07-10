//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public interface ITestBitLogicMatch<T,W> : TCheckVectors
        where T : struct
        where W : unmanaged, ITypeWidth
    {
        bit match<K>(T x, T y, K k = default)
            where K : unmanaged, IBitLogicKind;
    }    
}