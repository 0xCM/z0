//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public static class UriDelimiters
    {
        /// <summary>
        /// The text used to terminate a uri scheme and trailing '//'
        /// </summary>
        public const string EOS = IDI.EndOfScheme;

        /// <summary>
        /// Forward slash
        /// </summary>
        public const char PathSep = IDI.UriPathSep;

        /// <summary>
        /// Query marker
        /// </summary>
        public const char QueryMarker = IDI.UriQueryMarker;

        /// <summary>
        /// Hash marker
        /// </summary>
        public const char Fragment = IDI.UriFragment;
        
    }
}