//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct WfDelegates
    {
        /// <summary>
        /// Canonical signature for a function that projects the values of an enumeration onto a contiguous and strictly monotonic sequence
        /// of integers [0,.., n - 1] where n denotes the maximum number of indexed items
        /// </summary>
        /// <param name="k">The enum literal to map to an integer value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [Free]
        public delegate ulong Indexer<E>(E k)
            where E : unmanaged;
    }
}