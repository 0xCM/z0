//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static TernaryLogicOpKind;
    using static BitMatrixOps;

    /// <summary>
    /// Services for scalar operators
    /// </summary>
    public static class BitMatrixOpApi
    {
        /// <summary>
        /// Advertises the supported scalar binary opeators
        /// </summary>
        public static IEnumerable<BinaryLogicOpKind> BinaryKinds
            => items(
                BinaryLogicOpKind.And, BinaryLogicOpKind.Or, BinaryLogicOpKind.XOr,
                BinaryLogicOpKind.Nand, BinaryLogicOpKind.Nor, BinaryLogicOpKind.Xnor,
                BinaryLogicOpKind.AndNot, BinaryLogicOpKind.True, BinaryLogicOpKind.False
            );



    }

}
