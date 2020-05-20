//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IHexKindValue<T> : IHexCode
        where T : unmanaged
    {
        T Value {get;}

        byte[] Data 
            => ByteReader.Read(Value).ToArray();
    }
}