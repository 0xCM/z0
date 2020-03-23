//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    /// <summary>
    /// Characterizes a reified kind with which a fixed bit-width is associated
    /// </summary>
    public interface IFixedKind<F> : IFixed<F>,  IKind
        where F : unmanaged, IFixed
    {
        int IFixed.BitWidth
        {
            [MethodImpl(Inline)]
            get => (int)bitsize<F>();
        }        
        
    }

    public interface ITypeWidth : ILiteralKind<TypeWidth>, IFixedWidth
    {
        /// <summary>
        /// Refines the specificity of the class specifier
        /// </summary>
        TypeWidth TypeWidth {get;}

        FixedWidth IFixedWidth.FixedWidth 
            => (FixedWidth)TypeWidth;

        TypeWidth ILiftedEnum<TypeWidth>.Class 
            => TypeWidth;
    }

    public interface ITypeWidth<K> : ITypeWidth
        where K : unmanaged, ITypeWidth
    {
        
    }

    public interface ITypeWidth<K,T> : ITypeWidth<K>
        where K : unmanaged, ITypeWidth
        where T : unmanaged
    {
        TypeWidth ITypeWidth.TypeWidth 
        {
            [MethodImpl(Inline)]
            get => (TypeWidth)(Unsafe.SizeOf<T>() *8);            
        }    
    }

    public readonly struct TypeWidth<T> : ITypeWidth<TypeWidth<T>,T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator TypeWidth(TypeWidth<T> src)
            => src.Class;

        public TypeWidth Class 
        {
            [MethodImpl(Inline)]
            get => (TypeWidth)(Unsafe.SizeOf<T>()*8);            
        }
    }
}