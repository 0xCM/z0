//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    
    using static zfunc;

    partial class zfoc
    {
        //~ 8i -> x

        public static byte convert_8i_to_8u(sbyte src)
            => (byte)src;

        public static byte convert_8i_to_g8u(sbyte src)
            => Converter.convert<byte>(src);

        public static byte convert_g8i_to_g8u(sbyte src)
            => Converter.convert<sbyte,byte>(src);

        public static sbyte convert_8i_to_8i(sbyte src)
            => src;

        public static sbyte convert_8i_to_g8i(sbyte src)
            => Converter.convert<sbyte>(src);

        public static byte convert_g8i_to_g8i(sbyte src)
            => Converter.convert<sbyte,byte>(src);

        public static short convert_8i_to_16i(sbyte src)
            => src;

        public static short convert_8i_to_g16i(sbyte src)
            => Converter.convert<short>(src);            

        public static short convert_g8i_to_g16i(sbyte src)
            => Converter.convert<sbyte,short>(src);

        public static ushort convert_8i_to_16u(sbyte src)
            => (ushort)src;

        public static ushort convert_8i_to_g16u(sbyte src)
            => Converter.convert<ushort>(src);

        public static ushort convert_g8i_to_g16u(sbyte src)
            => Converter.convert<sbyte,ushort>(src);

        public static int convert_8i_to_32i(sbyte src)
            => src;

        public static int convert_8i_to_g32i(sbyte src)
            => Converter.convert<int>(src);

        public static int convert_g8i_to_g32i(sbyte src)
            => Converter.convert<sbyte,int>(src);

        public static uint convert_8i_to_g32(sbyte src)
            => (uint)src;

        public static uint convert_8i_to_g32u(sbyte src)
            => Converter.convert<uint>(src);

        public static uint convert_g8i_to_g32u(sbyte src)
            => Converter.convert<sbyte,uint>(src);

        public static long convert_8i_to_64i(sbyte src)
            => src;

        public static long convert_8i_to_g64i(sbyte src)
            => Converter.convert<long>(src);

        public static long convert_g8i_to_g64i(sbyte src)
            => Converter.convert<sbyte,long>(src);

        public static ulong convert_8i_to_64u(sbyte src)
            => (ulong)src;

        public static ulong convert_8i_to_g64u(sbyte src)
            => Converter.convert<ulong>(src);

        public static ulong convert_g8i_to_g64u(sbyte src)
            => Converter.convert<sbyte,ulong>(src);

        public static float convert_8i_to_32f(sbyte src)
            => src;

        public static float convert_8i_to_g32f(sbyte src)
            => Converter.convert<float>(src);

        public static float convert_g8i_to_g32f(sbyte src)
            => Converter.convert<sbyte,float>(src);

        public static double convert_8i_to_64f(sbyte src)
            => src;

        public static double convert_8i_to_g64f(sbyte src)
            => Converter.convert<double>(src);

        public static double convert_g8i_to_g64f(sbyte src)
            => Converter.convert<sbyte,double>(src);

        public static char convert_8i_to_ch16(sbyte src)
            => (char)src;

        public static char convert_8i_to_gch16(sbyte src)
            => Converter.convert<char>(src);

        public static char convert_g8i_to_gch16(sbyte src)
            => Converter.convert<sbyte,char>(src);

        //~ 8u -> x

        public static sbyte convert_8u_to_8i(byte src)
            => (sbyte)src;

        public static sbyte convert_8u_to_g8i(byte src)
            => Converter.convert<sbyte>(src);

        public static sbyte convert_g8u_to_g8i(byte src)
            => Converter.convert<byte,sbyte>(src);

        public static byte convert_8u_to_g8u(byte src)
            => Converter.convert<byte>(src);

        public static byte convert_g8u_to_g8u(byte src)
            => Converter.convert<byte,byte>(src);

        public static short convert_8u_to_16i(byte src)
            => src;
        
        public static short convert_8u_to_g16i(byte src)
            => Converter.convert<short>(src);

        public static ushort convert_8u_to_16u(byte src)
            => src;

        public static ushort convert_8u_to_g16u(byte src)
            => Converter.convert<ushort>(src);

        public static ushort convert_g8u_to_g16u(byte src)
            => Converter.convert<byte,ushort>(src);

        public static int convert_8u_to_g32i(byte src)
            => Converter.convert<int>(src);

        public static int convert_g8u_to_g32i(byte src)
            => Converter.convert<byte,int>(src);

        public static uint convert_8u_to_g32u(byte src)
            => Converter.convert<uint>(src);

        public static uint convert_g8u_to_g32u(byte src)
            => Converter.convert<byte,uint>(src);

        public static long convert_8u_to_g64i(byte src)
            => Converter.convert<long>(src);

        public static long convert_g8u_to_g64i(byte src)
            => Converter.convert<byte,long>(src);

        public static ulong convert_8u_to_g64u(byte src)
            => Converter.convert<ulong>(src);

        public static ulong convert_g8u_to_g64u(byte src)
            => Converter.convert<byte,ulong>(src);

        public static float convert_8u_to_g32f(byte src)
            => Converter.convert<float>(src);

        public static float convert_g8u_to_g32f(byte src)
            => Converter.convert<byte,float>(src);

        public static double convert_8u_to_g64f(byte src)
            => Converter.convert<double>(src);

        public static double convert_g8u_to_g64f(byte src)
            => Converter.convert<byte,double>(src);

        public static char convert_8u_to_gch16(byte src)
            => Converter.convert<char>(src);

        public static char convert_g8u_to_gch16(byte src)
            => Converter.convert<byte,char>(src);

        //~ 16i -> x

        public static byte convert_16i_to_g8u(short src)
            => Converter.convert<byte>(src);

        public static sbyte convert_16i_to_g8i(short src)
            => Converter.convert<sbyte>(src);

        public static ushort convert_16i_to_g16u(short src)
            => Converter.convert<ushort>(src);

        public static short convert_16i_to_g16i(short src)
            => Converter.convert<short>(src);
        
        public static int convert_16i_to_g32i(short src)
            => Converter.convert<int>(src);

        public static uint convert_16i_to_g32u(short src)
            => Converter.convert<uint>(src);

        public static long convert_16i_to_g64i(short src)
            => Converter.convert<long>(src);

        public static ulong convert_16i_to_g64u(short src)
            => Converter.convert<ulong>(src);

        public static ulong convert_g16i_to_g64u(short src)
            => Converter.convert<short,ulong>(src);

        public static float convert_16i_to_g32f(short src)
            => Converter.convert<float>(src);

        public static float convert_g16i_to_g32f(short src)
            => Converter.convert<short,float>(src);

        public static double convert_16i_to_g64f(short src)
            => Converter.convert<double>(src);

        public static double convert_g16i_to_g64f(short src)
            => Converter.convert<short,double>(src);

        public static char convert_16i_to_gch16(short src)
            => Converter.convert<char>(src);

        public static char convert_g16i_to_gch16(short src)
            => Converter.convert<short,char>(src);

        // ~ 16u -> x

        public static sbyte convert_16u_to_g8i(ushort src)
            => Converter.convert<sbyte>(src);

        public static byte convert_16u_to_g8u(ushort src)
            => Converter.convert<byte>(src);

        public static short convert_16u_to_g16i(ushort src)
            => Converter.convert<short>(src);

        public static ushort convert_16u_to_g16u(ushort src)
            => Converter.convert<ushort>(src);
        
        public static int convert_16u_to_g32i(ushort src)
            => Converter.convert<int>(src);

        public static uint convert_16u_to_g32u(ushort src)
            => Converter.convert<uint>(src);

        public static long convert_16u_to_g64i(ushort src)
            => Converter.convert<long>(src);

        public static ulong convert_16u_to_g64u(ushort src)
            => Converter.convert<ulong>(src);

        public static float convert_16u_to_g32f(ushort src)
            => Converter.convert<float>(src);

        public static double convert_16u_to_g64f(ushort src)
            => Converter.convert<double>(src);

        public static double convert_g16u_to_g64f(ushort src)
            => Converter.convert<ushort,double>(src);

        public static char convert_16u_to_gch16(ushort src)
            => Converter.convert<char>(src);

        //~ 32i -> x

        public static sbyte convert_32i_to_gi(int src)
            => (sbyte)src;

        public static sbyte convert_32i_to_g8i(int src)
            => Converter.convert<sbyte>(src);

        public static sbyte convert_g32i_to_g8i(int src)
            => Converter.convert<int,sbyte>(src);

        public static byte convert_32i_to_8u(int src)
            => (byte)src;

        public static byte convert_32i_to_g8u(int src)
            => Converter.convert<byte>(src);

        public static byte convert_g32i_to_g8u(int src)
            => Converter.convert<int,byte>(src);

        public static short convert_32i_to_16i(int src)
            => (short)src;

        public static short convert_32i_to_g16i(int src)
            => Converter.convert<short>(src);
        
        public static short convert_g32i_to_g16i(int src)
            => Converter.convert<int,short>(src);

        public static ushort convert_32i_to_16u(int src)
            => (ushort)src;

        public static ushort convert_32i_to_g16u(int src)
            => Converter.convert<ushort>(src);

        public static ushort convert_g32i_to_g16u(int src)
            => Converter.convert<int,ushort>(src);

        public static int convert_32i_to_32i(int src)
            => src;

        public static int convert_32i_to_g32i(int src)
            => Converter.convert<int>(src);

        public static int convert_g32i_to_g32i(int src)
            => Converter.convert<int,int>(src);

        public static uint convert_32i_to_32u(int src)
            => (uint)src;

        public static uint convert_32i_to_g32u(int src)
            => Converter.convert<uint>(src);

        public static uint convert_g32i_to_g32u(int src)
            => Converter.convert<int,uint>(src);

        public static long convert_32i_to_64i(int src)
            => src;

        public static long convert_32i_to_g64i(int src)
            => Converter.convert<long>(src);

        public static long convert_g32i_to_g64i(int src)
            => Converter.convert<int,long>(src);

        public static ulong convert_32i_to_64u(int src)
            => (ulong)src;

        public static ulong convert_32i_to_g64u(int src)
            => Converter.convert<ulong>(src);

        public static ulong convert_g32i_to_g64u(int src)
            => Converter.convert<int,ulong>(src);

        public static float convert_32i_to_32f(int src)
            => src;

        public static float convert_32i_to_g32f(int src)
            => Converter.convert<float>(src);

        public static float convert_g32i_to_g32f(int src)
            => Converter.convert<int,float>(src);

        public static double convert_32i_to_64f(int src)
            => src;

        public static double convert_32i_to_g64f(int src)
            => Converter.convert<double>(src);

        public static double convert_g32i_to_g64f(int src)
            => Converter.convert<int,double>(src);

        public static char convert_32i_to_ch16(int src)
            => (char)src;

        public static char convert_32i_to_gch16(int src)
            => Converter.convert<char>(src);

        public static char convert_g32i_to_gch16(int src)
            => Converter.convert<int,char>(src);

        //~ 32u -> x

        public static sbyte convert_32u_to_8i(uint src)
            => (sbyte)src;

        public static sbyte convert_32u_to_g8i(uint src)
            => Converter.convert<sbyte>(src);

        public static sbyte convert_g32u_to_g8i(uint src)
            => Converter.convert<uint,sbyte>(src);

        public static byte convert_32u_to_8u(uint src)
            => (byte)src;

        public static byte convert_32u_to_g8u(uint src)
            => Converter.convert<byte>(src);

        public static byte convert_g32u_to_g8u(uint src)
            => Converter.convert<uint,byte>(src);

        public static short convert_32u_to_16i(uint src)
            => (short)src;

        public static short convert_32u_to_g16i(uint src)
            => Converter.convert<short>(src);

        public static short convert_g32u_to_g16i(uint src)
            => Converter.convert<uint,short>(src);

        public static ushort convert_32u_to_16u(uint src)
            => (ushort)src;

        public static ushort convert_32u_to_g16u(uint src)
            => Converter.convert<ushort>(src);

        public static ushort convert_g32u_to_g16u(uint src)
            => Converter.convert<uint,ushort>(src);

        public static int convert_32u_to_32i(uint src)
            => (int)src;

        public static int convert_32u_to_g32i(uint src)
            => Converter.convert<int>(src);

        public static int convert_g32u_to_g32i(uint src)
            => Converter.convert<uint,int>(src);

        public static uint convert_32u_to_32u(uint src)
            => src;

        public static uint convert_32u_to_g32u(uint src)
            => Converter.convert<uint>(src);

        public static uint convert_g32u_to_g32u(uint src)
            => Converter.convert<uint,uint>(src);

        public static long convert_32u_to_64i(uint src)
            => src;

        public static long convert_32u_to_g64i(uint src)
            => Converter.convert<long>(src);

        public static long convert_g32u_to_g64i(uint src)
            => Converter.convert<uint,long>(src);

        public static ulong convert_32u_to_64u(uint src)
            => src;

        public static ulong convert_32u_to_g64u(uint src)
            => Converter.convert<ulong>(src);

        public static ulong convert_g32u_to_g64u(uint src)
            => Converter.convert<uint,ulong>(src);

        public static float convert_32u_to_32f(uint src)
            => src;

        public static float convert_32u_to_g32f(uint src)
            => Converter.convert<float>(src);

        public static float convert_g32u_to_g32f(uint src)
            => Converter.convert<uint,float>(src);

        public static double convert_32u_to_64f(uint src)
            => src;

        public static double convert_32u_to_g64f(uint src)
            => Converter.convert<double>(src);
 
        public static double convert_g32u_to_g64f(uint src)
            => Converter.convert<uint,double>(src);

        public static char convert_32u_to_ch(uint src)
            => (char)src;

        public static char convert_32u_to_gch16(uint src)
            => Converter.convert<char>(src);

        public static char convert_g32u_to_gch16(uint src)
            => Converter.convert<uint,char>(src);

        //~ 64i -> x

        public static byte convert_64i_to_g8u(long src)
            => Converter.convert<byte>(src);

        public static sbyte convert_64i_to_g8i(long src)
            => Converter.convert<sbyte>(src);

        public static ushort convert_64i_to_g16u(long src)
            => Converter.convert<ushort>(src);

        public static short convert_64i_to_g16i(long src)
            => Converter.convert<short>(src);
        
        public static int convert_64i_to_g32i(long src)
            => Converter.convert<int>(src);

        public static uint convert_64i_to_g32u(long src)
            => Converter.convert<uint>(src);

        public static long convert_64i_to_g64i(long src)
            => Converter.convert<long>(src);

        public static ulong convert_64i_to_g64u(long src)
            => Converter.convert<ulong>(src);

        public static float convert_64i_to_g32f(long src)
            => Converter.convert<float>(src);

        public static double convert_64i_to_g64f(long src)
            => Converter.convert<double>(src);
 
         public static char convert_64i_to_gch16(long src)
            => Converter.convert<char>(src);


        //~ 64u -> x

        public static sbyte convert_64u_to_g8i(ulong src)
            => Converter.convert<sbyte>(src);

        public static byte convert_64u_to_g8u(ulong src)
            => Converter.convert<byte>(src);

        public static short convert_64u_to_g16i(ulong src)
            => Converter.convert<short>(src);

        public static ushort convert_64u_to_g16u(ulong src)
            => Converter.convert<ushort>(src);

        public static ushort convert_g64u_to_g16u(ulong src)
            => Converter.convert<ulong,ushort>(src);

        public static int convert_64u_to_g32i(ulong src)
            => Converter.convert<int>(src);

        public static uint convert_64u_to_g32u(ulong src)
            => Converter.convert<uint>(src);

        public static uint convert_64u_to_32u(ulong src)
            => (uint)src;

        public static uint convert_g64u_to_g32u(ulong src)
            => Converter.convert<ulong,uint>(src);

        public static long convert_64u_to_g64i(ulong src)
            => Converter.convert<long>(src);

        public static ulong convert_64u_to_g64u(ulong src)
            => Converter.convert<ulong>(src);

        public static float convert_64u_to_g32f(ulong src)
            => Converter.convert<float>(src);

        public static double convert_64u_to_64f(ulong src)
            => (double)(long)src;

        public static double convert_64u_to_g64f(ulong src)
            => Converter.convert<double>(src);

        public static double convert_g64u_to_g64f(ulong src)
            => Converter.convert<ulong,double>(src);

         public static char convert_64u_to_gch16(ulong src)
            => Converter.convert<char>(src);

        // ~ 32f -> x

        public static sbyte convert_32f_to_g8i(float src)
            => Converter.convert<sbyte>(src);

        public static byte convert_32f_to_g8u(float src)
            => Converter.convert<byte>(src);

        public static short convert_32f_to_g16i(float src)
            => Converter.convert<short>(src);

        public static ushort convert_32f_to_g16u(float src)
            => Converter.convert<ushort>(src);
        
        public static int convert_32f_to_g32i(float src)
            => Converter.convert<int>(src);

        public static uint convert_32f_to_g32u(float src)
            => Converter.convert<uint>(src);

        public static long convert_32f_to_g64i(float src)
            => Converter.convert<long>(src);

        public static ulong convert_32f_to_g64u(float src)
            => Converter.convert<ulong>(src);

        public static float convert_32f_to_g32f(float src)
            => Converter.convert<float>(src);

        public static double convert_32f_to_g64f(float src)
            => Converter.convert<double>(src);
 
         public static char convert_32f_to_gch16(float src)
            => Converter.convert<char>(src);

        // ~ 64f -> x

        public static sbyte convert_64f_to_8i(double src)
            => (sbyte)src;

        public static sbyte convert_64f_to_g8i(double src)
            => Converter.convert<sbyte>(src);

        public static sbyte convert_g64f_to_g8i(double src)
            => Converter.convert<double,sbyte>(src);

        public static byte convert_64f_to_8u(double src)
            => (byte)((long)src);

        public static byte convert_64f_to_g8u(double src)
            => Converter.convert<byte>(src);

        public static byte convert_g64f_to_g8u(double src)
            => Converter.convert<double,byte>(src);

        public static short convert_64f_to_16i(double src)
            => (short)src;

        public static short convert_64f_to_g16i(double src)
            => Converter.convert<short>(src);

        public static short convert_g64f_to_g16i(double src)
            => Converter.convert<double,short>(src);

        public static ushort convert_64f_to_g16u(double src)
            => Converter.convert<ushort>(src);

        public static ushort convert_g64f_to_g16u(double src)
            => Converter.convert<double,ushort>(src);

        public static int convert_64f_to_g32i(double src)
            => Converter.convert<int>(src);

        public static int convert_g64f_to_g32i(double src)
            => Converter.convert<double,int>(src);

        public static uint convert_64f_to_g32u(double src)
            => Converter.convert<uint>(src);

        public static uint convert_g64f_to_g32u(double src)
            => Converter.convert<double,uint>(src);

        public static long convert_64f_to_g64i(double src)
            => Converter.convert<long>(src);

        public static long convert_g64f_to_g64i(double src)
            => Converter.convert<double,long>(src);

        public static ulong convert_64f_to_g64u(double src)
            => Converter.convert<ulong>(src);

        public static ulong convert_g64f_to_g64u(double src)
            => Converter.convert<double,ulong>(src);

        public static float convert_64f_to_g32f(double src)
            => Converter.convert<float>(src);

        public static double convert_64f_to_g64f(double src)
            => Converter.convert<double>(src);
 
         public static char convert_64f_to_gch16(double src)
            => Converter.convert<char>(src);

        // ~ ch -> x

        public static sbyte convert_ch16_to_8i(char src)
            => (sbyte)src;

        public static sbyte convert_ch16_to_g8i(char src)
            => Converter.convert<sbyte>(src);

        public static byte convert_ch16_to_g8u(char src)
            => Converter.convert<byte>(src);

        public static short convert_ch16_to_16i(char src)
            => (short)src;

        public static short convert_ch16_to_g16i(char src)
            => Converter.convert<short>(src);

        public static ushort convert_ch16_to_16u(char src)
            => (ushort)src;

        public static ushort convert_ch16_to_g16u(char src)
            => Converter.convert<ushort>(src);
        
        public static int convert_ch16_to_g32i(char src)
            => Converter.convert<int>(src);

        public static uint convert_ch16_to_g32u(char src)
            => Converter.convert<uint>(src);

        public static long convert_ch16_to_g64i(char src)
            => Converter.convert<long>(src);

        public static ulong convert_ch16_to_g64u(char src)
            => Converter.convert<ulong>(src);

        public static float convert_ch16_to_g32f(char src)
            => Converter.convert<float>(src);

        public static double convert_ch16_to_g64f(char src)
            => Converter.convert<double>(src);
 
        public static char convert_ch16_to_gch16(char src)
            => Converter.convert<char>(src);
    }

}