//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;         
    using static HexByteKind;       

    public static class EncodingModels
    {

        
    }

    public static class EncodingPrefixes
    {
        /// <summary>
        /// Defines the available REX prefixes
        /// </summary>
        public enum RexKind : byte
        {
            None = X00,

            REX40h = X40,
            
            REX41h = X41,
            
            REX42h = X42,

            REX43h = X43,

            REX44h = X44,

            REX45h = X45,

            REX46h = X46,

            REX47h = X47,

            REX48h = X48,

            REX49h = X49,

            REX4Ah = X4A,

            REX4Bh = X4B,

            REX4Ch = X4C,

            REX4Dh = X4D,

            REX4Eh = X4E,

            REX4Fh = X4F,

        }

    }

}