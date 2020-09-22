//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct ApiIdentity
    {
        /// <summary>
        /// Defines a primal identity if the source type represents a recognized primitive; otherwise,
        /// returns <see cref='PrimalIdentity.Empty'/>
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static PrimalIdentity primal(Type src)
            => src.IsSystemDefined() ?
               (NumericKinds.test(src)
               ? PrimalIdentity.Define(src.NumericKind(), ApiIdentity.keyword(src))
               : PrimalIdentity.Define(ApiIdentity.keyword(src))
               ) : PrimalIdentity.Empty;
    }
}