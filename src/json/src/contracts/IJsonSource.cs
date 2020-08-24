//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IJsonSource : ITextual
    {
        JsonText ToJson();

        string ITextual.Format()
            => ToJson().Format();
    }

    public interface IJsonSource<H> : IJsonSource
        where H : struct, IJsonSource<H>
    {

    }

}