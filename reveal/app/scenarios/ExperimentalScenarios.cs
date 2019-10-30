//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using static zfunc;


    class ExperimentalScenarios : Deconstructable<ExperimentalScenarios>
    {
        public ExperimentalScenarios()
            : base(callerfile())
        {

        }

        public Vec256<ulong> perm4x64_256x64(Vec256<ulong> src)
        {            
            var y = dinx.vperm4x64(src, Perm4.ABCD);            
            y = dinx.vperm4x64(y, Perm4.ABDC);
            y = dinx.vperm4x64(y, Perm4.ACBD);
            y = dinx.vperm4x64(y, Perm4.ACDB);
            y = dinx.vperm4x64(y, Perm4.ADBC);
            y = dinx.vperm4x64(y, Perm4.ADCB);
            return y;

        }

        public Vec256<ulong> perm4x64_256x64(ulong a, ulong b, ulong c, ulong d)
        {            
            var x = vparts(a,b,c,d);
            var y = dinx.vperm4x64(x, Perm4.ABCD);            
            y = dinx.vperm4x64(y, Perm4.ABDC);
            y = dinx.vperm4x64(y, Perm4.ACBD);
            y = dinx.vperm4x64(y, Perm4.ACDB);
            y = dinx.vperm4x64(y, Perm4.ADBC);
            y = dinx.vperm4x64(y, Perm4.ADCB);
            return y;

        }



        public int Switch14(int x)
        {
            switch(x)
            {
                case 1: return 1;
                case 2: return 4;
                case 3: return 8;
                case 4: return 16;
                case 5: return 32;
                case 6: return 64;
                case 7: return 128;
                case 8: return 256;
                case 9: return 512;
                case 10: return 1024;
                case 11: return 2028;
                case 12: return 10;
                case 13: return 20;
                case 14: return 30;
                case 7000: return 1024;
                case 7001: return 2028;
                case 7002: return 10;
                case 7003: return 20;
                case 7004: return 30;
                default: return 0;
            }
        }

        public int IfElse10(int x)
        {
            if(x == 1) return 1;
            else if(x == 2) return 4;
            else if(x == 3) return 8;
            else if(x == 4) return 16;
            else if(x == 5) return 32;
            else if(x == 6) return 64;
            else if(x == 7) return 128;
            else if(x == 8) return 256;
            else if(x == 9) return 512;
            else if(x == 10) return 1024;
            else return 0;
        }

        static ReadOnlySpan<byte> U8Data => new byte[]
        {
            0x20, 0xda, 0x1f, 0x32, 0x4b, 0xca, 0x42, 0x5b,
            0x06, 0xbd, 0xac, 0xdb, 0x28, 0x87, 0x7a, 0xd4,
            0x0c, 0xd9, 0x1e, 0xde, 0x5d, 0x17, 0xd6, 0x7c,
            0x08, 0xcf, 0x94, 0x93, 0xf4, 0x5c, 0x4f, 0x6b,
            0x7a, 0x02, 0x62, 0x31, 0x37, 0xed, 0x21, 0x03,
            0xef, 0xe4, 0x4c, 0x0a, 0xbd, 0x8d, 0x48, 0x21,
            0xaf, 0x50, 0x9b, 0x7a, 0x75, 0x7d, 0xc0, 0xa7,
            0x4b, 0x70, 0x86, 0x84, 0x64, 0xee, 0x2b, 0x04
        };

        static ReadOnlySpan<uint> U32Data => new uint[]
        {
            0x20da1f32, 0x4bca425b,
            0x06bdacdb, 0x28877ad4,
            0x0cd91ede, 0x5d17d67c,
            0x08cf9493, 0xf45c4f6b,
            0x7a026231, 0x37ed2103,
            0xefe44c0a, 0xbd8d4821,
            0xaf509b7a, 0x757dc0a7,
            0x4b708684, 0x64ee2b04
        };


        [MethodImpl(Inline)]
        public static uint Or8Inline(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
            => x0 | x1 | x2 | x3 | x4 | x5 | x6 | x7;

        [MethodImpl(Inline)]
        public static uint RotLU32Inline(uint x, int offset)
            => (x << (int)offset) | (x >> (32 - offset));



        [MethodImpl(Inline)]
        public int ChoiceIfElse5Inline(int x)
        {
            if(x == 1) return 1;
            else if(x == 2) return 4;
            else if(x == 3) return 8;
            else if(x == 4) return 16;
            else if(x == 5) return 32;
            else return 0;
        }



        public int CheckMatches()
        {
            var match = 0;
            match |= CheckMatches<sbyte>();
            match |= CheckMatches<byte>();
            match |= CheckMatches<short>();
            match |= CheckMatches<ushort>();
            match |= CheckMatches<int>();
            match |= CheckMatches<uint>();
            match |= CheckMatches<long>();
            match |= CheckMatches<ulong>();
            match |= CheckMatches<float>();
            match |= CheckMatches<double>();
            return match;
        }


        [MethodImpl(Inline)]
        public int CheckMatches<T>()
        {
            if(IsMatch<sbyte,T>())
                return 1;
            else if(IsMatch<byte,T>())                
                return 2;
            else if(IsMatch<short,T>())
                return 4;
            else if(IsMatch<ushort,T>())
                return 8;
            else if(IsMatch<int,T>())
                return 16;
            else if(IsMatch<uint,T>())
                return 32;
            else if(IsMatch<long,T>())
                return 64;
            else if(IsMatch<ulong,T>())
                return 128;
            else if(IsMatch<float,T>())
                return 256;
            else if(IsMatch<double,T>())
                return 512;
            else
                return 0;
        }

        
        [MethodImpl(Inline)]
        bool IsMatch<S,T>()
            => typeof(S) == typeof(T);






         public ReadOnlySpan<byte> ReadU8Data(int count)
            => U8Data;

        public ReadOnlySpan<uint> ReadU32Data(int count)
            => U32Data;

        [MethodImpl(NotInline)]
        public void VoidReturn()
            => Console.Write("");
    
        public int SizeTest()
        {
            var a = 0;
            var b = 1;
            var c = 2;

            int d = 1, e = 2, f = 2;

            var x = d * e * f;
            var y = a + b + c;

            return x + y;
        }

        public void VoidCalls1()
        {
            VoidReturn();
        }

        public void VoidCalls2()
        {
            VoidReturn();
            VoidReturn();
        }

        public void VoidCalls3()
        {
            VoidReturn();
            VoidReturn();
            VoidReturn();
        }

        public void VoidCalls4()
        {
            VoidReturn();
            VoidReturn();
            VoidReturn();
            VoidReturn();
        }

        [MethodImpl(Inline)]
        public int InvokeBinOp(Func<int,int,int> f, int x, int y)
            => f(x,y);

        [MethodImpl(Inline)]
        static int AddMulInline(int x, int y)
            => (x + y) *x + (x + y)*y;

        public int CallInvokeBinOp(int x, int y)
            => InvokeBinOp(AddMulInline, x, y);

        [MethodImpl(NotInline)]
        public int JumpTarget1()
            => 1;

        [MethodImpl(NotInline)]
        public int JumpTarget2()
            => 2;

        [MethodImpl(NotInline)]
        public int JumpTarget3()
            => 3;

        [MethodImpl(NotInline)]
        public int JumpTarget4()
            => 4;

        public int Jump(int target)
            => target == 1 ? JumpTarget1() 
             : target == 2 ? JumpTarget2() 
             : target == 3 ? JumpTarget3()
             : JumpTarget4();


            

    }

}