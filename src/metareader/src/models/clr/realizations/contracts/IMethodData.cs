//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using static ClrDataModel;    

    // public interface IFieldHelpers
    // {
    //     ITypeFactory Factory { get; }

    //     IDataReader DataReader { get; }

    //     bool ReadProperties(ClrType parentType, int token, out string? name, out FieldAttributes attributes, out ClrSigParser sigParser);

    //     ulong GetStaticFieldAddress(ClrStaticField field, ClrAppDomain? appDomain);
    // }

    public interface IAppDomainData
    {
        IAppDomainHelpers Helpers { get; }

        string? Name { get; }

        int Id { get; }

        ulong Address { get; }
    }
    
    public interface IAppDomainHelpers
    {
        string? GetConfigFile(ClrAppDomain domain);

        string? GetApplicationBase(ClrAppDomain domain);

        IEnumerable<ClrModule> EnumerateModules(ClrAppDomain domain);
    }

    public interface IMethodData
    {
        IMethodHelpers Helpers { get; }

        ulong MethodDesc { get; }
        
        int Token { get; }
        
        MethodCompilationType CompilationType { get; }
        
        ulong HotStart { get; }
        
        uint HotSize { get; }
        
        ulong ColdStart { get; }
        
        uint ColdSize { get; }
    }
}