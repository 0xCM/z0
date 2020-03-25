//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Kinds;

    public interface IVectorKind : IKind
    {

    }

    public interface IVectorType : IVectorKind
    {
        VectorWidth Width {get;}
    }    

    public interface IVectorType<V,T> : ITypeKind<T>, IVectorType
        where V : struct
        where T : unmanaged
    {
        VectorWidth IVectorType.Width 
        { 
            [MethodImpl(Inline)]
            get => (VectorWidth)(Unsafe.SizeOf<V>()*8); 
        }
    }

    public readonly struct VectorTypeKind : IVectorKind
    {

    }        
}