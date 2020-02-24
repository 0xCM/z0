//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Linq;

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    /// <summary>
    /// Generates the data presented by VData
    /// </summary>
    public static class VDataGen
    {
        /// <summary>
        /// Creates a vector populated with component values that alternate between the first operand and the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vpalt<T>(N128 n, T a, T b)
            where T : unmanaged
        {            
            var data = blocks.single<T>(n);
            var len = blocks.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i<len; i++)
                seek(ref mem, i) = even(i) ? a : b;
            return CpuVector.vload(n, in head(data));
        }

        /// <summary>
        /// Creates a 128-bit vector with components that decrease by uint step from an initial value
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vdecrements<T>(N128 n, T first)
            where T : unmanaged
        {
            var current = first;
            var data = blocks.single<T>(n);
            var len = blocks.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i < len; i++)
            {
                seek(ref mem, i) = current;
                current = gmath.dec(current);
            }
                        
            return CpuVector.vload(n, in mem);
        }    

        /// <summary>
        /// Creates a 128-bit vector with components that decrease by uint step from an initial value
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vdecrements<T>(N256 n, T first)
            where T : unmanaged
        {
            var current = first;
            var data = blocks.single<T>(n);
            var len = blocks.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i < len; i++)
            {
                seek(ref mem, i) = current;
                current = gmath.dec(current);
            }
                        
            return CpuVector.vload(n, in mem);
        }    

        /// <summary>
        /// Creates a 128-bit vector with components that decrease by a specified step from an initial value
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vdecrements<T>(N128 n, T first, T step)
            where T : unmanaged
        {
            var current = first;
            var data = blocks.single<T>(n);
            var len = blocks.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i < len; i++)
            {
                seek(ref mem, i) = current;
                current = gmath.sub(current, step);
            }
            return CpuVector.vload(n, in mem);
        }

        /// <summary>
        /// Creates a 256-bit vector with components that decrease by a specified step from an initial value
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vdecrements<T>(N256 n, T first, T step)
            where T : unmanaged
        {
            var current = first;
            var data = blocks.single<T>(n);
            var len = blocks.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i < len; i++)
            {
                seek(ref mem, i) = current;
                current = gmath.sub(current, step);
            }
            return CpuVector.vload(n, in mem);
        }

        public static Vector256<T> vdecrements<T>(N256 n, T first, params Swap[] swaps)
            where T : unmanaged
        {
            var current = first;
            var data = blocks.single<T>(n);
            var len = blocks.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i < len; i++)
            {
                seek(ref mem, i) = current;
                current = gmath.dec(current);
            }

            return CpuVector.vload(n, in head(data.Swap(swaps)));
        }            

        public static Vector128<T> vdecrements<T>(N128 n, T first, params Swap[] swaps)
            where T : unmanaged
        {
            var current = first;
            var data = blocks.single<T>(n);
            var len = blocks.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i < len; i++)
            {
                seek(ref mem, i) = current;
                current = gmath.dec(current);
            }

            return CpuVector.vload(n, in head(data.Swap(swaps)));
        }    
     
        /// <summary>
        /// Creates a 128-bit vector with components that increase by a specified step from an initial value
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vector128<T> vincrements<T>(N128 n, T first, T step)
            where T : unmanaged
        {
            var current = first;
            var data = blocks.single<T>(n);
            var len = blocks.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i<len; i++)
            {
                seek(ref mem, i) = current;
                current = gmath.add(current, step);
            }
            return CpuVector.vload(n, in mem);
        }

        /// <summary>
        /// Creates a 256-bit vector with components that increase by a specified step from an initial value
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vector256<T> vincrements<T>(N256 n, T first, T step)
            where T : unmanaged
        {
            var current = first;
            var data = blocks.single<T>(n);
            var len = blocks.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i<len; i++)
            {
                seek(ref mem, i) = current;
                current = gmath.add(current, step);
            }
            return CpuVector.vload(n, in mem);
        }
    
        public static Vector128<T> vincrements<T>(N128 n, T first, params Swap[] swaps)
            where T : unmanaged
        {
            var current = first;
            var data = blocks.single<T>(n);
            var len = blocks.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i<len; i++)
            {
                seek(ref mem, i) = current;
                current = gmath.inc(current);
            }

            return CpuVector.vload(n, in head(data.Swap(swaps)));
        }

        public static Vector256<T> vincrements<T>(N256 n, T first, params Swap[] swaps)
            where T : unmanaged
        {
            var current = first;
            var data = blocks.single<T>(n);
            var len = blocks.blocklen<T>(n);
            ref var mem = ref head(data);
            for(var i=0; i<len; i++)
            {
                seek(ref mem, i) = current;
                current = gmath.inc(current);
            }

            return CpuVector.vload(n, in head(data.Swap(swaps)));
        }            


        public static Vector256<byte> DefineLaneMergeData8u()
        {        
            //<lo = i,i+2,i+4 ... n-2 | hi = i+1, i + 3, i+5, ... n-1 >           
            //0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31
            byte i = 0, j = 1;
            return Vector256.Create(
                    i, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2,
                    j, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2
                );
        }

        public static Span<byte> DefineLaneMergeData16u()
        {        
            //<lo = i,i+2,i+4 ... n-2 | hi = i+1, i + 3, i+5, ... n-1 >   
            //components: 0, 2, 4, 6, 8, 10, 12, 14, 1, 3, 5, 7, 9, 11, 13, 15      
            //hexstring: 0x00,0x00,0x02,0x00,0x04,0x00,0x06,0x00,0x08,0x00,0x0A,0x00,0x0C,0x00,0x0E,0x00,0x01,0x00,0x03,0x00,0x05,0x00,0x07,0x00,0x09,0x00,0x0B,0x00,0x0D,0x00,0x0F,0x00  
            ushort i = 0, j = 1;
            Span<ushort> dst = new ushort[16]
            {
                i, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2, i+=2,
                j, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2, j+=2
            };
            return dst.AsBytes();
        }

        /// <summary>
        /// Creates a shuffle mask that zeroes-out ever-other vector component
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Span<T> DefineClearAlt<T>()
            where T : unmanaged
        {
            var mask = blocks.cellalloc<T>(n256,1);
            var chop = maxval<T>();
            
            //For the first 128-bit lane
            var half = mask.CellCount/2;
            for(byte i=0; i< half; i++)
            {
                if(i % 2 != 0)
                    mask[i] = chop;
                else
                    mask[i] = convert<byte,T>(i);
            }

            //For the second 128-bit lane
            for(byte i=0; i< half; i++)
            {
                if(i % 2 != 0)
                    mask[i + half] = chop;
                else
                    mask[i + half] = convert<byte,T>(i);
            }

            return mask;
        }
    }
}