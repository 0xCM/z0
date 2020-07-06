//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IIdentified<T> : IIdentified
        where T : IIdentification
    {
        T Id {get;}

        string IIdentified.Identifier 
            => Id.Identifier;
    }
}