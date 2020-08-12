//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Immutable;

    using Z0.MS;
    
    public interface ITypeFactory : IDisposable
    {
        bool IsThreadSafe { get; }

        ClrRuntime GetOrCreateRuntime();
        
        ClrHeap GetOrCreateHeap();
        
        ClrModule GetOrCreateModule(ClrAppDomain domain, ulong address);
        
        bool CreateMethodsForType(ClrType type, out ImmutableArray<ClrMethod> methods);
        
        bool CreateFieldsForType(ClrType type, out ImmutableArray<ClrInstanceField> fields, out ImmutableArray<ClrStaticField> staticFields);
        
        RuntimeCallableWrapper CreateRCWForObject(ulong obj);

        ComCallableWrapper? CreateCCWForObject(ulong obj);

        ClrType CreateSystemType(ClrHeap heap, ulong mt, string kind);
        
        ClrType GetOrCreateType(ClrHeap heap, ulong mt, ulong obj);
        
        ClrType GetOrCreateType(ulong mt, ulong obj);
        
        ClrType GetOrCreateBasicType(ClrElementType basicType);
        
        ClrType GetOrCreateArrayType(ClrType inner, int ranks);
        
        ClrType GetOrCreateTypeFromToken(ClrModule module, int token);
        
        ClrType GetOrCreatePointerType(ClrType innerType, int depth);
        
        ClrMethod CreateMethodFromHandle(ulong methodHandle);
    }        
}