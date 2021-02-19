//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IScoped
    {
        IScope Scope {get;}
    }

    public interface IScoped<T> : IScoped
        where T : IScope
    {
        new T Scope {get;}

        IScope IScoped.Scope
            => Scope;
    }

    public interface IScoped<F,T> : IScoped
        where T : IScope
        where F : IScoped<F,T>
    {
        new T Scope {get;}

        IScope IScoped.Scope
            => Scope;
    }
}