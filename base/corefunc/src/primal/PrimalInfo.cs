//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;
    
    public interface IPrimalInfo<T>
        where T : unmanaged
    {
        T MinVal {get;}
        
        T MaxVal {get;}
        
        bool Signed {get;}

        T One {get;}

        T Zero {get;}

        Option<T> Epsilon {get;}

        ulong BitSize {get;}

        int ByteSize {get;}
        
        bool Infinite {get;}

        PrimalKind Kind {get;}

    }

    public interface IPrimalDescriptor<T>
        where T : unmanaged
    {
        IPrimalInfo<T> Description {get;}
    }


    public readonly struct PrimalRep<T> 
        where T : unmanaged
    {

        internal static PrimalRep<T> TheOnly = default;
         
        readonly T exeplar;

        public PrimalRep(T exemplar = default)
        {
            this.exeplar = exemplar;
        }

        [MethodImpl(Inline)]
        public static implicit operator T(PrimalRep<T> src)
            => src.exeplar;
    }

    public readonly struct PrimalInfo : 
        IPrimalDescriptor<byte>, 
        IPrimalDescriptor<sbyte>, 
        IPrimalDescriptor<short>,
        IPrimalDescriptor<ushort>, 
        IPrimalDescriptor<int>,
        IPrimalDescriptor<uint>,
        IPrimalDescriptor<long>,
        IPrimalDescriptor<ulong>,            
        IPrimalDescriptor<float>, 
        IPrimalDescriptor<double> 
    {
        static readonly PrimalInfo Inhabitant = default;

        [MethodImpl(Inline)]
        public static IPrimalInfo<T> Get<T>()
            where T : unmanaged
            => Provider<T>().Description;            

        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : unmanaged
                => default(T);

        [MethodImpl(Inline)]
        public static T one<T>()
            where T : unmanaged
                => convert<T>(1);

        [MethodImpl(Inline)]
        public static T minval<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return minvali<T>();
            else if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return minvalu<T>();
            else
                return minvalf<T>();
        }                

        [MethodImpl(Inline)]
        static T minvali<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(sbyte.MinValue);
            else if(typeof(T) == typeof(short))
                return convert<T>(short.MinValue);
            else if(typeof(T) == typeof(int))
                return convert<T>(int.MinValue);
            else
                return convert<T>(long.MinValue);
        }

        [MethodImpl(Inline)]
        static T minvalu<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(byte.MinValue);
            else if(typeof(T) == typeof(ushort))
                return convert<T>(ushort.MinValue);
            else if(typeof(T) == typeof(uint))
                return convert<T>(uint.MinValue);
            else
                return convert<T>(ulong.MinValue);
        }

        [MethodImpl(Inline)]
        static T minvalf<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return convert<T>(float.MinValue);
            else if(typeof(T) == typeof(double))
                return convert<T>(double.MinValue);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return maxvali<T>();
            else if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return maxvalu<T>();
            else
                return maxvalf<T>();
        }                

        [MethodImpl(Inline)]
        static T maxvali<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(sbyte.MaxValue);
            else if(typeof(T) == typeof(short))
                return convert<T>(short.MaxValue);
            else if(typeof(T) == typeof(int))
                return convert<T>(int.MaxValue);
            else
                return convert<T>(long.MaxValue);
        }

        [MethodImpl(Inline)]
        static T maxvalu<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(byte.MaxValue);
            else if(typeof(T) == typeof(ushort))
                return convert<T>(ushort.MaxValue);
            else if(typeof(T) == typeof(uint))
                return convert<T>(uint.MaxValue);
            else
                return convert<T>(ulong.MaxValue);
        }

        [MethodImpl(Inline)]
        static T maxvalf<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return convert<T>(float.MaxValue);
            else if(typeof(T) == typeof(double))
                return convert<T>(double.MaxValue);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool signed<T>()
            where T : unmanaged
                => Get<T>().Signed;

        [MethodImpl(Inline)]
        public static bool unsigned<T>()
            where T : unmanaged
                => !Get<T>().Signed;

        [MethodImpl(Inline)]
        public static ulong bitsize<T>()
            where T : unmanaged
                => Get<T>().BitSize;

        [MethodImpl(Inline)]
        public static int bytesize<T>()
            where T : unmanaged
                => Get<T>().ByteSize;


        [MethodImpl(Inline)]
        static IPrimalDescriptor<T> Provider<T>() 
            where T : unmanaged
                => cast<IPrimalDescriptor<T>>(Inhabitant);

        IPrimalInfo<sbyte> IPrimalDescriptor<sbyte>.Description 
            => Int8Info.Summary;

        IPrimalInfo<byte> IPrimalDescriptor<byte>.Description 
            => UInt8Info.Summary;

        IPrimalInfo<short> IPrimalDescriptor<short>.Description 
            => Int16Info.Summary;

        IPrimalInfo<ushort> IPrimalDescriptor<ushort>.Description 
            => UInt16Info.Summary;

        IPrimalInfo<int> IPrimalDescriptor<int>.Description 
            => Int32Info.Summary;

        IPrimalInfo<uint> IPrimalDescriptor<uint>.Description 
            => UInt32Info.Summary;

        IPrimalInfo<long> IPrimalDescriptor<long>.Description 
            => Int64Info.Summary;

        IPrimalInfo<ulong> IPrimalDescriptor<ulong>.Description 
            => UInt64Info.Summary;

        IPrimalInfo<float> IPrimalDescriptor<float>.Description 
            => Float32Info.Summary;

        IPrimalInfo<double> IPrimalDescriptor<double>.Description 
            => Float64Info.Summary;
    }

    readonly struct Int8Info
    {
        public const sbyte Zero = 0;

        public const sbyte One = 1;

        public const uint BitSize = 8;

        public const sbyte MinVal = sbyte.MinValue;            

        public const sbyte MaxVal = sbyte.MaxValue;

        public const bool Signed = true;
        
        public static readonly PrimalInfo<sbyte> Summary 
            = new PrimalInfo<sbyte>((MinVal,MaxVal), Signed, Zero, One, BitSize);
        
                    
    }


    readonly struct UInt8Info
    {
        public const byte Zero = 0;

        public const byte One = 1;

        public const uint BitSize = 8;

        public const byte MinVal = byte.MinValue;            

        public const byte MaxVal = byte.MaxValue;

        public const bool Signed = false;
        
        public static readonly PrimalInfo<byte> Summary 
            = new PrimalInfo<byte>((MinVal,MaxVal), Signed, Zero, One, BitSize);

    }            

    readonly struct Int16Info
    {
        public const short Zero = 0;

        public const short One = 1;

        public const uint BitSize = 16;

        public const short MinVal = short.MinValue;            

        public const short MaxVal = short.MaxValue;

        public const bool Signed = true;
        
        public static readonly PrimalInfo<short> Summary 
            = new PrimalInfo<short>((MinVal,MaxVal), Signed, Zero, One, BitSize);

    }            

    readonly struct UInt16Info
    {
        public const ushort Zero = 0;

        public const ushort One = 1;

        public const uint BitSize = 16;

        public const ushort MinVal = ushort.MinValue;            

        public const ushort MaxVal = ushort.MaxValue;

        public const bool Signed = false;
        
        public static readonly PrimalInfo<ushort> Summary 
            = new PrimalInfo<ushort>((MinVal,MaxVal), Signed, Zero, One, BitSize);
    }            

    readonly struct Int32Info
    {
        public const int Zero = 0;

        public const int One = 1;

        public const uint BitSize = 32;

        public const int MinVal = int.MinValue;            

        public const int MaxVal = int.MaxValue;

        public const bool Signed = true;
        
        public static readonly PrimalInfo<int> Summary 
            = new PrimalInfo<int>((MinVal,MaxVal), Signed, Zero, One, BitSize);

    }            

    readonly struct UInt32Info
    {
        public const uint Zero = 0;

        public const uint One = 1;

        public const uint BitSize = 32;

        public const uint MinVal = uint.MinValue;            

        public const uint MaxVal = uint.MaxValue;

        public const bool Signed = false;
        
        public static readonly PrimalInfo<uint> Summary 
            = new PrimalInfo<uint>((MinVal,MaxVal), Signed, Zero, One, BitSize);

    }            

    readonly struct Int64Info
    {
        public const long Zero = 0;

        public const long One = 1;

        public const uint BitSize = 64;

        public const long MinVal = long.MinValue;            

        public const long MaxVal = long.MaxValue;

        public const bool Signed = true;
        
        public static readonly PrimalInfo<long> Summary 
            = new PrimalInfo<long>((MinVal,MaxVal), Signed, Zero, One, BitSize);

    }            

    readonly struct UInt64Info
    {
        public const ulong Zero = 0;

        public const ulong One = 1;

        public const uint BitSize = 64;

        public const ulong MinVal = ulong.MinValue;            

        public const ulong MaxVal = ulong.MaxValue;

        public const bool Signed = false;
        
        public static readonly PrimalInfo<ulong> Summary 
            = new PrimalInfo<ulong>((MinVal,MaxVal), Signed, Zero, One, BitSize);

    }            

    readonly struct Float32Info
    {
        public const float Zero = 0;

        public const float One = 1;

        public const uint BitSize = 32;

        public const float MinVal = float.MinValue;            

        public const float MaxVal = float.MaxValue;

        public const float Epsilon = float.Epsilon;

        public const bool Signed = true;
        
        public static readonly PrimalInfo<float> Summary 
            = new PrimalInfo<float>((MinVal,MaxVal), Signed, Zero, One, BitSize, Epsilon);

    }        

    readonly struct Float64Info
    {
        public const double Zero = 0;

        public const double One = 1;

        public const uint BitSize = 64;

        public const double MinVal = double.MinValue;            

        public const double MaxVal = double.MaxValue;

        public const double Epsilon = double.Epsilon;

        public const bool Signed = true;
        
        public static readonly PrimalInfo<double> Summary 
            = new PrimalInfo<double>((MinVal,MaxVal), Signed, Zero, One, BitSize, Epsilon);

    }            


    public readonly struct PrimalInfo<T> : IPrimalInfo<T>
        where T : unmanaged
    {
        public PrimalInfo((T min, T max) range, bool signed, T zero, T one, ulong bitsize, T epsilon = default, bool infinite = false)
        {
            this.MinVal = range.min;
            this.MaxVal = range.max;
            this.Signed = signed;
            this.One = one;
            this.Zero = zero;
            this.BitSize = bitsize;
            this.Infinite = infinite;
            this.Epsilon = ! epsilon.Equals(default) ? some(epsilon) : none<T>();
            this.ByteSize = (int)(BitSize/8ul);
            this.Kind = PrimalKinds.kind<T>();
        }

        public T MinVal {get;}
        
        public T MaxVal {get;}
        
        public bool Signed {get;}

        public T One {get;}

        public T Zero {get;}

        public Option<T> Epsilon {get;}

        public ulong BitSize {get;}

        public int ByteSize {get;}
        
        public bool Infinite {get;}

        public PrimalKind Kind {get;}
            
    }
}