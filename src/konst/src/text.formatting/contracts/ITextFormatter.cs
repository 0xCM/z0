//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITextFormatter<S> : IFormatter<S,string>
    {

    }

    public interface ITextFormatter<H,S> : ITextFormatter<S>, IService<H,ITextFormatter<S>,S>
        where H : ITextFormatter<H,S>
    {

    }
}