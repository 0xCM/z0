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
    using static AC32;

    using N = N32;
    using API = AsciCodes;
    using A = AsciCharCode;

    [ApiHost]
    public class AC32 : AsciCodeApi<N32,AC32>
    {
        public static AsciCode32 Blank => Init(AsciCharCode.Space);

        public static AsciCode32 Null => new AsciCode32(Vector256<byte>.Zero);

        public const int Length = (int)N.Value;

        [MethodImpl(Inline)]
        public static AsciCode32 Init(AsciCharCode fill = AsciCharCode.Space)
            => new AsciCode32(SymBits.vbroadcast(w256, (byte)fill));

        [MethodImpl(Inline), Op]
        public static string format(AsciCode32 src)
            => new string(chars(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in AsciCode32 src)
        {            
            var lo = API.vinflate(Vector256.GetLower(src.Data));
            var hi = API.vinflate(Vector256.GetUpper(src.Data));
            var data = new Seg512(lo,hi);
            return cast<char>(Control.bytespan(data));
        }

        /// <summary>
        /// Populates a 32-code asci block from a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static ref readonly AsciCode32 fill(ReadOnlySpan<char> src, out AsciCode32 dst)
        {
            dst = default;
            API.literals(src, Control.span<AsciCode32,A>(ref dst));
            return ref dst;
        }

        /// <summary>
        /// Populates a 16-code asci block from a character span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        [MethodImpl(Inline), Op]
        public static AsciCode32 fill(ReadOnlySpan<char> src)
        {
            var dst = Init();
            API.literals(src, Control.span<AsciCode32,A>(ref dst));
            return dst;
        }

        readonly struct Seg512
        {
            readonly Vector256<ushort> Lo;

            readonly Vector256<ushort> Hi;

            [MethodImpl(Inline), Op]
            public Seg512(Vector256<ushort> lo, Vector256<ushort> hi)
            {
                this.Lo = lo;
                this.Hi = hi;
            }
        }

        public static ArraySpan<AsciCode32> Alloc(int count)
        {
            ArraySpan<AsciCode32> dst = new AsciCode32[count];
            dst.Fill(Blank);
            return dst;
        }

    }
    
    /// <summary>
    /// Defines an asci code sequence of length 32
    /// </summary>
    public readonly struct AsciCode32 : IAsciSequence<AsciCode32,N>
    {
        internal readonly Vector256<byte> Data;        

        [MethodImpl(Inline)]
        public AsciCode32(Vector256<byte> src)
        {
            Data = src;
        }
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.Equals(default);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !Data.Equals(default);
        }

        public AsciCode32 Zero
        {
            [MethodImpl(Inline)]
            get => AC32.Null;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsciCode32 src)
            => Data.Equals(src.Data);
 
         public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is AsciCode32 j && Equals(j);

        [MethodImpl(Inline)]
        public string Format()
            => format(this);
 
        public override string ToString()
            => Format(); 

        [MethodImpl(Inline)]
        public static bool operator ==(AsciCode32 a, AsciCode32 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsciCode32 a, AsciCode32 b)
            => !a.Equals(b);

 
    }
}