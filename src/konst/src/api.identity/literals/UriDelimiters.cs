//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public static class UriDelimiters
    {
        /// <summary>
        /// The text used to terminate a uri scheme and trailing '//'
        /// </summary>
        public const string UriEndOfScheme = IDI.EndOfScheme;

        /// <summary>
        /// Forward slash
        /// </summary>
        public const char UriPathSep = IDI.UriPathSep;

        /// <summary>
        /// Query marker
        /// </summary>
        public const char UriQuery = IDI.UriQueryMarker;

        /// <summary>
        /// Hash marker
        /// </summary>
        public const char UriFragment = IDI.UriFragment;
    }
}