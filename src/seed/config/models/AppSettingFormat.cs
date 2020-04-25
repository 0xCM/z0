//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Seed;

    /// <summary>
    /// Defines an application setting format configuration
    /// </summary>
    public readonly struct AppSettingFormat
    {
        public static AppSettingFormat Default => new AppSettingFormat(true);

        [MethodImpl(Inline)]
        public AppSettingFormat(bool json)
        {
            FormatAsJson = json;
        }

        /// <summary>
        /// Specifies whether to render application settings as JSON text
        /// </summary>
        public bool FormatAsJson {get;}
    }
}