//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static HexLevel;

    [ApiHost]
    public struct HM0F
    {
        const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;        

        Vector128<byte> State;

        bit Processed;
        
        [MethodImpl(Inline), Op]
        public void Process(in ReadOnlySpan<byte> data)
        {
            var count = 0;
            for(var i=0; i<data.Length; i++)
            {

                if(Process(skip(data, i)))
                    count++;
            }
        }

        [MethodImpl(Inline), Op]
        public static HM0F Create(Vector128<byte> state)
            => new HM0F(state);
                    
        [MethodImpl(Inline)]
        internal HM0F(Vector128<byte> state)
        {
            State = default;
            Processed = false;
        }

        [MethodImpl(Inline), Op]
        public bit Process(byte code)
        {
            Processed = false;
            Process(h00, code);
            return Processed;
        }

        [MethodImpl(Inline)]
        void Process(X00 a, byte code)
        {
            if(code == h00)
                Process(h00);
            else if(code == h01)
                Process(h01);
            else if(code== h02)
                Process(h02);
            else if(code == h03)
                Process(h03);
            else if(code == h04)
                Process(h04);
            else if(code == h05)
                Process(h05);
            else
                Process(h06,code);
        }

        [MethodImpl(Inline)]
        void Process(X06 a, byte code)
        {
            if(code == h06)
                Process(h06);
            else if(code == h07)
                Process(h07);
            else if(code == h08)
                Process(h08);
            else if(code == h09)
                Process(h09);
            else if(code == h0A)
                Process(h0A);
            else if(code == h0B)
                Process(h0B);
            else
                Process(h0C,code);

        }

        [MethodImpl(Inline)]
        void Process(X0C a, byte code)
        {
            if(code == h0C)
                Process(h0C);
            else if(code == h0D)
                Process(h0D);
            else if(code == h0E)
                Process(h0E);
            else if(code == h0F)
                Process(h0F);
        }

        [MethodImpl(Inline), Op]
        public void Process(X00 x)
        {
            State = State.WithElement(x, x);                            
        }

        [MethodImpl(Inline), Op]
        public void Process(X01 x)
        {
            State = State.WithElement(x, x);                        
        }

        [MethodImpl(Inline), Op]
        public void Process(X02 x)
        {
            State = State.WithElement(x, x);                            
        }

        [MethodImpl(Inline), Op]
        public void Process(X03 x)
        {
            State = State.WithElement(x, x);                                
        }

        [MethodImpl(Inline), Op]
        public void Process(X04 x)
        {
            State = State.WithElement(x, x);                           
        }

        [MethodImpl(Inline), Op]
        public void Process(X05 x)
        {
            State = State.WithElement(x, x);           
        }

        [MethodImpl(Inline), Op]
        public void Process(X06 x)
        {
            State = State.WithElement(x, x);           
        }


        [MethodImpl(Inline), Op]
        public void Process(X07 x)
        {
            State = State.WithElement(x, x);           
        }

        [MethodImpl(Inline), Op]
        public void Process(X08 x)
        {
            State = State.WithElement(x, x);           
        }

        [MethodImpl(Inline), Op]
        public void Process(X09 x)
        {
            State = State.WithElement(x, x);           
        }

        [MethodImpl(Inline), Op]
        public void Process(X0A x)
        {
            State = State.WithElement(x, x);           
        }

        [MethodImpl(Inline), Op]
        public void Process(X0B x)
        {
            State = State.WithElement(x, x);                            
        }

        [MethodImpl(Inline), Op]
        public void Process(X0C x)
        {
            State = State.WithElement(x, x);                                
        }

        [MethodImpl(Inline), Op]
        public void Process(X0D x)
        {
            State = State.WithElement(x, x);                                
        }

        [MethodImpl(Inline), Op]
        public void Process(X0E x)
        {
            State = State.WithElement(x, x);                       
         
        }

        [MethodImpl(Inline), Op]
        public void Process(X0F x)
        {
            State = State.WithElement(x, x);           
        }
    }
}