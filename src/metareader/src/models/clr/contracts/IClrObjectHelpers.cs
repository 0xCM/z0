//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ClrDataModel
    {        
        public interface IClrObjectHelpers
        {
            ITypeFactory Factory { get; }

            IDataReader DataReader { get; }

            IExceptionHelpers ExceptionHelpers { get; }
        }       
    }
}