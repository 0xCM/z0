//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Threading;

    using static core;

    public abstract class ADT<T>
        where T : ADT<T>, new()
    {
        Label Name {get;}

        protected ADT(Label name)
        {
            Name = name;
        }
    }

    public readonly partial struct ADT
    {


    }
}