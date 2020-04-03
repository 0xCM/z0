//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    /// <summary>
    /// Characterises a vector type stratifier
    /// </summary>
    public interface IVectorKind : ITypeKind
    {

    }

    public interface IVectorType : ITypeKind
    {
        VectorWidth Width {get;}
    }    

    public interface IVectorType<W> : IVectorType
        where W : unmanaged, ITypeWidth
    {
        VectorWidth IVectorType.Width => default;
    }

    public interface IVectorType<V,T> : IVectorType, ITypeKind<T>
        where V : struct
        where T : unmanaged
    {
        VectorWidth IVectorType.Width 
        { 
            [MethodImpl(Inline)]
            get => (VectorWidth)Widths.measure<V>();
        }
    }

    public readonly struct VectorTypeKind : IVectorType
    {
        public VectorWidth Width {get;}
        
        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(VectorWidth width)
            => new VectorTypeKind(width);

        [MethodImpl(Inline)]
        public VectorTypeKind(VectorWidth width)
        {
            this.Width = width;
        }
    }        
}