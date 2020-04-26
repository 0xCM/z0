//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using BK = BlockedKind;

    partial class Kinds
    {
        public readonly struct Block16x8u : IBlockedKind<Block16x8u,W16,byte> { }
        
        public readonly struct Block16x8i : IBlockedKind<Block16x8i,W16,sbyte> { }
                
        public readonly struct Block16x16u : IBlockedKind<Block16x16u,W16,ushort> { }
        
        public readonly struct Block16x16i : IBlockedKind<Block16x16i,W16,short> { }
        
        public readonly struct Block32x8u : IBlockedKind<W32,byte> { }
                
        public readonly struct Block32x8i : IBlockedKind<W32,sbyte> { }
                
        public readonly struct Block32x16u : IBlockedKind<W32,ushort> { }
        
        public readonly struct Block32x16i : IBlockedKind<W32,short> { }
        
        public readonly struct Block32x32u : IBlockedKind<W32,uint> { }
        
        public readonly struct Block32x32i : IBlockedKind<W32,int> { }
        
        public readonly struct Block64x8u : IBlockedKind<W64,byte> 
        { 
            
        }
        
        public readonly struct Block64x8i : IBlockedKind<W64,sbyte> 
        { 
            
        }
        
        public readonly struct Block64x16u : IBlockedKind<W64,ushort> 
        {
            
        }

        public readonly struct Block64x16i : IBlockedKind<W64,short> 
        { 
            
        }

        public readonly struct Block64x32u : IBlockedKind<W64,uint> 
        { 
            
        }

        public readonly struct Block64x32i : IBlockedKind<W64,int> 
        { 
            
        }

        public readonly struct Block64x64u : IBlockedKind<W64,ulong> 
        { 
            
        }

        public readonly struct Block64x64i : IBlockedKind<W64,long> 
        {
            
        }

        public readonly struct Block128x8u : IBlockedKind<W128,byte> 
        {
            
        }
        
        public readonly struct Block128x8i : IBlockedKind<W128,sbyte> 
        {

        }
        
        public readonly struct Block128x16u : IBlockedKind<W128,ushort> 
        {

        }

        public readonly struct Block128x16i : IBlockedKind<W128,short> 
        { 

        }

        public readonly struct Block128x32u : IBlockedKind<W128,uint> 
        {

        }

        public readonly struct Block128x32i : IBlockedKind<W128,int> 
        { 

        }

        public readonly struct Block128x64u : IBlockedKind<W128,ulong> 
        {

        }

        public readonly struct Block128x64i : IBlockedKind<W128,long> 
        { 

        }

        public readonly struct Block128x32f : IBlockedKind<W128,float> 
        {

        }

        public readonly struct Block128x64f : IBlockedKind<W128,double> 
        {

        }

        public readonly struct Block256x8u : IBlockedKind<W256,byte> 
        {
            
        }
        
        public readonly struct Block256x8i : IBlockedKind<W256,sbyte> 
        {

        }
        
        public readonly struct Block256x16u : IBlockedKind<W256,ushort> 
        {

        }

        public readonly struct Block256x16i : IBlockedKind<W256,short> 
        { }       

        public readonly struct Block256x32u : IBlockedKind<W256,uint> 
        { }       

        public readonly struct Block256x32i : IBlockedKind<W256,int> 
        { }       

        public readonly struct Block256x64u : IBlockedKind<W256,ulong> { }       

        public readonly struct Block256x64i : IBlockedKind<W256,long> { }       

        public readonly struct Block256x32f : IBlockedKind<W256,float> { }       

        public readonly struct Block256x64f : IBlockedKind<W256,double> 
        { }       

        public readonly struct Block512x8u : IBlockedKind<W512,byte> 
        { }       
        
        public readonly struct Block512x8i : IBlockedKind<W512,sbyte> 
        { }       
        
        public readonly struct Block512x16u : IBlockedKind<W512,ushort> 
        { }       

        public readonly struct Block512x16i : IBlockedKind<W512,short> 
        { }       

        public readonly struct Block512x32u : IBlockedKind<W512,uint> 
        { }       

        public readonly struct Block512x32i : IBlockedKind<W512,int> 
        { }       

        public readonly struct Block512x64u : IBlockedKind<W512,ulong> 
        { }       

        public readonly struct Block512x64i : IBlockedKind<W512,long> 
        { }       

        public readonly struct Block512x32f : IBlockedKind<W512,float> 
        { }       

        public readonly struct Block512x64f : IBlockedKind<W512,double> 
        { }       
         
        public readonly struct Blocked16 : IBlockedKind<Blocked16>
        {
            public BK Class => BK.b16;

            [MethodImpl(Inline)]
            public static implicit operator BK(Blocked16 src)
                => src.Class;
        }        

        public readonly struct Blocked32 : IBlockedKind<Blocked32>
        {
            public BK Class => BK.b32;

            [MethodImpl(Inline)]
            public static implicit operator BlockedKind(Blocked32 src)
                => src.Class;
        }        

        public readonly struct Blocked64 : IBlockedKind<Blocked64>
        {
            public BK Class => BK.b64;

            [MethodImpl(Inline)]
            public static implicit operator BK(Blocked64 src)
                => src.Class;
        }        

        public readonly struct Blocked128 : IBlockedKind<Blocked128>
        {
            public BK Class => BK.b128;

            [MethodImpl(Inline)]
            public static implicit operator BK(Blocked128 src)
                => src.Class;
        }        

        public readonly struct Blocked256 : IBlockedKind<Blocked256>
        {
            public BK Class => BK.b256;

            [MethodImpl(Inline)]
            public static implicit operator BK(Blocked256 src)
                => src.Class;
        }        

        public readonly struct Blocked512 : IBlockedKind<Blocked512>
        {
            public BK Class => BK.b512;

            [MethodImpl(Inline)]
            public static implicit operator BK(Blocked512 src)
                => src.Class;
        }        
    }
}