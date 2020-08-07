//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    
    using static Konst;
    using static z;

    [LiteralProvider]
    public readonly struct FormatAtoms
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
        /// <summary>
        /// Defines the singular representative of the <see cref='FlowLiteralKind.Pipe'/> class
        /// </summary>
        public const string Pipe = "|";

        /// <summary>
        /// Defines the <see cref='FlowLiteralKind.PSxN'/> constituent "| {0}"
        /// </summary>
        public const string PS0 = Pipe + SS0;

        /// <summary>
        /// Defines the <see cref='FlowLiteralKind.PSxN'/> constituent "| {1}"
        /// </summary>
        public const string PS1 = Pipe + SS1;

        /// <summary>
        /// Defines the <see cref='FlowLiteralKind.PSxN'/> constituent "| {2}"
        /// </summary>
        public const string PS2 = Pipe + SS2;

        /// <summary>
        /// Defines the <see cref='FlowLiteralKind.PSxN'/> constituent "| {3}"
        /// </summary>
        public const string PS3 = Pipe + SS3;

        /// <summary>
        /// Defines the <see cref='FlowLiteralKind.PSxN'/> constituent "| {4}"
        /// </summary>
        public const string PS4 = Pipe + SS4;

        /// <summary>
        /// Defines the <see cref='FlowLiteralKind.PSxN'/> constituent "| {5}"
        /// </summary>
        public const string PS5 = Pipe + SS5;

        /// <summary>
        /// Defines the literal "{0} | {1}"
        /// </summary>
        public const string PSx2 = Slot0 + SpacePipe + Slot1;

        /// <summary>
        /// Defines the literal "{0} | {1} | {2}"
        /// </summary>
        public const string PSx3 = PSx2 + SpacePipe + Slot2;

        /// <summary>
        /// Defines the literal "{0} | {1} | {2} | {3}"
        /// </summary>
        public const string PSx4 = PSx3 + SpacePipe + Slot3;

        /// <summary>
        /// Defines the literal "{0} | {1} | {2} | {3} | {4}"
        /// </summary>
        public const string PSx5 = PSx4 + SpacePipe + Slot4;

        /// <summary>
        /// Defines the literal "{0} | {1} | {2} | {3} | {4} | {5}"
        /// </summary>
        public const string PSx6 = PSx5 + SpacePipe + Slot5;

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