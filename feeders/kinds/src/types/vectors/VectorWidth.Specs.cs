//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Kinds;
    
    public interface IVectorWidth : ITypeWidth
    {
        /// <summary>
        /// Refines the specificity of the class specifier
        /// </summary>
        new VectorWidth Class {get;}

        /// <summary>
        /// Defines a class specifier synonym to facilitate disambiguaton
        /// </summary>
        VectorWidth VectorWidth 
            => Class;

        /// <summary>
        /// Reifies the classifier relationship invariant
        /// </summary>
        TypeWidth ITypeWidth.TypeWidth 
            => (TypeWidth)Class;
    }
    
    public interface IVectorWidth<K> : IVectorWidth, ITypeWidth<K>
        where K : unmanaged, IVectorWidth
    {

    }

    public interface IVectorWidth<K,T> : IVectorWidth<K>
        where K : unmanaged, IVectorWidth
        where T : unmanaged
    {
        VectorWidth IVectorWidth.Class
        {
            [MethodImpl(Inline)]
            get => (VectorWidth)(Unsafe.SizeOf<T>() *8);            
        }

    }
}