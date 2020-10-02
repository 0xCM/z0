//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

   public abstract class Algorithm<T> : CodeModel<T>
        where T : Algorithm<T>, new()
    {

    }
}