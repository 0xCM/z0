//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;


    /// <summary>
    /// Characterizes a model of a class type
    /// </summary>
    public interface IClrClass : IClrType
    {
        ClrTypeKind IClrType.Kind 
            => ClrTypeKind.Class;        
   
    }

}