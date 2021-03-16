//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct BitSeq
    {
        static ReadOnlySpan<byte> W1
            => new byte[2]{0b00,0b01};

        static ReadOnlySpan<byte> W2
            => new byte[4]{0b00,0b01,0b10,0b11};

        static ReadOnlySpan<byte> W3
            => new byte[8]{0b000,0b001,0b010,0b011,0b100,0b101,0b110,0b111};

        static ReadOnlySpan<byte> W4
            => new byte[16]{
                0b0000,0b0001,0b0010,0b0011,0b0100,0b0101,0b0110,0b0111,
                0b1000,0b1001,0b1010,0b1011,0b1100,0b1101,0b1110,0b1111,
                };

        static ReadOnlySpan<byte> W5
            => new byte[32]{
                0b00000,0b00001,0b00010,0b00011,0b00100,0b00101,0b00110,0b00111,
                0b01000,0b01001,0b01010,0b01011,0b01100,0b01101,0b01110,0b01111,
                0b10000,0b10001,0b10010,0b10011,0b10100,0b10101,0b10110,0b10111,
                0b11000,0b11001,0b11010,0b11011,0b11100,0b11101,0b11110,0b11111,
                };

        static ReadOnlySpan<byte> W6
            => new byte[64]{
                0b000000,0b000001,0b000010,0b000011,0b000100,0b000101,0b000110,0b000111,
                0b001000,0b001001,0b001010,0b001011,0b001100,0b001101,0b001110,0b001111,
                0b010000,0b010001,0b010010,0b010011,0b010100,0b010101,0b010110,0b010111,
                0b011000,0b011001,0b011010,0b011011,0b011100,0b011101,0b011110,0b011111,
                0b100000,0b100001,0b100010,0b100011,0b100100,0b100101,0b100110,0b100111,
                0b101000,0b101001,0b101010,0b101011,0b101100,0b101101,0b101110,0b101111,
                0b110000,0b110001,0b110010,0b110011,0b110100,0b110101,0b110110,0b110111,
                0b111000,0b111001,0b111010,0b111011,0b111100,0b111101,0b111110,0b111111,
                };

        static ReadOnlySpan<byte> W7
            => new byte[128]{
                0b0000000,0b0000001,0b0000010,0b0000011,0b0000100,0b0000101,0b0000110,0b0000111,
                0b0001000,0b0001001,0b0001010,0b0001011,0b0001100,0b0001101,0b0001110,0b0001111,
                0b0010000,0b0010001,0b0010010,0b0010011,0b0010100,0b0010101,0b0010110,0b0010111,
                0b0011000,0b0011001,0b0011010,0b0011011,0b0011100,0b0011101,0b0011110,0b0011111,
                0b0100000,0b0100001,0b0100010,0b0100011,0b0100100,0b0100101,0b0100110,0b0100111,
                0b0101000,0b0101001,0b0101010,0b0101011,0b0101100,0b0101101,0b0101110,0b0101111,
                0b0110000,0b0110001,0b0110010,0b0110011,0b0110100,0b0110101,0b0110110,0b0110111,
                0b0111000,0b0111001,0b0111010,0b0111011,0b0111100,0b0111101,0b0111110,0b0111111,
                0b1000000,0b1000001,0b1000010,0b1000011,0b1000100,0b1000101,0b1000110,0b1000111,
                0b1001000,0b1001001,0b1001010,0b1001011,0b1001100,0b1001101,0b1001110,0b1001111,
                0b1010000,0b1010001,0b1010010,0b1010011,0b1010100,0b1010101,0b1010110,0b1010111,
                0b1011000,0b1011001,0b1011010,0b1011011,0b1011100,0b1011101,0b1011110,0b1011111,
                0b1100000,0b1100001,0b1100010,0b1100011,0b1100100,0b1100101,0b1100110,0b1100111,
                0b1101000,0b1101001,0b1101010,0b1101011,0b1101100,0b1101101,0b1101110,0b1101111,
                0b1110000,0b1110001,0b1110010,0b1110011,0b1110100,0b1110101,0b1110110,0b1110111,
                0b1111000,0b1111001,0b1111010,0b1111011,0b1111100,0b1111101,0b1111110,0b1111111,
                };

        static ReadOnlySpan<byte> W8
            => new byte[256]{
                0b00000000,0b00000001,0b00000010,0b00000011,0b00000100,0b00000101,0b00000110,0b00000111,
                0b00001000,0b00001001,0b00001010,0b00001011,0b00001100,0b00001101,0b00001110,0b00001111,
                0b00010000,0b00010001,0b00010010,0b00010011,0b00010100,0b00010101,0b00010110,0b00010111,
                0b00011000,0b00011001,0b00011010,0b00011011,0b00011100,0b00011101,0b00011110,0b00011111,
                0b00100000,0b00100001,0b00100010,0b00100011,0b00100100,0b00100101,0b00100110,0b00100111,
                0b00101000,0b00101001,0b00101010,0b00101011,0b00101100,0b00101101,0b00101110,0b00101111,
                0b00110000,0b00110001,0b00110010,0b00110011,0b00110100,0b00110101,0b00110110,0b00110111,
                0b00111000,0b00111001,0b00111010,0b00111011,0b00111100,0b00111101,0b00111110,0b00111111,
                0b01000000,0b01000001,0b01000010,0b01000011,0b01000100,0b01000101,0b01000110,0b01000111,
                0b01001000,0b01001001,0b01001010,0b01001011,0b01001100,0b01001101,0b01001110,0b01001111,
                0b01010000,0b01010001,0b01010010,0b01010011,0b01010100,0b01010101,0b01010110,0b01010111,
                0b01011000,0b01011001,0b01011010,0b01011011,0b01011100,0b01011101,0b01011110,0b01011111,
                0b01100000,0b01100001,0b01100010,0b01100011,0b01100100,0b01100101,0b01100110,0b01100111,
                0b01101000,0b01101001,0b01101010,0b01101011,0b01101100,0b01101101,0b01101110,0b01101111,
                0b01110000,0b01110001,0b01110010,0b01110011,0b01110100,0b01110101,0b01110110,0b01110111,
                0b01111000,0b01111001,0b01111010,0b01111011,0b01111100,0b01111101,0b01111110,0b01111111,
                0b10000000,0b10000001,0b10000010,0b10000011,0b10000100,0b10000101,0b10000110,0b10000111,
                0b10001000,0b10001001,0b10001010,0b10001011,0b10001100,0b10001101,0b10001110,0b10001111,
                0b10010000,0b10010001,0b10010010,0b10010011,0b10010100,0b10010101,0b10010110,0b10010111,
                0b10011000,0b10011001,0b10011010,0b10011011,0b10011100,0b10011101,0b10011110,0b10011111,
                0b10100000,0b10100001,0b10100010,0b10100011,0b10100100,0b10100101,0b10100110,0b10100111,
                0b10101000,0b10101001,0b10101010,0b10101011,0b10101100,0b10101101,0b10101110,0b10101111,
                0b10110000,0b10110001,0b10110010,0b10110011,0b10110100,0b10110101,0b10110110,0b10110111,
                0b10111000,0b10111001,0b10111010,0b10111011,0b10111100,0b10111101,0b10111110,0b10111111,
                0b11000000,0b11000001,0b11000010,0b11000011,0b11000100,0b11000101,0b11000110,0b11000111,
                0b11001000,0b11001001,0b11001010,0b11001011,0b11001100,0b11001101,0b11001110,0b11001111,
                0b11010000,0b11010001,0b11010010,0b11010011,0b11010100,0b11010101,0b11010110,0b11010111,
                0b11011000,0b11011001,0b11011010,0b11011011,0b11011100,0b11011101,0b11011110,0b11011111,
                0b11100000,0b11100001,0b11100010,0b11100011,0b11100100,0b11100101,0b11100110,0b11100111,
                0b11101000,0b11101001,0b11101010,0b11101011,0b11101100,0b11101101,0b11101110,0b11101111,
                0b11110000,0b11110001,0b11110010,0b11110011,0b11110100,0b11110101,0b11110110,0b11110111,
                0b11111000,0b11111001,0b11111010,0b11111011,0b11111100,0b11111101,0b11111110,0b11111111,
            };
    }
}