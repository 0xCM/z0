//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

        
    using static zfunc;

    public interface ICpuReg
    {
    
    }

    public interface ICpuReg<N> : ICpuReg
        where N : unmanaged, ITypeNat
    {
        static readonly BitSize BW =new N().NatValue;

        static readonly ByteSize BZ = new ByteSize(BW/8);
        
        BitSize BitWidth 
        { 
            [MethodImpl(Inline)]
            get => BW;
        }

        ByteSize ByteSize 
        { 
            [MethodImpl(Inline)]
            get => BZ;
        }

    }

    public interface ICpuReg<N, T> : ICpuReg<N>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
    
    }

    public interface IVectorReg<N> : ICpuReg<N>
        where N : unmanaged, ITypeNat, INatPow2
    {
        Volatility Volatility(int index);
    }

    public interface ICpuReg8 : ICpuReg<N8, ushort>
    {

    }

    public interface ICpuReg16 : ICpuReg<N16, ushort>
    {

    }

    public interface ICpuReg32 : ICpuReg<N32, uint>
    {

    }

    public interface ICpuReg64 : ICpuReg<N64,ulong>
    {

    }

    public interface ICpuReg128 : IVectorReg<N128>
    {
        
    }

    public interface ICpuReg256 : IVectorReg<N256>
    {
        Volatility Volatility(int index, int part);
    }

    public interface ICpuReg512 : IVectorReg<N512>
    {

    }

    public interface IGpReg : ICpuReg
    {
        GpRegId Id {get;}   

        Volatility Volatility 
            => Volatility.NonVolatile;

    }

    public interface IGpReg<N,R,T> : ICpuReg<N,T>, IGpReg
        where N : unmanaged, ITypeNat, INatPow2
        where R : struct, ICpuReg
        where T : unmanaged
    {        

    }

    public interface ISegReg : ICpuReg
    {
        
    }

    public interface IGpReg64<R> : IGpReg<N64, R, ulong>
        where R : struct, ICpuReg 
    {        
        byte Lo8 {get; set;}
        
        ushort Lo16 {get; set;}

        uint Lo32 {get; set;}        

        GpRegId64 RegKind {get;}

    }

    public interface IGpReg32<R> : IGpReg<N32, R, uint>
        where R : struct, ICpuReg 
    {        
        byte Lo8 {get; set;}
        
        ushort Lo16 {get; set;}        
    }

    public interface IGpReg16<R> : IGpReg<N16, R, ushort>
        where R : struct, ICpuReg 
    {        
        byte Lo8 {get; set;}                
    }

    public interface IGpReg8<R> : IGpReg<N8, R, byte>
        where R : struct, ICpuReg 
    {        
        
    }

    public interface IFpuReg32 : ICpuReg<N32,float>
    {


    }

    public interface IFpuReg64 : ICpuReg<N64,double>, IFpuReg32
    {


    }

    public interface IFpuReg80 : ICpuReg<N80,Float80>, IFpuReg64
    {


    }

    public interface IMMReg : ICpuReg
    {

        ref T Cell<T>(int index)      
            where T : unmanaged;        


        bit this[uint r] {get;}            
    }

   
}