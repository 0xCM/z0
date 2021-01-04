//-----------------------------------------------------------------------------
// Copyright   :  See license-v8 in ./licenenses
// From        :  https://github.com/google/double-conversion
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Part;

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static void assert(bool condition)
            => Debug.Assert(condition);

        [MethodImpl(Inline), Op]
        public static ref ifloat mul(ref ifloat dst, in ifloat src)
        {
            const ulong kM32 = 0xFFFFFFFFU;
            var a = dst.f_ >> 32;
            var b = dst.f_ & kM32;
            var c = src.f_ >> 32;
            var d = src.f_ & kM32;
            var ac = a * c;
            var bc = b * c;
            var ad = a * d;
            var bd = b * d;
            var tmp = (bd >> 32) + (ad & kM32) + (bc & kM32) + (1U << 31);
            dst.e_ += src.e_ + 64;
            dst.f_ = ac + (ad >> 32) + (bc >> 32) + (tmp >> 32);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ifloat sub(ref ifloat dst, in ifloat src)
        {
            assert(dst.e_ == src.e_);
            assert(dst.f_ >= src.f_);
            dst.f_ -= src.f_;
            return ref dst;
        }
    }

    // This "Do It Yourself Floating Point" class implements a floating-point number
    // with a uint64 significand and an int exponent. Normalized DiyFp numbers will
    // have the most significant bit of the significand set.
    // Multiplication and Subtraction do not normalize their results.
    // DiyFp store only non-negative numbers and are not designed to contain special
    // doubles (NaN and Infinity).
    public struct ifloat
    {
        public const int kSignificandSize = 64;

        internal ulong f_;

        internal int e_;

        [MethodImpl(Inline)]
        public ifloat(ulong f, int e)
        {
            f_ = f;
            e_ = e;
        }

        public readonly ulong Significand
        {
            [MethodImpl(Inline)]
            get => f_;
        }

        public readonly int Exponent
        {
            [MethodImpl(Inline)]
            get => e_;
        }

        [MethodImpl(Inline)]
        public static implicit operator ifloat(ulong f)
            => new ifloat(f,0);

        [MethodImpl(Inline)]
        public static implicit operator ifloat((ulong f, int e) src)
            => new ifloat(src.f,src.e);
    }
}