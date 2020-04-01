//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Core
    {
        /// <summary>
        /// Computes the type width of a prametrically-identified type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static TypeWidth width<T>()     
            where T : struct       
                => (TypeWidth)bitsize<T>();

    }
}