//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.Intrinsics;
    
    using static zfunc;


    public interface IClrMetadata<E>
    {
        E Element {get;}
    }

    public interface IMethodMetadata : IClrMetadata<MethodInfo>
    {        
    
    }

    public interface IMethodMetadata<T> : IMethodMetadata
        where T : unmanaged
    {
        
    }

    public interface IMethodMetadata<W,T> : IMethodMetadata<T>
        where W : unmanaged, ITypeNat
        where T : unmanaged
    {
        
    }

    public interface ITypeMetadata : IClrMetadata<Type>
    {
        
    }

    public enum GenericKind
    {
        None = 0,

        Open = 1,

        Closed = 2,

        Definition
    }

    public interface IGeneric<T> : IClrMetadata<T>
    {        

        GenericKind Kind {get;}
    }

}