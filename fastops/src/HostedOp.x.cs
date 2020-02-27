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

    public static class HostedOpX
    {
        /// <summary>
        /// Determines the direct operations available through an api host
        /// </summary>
        /// <param name="src">The source host</param>
        public static IEnumerable<DirectOpGroup> DirectOps(this ApiHost src)
            => HostedOps.groups(src);

        /// <summary>
        /// Determines the generic operations available through an api host
        /// </summary>
        /// <param name="src">The source host</param>
        public static IEnumerable<GenericOpSpec> GenericOps(this ApiHost src)
            => HostedOps.generic(src);

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<ClosedOpSpec> Close(this GenericOpSpec op)
            => HostedOps.close(op);        

    }
}
