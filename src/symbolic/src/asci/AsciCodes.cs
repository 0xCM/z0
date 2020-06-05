//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static Seed;
    using static Control;

    [ApiHost]
    public partial class AsciCodes : IApiHost<AsciCodes>
    {                
        [MethodImpl(Inline), Op]
        public void Encode(string[] values, N16 w, Span<byte> dst)
        {
            var count = values.Length;
            ReadOnlySpan<string> src = values;
            for(int i=0, j=0; i< count; i++, j+=w)
            {
                ReadOnlySpan<char> value = skip(src,i);
                AC16.encode(value, out var encoded);
                encoded.CopyTo(dst.Slice(j,w));                            
            }
        }

        [MethodImpl(Inline)]
        internal static Vector256<ushort> vinflate(Vector128<byte> src)
            => ConvertToVector256Int16(src).AsUInt16();

        [MethodImpl(Inline)]
        static ushort vextract(Vector128<ushort> src, byte index)   
        {
            var x = ShiftRightLogical(src, index);
            return (ushort)ConvertToUInt32(x.AsUInt32());
        }

        [MethodImpl(Inline)]
        static ushort vextract(Vector256<ushort> src, byte index)   
        {
            var x = ShiftRightLogical(src, index);
            return (ushort)ConvertToUInt32(x.AsUInt32());
        }
    } 
}