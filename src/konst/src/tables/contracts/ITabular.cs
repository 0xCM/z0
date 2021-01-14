//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
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

    [Free]
    public interface ITabular<F,R> : ITabular
        where F : unmanaged, Enum
        where R : struct
    {
        string[] ITabular.HeaderNames
            => ClrEnums.names<F>();
    }
}