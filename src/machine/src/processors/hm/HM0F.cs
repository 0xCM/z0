//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Memories;
    using static HexLevel;

    [ApiHost]
    public struct HM0F
    {
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
            Process(x00, code);
            return Processed;
        }

        [MethodImpl(Inline)]
        void Process(X00 a, byte code)
        {
            if(code == x00)
                Process(x00);
            else if(code == x01)
                Process(x01);
            else if(code== x02)
                Process(x02);
            else if(code == x03)
                Process(x03);
            else if(code == x04)
                Process(x04);
            else if(code == x05)
                Process(x05);
            else
                Process(x06,code);
        }

        [MethodImpl(Inline)]
        void Process(X06 a, byte code)
        {
            if(code == x06)
                Process(x06);
            else if(code == x07)
                Process(x07);
            else if(code == x08)
                Process(x08);
            else if(code == x09)
                Process(x09);
            else if(code == x0a)
                Process(x0a);
            else if(code == x0b)
                Process(x0b);
            else
                Process(x0c,code);

        }

        [MethodImpl(Inline)]
        void Process(X0C a, byte code)
        {
            if(code == x0c)
                Process(x0c);
            else if(code == x0d)
                Process(x0d);
            else if(code == x0e)
                Process(x0e);
            else if(code == x0f)
                Process(x0f);
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