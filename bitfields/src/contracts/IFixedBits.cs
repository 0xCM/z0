//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    

    public interface IFixedBits<W,F> : IBitField<W>
        where W : unmanaged, ITypeWidth
        where F : unmanaged, IFixed
    {

    }

}