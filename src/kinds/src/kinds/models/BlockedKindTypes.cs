//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using BK = BlockedKind;

    partial class Kinds
    {
        public readonly struct Block16x8u : TBlockedKind<Block16x8u,W16,byte> 
        {

        }
        
        public readonly struct Block16x8i : TBlockedKind<Block16x8i,W16,sbyte> 
        {


        }
                
        public readonly struct Block16x16u : TBlockedKind<Block16x16u,W16,ushort> 
        { 
            
        }       
        
        public readonly struct Block16x16i : TBlockedKind<Block16x16i,W16,short>
        { 
            
        }       
        
        public readonly struct Block32x8u : TBlockedKind<W32,byte> 
        {

        }
                
        public readonly struct Block32x8i : TBlockedKind<W32,sbyte> 
        { 

        }
                
        public readonly struct Block32x16u : TBlockedKind<W32,ushort>
        {

        }
        
        public readonly struct Block32x16i : TBlockedKind<W32,short>
        {

        }
        
        public readonly struct Block32x32u : TBlockedKind<W32,uint> 
        { 
            
        }       
        
        public readonly struct Block32x32i : TBlockedKind<W32,int> 
        { 
            
        }       
        
        public readonly struct Block64x8u : TBlockedKind<W64,byte> 
        { 
            
        }
        
        public readonly struct Block64x8i : TBlockedKind<W64,sbyte> 
        { 
            
        }
        
        public readonly struct Block64x16u : TBlockedKind<W64,ushort> 
        {
            
        }

        public readonly struct Block64x16i : TBlockedKind<W64,short> 
        { 
            
        }

        public readonly struct Block64x32u : TBlockedKind<W64,uint> 
        { 
            
        }

        public readonly struct Block64x32i : TBlockedKind<W64,int> 
        { 
            
        }

        public readonly struct Block64x64u : TBlockedKind<W64,ulong> 
        { 
            
        }

        public readonly struct Block64x64i : TBlockedKind<W64,long> 
        {
            
        }

        public readonly struct Block128x8u : TBlockedKind<W128,byte> 
        {
            
        }
        
        public readonly struct Block128x8i : TBlockedKind<W128,sbyte> 
        {

        }
        
        public readonly struct Block128x16u : TBlockedKind<W128,ushort> 
        {

        }

        public readonly struct Block128x16i : TBlockedKind<W128,short> 
        { 

        }

        public readonly struct Block128x32u : TBlockedKind<W128,uint> 
        {

        }

        public readonly struct Block128x32i : TBlockedKind<W128,int> 
        { 

        }

        public readonly struct Block128x64u : TBlockedKind<W128,ulong> 
        {

        }

        public readonly struct Block128x64i : TBlockedKind<W128,long> 
        { 

        }

        public readonly struct Block128x32f : TBlockedKind<W128,float> 
        {

        }

        public readonly struct Block128x64f : TBlockedKind<W128,double> 
        {

        }

        public readonly struct Block256x8u : TBlockedKind<W256,byte> 
        {
            
        }
        
        public readonly struct Block256x8i : TBlockedKind<W256,sbyte> 
        {

        }
        
        public readonly struct Block256x16u : TBlockedKind<W256,ushort> 
        {

        }

        public readonly struct Block256x16i : TBlockedKind<W256,short> 
        { 
            
        }       

        public readonly struct Block256x32u : TBlockedKind<W256,uint> 
        { 
            
        }       

        public readonly struct Block256x32i : TBlockedKind<W256,int> 
        { 
            
        }       

        public readonly struct Block256x64u : TBlockedKind<W256,ulong> 
        { 
            
        }       

        public readonly struct Block256x64i : TBlockedKind<W256,long>
        { 
            
        }       

        public readonly struct Block256x32f : TBlockedKind<W256,float> { }       

        public readonly struct Block256x64f : TBlockedKind<W256,double> 
        { 

        }       

        public readonly struct Block512x8u : TBlockedKind<W512,byte> 
        { 
            
        }       
        
        public readonly struct Block512x8i : TBlockedKind<W512,sbyte> 
        { 
            
        }       
        
        public readonly struct Block512x16u : TBlockedKind<W512,ushort> 
        { 
            
        }       

        public readonly struct Block512x16i : TBlockedKind<W512,short> 
        { 
            
        }       

        public readonly struct Block512x32u : TBlockedKind<W512,uint> 
        { 
            
        }       

        public readonly struct Block512x32i : TBlockedKind<W512,int> 
        { 
            
        }       

        public readonly struct Block512x64u : TBlockedKind<W512,ulong> 
        { 
            
        }       

        public readonly struct Block512x64i : TBlockedKind<W512,long> 
        { 
            
        }       

        public readonly struct Block512x32f : TBlockedKind<W512,float> 
        { 
            
        }       

        public readonly struct Block512x64f : TBlockedKind<W512,double> 
        { 
            
        }       
         
        public readonly struct Blocked16 : IBlockedKind<Blocked16>
        {
            public BK Class => BK.b16;

            public static implicit operator BK(Blocked16 src)
                => src.Class;
        }        

        public readonly struct Blocked32 : IBlockedKind<Blocked32>
        {
            public BK Class => BK.b32;

            public static implicit operator BlockedKind(Blocked32 src)
                => src.Class;
        }        

        public readonly struct Blocked64 : IBlockedKind<Blocked64>
        {
            public BK Class => BK.b64;

            public static implicit operator BK(Blocked64 src)
                => src.Class;
        }        

        public readonly struct Blocked128 : IBlockedKind<Blocked128>
        {
            public BK Class => BK.b128;

            public static implicit operator BK(Blocked128 src)
                => src.Class;
        }        

        public readonly struct Blocked256 : IBlockedKind<Blocked256>
        {
            public BK Class => BK.b256;

            public static implicit operator BK(Blocked256 src)
                => src.Class;
        }        

        public readonly struct Blocked512 : IBlockedKind<Blocked512>
        {
            public BK Class => BK.b512;

            public static implicit operator BK(Blocked512 src)
                => src.Class;
        }        
    }
}