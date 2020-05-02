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
    using System.Collections;
    using System.Collections.Generic;

    using static Seed;
    using static Memories;

    using Z0.Asm;

    public static class FormatX53
    {
        public static string FormatCount(this byte src, int zpad = 3)
            => src.ToString().PadLeft(zpad, '0').PadLeft(zpad + 1, Chars.Space) + Chars.Space;

        public static string FormatCount(this ushort src, int zpad = 5)
            => src.ToString().PadLeft(zpad, '0').PadLeft(zpad + 1, Chars.Space) + Chars.Space;

        public static string Format(this FlowControl src)
            => src.ToString();

        public static string FormatLabeled(this FlowControl src)
            => $"flow/{src.Format()}";
    }

    public interface IReflector
    {
        PropertyInfo[] StaticProperties {get;}
    }

    public interface IReflector<F> : IReflector
    {
        PropertyInfo[] IReflector.StaticProperties => typeof(F).StaticProperties();
    }

    public readonly struct Reflector<F> : IReflector<F>
    {

    }

    public interface IEnumerableArray<T> : IEnumerable<T>
    {
        T[] Data {get;}

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Data.AsEnumerable().GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator() 
            => Data.GetEnumerator();

    }

    public interface IBinaryResourceSource : IEnumerableArray<BinaryResource>
    {        
        BinaryResource Find(string id)
            => Data.First(r => r.Id == id);

        Option<BinaryResource> TryFind(string id)
        {
            for(var i=0; i< Data.Length; i++)   
            {
                var res = Data[i];
                if(res.Id == id)
                    return res;
            }
            return none<BinaryResource>();
        }
    }


    public interface IBinaryResourceHost<F> : IBinaryResourceSource
        where F : IBinaryResourceHost<F>, new()
    {
    }

    static class CaseIdBuilder
    {
        public static OpIdentity Op(OpKindId id, params NumericKind[] kinds)
            => Op(id,false,kinds);
        
        public static OpIdentity Op(OpKindId id, bool generic, params NumericKind[] kinds)
        {
            var result = text.build();
            result.Append(id.Format());
            for(var i=0; i<kinds.Length; i++)
            {
                if(i == 0)
                {
                    result.Append(IDI.PartSep);
                    if(generic)
                        result.Append(IDI.Generic);
                    result.Append(IDI.ArgsOpen);
                }
                else
                {
                    result.Append(IDI.ArgSep);
                }
                
                result.Append(kinds[i].Format());
            }
            result.Append(IDI.ArgsClose);

            return Identify.Op(result.ToString());
        }
    }

    public interface IAsmFunctionCases : IBinaryResourceSource
    {
        LocatedCode Case(OpKindId k, params NumericKind[] kinds)
        {
            var id = CaseIdBuilder.Op(k, kinds).ToLegal();
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
    }
}
