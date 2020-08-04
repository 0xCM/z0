//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow    
    {
        const string Space = " ";

        /// <summary>
        /// Defines the literal "{0}"
        /// </summary>
        public const string Slot0 = "{0}";
        
        /// <summary>
        /// Defines the literal "{1}"
        /// </summary>
        public const string Slot1 = "{1}";

        /// <summary>
        /// Defines the literal "{2}"
        /// </summary>
        public const string Slot2 = "{2}";

        /// <summary>
        /// Defines the literal "{3}"
        /// </summary>
        public const string Slot3 = "{3}";

        /// <summary>
        /// Defines the literal "{4}"
        /// </summary>
        public const string Slot4 = "{4}";

        /// <summary>
        /// Defines the literal "{5}"
        /// </summary>
        public const string Slot5 = "{5}";

        /// <summary>
        /// Defines the literal "{6}"
        /// </summary>
        public const string Slot6 = "{6}";

        /// <summary>
        /// Retrieves the <see cref='Slot0' /> literal
        /// </summary>
        /// <param name="n">The slot selector</param>
        public static string slot(N0 n)
            => Slot0;
        
        /// <summary>
        /// Retrieves the <see cref='Slot1' /> literal
        /// </summary>
        /// <param name="n">The slot selector</param>
        public static string slot(N1 n)
            => Slot1;

        /// <summary>
        /// Retrieves the <see cref='Slot2' /> literal
        /// </summary>
        /// <param name="n">The slot selector</param>
        public static string slot(N2 n)
            => Slot2;

        /// <summary>
        /// Retrieves the <see cref='Slot3' /> literal
        /// </summary>
        /// <param name="n">The slot selector</param>
        public static string slot(N3 n)
            => Slot3;
        
        /// <summary>
        /// Retrieves the <see cref='Slot4' /> literal
        /// </summary>
        /// <param name="n">The slot selector</param>
        public static string slot(N4 n)
            => Slot4;
    }
}