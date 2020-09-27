//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    
    public interface IClrObjectHelpers
    {
        ITypeFactory Factory { get; }

        IDataReader DataReader { get; }

        IExceptionHelpers ExceptionHelpers { get; }
    }        
}