//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Alternate representation for uri's such as located://bitgrids/bitgrid?and#and_g[8u](bg8u~in,bg8u~in,bg8u~in)
    /// </summary>
    public partial struct ApiArrow
    {
        internal Component C;

        internal Component H;

        internal Name N;

        internal Parameters P;

        internal Operands O;

        public readonly struct Component
        {
            public ushort Index {get;}

            [MethodImpl(Inline)]
            public Component(ushort index)
            {
                Index = index;
            }
        }

        public readonly struct Host
        {
            public ushort Index {get;}

            [MethodImpl(Inline)]
            public Host(ushort index)
            {
                Index = index;
            }
        }

        public readonly struct ApiType
        {
            public ushort Index {get;}

            [MethodImpl(Inline)]
            public ApiType(ushort index)
            {
                Index = index;
            }
        }

        public readonly struct Name
        {
            public ushort Index {get;}

            [MethodImpl(Inline)]
            public Name(ushort index)
            {
                Index = index;
            }
        }

        public readonly struct OpenParameter
        {
            public uint4 Index {get;}

            [MethodImpl(Inline)]
            public OpenParameter(uint4 index)
            {
                Index = index;
            }
        }

        public readonly struct ClosedParameter
        {
            public OpenParameter Parameter {get;}

            public ApiType Closure {get;}

            [MethodImpl(Inline)]
            public ClosedParameter(OpenParameter p, ApiType c)
            {
                Parameter = p;
                Closure = c;
            }
        }

        public readonly struct Parameters
        {
            public Cell256 Data {get;}

            [MethodImpl(Inline)]
            public Parameters(Cell256 data)
            {
                Data = data;
            }
        }

        public readonly struct Operand
        {
            public uint4 Index {get;}

            public ApiSigModKind Modifier {get;}

            [MethodImpl(Inline)]
            public Operand(uint4 index, ApiSigModKind modifier)
            {
                Index = index;
                Modifier = modifier;
            }
        }

        public readonly struct Operands
        {
            public Cell256 Data {get;}

            [MethodImpl(Inline)]
            public Operands(Cell256 data)
            {
                Data = data;
            }
        }
    }
}