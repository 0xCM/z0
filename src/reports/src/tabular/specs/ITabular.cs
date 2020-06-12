//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITabular
    {
        /// <summary>
        /// Returns a line of text represents the record value
        /// </summary>
        string DelimitedText(char delimiter) 
            => string.Empty;

        string[] HeaderNames {get;}        
    }

    public interface ITabular<R> : ITabular
        where R : ITabular
    {
        string[] ITabular.HeaderNames
            => TabularFormats.headers<R>();
    }

    public interface ITabular<F,T> : ITabular<T>
        where F : unmanaged, Enum
        where T : ITabular
    {

    }
}