//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static PartIdentity;

    partial class Widths
    {        
        /// <summary>
        /// Computes the width of a parametrically-identified measurable type
        /// </summary>
        /// <typeparam name="T">The measurable type</typeparam>
        [MethodImpl(Inline)]
        public static uint measure<T>()
            where T : struct
                =>  (uint)(Unsafe.SizeOf<T>()*8);
    }
}