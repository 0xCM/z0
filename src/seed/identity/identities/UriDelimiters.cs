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
        /// End of scheme
        /// </summary>
        public const char EOS = ':';

        /// <summary>
        /// Forward slash
        /// </summary>
        public const char FS = '/';

        /// <summary>
        /// Query marker
        /// </summary>
        public const char Q = '?';

        /// <summary>
        /// Hash marker
        /// </summary>
        public const char H = '#';
        
        /// <summary>
        /// FS*2
        /// </summary>
        public const string FS2 = "//";
    }
}