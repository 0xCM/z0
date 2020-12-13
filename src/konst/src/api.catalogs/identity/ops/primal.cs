//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct ApiIdentify
    {
        /// <summary>
        /// Defines a primal identity if the source type represents a recognized primitive; otherwise,
        /// returns <see cref='PrimalIdentity.Empty'/>
        /// </summary>
        /// <param name="src">The source type</param>
        [Op]
        public static PrimalIdentity primal(Type src)
            => src.IsSystemDefined() ?
               (NumericKinds.test(src)
               ? PrimalIdentity.Define(src.NumericKind(), ApiIdentify.keyword(src))
               : PrimalIdentity.Define(ApiIdentify.keyword(src))
               ) : PrimalIdentity.Empty;
    }
}