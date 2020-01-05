namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    public class AsmRdRand
    {        
        /// <summary>
        /// Finds the first method declared by a type that matches a specified name
        /// and returns a pointer to the method definition
        /// </summary>
        /// <param name="name">The method name</param>
        /// <typeparam name="T">The declaring type</typeparam>
        [MethodImpl(Inline)]
        public static IntPtr methodPtr<T>(string name, T t = default)
            => method<T>(name).MethodHandle.GetFunctionPointer();

        static AsmRdRand()
        {
            var rdrand = new byte[] 
            { 
                0x0f, 0xc7, 0xf0,  // rdrand eax
                0x0f, 0x92, 0x01,  // setc byte ptr [rcx]                           
                0xc3               // ret
            };            
            
            Marshal.Copy(rdrand, 0, methodPtr<AsmRdRand>(nameof(RandNative)), rdrand.Length);
        
            
            var code = AsmCode.Load(rdrand, moniker<uint>("rdrand"));
            var emitter = code.CreateEmitter<uint>();
            emitter();

        }


        [MethodImpl(Inline)]
        public static uint Rand()
            => RandNative();


        [MethodImpl(NotInline)]
        static uint RandNative()
        {
            var data = new byte[6];
            return 0;
        }



    }
}