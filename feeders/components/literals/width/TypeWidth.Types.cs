//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    public interface ITypeWidth //: ILiteralKind<TypeWidth>, IFixedWidth
    {
        /// <summary>
        /// Refines the specificity of the class specifier
        /// </summary>
        TypeWidth TypeWidth {get;}


        TypeWidth Class => TypeWidth;

        // FixedWidth IFixedWidth.FixedWidth 
        //     => (FixedWidth)TypeWidth;

        // TypeWidth ITypeLevelEnum<TypeWidth>.Class 
        //     => TypeWidth;
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

        TypeWidth ITypeWidth.TypeWidth 
        {
            [MethodImpl(Inline)]
            get => (TypeWidth)(Unsafe.SizeOf<T>() *8);            
        }

        public TypeWidth Class 
        {
            [MethodImpl(Inline)]
            get => (TypeWidth)(Unsafe.SizeOf<T>()*8);            
        }
    }
}