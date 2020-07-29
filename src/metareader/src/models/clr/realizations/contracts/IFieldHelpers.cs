//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Reflection;

    using Z0.Dac;    

    using static ClrDataModel;        

    public interface IFieldHelpers
    {
        ITypeFactory Factory { get; }
        
        IDataReader DataReader { get; }
        
        bool ReadProperties(ClrType parentType, int token, out string? name, out FieldAttributes attributes, out ClrSigParser sigParser);
        
        ulong GetStaticFieldAddress(ClrStaticField field, ClrAppDomain? appDomain);
    }
}