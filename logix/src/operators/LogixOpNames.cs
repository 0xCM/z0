//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    static class LogixOpNames
    {        
        /// <summary>
        /// Unary bitlogic
        /// </summary>
        public const string ubl = "ubl";

        /// <summary>
        /// Binary bitlogic
        /// </summary>
        public const string bbl = "bbl";

        /// <summary>
        /// Ternary bitlogic
        /// </summary>
        public const string tbl = "tbl";

        /// <summary>
        /// Comparison
        /// </summary>
        public const string cmp = "cmp";

        /// <summary>
        /// Unary arithmetic
        /// </summary>
        public const string ua = "ua";

        /// <summary>
        /// Binary arithmetic
        /// </summary>
        public const string ba = "ba";

        /// <summary>
        /// Shift evaluation
        /// </summary>
        public const string shift = "shift";

    }
}
