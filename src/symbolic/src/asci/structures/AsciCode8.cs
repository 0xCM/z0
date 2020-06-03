//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Control;
    using static AC8;

    using N = N8;
    using C = AsciCode;
    using A = AsciCharCode;
    using API = AsciCodes;


    [ApiHost]
    public class AC8 : AsciCodeApi<N8,AC8>
    {
        public static AsciCode8 Empty => new AsciCode8(0);

        public const int Length = (int)N.Value;

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode8 define(in ulong src)
            => ref view<ulong,AsciCode8>(src);

        /// <summary>
        /// Populates an 8-code asci block from a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode8 fill(ReadOnlySpan<char> src, out AsciCode8 dst)
        {
            dst = default;
            API.literals(src, Control.span<AsciCode8,A>(ref dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static AsciCode8 define(ReadOnlySpan<byte> src)
            => define(head(cast<byte,uint>(src)));

        [MethodImpl(Inline), Op]
        public static C code(AsciCode8 src, byte index)
            => (byte)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> kinds(AsciCode8 src)
            => cast<C>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode8 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(code(src,index));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> codes(AsciCode8 src)
            => cast<C>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static void chars(AsciCode8 src, Span<char> dst)
        {
            var data = codes(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
            seek(dst,4) = skip(data,4);
            seek(dst,5) = skip(data,5);
            seek(dst,6) = skip(data,6);
            seek(dst,7) = skip(data,7);
        } 

        [MethodImpl(Inline), Op]
        public static string format(AsciCode8 src)
        {
            Span<char> dst = stackalloc char[Length];
            chars(src,dst);
            return new string(dst);
        }

        [MethodImpl(Inline), Op]
        public static A kind(AsciCode8 src, byte index)
            => (A)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static char @char(AsciCode8 src, byte index)
            => (char)kind(src,index);
    }
    
    /// <summary>
    /// Defines a 64-bit asci code sequence of length 8
    /// </summary>
    public readonly struct AsciCode8 : IAsciSequence<AsciCode8,N>
    {        
        internal readonly ulong Data;

        [MethodImpl(Inline)]
        public AsciCode8(ulong src)
        {
            Data = src;
        }
      
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data != 0;
        }

        public AsciCode8 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsciCode8 src)
            => Data == src.Data;

        public override bool Equals(object src)
            => src is AsciCode8 x && Equals(x);

        public override int GetHashCode()
            => Data.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => format(this);
 
        public override string ToString()
            => Format(); 

        [MethodImpl(Inline)]
        public static bool operator ==(AsciCode8 a, AsciCode8 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsciCode8 a, AsciCode8 b)
            => !a.Equals(b);
    }
}