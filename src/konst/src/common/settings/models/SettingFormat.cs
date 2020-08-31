//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines an application setting format configuration
    /// </summary>
    public readonly struct SettingFormat
    {
        public static SettingFormat Default => new SettingFormat(true);

        [MethodImpl(Inline)]
        public SettingFormat(bool json)
        {
            FormatAsJson = json;
        }

        /// <summary>
        /// Specifies whether to render application settings as JSON text
        /// </summary>
        public bool FormatAsJson {get;}
    }
}