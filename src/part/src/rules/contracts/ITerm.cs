//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITerm
    {
        TermId Id {get;}
    }

    public interface ITerm<T> : ITerm
    {

    }
}