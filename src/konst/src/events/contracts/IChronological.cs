//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IChronic
    {
        Timestamp Ts 
            => DateTime.Now;
    }

    public interface IChronic<F> : IChronic
        where F : struct, IChronic
    {

    }
}