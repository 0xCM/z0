//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITextResource : IContented<string>
    {
        ulong Identifier {get;}

        MemoryAddress Location {get;}        
    }

    public interface ITextResource<E> : ITextResource
        where E : unmanaged, Enum
    {
        new E Identifier {get;}

        ulong ITextResource.Identifier 
            => Enums.numeric<E,ulong>(Identifier);
    }
}