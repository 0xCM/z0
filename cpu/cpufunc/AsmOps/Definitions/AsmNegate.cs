//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static AsmOps;

    partial class AsmOps
    {
        readonly struct NegateHost<T>
            where T : unmanaged
        {
            public static readonly NegateHost<T> TheOnly = default;

            static readonly AsmUnaryOp<T> Reified = NegateCode<T>().CreateUnaryOp();

            public AsmUnaryOp<T> Operator
                => Reified;
        }

        [MethodImpl(Inline)]
        public static AsmUnaryOp<T> Negate<T>()
            where T : unmanaged
                => NegateHost<T>.TheOnly.Operator;

        [MethodImpl(Inline)]
        static AsmCode<T> NegateCode<T>()
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return AsmCode.FromBytes<T>(negate8iBytes);
            else if(typematch<T,byte>())
                return AsmCode.FromBytes<T>(negate8uBytes);
            else if(typematch<T,short>())
                return AsmCode.FromBytes<T>(negate16iBytes);
            else if(typematch<T,ushort>())
                return AsmCode.FromBytes<T>(negate16uBytes);
            else if(typematch<T,int>())
                return AsmCode.FromBytes<T>(negate32iBytes);
            else if(typematch<T,uint>())
                return AsmCode.FromBytes<T>(negate32uBytes);
            else if(typematch<T,long>())
                return AsmCode.FromBytes<T>(negate64iBytes);
            else if(typematch<T,ulong>())
                return AsmCode.FromBytes<T>(negate64uBytes);
            else if(typematch<T,float>())
                return AsmCode.FromBytes<T>(negate32fBytes);
            else if(typematch<T,double>())
                return AsmCode.FromBytes<T>(negate64fBytes);
            else 
                throw unsupported<T>();
        }


        public static ReadOnlySpan<byte> negate8uBytes 
            => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};

        public static ReadOnlySpan<byte> negate8iBytes 
            => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD8,0x48,0x0F,0xBE,0xC0,0xC3};

        public static ReadOnlySpan<byte> negate16iBytes 
            => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD8,0x48,0x0F,0xBF,0xC0,0xC3};

        public static ReadOnlySpan<byte> negate16uBytes 
            => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};

        public static ReadOnlySpan<byte> negate32iBytes 
            => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD8,0xC3};

        public static ReadOnlySpan<byte> negate32uBytes 
            => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};

        public static ReadOnlySpan<byte> negate64iBytes 
            => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0xC3};

        public static ReadOnlySpan<byte> negate64uBytes 
            => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0xC3};

        public static ReadOnlySpan<byte> negate32fBytes 
            => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF2,0x5C,0xC8,0xC5,0xF8,0x28,0xC1,0xC3};

        public static ReadOnlySpan<byte> negate64fBytes 
            => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF3,0x5C,0xC8,0xC5,0xF8,0x28,0xC1,0xC3};

    }
}