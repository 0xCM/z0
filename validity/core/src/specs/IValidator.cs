//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IValidator : IService<IValidationContext>
    {

    }

    public interface IValidator<T> : IValidator
        where T : unmanaged
    {   
        
    }


}