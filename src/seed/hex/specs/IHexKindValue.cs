//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface IHexKindValue<T> : IHexCode
        where T : unmanaged
    {
        T Value {get;}

        ReadOnlySpan<byte> Data {get;}

        Type IHexCode.Reified 
            => typeof(T);           
    }
}