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

    using A = AsciCharCode;    
    using C = AsciCode;

    public abstract class AsciCodeApi<N,T>
        where N : unmanaged, ITypeNat
        where T : AsciCodeApi<N,T>, new()
    {

    }

    [ApiHost]
    public partial class AsciCodes : IApiHost<AsciCodes>
    {                
        [MethodImpl(Inline), Op]
        public static void codes(ReadOnlySpan<char> src, Span<C> dst)
        {
            var count = Math.Min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i);
        }

        [MethodImpl(Inline), Op]
        public static void bytes(ReadOnlySpan<char> src, Span<byte> dst)
        {
            var count = Math.Min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
                seek(dst,i) = (byte)skip(src,i);
        }

        [MethodImpl(Inline), Op]
        public static void bytes(in char src, int count, ref byte dst)
        {
            for(var i=0; i<count; i++)
                seek(ref dst,i) = (byte)skip(src,i);
        }

        [MethodImpl(Inline), Op]
        public static void literals(in char src, int count, ref A dst)
        {
            for(var i=0; i<count; i++)
                seek(ref dst,i) = (A)skip(src,i);
        }

        [MethodImpl(Inline), Op]
        public static void literals(ReadOnlySpan<char> src, Span<A> dst)
        {
            var count = Math.Min(src.Length, dst.Length);
            literals(in head(src), count, ref head(dst));
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