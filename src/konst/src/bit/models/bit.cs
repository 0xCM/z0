//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;


    /// <summary>
    /// An anti-succinct representation of a bit 
    /// </summary>
    /// <remarks>
    /// An essay would be required to fully explain why a 32-bit integer is used to 
    /// encose the content of a single bit. Briefly, it is because its the only way
    /// to acheive performance characteristics on par with the system-defined bool
    /// data type. Bool, which is itself predicated on a byte, is a privileged 
    /// data structure that garners special treatment by the runtime. A user-defined
    /// type predicated on a byte would not enjoy this status and would endure
    /// a constant barrage of shifts, movements, etc. from not being 32-bit aligned.
    /// </remarks>    
    [
        IdentityProvider(typeof(bit)),
        UserType(UserTypeId.BitId), 
        Width(TypeWidth.W1),
        ConversionProvider(typeof(BitDataTypeConverter)),
        ApiHost
    ]
    public readonly struct bit : ITextual<bit>, ITypeIdentityProvider<bit> 
    {
        public const char Zero = '0';

        public const char One = '1';

        readonly uint state;        
        
        [MethodImpl(Inline), Op]
        unsafe bit(bool on)
            => this.state  = *((byte*)(&on));

        [MethodImpl(Inline)]
        bit(uint state)
            => this.state = state;

        [MethodImpl(Inline), Op]
        public char ToChar()
            => (char)(state + 48);
        
        [MethodImpl(Inline), Op]
        public static bit Parse(char c)
            => c == One;

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T generic<T>(bit src)
            => Unsafe.As<bit,T>(ref src);                 

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bit specific<T>(T src)
            => Unsafe.As<T,bit>(ref src);        

        public static bit Parse(string src)
            => OnLabels.Contains(src.Trim().ToLower());

        static string[] OnLabels 
            => new string[]{"on", "1", "enabled", "true", "yes"};
            
        /// <summary>
        /// Constructs a disabled bit
        /// </summary>
        public static bit Off 
        {
             [MethodImpl(Inline)]
             get  => new bit(0u);
        }

        /// <summary>
        /// Constructs an enabled bit
        /// </summary>
        public static bit On 
        {
             [MethodImpl(Inline)]
             get  => new bit(1u);
        }

        public static bit[] B01 
        {
            [MethodImpl(Inline)]
            get => new bit[]{Off,On};
        }

        [MethodImpl(Inline), Op]
        public unsafe static bit From(bool src)        
        {
            uint state = *((byte*)(&src));
            return new bit(state);
        }

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static bit test(sbyte src, byte pos)
            => new bit((src & (1 << pos)) != 0);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static bit test(byte src, int pos)
            => Wrap(((uint)src >> pos) & 1);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static bit test(short src, int pos)
            => new bit((src & (1 << pos)) != 0);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static bit test(ushort src, int pos)
            => Wrap(((uint)src >> pos) & 1);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static bit test(int src, int pos)
            => new bit((src & (1 << pos)) != 0);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static bit test(long src, int pos)
            => new bit((src & (1L << pos)) != 0);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static bit test(uint src, int pos)
            => Wrap((src >> pos) & 1);

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static bit test(ulong src, int pos)
            => Wrap((uint)((src >> pos) & 1));

        /// <summary>
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline), Op]
        public static sbyte set(sbyte src, byte pos, bit state)            
        {
            var c = ~(sbyte)state + 1;
            src ^= (sbyte)((c ^ src) & (1 << pos));
            return src;
        }

        /// <summary>
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline), Op]
        public static byte set(byte src, byte pos, bit state)            
        {
            var c = ~(byte)state + 1;
            src ^= (byte)((c ^ src) & (1 << pos));
            return src;
        }

        /// <summary>
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline), Op]
        public static short set(short src, byte pos, bit state)            
        {
            var c = ~(short)state + 1;
            src ^= (short)((c ^ src) & (1 << pos));
            return src;
        }

        /// <summary>
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline), Op]
        public static ushort set(ushort src, byte pos, bit state)            
        {
            var c = ~(ushort)state + 1;
            src ^= (ushort)((c ^ src) & (1 << pos));
            return src;
        }

        /// <summary>
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline), Op]
        public static int set(int src, byte pos, bit state)            
        {
            var c = ~(int)state + 1;
            src ^= (c ^ src) & (1 << pos);
            return src;
        }

        /// <summary>
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline), Op]
        public static uint set(uint src, byte pos, bit state)            
        {
            var c = ~(uint)state + 1u;
            src ^= (c ^ src) & (1u << pos);
            return src;
        }

        /// <summary>
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="pos">The source bit index</param>
        /// <param name="state">The state with which to align a source bit</param>
        [MethodImpl(Inline), Op]
        public static long set(long src, byte pos, bit state)            
        {
            var c = ~(long)state + 1L;
            src ^= (c ^ src) & (1L << pos);
            return src;
        }

        /// <summary>
        /// Aligns an index-identified source bit with with a suplied state
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline), Op]
        public static ulong set(ulong src, byte pos, bit state)
        {
            var c = ~(ulong)state + 1ul;
            src ^= (c ^ src) & (1ul << pos);
            return src;
        }
         
        /// <summary>
        /// The identity function
        /// </summary>
        /// <param name="b">The source bit</param>
        [MethodImpl(Inline), Op]
        public static bit identity(bit b)
            => b;

        /// <summary>
        /// Computes c = a & b
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline), Op]
        public static bit and(bit a, bit b) 
            => Wrap(a.state & b.state);

        /// <summary>
        /// Computes c = a | b
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline), Op]
        public static bit or(bit a, bit b) 
            => Wrap(a.state | b.state);

        /// <summary>
        /// Computes c = a ^ b
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline), Op]
        public static bit xor(bit a, bit b)
            => Wrap(a.state ^ b.state);

        /// <summary>
        /// Computes c := ~a = !a
        /// </summary>
        /// <param name="a">The source bit</param>
        [MethodImpl(Inline), Op]
        public static bit not(bit a)
            => SafeWrap(~a.state);

        /// <summary>
        /// Computes c := ~ (a & b)
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Op]
        public static bit nand(bit a, bit b)
            => SafeWrap(~(a.state & b.state));

        /// <summary>
        /// Computes c := ~ (a | b)
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Logical_biconditional</remarks>
        [MethodImpl(Inline), Op]
        public static bit nor(bit a, bit b)
            => SafeWrap(~(a.state | b.state));

        /// <summary>
        /// Computes c := ~ (a ^ b)
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Logical_biconditional</remarks>
        [MethodImpl(Inline), Op]
        public static bit xnor(bit a, bit b)
            => SafeWrap(~(a.state ^ b.state));

        /// <summary>
        /// Computes c := a -> b := a | ~b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Material_conditional</remarks>
        [MethodImpl(Inline), Op]
        public static bit impl(bit a, bit b)
            => or(a,  not(b));

        /// <summary>
        /// Computes the nonimplication c := a < -- b := ~(a | ~b) = ~a & b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Op]
        public static bit nonimpl(bit a, bit b)
            => and(not(a),  b);

        /// <summary>
        /// Computes the converse implication c := ~a | b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Op]
        public static bit cimpl(bit a, bit b)
            => or(not(a),  b);

        /// <summary>
        /// Computes the converse nonimplication c := a & ~b
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Op]
        public static bit cnonimpl(bit a, bit b)
            => and(a, not(b));

        /// <summary>
        /// Computes the ternary select s := a ? b : c = (a & b) | (~a & c)
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Op]
        public static bit select(bit a, bit b, bit c)
            => SafeWrap((a.state & b.state) | (~a.state & c.state));

        /// <summary>
        /// Returns true if the bit is enabled, false otherwise
        /// </summary>
        /// <param name="b">The bit to test</param>
        [MethodImpl(Inline), Op]
        public static bool operator true(bit b)
            => b.state != 0;

        /// <summary>
        /// Returns false if the bit is disabled, true otherwise
        /// </summary>
        /// <param name="b">The bit to test</param>
        [MethodImpl(Inline), Op]
        public static bool operator false(bit b)
            => b.state == 0;

        /// <summary>
        /// Implicitly constructs a bit from a bool
        /// </summary>
        /// <param name="state">The state of the bit to construct</param>
        [MethodImpl(Inline), Op]
        public static implicit operator bit(bool state)
            => new bit(state);

        /// <summary>
        /// Implicitly constructs a bool from a bit
        /// </summary>
        /// <param name="state">The state of the bit to construct</param>
        [MethodImpl(Inline), Op]
        public static implicit operator bool(bit src)
            => src.state != 0;

        /// <summary>
        /// Defines an explicit bit -> byte conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static explicit operator byte(bit src)
            => (byte)src.state;

        /// <summary>
        /// Defines an explicit bit -> byte conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static explicit operator sbyte(bit src)
            => (sbyte)src.state;

        /// <summary>
        /// Defines an explicit byte -> bit conversion
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static explicit operator bit(byte src)
            => SafeWrap(src);

        /// <summary>
        /// Defines an explicit bit -> ushort conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static explicit operator ushort(bit src)
            => (ushort)src.state;

        /// <summary>
        /// Defines an explicit bit -> ushort conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static explicit operator short(bit src)
            => (short)src.state;

        /// <summary>
        /// Defines an explicit ushort -> bit conversion
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static explicit operator bit(ushort src)
            => SafeWrap(src);

        /// <summary>
        /// Defines an explicit bit -> int conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static explicit operator int(bit src)
            => (int)src.state;

        /// <summary>
        /// Defines an *implicit* int -> bit conversion to aid sanity retention
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static implicit operator bit(int src)
            => SafeWrap(src);

        /// <summary>
        /// Defines an explicit bit -> uint conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static explicit operator uint(bit src)
            => src.state;

        /// <summary>
        /// Defines an explicit bit -> long conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static explicit operator long(bit src)
            => src.state;

        /// <summary>
        /// Defines an explicit bit -> float conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static explicit operator float(bit src)
            => src.state;

        /// <summary>
        /// Defines an explicit bit -> double conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static explicit operator double(bit src)
            => src.state;

        /// <summary>
        /// Defines an explicit uint -> bit conversion
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static explicit operator bit(uint src)
            => SafeWrap(src);

        /// <summary>
        /// Defines an explicit bit -> ulong conversion
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static explicit operator ulong(bit src)
            => src.state;

        [MethodImpl(Inline), Op]
        public static implicit operator bit(BitState src)
            => new bit((byte)src);

        [MethodImpl(Inline), Op]
        public static implicit operator BitState(bit src)
            => (BitState)(byte)src;

        /// <summary>
        /// Defines an explicit ulong -> bit conversion
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static explicit operator bit(ulong src)
            => SafeWrap(src);

        /// <summary>
        /// Combines the states of the source bits
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator + (bit a, bit b) 
            => Wrap(a.state ^ b.state);

        /// <summary>
        /// Computes the bitwise AND between the operands
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator & (bit a, bit b) 
            => and(a,b);

        /// <summary>
        /// Computes the bitwise OR between the operands
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator | (bit a, bit b) 
            => or(a,b);
            
        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator ^ (bit a, bit b) 
            => xor(a,b);

        /// <summary>
        /// Inverts the state of the source bit
        /// </summary>
        /// <param name="a">The source bit</param>
        [MethodImpl(Inline)]
        public static bit operator ~ (bit a) 
            => not(a);

        /// <summary>
        /// Inverts the state of the source bit
        /// </summary>
        /// <param name="a">The source bit</param>
        [MethodImpl(Inline)]
        public static bit operator ! (bit a) 
            => not(a);

        [MethodImpl(Inline)]
        public static bool operator ==(bit a, bit b)
            => a.state == b.state;

        [MethodImpl(Inline)]
        public static bool operator !=(bit a, bit b)
            => a.state != b.state;

        /// <summary>
        /// Promotes a bit to a numeric value where all target bits are enabled if the state of the
        /// bit is on; otherwise all target bits are disabled
        /// </summary>
        /// <param name="src">The source bit</param>
        /// <typeparam name="T">The target numeric type</typeparam>
        [MethodImpl(Inline), Op]
        public T Promote<T>()
            where T : unmanaged
                => this ? NumericLiterals.maxval<T>() : default;

        [MethodImpl(Inline), Op]
        public bool Equals(bit b)
            => state == b.state; 

        public override bool Equals(object b)
            => b is bit x && Equals(x);

        public override int GetHashCode()
            => (int)state; 
        
        public string Format()
            => state.ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline), Op]
        static bit Wrap(uint state)
            => new bit(state);

        [MethodImpl(Inline), Op]
        static bit SafeWrap(byte state)
            => new bit((uint)state & 1);

        [MethodImpl(Inline), Op]
        static bit SafeWrap(ushort state)
            => new bit((uint)state & 1);

        [MethodImpl(Inline), Op]
        static bit SafeWrap(uint state)
            => new bit(state & 1);

        [MethodImpl(Inline), Op]
        static bit SafeWrap(int state)
            => new bit((uint)state & 1);

        [MethodImpl(Inline), Op]
        static bit SafeWrap(ulong state)
            => new bit((uint)state & 1);

        [MethodImpl(Inline)]
        public TypeIdentity Identity()
            => TypeIdentity.Define("1u");
    }

    /// <summary>
    /// Conversion provider for the bit data type
    /// </summary>
    readonly struct BitDataTypeConverter : IConversionProvider<BitDataTypeConverter, bit>, IBiconverter<bit>
    {
        public BitDataTypeConverter Converter => default;

        [MethodImpl(Inline)]
        public T Convert<T>(bit src)
            => BitConversionOps.from<T>(src);

        [MethodImpl(Inline)]
        public bit Convert<T>(T src) 
            => BitConversionOps.to<T>(src);

        [MethodImpl(Inline)]
        public Option<object> ConvertFromTarget(object incoming, Type dst)
            => BitConversionOps.FromTarget(incoming,dst);

        [MethodImpl(Inline)]
        public Option<object> ConvertToTarget(object incoming)
            => BitConversionOps.ToTarget(incoming);
    }
}