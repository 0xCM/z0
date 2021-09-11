//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    public readonly struct AsmLayoutModels
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct LayoutCore : IAsmLayout<LayoutCore>
        {
            public RexPrefix Rex;

            public Hex8 OpCode;

            public ModRm ModRm;

            public Sib Sib;

            public ReadOnlySpan<byte> Content
            {
                [MethodImpl(Inline)]
                get => bytes(this);
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct Layout1 : IAsmLayout<Layout1>
        {
            public Hex8 OpCode;

            public ReadOnlySpan<byte> Content
            {
                [MethodImpl(Inline)]
                get => bytes(this);
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct Layout2 : IAsmLayout<Layout2>
        {
            public Hex8 OpCode;

            public ModRm ModRm;

            public ReadOnlySpan<byte> Content
            {
                [MethodImpl(Inline)]
                get => bytes(this);
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct Layout3 : IAsmLayout<Layout3>
        {
            public RexPrefix Rex;

            public Hex8 OpCode;

            public ModRm ModRm;

            public ReadOnlySpan<byte> Content
            {
                [MethodImpl(Inline)]
                get => bytes(this);
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct Layout6 : IAsmLayout<Layout6>
        {
            public VexPrefix Vex;

            public Hex8 OpCode;

            public ModRm ModRm;

            public Sib Sib;

            public ReadOnlySpan<byte> Content
            {
                [MethodImpl(Inline)]
                get => bytes(this);
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct Layout7 : IAsmLayout<Layout7>
        {
            public Hex8 OpCode;

            public Disp8 Disp;

            public ReadOnlySpan<byte> Content
            {
                [MethodImpl(Inline)]
                get => bytes(this);
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct Layout8 : IAsmLayout<Layout8>
        {
            public Hex8 OpCode;

            public Disp32 Disp;

            public ReadOnlySpan<byte> Content
            {
                [MethodImpl(Inline)]
                get => bytes(this);
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct Layout9 : IAsmLayout<Layout9>
        {
            public VexPrefix Vex;

            public Hex8 OpCode;

            public ModRm ModRm;

            public ReadOnlySpan<byte> Content
            {
                [MethodImpl(Inline)]
                get => bytes(this);
            }
        }
    }
}