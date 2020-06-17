//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
    
    public interface IBitFieldInfo
    {
        Type DataType {get;}
        
        ReadOnlySpan<FieldSegInfo> Segments {get;}
    }

    public readonly struct FieldSegInfo
    {
        [MethodImpl(Inline)]
        public static FieldSegInfo<E,T> define<E,T>(byte left, byte width, string name = null)
            where E : unmanaged, Enum
            where T : unmanaged
                => new FieldSegInfo<E,T>(left,width,name);

        [MethodImpl(Inline)]
        public FieldSegInfo(byte left, string name, Type fieldType, Type dataType, byte width)
        {
            this.LeftIndex = left;
            this.Name = name;
            this.FieldType = fieldType;
            this.DataType = dataType;
            this.Width = width;
        }
        
        public readonly byte LeftIndex;
        
        public readonly string Name;

        public readonly Type FieldType;

        public readonly Type DataType;
        
        public readonly byte Width;

        public byte LastIndex 
            => (byte)(LeftIndex + Width);
    }

    public readonly struct FieldSegInfo<E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        public readonly byte LeftIndex;

        public readonly string Name;

        public readonly byte Width;

        [MethodImpl(Inline)]
        public static implicit operator FieldSegInfo(FieldSegInfo<E,T> src)
            => new FieldSegInfo(src.LeftIndex, src.Name, src.FieldType, src.DataType, src.Width);
        
        [MethodImpl(Inline)]
        public FieldSegInfo(byte left, byte width, string name = null)
        {
            this.LeftIndex = left;
            this.Width = width;
            this.Name = name ?? typeof(E).Name;
        }

        public byte RightIndex 
            => (byte)(LeftIndex + Width);

        public Type DataType 
            => typeof(T);
        
        public Type FieldType 
            => typeof(E);        
    }

    public readonly struct BitFieldInfo : IBitFieldInfo
    {
        readonly FieldSegInfo[] segments;

        [MethodImpl(Inline)]
        public BitFieldInfo(Type type, FieldSegInfo[] segments)
        {
            this.DataType = type;
            this.segments = segments;
        }

        public ReadOnlySpan<FieldSegInfo> Segments
        {
            [MethodImpl(Inline)]
            get => segments;
        }

        public Type DataType {get;}
    }
}