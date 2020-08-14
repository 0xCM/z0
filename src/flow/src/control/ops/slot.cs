//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static FormatLiterals;

    partial struct Flow    
    {
        /// <summary>
        /// Retrieves the <see cref='Slot0' /> literal
        /// </summary>
        /// <param name="n">The slot selector</param>
        [MethodImpl(Inline), Op]
        public static string slot(N0 n)
            => Slot0;
        
        /// <summary>
        /// Retrieves the <see cref='Slot1' /> literal
        /// </summary>
        /// <param name="n">The slot selector</param>
        [MethodImpl(Inline), Op]
        public static string slot(N1 n)
            => Slot1;

        /// <summary>
        /// Retrieves the <see cref='Slot2' /> literal
        /// </summary>
        /// <param name="n">The slot selector</param>
        [MethodImpl(Inline), Op]
        public static string slot(N2 n)
            => Slot2;

        /// <summary>
        /// Retrieves the <see cref='Slot3' /> literal
        /// </summary>
        /// <param name="n">The slot selector</param>
        [MethodImpl(Inline), Op]
        public static string slot(N3 n)
            => Slot3;
        
        /// <summary>
        /// Retrieves the <see cref='Slot4' /> literal
        /// </summary>
        /// <param name="n">The slot selector</param>
        [MethodImpl(Inline), Op]
        public static string slot(N4 n)
            => Slot4;
    }
}