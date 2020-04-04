//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Presumeably, a field constructed from bits
    /// </summary>
    public interface IBitField
    {
        int TotalWidth {get;}
    }
    
    public interface IBitField<W> : IBitField
        where W : unmanaged, ITypeWidth
    {
        int IBitField.TotalWidth => (int)Widths.type<W>();
    }
}