//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;
    using static As;

    public struct num<T> : IEquatable<num<T>>
        where T : unmanaged
    {
        T x;

        public static readonly IPrimalInfo<T> NumInfo = PrimalInfo.Get<T>();

        public static bool Signed => NumInfo.Signed;

        public static ByteSize ByteSize => NumInfo.ByteSize;

        public static BitSize BitSize => NumInfo.BitSize;

        public static num<T> Zero => Num.zero<T>();

        public static num<T> One => Num.one<T>();

        [MethodImpl(Inline)]
        public static explicit operator sbyte(in num<T> src)
            => convert(scalar(ref mutable(in src)), out sbyte x);

        [MethodImpl(Inline)]
        public static explicit operator byte(in num<T> src)
            => convert(scalar(ref mutable(in src)), out byte x);

        [MethodImpl(Inline)]
        public static explicit operator short(in num<T> src)
            => convert(scalar(ref mutable(in src)), out short x);

        [MethodImpl(Inline)]
        public static explicit operator ushort(in num<T> src)
            => convert(scalar(ref mutable(in src)), out ushort x);

        [MethodImpl(Inline)]
        public static explicit operator int(in num<T> src)
            => convert(scalar(ref mutable(in src)), out int x);

        [MethodImpl(Inline)]
        public static explicit operator uint(in num<T> src)
            => convert(scalar(ref mutable(in src)), out uint x);

        [MethodImpl(Inline)]
        public static explicit operator long(in num<T> src)
            => convert(scalar(ref mutable(in src)), out long x);

        [MethodImpl(Inline)]
        public static explicit operator ulong(in num<T> src)
            => convert(scalar(ref mutable(in src)), out ulong x);

        [MethodImpl(Inline)]
        public static explicit operator float(in num<T> src)
            => convert(scalar(ref mutable(in src)), out float x);

        [MethodImpl(Inline)]
        public static explicit operator double(in num<T> src)
            => convert(scalar(ref mutable(in src)), out double x);

        [MethodImpl(Inline)]
        public static explicit operator num<T>(in sbyte src)
            => toNum(ref generic<T>(ref mutable(in src)));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(in byte src)
            => toNum(ref generic<T>(ref mutable(in src)));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(in short src)
            => toNum(ref generic<T>(ref mutable(in src)));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(in ushort src)
            => toNum(ref generic<T>(ref mutable(in src)));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(in int src)
            => toNum(ref generic<T>(ref mutable(in src)));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(in uint src)
            => toNum(ref generic<T>(ref mutable(in src)));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(in long src)
            => toNum(ref generic<T>(ref mutable(in src)));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(in ulong src)
            => toNum(ref generic<T>(ref mutable(in src)));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(in float src)
            => toNum(ref g32f<T>(in src));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(in double src)
            => toNum(ref g64f<T>(in src));

        static ref num<T> toNum(ref T src)
            => ref Unsafe.As<T,num<T>>(ref  src);

        [MethodImpl(Inline)]
        public static implicit operator num<T>(in T src)
            => Unsafe.As<T,num<T>>(ref  mutable(in src));

        [MethodImpl(Inline)]
        public static num<T> operator + (in num<T> lhs, in num<T> rhs) 
        {
            ref var result = ref gmath.add(ref unwrap(in lhs), unwrap(in rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }
        
        [MethodImpl(Inline)]
        public static num<T> operator - (in num<T> lhs, in num<T> rhs) 
        {
            ref var result = ref gmath.sub(ref unwrap(in lhs), unwrap(in rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator * (in num<T> lhs, in num<T> rhs) 
        {
            ref var result = ref gmath.mul(ref unwrap(in lhs), unwrap(in rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator / (in num<T> lhs, in num<T> rhs) 
        {
            if(typeof(T) == typeof(float) || typeof(T) == typeof(double))
                return Unsafe.As<T,num<T>>(ref gfp.div(ref unwrap(in lhs), unwrap(rhs)));
            else
                return Unsafe.As<T,num<T>>(ref gmath.div(ref unwrap(in lhs), unwrap(rhs)));
        }

        [MethodImpl(Inline)]
        public static num<T> operator % (in num<T> lhs, in num<T> rhs)
        {
            ref var result = ref gmath.mod(ref unwrap(in lhs), unwrap(rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator - (in num<T> src) 
        {
            ref var result = ref gmath.negate(ref unwrap(in src));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator ++ (in num<T> src) 
        {
            ref var result = ref gmath.inc(ref unwrap(in src));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator -- (in num<T> src) 
        {
            ref var result = ref gmath.dec(ref unwrap(in src));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator & (in num<T> lhs, in num<T> rhs) 
        {
            var result = gmath.and(unwrap(in lhs), unwrap(in rhs));
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator | (in num<T> lhs, in num<T> rhs) 
        {
            ref var result = ref gmath.or(ref unwrap(in lhs), unwrap(in rhs));
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator ^ (in num<T> lhs, in num<T> rhs) 
        {
            ref var result = ref gmath.xor(ref unwrap(in lhs), unwrap(rhs));
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator ~ (in num<T> lhs) 
        {
            ref var result = ref gmath.not(ref unwrap(in lhs));
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static bool operator == (in num<T> lhs, in num<T> rhs) 
            => gmath.eq(unwrap(in lhs), unwrap(in rhs));            
            
        [MethodImpl(Inline)]
        public static bool operator != (in num<T> lhs, in num<T> rhs) 
            => gmath.neq(unwrap(in lhs), unwrap(in rhs));            

        [MethodImpl(Inline)]
        public static bool operator < (in num<T> lhs, in num<T> rhs) 
            => gmath.lt(unwrap(in lhs), unwrap(in rhs));            

        [MethodImpl(Inline)]
        public static bool operator <= (in num<T> lhs, in num<T> rhs) 
            => gmath.lteq(unwrap(in lhs), unwrap(in rhs));            

        [MethodImpl(Inline)]
        public static bool operator > (in num<T> lhs, in num<T> rhs) 
            => gmath.gt(unwrap(in lhs), unwrap(in rhs));            

        [MethodImpl(Inline)]
        public static bool operator >= (in num<T> lhs, in num<T> rhs) 
            => gmath.gteq(unwrap(in lhs), unwrap(in rhs));            

        [MethodImpl(Inline)]
        public num<T> abs() 
        {
            ref var result = ref gmath.abs(ref unwrap(in this));
            return Unsafe.As<T,num<T>>(ref result);
        }

        public bool nonzero
        {
            [MethodImpl(Inline)]
            get => gmath.nonzero(unwrap(in this));
        }

        [MethodImpl(Inline)]
        public num<T> max(in num<T> rhs)
        {
            var result = gmath.max(unwrap(in this), unwrap(in rhs));
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public num<T> min(in num<T> rhs)
        {
            var result = gmath.min(unwrap(in this), unwrap(in rhs));
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public bool between(in num<T> lower, in num<T> upper)        
            => gmath.between(unwrap(in this), unwrap(in lower), unwrap(in upper));        

        [MethodImpl(Inline)]
        public bool Equals(num<T> rhs)
            => gmath.eq(unwrap(this), unwrap(rhs));            
       
        public override int GetHashCode()
            => unwrap(this).GetHashCode();

        public override bool Equals(object rhs)
            => rhs is num<T> x ? Equals(x) : false;

        public override string ToString()        
            => scalar(ref this).ToString();        

        /// <summary>
        /// Converts a generic number to a bitstring
        /// </summary>
        /// <param name="src">The source number</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]
        public BitString ToBitString()
            => BitString.from<T>(in scalar(ref this));
 
        [MethodImpl(Inline)]
        static ref T scalar(ref num<T> src)
            => ref Unsafe.As<num<T>,T>(ref src);

        [MethodImpl(Inline)]
        static ref T unwrap(in num<T> src)
            => ref Unsafe.As<num<T>,T>(ref mutable(in src));
    }
}