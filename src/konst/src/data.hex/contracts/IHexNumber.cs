//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    public interface IHexNumber : IByte
    {

    }

    public interface IHexNumber<K> : IHexNumber
        where K : unmanaged, Enum
    {
        new K Value {get;}

        byte IByte.Value 
            => (byte)(object)Value;
    }    
    
    public interface IHexNumber<F,K> : IHexNumber<K>, IByte<F>
        where F : unmanaged, IHexNumber<F,K>
        where K : unmanaged, Enum
    {

    }
}