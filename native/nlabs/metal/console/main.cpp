# include <inttypes.h>
# include <stdio.h>

//# include "main.h"

class Calc
{
    public:

    static uint32_t calc7(uint64_t state)
    {

        int32_t a = state >> 59;
        printf("a = %d\n",a);

        int32_t b = a + 5;
        printf("b = %d\n",b);

        uint64_t c = state >> b;
        printf("c = %llu\n",c);

        uint64_t d = c ^ state;
        printf("d = %llu\n",d);

        uint64_t e = (d * 12605985483714917081ull) >> 32;
        printf("e = %llu\n",e);

        uint32_t f = e;
        printf("f = %d\n",f);

        return f;
    }


    static int8_t mod(int8_t x, int8_t y)
    {
        return x % y;
    }

    static uint8_t mod(uint8_t x, uint8_t y)
    {
        return x % y;
    }

    static int16_t mod(int16_t x, int16_t y)
    {
        return x % y;
    }

    static uint16_t mod(uint16_t x, uint16_t y)
    {
        return x % y;
    }

    static int32_t mod(int32_t x, int32_t y)
    {
        return x % y;
    }

    static uint32_t mod(uint32_t x, uint32_t y)
    {
        return x % y;
    }

    static int64_t mod(int64_t x, int64_t y)
    {
        return x % y;
    }

    static uint64_t mod(uint64_t x, uint64_t y)
    {
        return x % y;
    }

    static uint8_t rot(uint8_t value, uint8_t offset)
    {
        return (value >> offset) | (value << (~offset & 31 ));
    }

    static uint16_t rot(uint16_t value, uint16_t offset)
    {
        return (value >> offset) | (value << (~offset & 31 ));
    }

    static uint32_t rot(uint32_t value, uint32_t offset)
    {
        return (value >> offset) | (value << (~offset & 31 ));
    }

    static uint64_t rot(uint64_t value, uint64_t offset)
    {
        return (value >> offset) | (value << (~offset & 31 ));
    }

};

// int TestOps()
// {
//     auto rcase1 = rotate1(34,2);
//     printf("Rotate Version 1: 0x%08x\n", rcase1);
//     auto rcase2 = rotate2(34,2);
//     printf("Roate Version 2: 0x%08x\n", rcase2);

//     auto tcase1 = threshold1(27);
//     printf("Threshold Version 1: 0x%08x\n", tcase1);

//     auto tcase2 = threshold2(27);
//     printf("Threshold Version 2: 0x%08x\n", tcase2);

//     auto ocase1 = output1(27ull);
//     printf("Output Version 1: %d\n", ocase1);

//     auto ocase2 = output2(27ull);
//     printf("Output Version 2: %d\n", ocase2);

//     auto x64 = 128;
//     uint64_t y64 = -x64;
//     printf("-128u64 = %" PRIu64 "\n", y64);

//     uint32_t x32 = 128;
//     uint32_t y32 = -x32;
//     printf("-128u32 = %" PRIu32 "\n", y32);

//     uint16_t x16 = 128;
//     uint16_t y16 = -x16;
//     printf("-128u16 = %" PRIu16 "\n", y16);

//     uint8_t x8 = 128;
//     uint8_t y8 = -x8;
//     printf("-128u8 = %" PRIu8 "\n", y8);

//     return 0;
// }

// int TestGf()
// {
//     __m128i a = _mm_set_epi32(2,0,4,0);
//     __m128i b = _mm_set_epi32(8,0,6,0);
//     __m128i c = gfmul(a,b);
//     print128(a);
//     print128(b);
//     print128(c);
//     return 0;
// }

int main(int argc, char** argv)
{
    Calc::rot((uint8_t)10,(uint8_t)5);
    Calc::mod((uint8_t)10,(uint8_t)5);
    Calc::rot((uint64_t)289,(uint64_t)12);
    Calc::calc7(52039ull);
      //TestOps();
}