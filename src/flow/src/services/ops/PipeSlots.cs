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
        const string Pipe = "|";

        /// <summary>
        /// Defines the literal "| {0}"
        /// </summary>
        public const string PS0 = Pipe + SS0;

        /// <summary>
        /// Defines the literal "| {1}"
        /// </summary>
        public const string PS1 = Pipe + SS1;

        /// <summary>
        /// Defines the literal "| {2}"
        /// </summary>
        public const string PS2 = Pipe + SS2;

        /// <summary>
        /// Defines the literal "| {3}"
        /// </summary>
        public const string PS3 = Pipe + SS3;

        /// <summary>
        /// Defines the literal "| {4}"
        /// </summary>
        public const string PS4 = Pipe + SS4;

        /// <summary>
        /// Defines the literal "| {5}"
        /// </summary>
        public const string PS5 = Pipe + SS5;

        /// <summary>
        /// Defines the literal "{0} | {1}"
        /// </summary>
        public const string PSx2 = Slot0 + SpacePipe + Slot1;

        /// <summary>
        /// Defines the literal "{0} {1} {2}"
        /// </summary>
        public const string PSx3 = PSx2 + SpacePipe + Slot2;

        /// <summary>
        /// Defines the literal "{0} {1} {2} {3}"
        /// </summary>
        public const string PSx4 = PSx3 + SpacePipe + Slot3;

        /// <summary>
        /// Defines the literal "{1} | {2}"
        /// </summary>
        public const string PS1x2 = Slot1 + SpacePipe + Slot2;

        /// <summary>
        /// Defines the literal "{1} | {2} | {3}"
        /// </summary>
        public const string PS1x3 = PS1x2 + SpacePipe + Slot3;


        /// <summary>
        /// Defines the literal "{1} | {2} | {3} {4}"
        /// </summary>
        public const string PS1x4 = PS1x3 + SpacePipe + Slot4;

    }
}