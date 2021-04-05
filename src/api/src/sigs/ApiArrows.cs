//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    using A = ApiArrow;

    public class ApiArrows
    {
        Index<Assembly> Components;

        Index<Type> Hosts;

        Index<A.ApiType> CanonicalTypes;

        void InitTypes()
        {
            CanonicalTypes = sys.alloc<A.ApiType>(256);
            ref var t = ref CanonicalTypes.First;
            seek8k(t, 0) = new A.ApiType((byte)PrimalCode.None);
            seek8k(t, PrimalCode.U1) = new A.ApiType((byte)PrimalCode.U1);

            seek8k(t, PrimalCode.U8) = new A.ApiType((byte)PrimalCode.U8);
            seek8k(t, PrimalCode.U16) = new A.ApiType((byte)PrimalCode.U16);
            seek8k(t, PrimalCode.U32) = new A.ApiType((byte)PrimalCode.U32);
            seek8k(t, PrimalCode.U64) = new A.ApiType((byte)PrimalCode.U64);

            seek8k(t, PrimalCode.I8) = new A.ApiType((byte)PrimalCode.I8);
            seek8k(t, PrimalCode.I16) = new A.ApiType((byte)PrimalCode.I16);
            seek8k(t, PrimalCode.I32) = new A.ApiType((byte)PrimalCode.I32);
            seek8k(t, PrimalCode.I64) = new A.ApiType((byte)PrimalCode.I64);

            seek8k(t, PrimalCode.C16) = new A.ApiType((byte)PrimalCode.C16);

            seek8k(t, PrimalCode.F32) = new A.ApiType((byte)PrimalCode.F32);
            seek8k(t, PrimalCode.F64) = new A.ApiType((byte)PrimalCode.F64);
            seek8k(t, PrimalCode.F128) = new A.ApiType((byte)PrimalCode.F128);

            seek8k(t, PrimalCode.Object) = new A.ApiType((byte)PrimalCode.Object);
            seek8k(t, PrimalCode.DBNull) = new A.ApiType((byte)PrimalCode.DBNull);
            seek8k(t, PrimalCode.DateTime) = new A.ApiType((byte)PrimalCode.DateTime);
            seek8k(t, PrimalCode.String) = new A.ApiType((byte)PrimalCode.String);
        }

        ApiArrows()
        {
            InitTypes();
        }

        public ApiArrow Define(OpUri uri)
        {

            return default;
        }
    }

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

            public ApiSigs.ModifierKind Modifier {get;}

            [MethodImpl(Inline)]
            public Operand(uint4 index, ApiSigs.ModifierKind modifier)
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