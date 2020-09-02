//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAsciResource<A> : IContented<A>
        where A : IBytes
    {
        asci32 Name {get;}

        asci64 Description {get;}
    }
}