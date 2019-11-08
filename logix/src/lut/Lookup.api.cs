//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static As;

    public static class Lookup
    {        

        /// <summary>
        /// Retrieves a slot-identified key from a lookup table
        /// </summary>
        /// <param name="table">The source table</param>
        /// <param name="slot">The key slot</param>
        [MethodImpl(Inline)]
        public static LookupKey GetKey(in Lut16 table, LookupSlot slot)
        {
            ref var key = ref seekb(ref Unsafe.As<Lut16,byte>(ref asRef(in table)), (byte)slot);
            return (LookupKey)key;
        }

        [MethodImpl(Inline)]
        public static void SetKey(ref Lut16 table, LookupSlot slot, LookupKey value)
        {
            ref var key = ref seekb(ref Unsafe.As<Lut16,byte>(ref table), (byte)slot);
            key = (byte)value;
        }

        /// <summary>
        /// Loads a cpu vector from a lookup table
        /// </summary>
        /// <param name="src">The source table</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> LoadVector(in Lut16 src)
        {
            ref var mem = ref Unsafe.As<Lut16,byte>(ref As.asRef(in src));
            return ginx.vload(n128, in mem);
        }

        /// <summary>
        /// Loads a cpu vector from a lookup table
        /// </summary>
        /// <param name="src">The source table</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> LoadVector(in Lut32 src)
        {
            ref var mem = ref Unsafe.As<Lut32,byte>(ref As.asRef(in src));
            return ginx.vload(n256, in mem);
        }

        /// <summary>
        /// Loads a span from lookup table content
        /// </summary>
        /// <param name="src">The source table</param>
        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsSpan(in Lut16 src)
        {
            ref var mem = ref Unsafe.As<Lut16,byte>(ref As.asRef(in src));
            return new Span<byte>(As.constptr(in src), Lut16.Size);
        }

        /// <summary>
        /// Loads a span from lookup table content
        /// </summary>
        /// <param name="src">The source table</param>
        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsSpan(in Lut32 src)
        {
            ref var mem = ref Unsafe.As<Lut32,byte>(ref As.asRef(in src));
            return new Span<byte>(As.constptr(in src), Lut32.Size);
        }

        /// <summary>
        /// Loads an existing lookup table from a source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target table</param>
        [MethodImpl(Inline)]
        public static ref Lut16 From(Vector128<byte> src, ref Lut16 dst)
        {            
            ref var mem = ref Unsafe.As<Lut16,byte>(ref dst);
            ginx.vstore(src, ref mem);
            return ref dst;            
        }

        /// <summary>
        /// Loads an existing lookup table from a source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target table</param>
        [MethodImpl(Inline)]
        public static ref Lut32 From(Vector256<byte> src, ref Lut32 dst)
        {            
            ref var mem = ref Unsafe.As<Lut32,byte>(ref dst);
            ginx.vstore(src, ref mem);
            return ref dst;            
        }

        /// <summary>
        /// Defines a 16-key lookup table from the elements in a span
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Lut16 From(N16 n, Span<byte> src)
            => head(MemoryMarshal.Cast<byte,Lut16>(src));

        /// <summary>
        /// Defines a 32-key lookup table from the elements in a span
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Lut32 From(N32 n, Span<byte> src)
            => head(MemoryMarshal.Cast<byte,Lut32>(src));

    }
}