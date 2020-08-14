//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;
    using static FormatLiterals;

    partial struct Flow
    {
        /// <summary>
        /// Defines the default field delimiter
        /// </summary>
        public const string FieldSep = " | ";

        /// <summary>
        /// Defines the default content separator
        /// </summary>
        public const string ContentSep = ": ";

        /// <summary>
        /// Defines the default file extension part separator
        /// </summary>
        public const string ExtPartSep = ".";

        /// <summary>
        /// Defines the default extension for structured data
        /// </summary>
        public const string DataFileExt = "csv";

        public const string Plural = "s";

        public const string IdMarker = Slot0 + FieldSep;

        public const string ContentMarker = ContentSep + Slot0;

    }
}