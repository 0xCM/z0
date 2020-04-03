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

    public interface ITypeWidth<W> : ITypeWidth
        where W : unmanaged, ITypeWidth
    {
        TypeWidth ITypeWidth.TypeWidth 
        {
            [MethodImpl(Inline)]
            get => Widths.literal<W>();
        }    
    }

    public interface ITypeWidth<W,T> : ITypeWidth<W>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {     
    
    }
}