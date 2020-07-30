//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface ITabular : ITextual
    {
        /// <summary>
        /// Returns a line of text represents the record value
        /// </summary>
        string DelimitedText(char delimiter);

        string[] HeaderNames {get;}     

        string ITextual.Format()
            => DelimitedText(FieldDelimiter);   
    }

    public interface ITabular<R> : ITabular
        where R : ITabular
    {
    }

    public interface ITabular<F,R> : ITabular<R>
        where F : unmanaged, Enum
        where R : ITabular
    {
        string[] ITabular.HeaderNames 
            => Enums.names<F>();
    }
}