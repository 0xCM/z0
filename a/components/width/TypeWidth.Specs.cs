//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface ITypeWidth
    {
        /// <summary>
        /// Refines the specificity of the class specifier
        /// </summary>
        TypeWidth TypeWidth {get;}


        TypeWidth Class => TypeWidth;

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
}