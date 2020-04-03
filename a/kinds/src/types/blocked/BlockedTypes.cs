//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct BlockedTypeKind : ILiteralKind<BlockedKind>
    {        
        [MethodImpl(Inline)]
        public static implicit operator BlockedTypeKind(BlockedKind kind)
            => new BlockedTypeKind(kind);

        [MethodImpl(Inline)]
        public static implicit operator BlockedKind(BlockedTypeKind kind)
            => kind.Class;

        [MethodImpl(Inline)]
        public BlockedTypeKind(BlockedKind kind)
        {
            this.Class = kind;
        }
        
        public BlockedKind Class {get;}
    }

    public readonly struct BlockedTypeKind<T> : IBlockedType<BlockedTypeKind<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator BlockedTypeKind<T>(BlockedKind src)
            => new BlockedTypeKind<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BlockedKind(BlockedTypeKind<T> src)
            => src.Class;

        [MethodImpl(Inline)]
        public static implicit operator BlockedTypeKind<T>(BlockedTypeKind src)
            => new BlockedTypeKind<T>(src.Class);

        [MethodImpl(Inline)]
        public static implicit operator BlockedTypeKind(BlockedTypeKind<T> src)
            =>  new BlockedTypeKind(src.Class);

        [MethodImpl(Inline)]
        public BlockedTypeKind(BlockedKind kind)
        {
            this.Class = kind;
        }
        
        public BlockedKind Class {get;}
    }        

    public readonly struct BlockedTypeKind<W,T> :  IBlockedType<BlockedTypeKind<W,T>, W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {
        public BlockedKind Class => BlockedType.kind<W,T>();

        [MethodImpl(Inline)]
        public static implicit operator BlockedKind(BlockedTypeKind<W,T> src)
            => src.Class;

        [MethodImpl(Inline)]
        public static implicit operator BlockedTypeKind(BlockedTypeKind<W,T> src)
            => new BlockedTypeKind(src.Class);

        [MethodImpl(Inline)]
        public static implicit operator BlockedTypeKind<T>(BlockedTypeKind<W,T> src)
            => new BlockedTypeKind<T>(src.Class);
    } 

    public static class BlockedTypes
    {
        public readonly struct Blocked16 : IBlockedType<Blocked16>
        {
            public BlockedKind Class => BlockedKind.b16;

            [MethodImpl(Inline)]
            public static implicit operator BlockedTypeKind(Blocked16 src)
                => src.Class;

            [MethodImpl(Inline)]
            public static implicit operator BlockedKind(Blocked16 src)
                => src.Class;
        }        

        public readonly struct Blocked32 : IBlockedType<Blocked32>
        {
            public BlockedKind Class => BlockedKind.b32;

            [MethodImpl(Inline)]
            public static implicit operator BlockedTypeKind(Blocked32 src)
                => BlockedKind.b32;

            [MethodImpl(Inline)]
            public static implicit operator BlockedKind(Blocked32 src)
                => BlockedKind.b32;
        }        

        public readonly struct Blocked64 : IBlockedType<Blocked64>
        {
            public BlockedKind Class => BlockedKind.b64;

            [MethodImpl(Inline)]
            public static implicit operator BlockedTypeKind(Blocked64 src)
                => src.Class;

            [MethodImpl(Inline)]
            public static implicit operator BlockedKind(Blocked64 src)
                => src.Class;
        }        

        public readonly struct Blocked128 : IBlockedType<Blocked128>
        {
            public BlockedKind Class => BlockedKind.b128;

            [MethodImpl(Inline)]
            public static implicit operator BlockedTypeKind(Blocked128 src)
                => src.Class;

            [MethodImpl(Inline)]
            public static implicit operator BlockedKind(Blocked128 src)
                => src.Class;
        }        

        public readonly struct Blocked256 : IBlockedType<Blocked256>
        {
            public BlockedKind Class => BlockedKind.b256;

            [MethodImpl(Inline)]
            public static implicit operator BlockedTypeKind(Blocked256 src)
                => src.Class;

            [MethodImpl(Inline)]
            public static implicit operator BlockedKind(Blocked256 src)
                => src.Class;
        }        

        public readonly struct Blocked512 : IBlockedType<Blocked512>
        {
            public BlockedKind Class => BlockedKind.b512;

            [MethodImpl(Inline)]
            public static implicit operator BlockedTypeKind(Blocked512 src)
                => src.Class;

            [MethodImpl(Inline)]
            public static implicit operator BlockedKind(Blocked512 src)
                => src.Class;
        }        

        public readonly struct Block16x8u : IBlockedType<Block16x8u,W16,byte> 
        {         
            
        }
        
        public readonly struct Block16x8i : IBlockedType<Block16x8i,W16,sbyte> 
        {
            
        }
        
        public readonly struct Block16x16u : IBlockedType<Block16x16u,W16,ushort> 
        {         
                 
        }

        public readonly struct Block16x16i : IBlockedType<Block16x16i,W16,short> 
        {     
            
        }

        public readonly struct Block32x8u : IBlockedType<W32,byte> 
        {         
            
        }
        
        public readonly struct Block32x8i : IBlockedType<W32,sbyte> 
        {         
            
        }
        
        public readonly struct Block32x16u : IBlockedType<W32,ushort> 
        { 
            
        }

        public readonly struct Block32x16i : IBlockedType<W32,short> 
        { 
            
        }

        public readonly struct Block32x32u : IBlockedType<W32,uint> 
        { 
            
        }

        public readonly struct Block32x32i : IBlockedType<W32,int> 
        { 
            
        }

        public readonly struct Block64x8u : IBlockedType<W64,byte> 
        { 
            
        }
        
        public readonly struct Block64x8i : IBlockedType<W64,sbyte> 
        { 
            
        }
        
        public readonly struct Block64x16u : IBlockedType<W64,ushort> 
        {
            
        }

        public readonly struct Block64x16i : IBlockedType<W64,short> 
        { 
            
        }

        public readonly struct Block64x32u : IBlockedType<W64,uint> 
        { 
            
        }

        public readonly struct Block64x32i : IBlockedType<W64,int> 
        { 
            
        }

        public readonly struct Block64x64u : IBlockedType<W64,ulong> 
        { 
            
        }

        public readonly struct Block64x64i : IBlockedType<W64,long> 
        {
            
        }

        public readonly struct Block128x8u : IBlockedType<W128,byte> 
        {
            
        }
        
        public readonly struct Block128x8i : IBlockedType<W128,sbyte> 
        {

        }
        
        public readonly struct Block128x16u : IBlockedType<W128,ushort> 
        {

        }

        public readonly struct Block128x16i : IBlockedType<W128,short> 
        { 

        }

        public readonly struct Block128x32u : IBlockedType<W128,uint> 
        {

        }

        public readonly struct Block128x32i : IBlockedType<W128,int> 
        { 

        }

        public readonly struct Block128x64u : IBlockedType<W128,ulong> 
        {

        }

        public readonly struct Block128x64i : IBlockedType<W128,long> 
        { 

        }

        public readonly struct Block128x32f : IBlockedType<W128,float> 
        {

        }

        public readonly struct Block128x64f : IBlockedType<W128,double> 
        {

        }

        public readonly struct Block256x8u : IBlockedType<W256,byte> 
        {
            
        }
        
        public readonly struct Block256x8i : IBlockedType<W256,sbyte> 
        {

        }
        
        public readonly struct Block256x16u : IBlockedType<W256,ushort> 
        {

        }

        public readonly struct Block256x16i : IBlockedType<W256,short> 
        { 

        }

        public readonly struct Block256x32u : IBlockedType<W256,uint> 
        {

        }

        public readonly struct Block256x32i : IBlockedType<W256,int> 
        { 

        }

        public readonly struct Block256x64u : IBlockedType<W256,ulong> 
        {

        }

        public readonly struct Block256x64i : IBlockedType<W256,long> 
        { 

        }

        public readonly struct Block256x32f : IBlockedType<W256,float> 
        {

        }

        public readonly struct Block256x64f : IBlockedType<W256,double> 
        {


        }

        public readonly struct Block512x8u : IBlockedType<W512,byte> 
        {
            
        }
        
        public readonly struct Block512x8i : IBlockedType<W512,sbyte> 
        {

        }
        
        public readonly struct Block512x16u : IBlockedType<W512,ushort> 
        {

        }

        public readonly struct Block512x16i : IBlockedType<W512,short> 
        { 

        }

        public readonly struct Block512x32u : IBlockedType<W512,uint> 
        {

        }

        public readonly struct Block512x32i : IBlockedType<W512,int> 
        { 

        }

        public readonly struct Block512x64u : IBlockedType<W512,ulong> 
        {

        }

        public readonly struct Block512x64i : IBlockedType<W512,long> 
        { 

        }

        public readonly struct Block512x32f : IBlockedType<W512,float> 
        {

        }

        public readonly struct Block512x64f : IBlockedType<W512,double> 
        {

        }       
    }
}