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
        /// <summary>
        /// Defines the literal " {0}"
        /// </summary>
        public const string SS0 = Space + Slot0;

        /// <summary>
        /// Defines the literal " {1}"
        /// </summary>
        public const string SS1 = Space + Slot1;

        /// <summary>
        /// Defines the literal " {2}"
        /// </summary>
        public const string SS2 = Space + Slot2;

        /// <summary>
        /// Defines the literal " {3}"
        /// </summary>
        public const string SS3 = Space + Slot3;

        /// <summary>
        /// Defines the literal " {4}"
        /// </summary>
        public const string SS4 = Space + Slot4;

        /// <summary>
        /// Defines the literal " {5}"
        /// </summary>
        public const string SS5 = Space + Slot5;

        /// <summary>
        /// Defines the literal "{0} {1}"
        /// </summary>
        public const string SSx2 = Slot0 + SS1;        

        /// <summary>
        /// Defines the literal "{0} {1} {2}"
        /// </summary>
        public const string SSx3 = Slot0 + SS1 + SS2;        

        /// <summary>
        /// Defines the literal "{1} {2}"
        /// </summary>
        public const string SS1x2 = Slot1 + SS2;

        /// <summary>
        /// Defines the literal "{1} {2} {3}"
        /// </summary>
        public const string SS1x3 = Slot0 + SS1 + SS2 + SS3;
    }
}