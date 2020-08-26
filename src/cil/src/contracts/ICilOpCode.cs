//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;

    using static Konst;

    public interface ICilOpCode
    {
        ILOpCode Id {get;}

    }

    public interface ICilOpCode<K> : ICilOpCode
        where K : unmanaged, ICilOpCode<K>
    {

    }
}