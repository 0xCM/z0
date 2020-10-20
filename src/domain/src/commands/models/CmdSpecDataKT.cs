//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;


    public struct CmdSpecData<K,T>
        where K : unmanaged
    {
        public CmdId Id;

        public TableSpan<CmdOption<K,T>> Options;
    }
}