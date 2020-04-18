//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISFValidator : IService<ITestContext>
    {

    }

    public interface ISFValidator<T> : ISFValidator
        where T : unmanaged
    {   
        
    }


}