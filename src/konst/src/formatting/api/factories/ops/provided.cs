//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial struct Formatters
    {
        /// <summary>
        /// Creates a delegator that formats T-cells via a <see cref='IFormatProvider'/>
        /// </summary>
        /// <param name="provider">The source provider</param>
        /// <param name="t">A cell representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ProvidedFormatter<T> provided<T>(IFormatProvider provider, T t = default)
            where T : IFormattable
                => new ProvidedFormatter<T>(provider);
    }
}