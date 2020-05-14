//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface ITabular
    {
        /// <summary>
        /// Returns a line of text represents the record value
        /// </summary>
        string DelimitedText(char delimiter);

        string[] HeaderNames {get;}        
    }

    public interface ITabular<R> : ITabular
        where R : ITabular
    {
        string[] ITabular.HeaderNames
            => TabularFormats.headers<R>();
    }

    public interface ITabular<E,R> : ITabular<R>
        where E : unmanaged, Enum
        where R : ITabular
    {
        
    }   


}