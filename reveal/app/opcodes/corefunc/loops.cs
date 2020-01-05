//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;    
    using static zfunc;

    /// <summary>
    /// Opcodes for loop-related operations
    /// </summary>
    [OpCodeProvider]
    public static class loops
    {
        [MethodImpl(Inline)]
        public static long loop_inc(int start, int max, long count)
        {
            var sum = count;
            for(var i=start; i<max; i++)
                sum += i;
            return sum;
        }

        [MethodImpl(Inline)]
        public static long loop_inc_test_neq(int start, int test, long count)
        {
            var sum = count;
            for(var i=start; i != test; i++)
                sum += i;
            return sum;
        }

        [MethodImpl(Inline)]
        public static long loop_dec(int start, int min, long count)
        {
            var sum = count;
            for(var i=start; i>=min; i--)
                sum += i;
            return sum;
        }

        [MethodImpl(Inline)]
        public static long loop_inc_step(int start, int max, int step, long count)
        {
            var sum = count;
            for(var i=start; i<max; i+= step)
                sum += i;
            return sum;
        }

        [MethodImpl(Inline)]
        public static long loop_dec_step(int start, int min, int step, long count)
        {
            var sum = count;
            for(var i=start; i>=min; i-= step)
                sum += i;
            return sum;
        }

        /*
        mov rax,rcx
        mov edx,66h
        STEP: movsxd rcx,edx
        add rax,rcx
        inc edx
        cmp edx,666h
        jl short STEP
        */
        public static long loop_inc_call(long count)
        {
            return loop_inc(0x66,0x666,count);
        }

        public static long loop_inc_test_neq_call(long count)
        {
            return loop_inc_test_neq(0x66, 0x666, count);
        }

        /*
        mov rax,rcx
        mov edx,66h
        STEP: movsxd rcx,edx
        add rax,rcx
        add edx,6
        cmp edx,666h
        jl short STEP
        */
        public static long loop_inc_step_call(long count)
        {
            return loop_inc_step(0x66,0x666,6,count);
        }

        /*
        mov edx,666h
        STEP: movsxd rcx,edx
        add rax,rcx
        dec edx
        cmp edx,66h
        jge short STEP
        */
        public static long loop_dec_call(long count)
        {
            return loop_dec(0x666, 0x66, count);
        }
        
        public static long loop_dec_step_call(long count)
        {
            return loop_dec_step(0x666, 0x66, 6,count);
        }



        // https://github.com/aspnet/KestrelHttpServer/pull/1138
        // https://gist.github.com/benaadams/2dd3f99230757111e91915f638067a09

        const ulong BENS_MAGIC_NUMBER = 0x81018202830380;

        [MethodImpl(Inline)]
        public static int FindByte(ulong src)
        {
            var flag = (src & ((ulong)-(long)src)) >> 8;
            return (int)((flag * BENS_MAGIC_NUMBER) >> 55) & 7;
        }

        [MethodImpl(Inline)]
        public static int FindByte(in Block256<byte> src)
        {
            var key = 0ul;
            var i = 0;

            // Should only be called when byte in Vector. Since range check 
            // can't be elminated, make loop one larger to throw if not found
            // rather than doing the throw ourselves
            for (; i < 32 + 1; i++)
            {
                key = src[i];
                if (key != 0)
                    break;
            }

            // Single LEA instruction with jitted const (using function result)
            return i * 8 + FindByte(key);
        }        
 
        
        public static int downBy2ne(int amount)
        {
            int i;
            int sum = 0;
            for (i = 9; i != 1; i -= 2)
            {
                sum += amount;
            }
            return sum + i;
        }

        public static int upBy1ne(int amount)
        {
            int i;
            int sum = 0;
            for (i = 1; i != 8; i += 1)
            {
                sum += amount;
            }
            return sum + i;
        }

        public static int downBy1ne(int amount)
        {
            int i;
            int sum = 0;
            for (i = 9; i != 2; i -= 1)
            {
                sum += amount;
            }
            return sum + i;
        }

        public static int upBy2ne(int amount)
        {
            int i;
            int sum = 0;
            for (i = 1; i != 9; i += 2)
            {
                sum += amount;
            }
            return sum + i;
        }

        public static int upBy3neWrap(int amount)
        {
            short i;
            int sum = 0;
            for (i = 1; i != 8; i += 3)
            {
                sum += amount;
            }
            return sum + i;
        }

        public static int downBy3neWrap(int amount)
        {
            short i;
            int sum = 0;
            for (i = 8; i != 1; i -= 3)
            {
                sum += amount;
            }
            return sum + i;
        }

    }

}