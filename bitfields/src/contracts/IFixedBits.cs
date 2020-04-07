//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Core;    

    public interface IFixedBits<W,F> : IBitField<W>
        where W : unmanaged, ITypeWidth
        where F : unmanaged, IFixed
    {

    }

}