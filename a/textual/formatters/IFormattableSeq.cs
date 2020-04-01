//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IFormattableSeq<T> : ISeq<T>, ICustomFormattable
        where T : ICustomFormattable
    {
        string ICustomFormattable.Format()
            => Content.FormatList();        
    }
}