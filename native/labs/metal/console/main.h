# include <stdio.h>
# include <inttypes.h>
# include <immintrin.h>
# include <emmintrin.h>
# include <smmintrin.h>
# include <wmmintrin.h>
# include <xmmintrin.h>


static int8_t mod8i(int8_t x, int8_t y)
{
    return x % y;
}

inline uint8_t mod8u(uint8_t x, uint8_t y)
{
    return x % y;
}

inline int16_t mod16i(int16_t x, int16_t y)
{
    return x % y;
}

inline uint16_t mod16u(uint16_t x, uint16_t y)
{
    return x % y;
}

inline int32_t mod32i(int32_t x, int32_t y)
{
    return x % y;
}

inline uint32_t mod32u(uint32_t x, uint32_t y)
{
    return x % y;
}

inline int64_t mod64i(int64_t x, int64_t y)
{
    return x % y;
}

inline uint64_t mod64u(uint64_t x, uint64_t y)
{
    return x % y;
}


uint32_t rotate1(uint32_t value, uint32_t rotate)
{
    return (value >> rotate) | (value << (~rotate & 31 ));
}

uint32_t rotate2(uint32_t value, int rotate)
{
    return (value >> rotate) | (value << ((-rotate & 31) - 1));
}

static uint16_t threshold1(uint16_t bound)
{
    return ((uint16_t)(-bound)) % bound;
}

static uint16_t threshold2(uint16_t bound)
{
    return ((uint16_t)(~bound) + 1) % bound;
}

static uint32_t output1(uint64_t state)
{
    uint64_t a = state >> 59u;
    uint64_t b = (a + 5u);
    uint64_t c = (state >> b) ^ state;
    return (c * 12605985483714917081ull) >> 32u;
}


void print128(__m128i var)
{
    int64_t *v64val = (int64_t*) &var;
    printf("%.16llx %.16llx\n", v64val[1], v64val[0]);
}

__m128i gfmul (__m128i a, __m128i b)
{
    __m128i tmp0, tmp1, tmp2, tmp3, tmp4, tmp5, tmp6, tmp7, tmp8, tmp9;
    tmp3 = _mm_clmulepi64_si128(a, b, 0x00);
    tmp4 = _mm_clmulepi64_si128(a, b, 0x10);
    tmp5 = _mm_clmulepi64_si128(a, b, 0x01);
    tmp6 = _mm_clmulepi64_si128(a, b, 0x11);
    tmp4 = _mm_xor_si128(tmp4, tmp5);
    tmp5 = _mm_slli_si128(tmp4, 8);
    tmp4 = _mm_srli_si128(tmp4, 8);
    tmp3 = _mm_xor_si128(tmp3, tmp5);
    tmp6 = _mm_xor_si128(tmp6, tmp4);
    tmp7 = _mm_srli_epi32(tmp3, 31);
    tmp8 = _mm_srli_epi32(tmp6, 31);
    tmp3 = _mm_slli_epi32(tmp3, 1);
    tmp6 = _mm_slli_epi32(tmp6, 1);
    tmp9 = _mm_srli_si128(tmp7, 12);
    tmp8 = _mm_slli_si128(tmp8, 4);
    tmp7 = _mm_slli_si128(tmp7, 4);
    tmp3 = _mm_or_si128(tmp3, tmp7);
    tmp6 = _mm_or_si128(tmp6, tmp8);
    tmp6 = _mm_or_si128(tmp6, tmp9);
    tmp7 = _mm_slli_epi32(tmp3, 31);
    tmp8 = _mm_slli_epi32(tmp3, 30);
    tmp9 = _mm_slli_epi32(tmp3, 25);
    tmp7 = _mm_xor_si128(tmp7, tmp8);
    tmp7 = _mm_xor_si128(tmp7, tmp9);
    tmp8 = _mm_srli_si128(tmp7, 4);
    tmp7 = _mm_slli_si128(tmp7, 12);
    tmp3 = _mm_xor_si128(tmp3, tmp7);
        tmp2 = _mm_srli_epi32(tmp3, 1);
    tmp4 = _mm_srli_epi32(tmp3, 2);
    tmp5 = _mm_srli_epi32(tmp3, 7);
    tmp2 = _mm_xor_si128(tmp2, tmp4);
    tmp2 = _mm_xor_si128(tmp2, tmp5);
    tmp2 = _mm_xor_si128(tmp2, tmp8);
    tmp3 = _mm_xor_si128(tmp3, tmp2);
    tmp6 = _mm_xor_si128(tmp6, tmp3);
    return tmp6;
}
