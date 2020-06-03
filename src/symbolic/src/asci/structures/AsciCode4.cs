//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Control;
    using static AC4;

    using N = N4;    
    using A = AsciCharCode;
    using C = AsciCode;
    using API = AsciCodes;

    [ApiHost]
    public class AC4 : AsciCodeApi<N4,AC4>
    {
        public const int Length = (int)N.Value;

        public static AsciCode4 Empty => new AsciCode4(0);

 
        [MethodImpl(Inline), Op]
        public static C code(AsciCode4 src, byte index)
            => (byte)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> codes(AsciCode4 src)
            => cast<C>(bytespan(src));


        [MethodImpl(Inline), Op]
        public static AsciCode4 define(C a, C b, C c, C d)
        {
            var x0 = (uint)a;
            var x1 = (uint)((uint)b << 8);
            var x2 = (uint)((uint)c << 16);
            var x3 = (uint)((uint)d << 24);
            return new AsciCode4(x0 | x1 | x2 | x3);
        }

        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode4 define(in uint src)
            => ref view<uint,AsciCode4>(src);

        [MethodImpl(Inline), Op]
        public static AsciCode4 define(string src)
        {
            var dst = 0u;
            var data = span(src);
            ref readonly var src16 = ref head(data);
            ref var dst8 = ref imagine<uint,byte>(ref dst);
            seek(ref dst8, 0) = (byte)skip(src16, 0);
            seek(ref dst8, 1) = (byte)skip(src16, 1);
            seek(ref dst8, 2) = (byte)skip(src16, 2);
            seek(ref dst8, 3) = (byte)skip(src16, 3);
            return define(dst);
        }

        [MethodImpl(Inline), Op]
        public static AsciCode4 define(ReadOnlySpan<byte> src)
            => define(head(cast<byte,uint>(src)));
        
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> kinds(AsciCode4 src)
            => cast<C>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static Symbol<AsciChar,byte> symbol(AsciCode4 src, byte index)
            => Symbolic.symbol<AsciChar,byte>(code(src,index));

        [MethodImpl(Inline), Op]
        public static A kind(AsciCode4 src, byte index)
            => (A)(src.Data >> index);

        [MethodImpl(Inline), Op]
        public static char @char(AsciCode4 src, byte index)
            => (char)kind(src,index);


        [MethodImpl(Inline), Op]
        public static void chars(AsciCode4 src, Span<char> dst)
        {
            var data = codes(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
        } 

        /// <summary>
        /// Populates a 4-code asci block from a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode4 fill(ReadOnlySpan<char> src, out AsciCode4 dst)
        {
            dst = default;
            API.literals(src, Control.span<AsciCode4,A>(ref dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static string format(AsciCode4 src)
        {
            Span<char> dst = stackalloc char[Length];
            chars(src,dst);
            return new string(dst);
        }

    }

    /// <summary>
    /// Defines an asci code sequence of length 4
    /// </summary>
    public readonly struct AsciCode4 : IAsciSequence<AsciCode4,N>
    {        
        internal readonly uint Data;

        [MethodImpl(Inline)]
        public AsciCode4(uint src)
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

        public AsciCode4 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsciCode4 src)
            => Data == src.Data;

        public override bool Equals(object src)
            => src is AsciCode4 j && Equals(j);

        public override int GetHashCode()
            => Data.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => format(this);
 
        public override string ToString()
            => Format(); 

        [MethodImpl(Inline)]
        public static bool operator ==(AsciCode4 a, AsciCode4 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsciCode4 a, AsciCode4 b)
            => !a.Equals(b);
    }
}