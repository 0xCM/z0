//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPathComponent
    {

    }

    public interface IPathComponent<T> : IPathComponent, IIdentification<T>
        where T : IPathComponent<T>, new()
    {
        string  Name {get;} 
        
        static T Empty => new T();        

        string IIdentified.Identifier 
            => Name;
    }
}