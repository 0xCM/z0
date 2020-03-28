//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Kinds;

    public interface INumericWidth : ITypeWidth
    {
        /// <summary>
        /// Refines the specificity of the class specifier
        /// </summary>
        new NumericWidth Class {get;}

        /// <summary>
        /// Defines a class specifier synonym to facilitate disambiguaton
        /// </summary>
        NumericWidth NumericWidth 
            => Class;

        /// <summary>
        /// Reifies the classifier relationship invariant
        /// </summary>
        TypeWidth ITypeWidth.TypeWidth 
            => (TypeWidth)Class;
    }

    public interface INumericWidth<K> : INumericWidth, ITypeWidth<K>
        where K : unmanaged, INumericWidth
    {

    }

    public interface INumericWidth<K,T> : INumericWidth<K>
        where K : unmanaged, INumericWidth
        where T : unmanaged
    {
        NumericWidth INumericWidth.Class
        {
            [MethodImpl(Inline)]
            get => (NumericWidth)(Unsafe.SizeOf<T>() *8);            
        }
    }
}