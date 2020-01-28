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
        /// Scalar operations
        /// </summary>
        public const string scalar = "scalar";

        /// <summary>
        /// Logical operations
        /// </summary>
        public const string logic = "logic";

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
        public const string tbl = nameof(tbl);

        /// <summary>
        /// Comparison
        /// </summary>
        public const string cmp = nameof(cmp);

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

        public const string vcmp128 = nameof(vcmp128);

        public const string vcmp256 = nameof(vcmp256);

        public const string veval128 = nameof(veval128);

        public const string veval256 = nameof(veval256);

        
    }
}
