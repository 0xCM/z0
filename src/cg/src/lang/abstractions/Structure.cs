//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;

   public abstract class Structure<T> : CodeModel<T>
        where T : Structure<T>, new()
    {

    }

}