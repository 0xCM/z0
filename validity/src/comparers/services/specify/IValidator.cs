//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static Root;
    using static Validity;
    using static vgeneric;

    using C = OpClass;

    public interface IValidator : IService<IValidationContext>
    {

    }

    public interface IValidator<T> : IValidator
        where T : unmanaged
    {   
        
    }


}