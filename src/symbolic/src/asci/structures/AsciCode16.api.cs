//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Typed;
    using static Control;

    using N = N16;
    using API = AsciCodes;
    using A = AsciCharCode;
    using C = AsciCode;

    [ApiHost]
    public class AC16 : AsciCodeApi<N8,AC16>
    {
        public const int Length = (int)N.Value;

        public static AsciCode16 Blank => Init(AsciCharCode.Space);
        
        public static AsciCode16 Null => new AsciCode16(Vector128<byte>.Zero);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> codes(AsciCode16 src)
            => cast<C>(bytespan(src)); 

        [MethodImpl(Inline), Op]
        public static AsciCode16 define(ulong lo, ulong hi)
            => new AsciCode16(Vector128.Create(lo,hi).AsByte());

        public static ArraySpan<AsciCode16> Alloc(int count)
        {
            ArraySpan<AsciCode16> dst = new AsciCode16[count];
            dst.Fill(Blank);
            return dst;
        }
        
        /// <summary>
        /// Populates a 16-code asci block from a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static AsciCode16 fill( ReadOnlySpan<char> src)
        {
            var dst = Init();
            Symbolic.literals(src, Control.span<AsciCode16,A>(ref dst));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode16 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(src.Data.GetElement(index));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<AsciChar,byte>> symbols(AsciCode16 src)
            => cast<Symbol<AsciChar,byte>>(bytespan(API.vinflate(src.Data)));

        /// <summary>
        /// Populates a 16-code asci block from a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode16 fill(ReadOnlySpan<char> src, out AsciCode16 dst)
        {
            dst = default;
            Symbolic.literals(src, Control.span<AsciCode16,A>(ref dst));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static AsciCode16 Init(AsciCharCode fill = AsciCharCode.Space)
            => new AsciCode16(SymBits.vbroadcast(w128, (byte)fill));
        
        [MethodImpl(Inline), Op]
        public static A kind(AsciCode16 src, byte index)
            => (A)src.Data.GetElement(index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<A> kinds(AsciCode16 src)
            => cast<A>(bytespan(src)); 

        [MethodImpl(Inline), Op]
        public static char @char(AsciCode16 src, byte index)
            => (char)kind(src,index);

        [MethodImpl(Inline), Op]
        public static AsciCode16 define(ReadOnlySpan<char> src)
        {
            var dst = Init();
            Symbolic.literals(src, Control.span<AsciCode16,AsciCharCode>(ref dst));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static C code(AsciCode16 src, byte index)
            => (C)src.Data.GetElement(index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in AsciCode16 src)
        {
            var data = API.vinflate(src.Data);
            var bytes = bytespan(data);
            var chars = cast<char>(bytes);    
            var len = chars.Length;
            for(var i=0; i<len; i++)
            {
                if((AsciCharCode)skip(chars,i) == AsciCharCode.Null)
                {
                    len = i;
                    break;
                }
            }

            return chars.Slice(0, len);
        }

        [MethodImpl(Inline), Op]
        public static string format(AsciCode16 src)
            => new string(chars(src));
    }
}