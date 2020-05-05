//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;

    public interface IAsmFunctionCases : IBinaryResources
    {
        LocatedCode Case(OpKindId k, params NumericKind[] kinds)
        {
            var id = Identify.NumericOp(k, kinds).ToLegalIdentifier();
            var resource = TryFind(id);
            if(!resource)
                throw new KeyNotFoundException(id);

            return LocatedCode.Define(MemoryAddress.Zero, resource.Require().Data.ToArray());
        }
    }

    public readonly struct ParsedFunctions : IBinaryResourceHost<ParsedFunctions>, IAsmFunctionCases
    {        
        public static IAsmFunctionCases Service => new ParsedFunctions(BinaryResource.Providers<ParsedFunctions>().Length);

        [MethodImpl(Inline)]
        ParsedFunctions(int count)
        {
            Data = Control.alloc<BinaryResource>(count);
            var index = 0;
            Register(index++, Identify.Op(nameof(or_ᐤ8uㆍ8uᐤ)), or_ᐤ8uㆍ8uᐤ);
            Register(index++, Identify.Op(nameof(or_ᐤ16uㆍ16uᐤ)), or_ᐤ16uㆍ16uᐤ);
            Register(index++, Identify.Op(nameof(or_ᐤ32uㆍ32uᐤ)), or_ᐤ32uㆍ32uᐤ);
            Register(index++, Identify.Op(nameof(or_ᐤ64uㆍ64uᐤ)), or_ᐤ64uㆍ64uᐤ);
            Register(index++, Identify.Op(nameof(within_ᐤ8uㆍ8uㆍ8uᐤ)), within_ᐤ8uㆍ8uㆍ8uᐤ);
        }

        public BinaryResource[] Data {get;}

        [MethodImpl(Inline)]
        unsafe void Register(int index, OpIdentity id, ReadOnlySpan<byte> src)
            => Data[index] = BinaryResource.Define(PartId.AsmTest, id, src); 

        public static ReadOnlySpan<byte> or_ᐤ8uㆍ8uᐤ => new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0xc3}; 

        public static ReadOnlySpan<byte> or_ᐤ16uㆍ16uᐤ => new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xd2,0x0b,0xc2,0x0f,0xb7,0xc0,0xc3};    

        public static ReadOnlySpan<byte> or_ᐤ32uㆍ32uᐤ => new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x0b,0xc2,0xc3};    

        public static ReadOnlySpan<byte> or_ᐤ64uㆍ64uᐤ => new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x48,0x0b,0xc2,0xc3};

        public static ReadOnlySpan<byte> within_gᐸ8uᐳᐤ8uㆍ8uㆍ8uᐤ => new byte[43]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x41,0x0f,0xb6,0xc8,0x3b,0xc2,0x73,0x07,0x2b,0xd0,0x44,0x8b,0xc2,0xeb,0x05,0x2b,0xc2,0x44,0x8b,0xc0,0x8b,0xc1,0x4c,0x3b,0xc0,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xc3};        

        public static ReadOnlySpan<byte> within_ᐤ8uㆍ8uㆍ8uᐤ => new byte[41]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x3b,0xc2,0x7d,0x07,0x2b,0xd0,0x48,0x63,0xca,0xeb,0x05,0x2b,0xc2,0x48,0x63,0xc8,0x41,0x0f,0xb6,0xc0,0x48,0x3b,0xc8,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> f52_gᐸ8uᐳᐤ8uㆍ8uㆍ8uᐤ => new byte[43]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc2,0x41,0x0f,0xb6,0xd0,0x44,0x8b,0xc2,0x41,0x23,0xc0,0x0f,0xb6,0xc0,0xf7,0xd0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc9,0x33,0xd1,0x0f,0xb6,0xd2,0x0f,0xb6,0xc0,0x23,0xc2,0x0f,0xb6,0xc0,0xc3};        
    }
}